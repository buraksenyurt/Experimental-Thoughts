namespace Shared;

public class Result<TResult, TError>
{
    public TResult? Data { get; set; }
    public TError? Error { get; set; }
    public bool IsSuccess => Error == null;
    public static Result<TResult, TError> Success(TResult data) => new() { Data = data };
    public static Result<TResult, TError> Failure(TError error) => new() { Error = error };
}

