using Microsoft.Extensions.Logging;
using RestSharp;

namespace Zerg.Http.Util;

public static class LoggingExtensions
{
    public static void LogRestResponse<T>(this ILogger<T> logger, RestResponse res)
    {
        var resource = res.Request.Resource;
        var method = res.Request.Method.ToString();
        var statusCode = res.StatusCode;
        var message = res.StatusDescription;
        
        logger.LogInformation("[{Resource}] [{Method}] [{StatusCode}] {Message}", resource, method, statusCode, message);
    }
    
    public static void LogRestResponse(this ILogger logger, RestResponse res)
    {
        var resource = res.Request.Resource;
        var method = res.Request.Method.ToString();
        var statusCode = (int) res.StatusCode;
        var message = res.StatusDescription;
        
        logger.LogInformation("API REQUEST [{Method}] [{Resource}] > [{StatusCode}] {Message}", resource, method, statusCode, message);
    }
}