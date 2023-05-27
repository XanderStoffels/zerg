namespace Zerg.Http.ApiResponseTypes;

public class Ok<T> : IApiResponse<T>
{
    public T Result { get; }
    public bool IsOk { get; }

    public Ok(T result)
    {
        Result = result;
        IsOk = true;
    }
    
    public static implicit operator Ok<T>(T result) => new(result);
}