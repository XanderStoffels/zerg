using System.Net;
using System.Text.Json;
using RestSharp;
using Zerg.Http.Exceptions;

namespace Zerg.Http.Util;

/*
 * https://docs.spacetraders.io/api-guide/rate-limits
 * x-ratelimit-type	                The type of rate limit that was exceeded.
 * x-ratelimit-limit	            The maximum number of requests that can be made in a given time period.
 * x-ratelimit-remaining	        The number of requests remaining in the current time period.
 * x-ratelimit-reset	            The time at which the current time period will reset.
 * x-ratelimit-limit-burst	        The maximum number of requests that can be made in a given burst duration.
 * x-ratelimit-limit-per-second	    The maximum number of requests that can be made in a given time period.
 */


public static class RestResponseExtensions
{
    
    public static T UnpackWithResponse<T>(this RestResponse response)
    {
        switch (response)
        {
            // Get requests should always return content.
            case { IsSuccessful: true, Content: null }:
                throw new HttpException("Response was successful but did not contain any content", response.ErrorException);
            
            // The Happy Path™
            case { IsSuccessful: true }:
                try
                {
                    var result = JsonSerializer.Deserialize<T>(response.Content, new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    if (result != null) return result;
                    throw new HttpException("Response was successful but deserialized to null", response.ErrorException);
                }
                catch (JsonException e)
                {
                    throw new HttpException("Response was successful but could not be deserialized", e);
                }

            // Find out why it failed.
            case { IsSuccessful: false }: 
                
                // Did the server respond?
                switch (response.ResponseStatus)
                {
                    // The server responded, check the status code.
                    case ResponseStatus.Completed:
                    case ResponseStatus.Error:
                        break;
                
                    // We did not reach the server, blame it on the connection.
                    case ResponseStatus.None:
                    case ResponseStatus.TimedOut:
                    case ResponseStatus.Aborted:
                    default:
                        throw new HttpException("Request failed to reach the server", response.ErrorException);
                }
            
                // The server responded, but was it a valid response?
                throw response.StatusCode switch
                {
                    // Unauthorized
                    HttpStatusCode.Unauthorized => new HttpException(
                        "You are unauthorized, check your token", response.ErrorException),
                    
                    // Server error
                    HttpStatusCode.InternalServerError => new HttpException(
                        "The server responded with internal server error", response.ErrorException),
                    
                    // DDOS protection, wait 3 minutes and try again.
                    HttpStatusCode.BadGateway => new(
                        "The server gave you a DDOS time-out. Wait a while before sending again",
                        response.ErrorException),
                    
                    // Rate limited, check the headers when you can try again.
                    HttpStatusCode.TooManyRequests => new(
                        "The server gave you a rate limit time-out. Wait a while before sending again",
                        response.ErrorException),
                    
                    _ => new(
                        $"The server responded with an undocumented error, status code {response.StatusCode}",
                        response.ErrorException)
                };
            default:
                throw new HttpException($"Unhandled response case with status {response.StatusCode}", response.ErrorException);
        }
    }
    
    public static T? GetHeaderValue<T>(this IEnumerable<HeaderParameter> headers, string headerKey)
    {
        var rateLimitType = headers.FirstOrDefault(h => h.Name == headerKey);
        return rateLimitType is { Value: T x } ? x : default;
    }
    
    public static T GetHeaderValueOrDefault<T>(this IEnumerable<HeaderParameter> headers, string headerKey, T defaultValue)
    {
        return headers.GetHeaderValue<T>(headerKey) ?? defaultValue;
    }
    
    public static RateLimitInfo? GetRateLimitInfo(this RestResponse response)
    {
        var headers = response.Headers;

        if (headers?.GetHeaderValue<string>( "x-ratelimit-type") is not { } type) return null;
        var limit = headers.GetHeaderValue<int>("x-ratelimit-limit");
        var remaining = headers.GetHeaderValue<int>("x-ratelimit-remaining");
        
        // Parse the header to string, and then parse this string to a date time offset.
        if (headers.GetHeaderValue<string>("x-ratelimit-reset") is not {} resetIso 
            || !DateTime.TryParse(resetIso, out var reset)) 
            return null;

        var burstLimit = headers.GetHeaderValue<int>("x-ratelimit-limit-burst");
        var limitPerSecond = headers.GetHeaderValue<int>("x-ratelimit-limit-per-second");
        
        return new()
        {
            Type = type,
            Limit = limit,
            BurstLimit = burstLimit,
            LimitPerSecond = limitPerSecond,
            Remaining = remaining,
            ResetsAt = reset
        };
    }
}