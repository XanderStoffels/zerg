namespace Zerg.Http.ApiResponseTypes;

public class DdosTimeout<T> : IApiResponse<T>
{
    public T? Result { get; } = default;
    public bool IsOk { get; } = false;
}