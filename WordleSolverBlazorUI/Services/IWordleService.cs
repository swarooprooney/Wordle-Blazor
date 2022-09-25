using WordleSolverBlazorUI.Dtos;

namespace WordleSolverBlazorUI.Services
{
    public interface IWordleService
    {
        Task<string> GetFirstGuessAsync();
        Task<string> GetNextGuessAsync(GetNextGuessDto dto);
    }
}
