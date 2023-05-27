namespace Zerg.Http.ApiResponseTypes;

public class JsonError<T> : IApiResponse<T>
{
    public T? Result { get; } = default;
    public bool IsOk { get; } = false;

    public string? Content { get; }
    
    public JsonError(string? content)
    {
        Content = content;
    }
    
}