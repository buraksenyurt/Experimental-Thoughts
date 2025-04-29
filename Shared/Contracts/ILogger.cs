
namespace Shared.Contracts;

public interface ILogger
{
    void Info(string message);
    void Debug(string message);
    void Error(string message, Exception exception);
    void Warn(string message);
}