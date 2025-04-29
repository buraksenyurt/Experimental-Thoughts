using Shared.Contracts;

namespace App;

public class Logger
    : ILogger
{
    public void Debug(string message)
    {
        Console.WriteLine($"[DEBUG] {message}");
    }

    public void Error(string message, Exception exception)
    {
        Console.WriteLine($"[ERROR] {message}: {exception.Message}");
    }

    public void Info(string message)
    {
        Console.WriteLine($"[INFO] {message}");
    }

    public void Warn(string message)
    {
        Console.WriteLine($"[WARN] {message}");
    }
}