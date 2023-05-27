namespace Zerg.Http.ApiResponseTypes;

public class ServerError<T> : IApiResponse<T>
{
    public T? Result { get; } = default;
    public bool IsOk { get; } = false;

    public string Message { get; } = "A server error occurred";
    
    public ServerError()
    {
    }
    
    public ServerError(string message)
    {
        Message = message;
    }
}