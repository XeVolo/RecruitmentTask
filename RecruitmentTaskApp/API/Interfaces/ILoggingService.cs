using API.DTO;

namespace API.Interfaces;

public interface ILoggingService
{
    Task LogToFileAsync(CatFactResponse fact);
}

