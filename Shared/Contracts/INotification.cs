using Shared.Errors;

namespace Shared.Contracts;

public interface INotification<TResult, TSource, TError>
    where TError : DefaultError
{
    Result<TResult, TError> Push(TSource source);
}

