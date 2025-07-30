using API.DTO;

namespace API.Interfaces;

public interface ICatFactService
{
    Task<CatFactResponse?> GetCatFactAsync();
}
