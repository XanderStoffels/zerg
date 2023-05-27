namespace Zerg.Http.ApiResponseTypes;

public class RateLimitError<T> : IApiResponse<T>
{
    public T? Result { get; } = default;
    public bool IsOk { get; } = false;
}