namespace Zerg.Http.ApiResponseTypes;

public class ConnectionError<T> : IApiResponse<T>
{
    public T? Result { get; } = default;
    public bool IsOk { get; } = false;
    public Exception? Exception { get; set; }
}