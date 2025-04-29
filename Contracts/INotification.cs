using Shared;
using Shared.Errors;

namespace Contracts;

public interface INotification<TResult, TSource, TError>
    where TError : DefaultError
{
    Result<TResult, TError> Push(TSource source);
}

