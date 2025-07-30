using API.DTO;
using API.Interfaces;
using System.Text.Json;

namespace API.Services;

public class LoggingService : ILoggingService
{
    private readonly string _filePath = "catfacts.txt";

    public async Task LogToFileAsync(CatFactResponse fact)
    {
        try
        {
            var jsonLine = JsonSerializer.Serialize(fact);
            await File.AppendAllTextAsync(_filePath, jsonLine + Environment.NewLine);
        }
        catch (Exception ex)
        {
            throw new IOException("Failed to save file.", ex);
        }
    }
}

