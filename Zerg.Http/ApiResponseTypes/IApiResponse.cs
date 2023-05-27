namespace Zerg.Http.ApiResponseTypes;

public interface IApiResponse<out T> 
{
    public T? Result { get; }
    public bool IsOk { get; }
    public bool IsError => !IsOk;
    
}