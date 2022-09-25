
using System.Text.Json;
using WordleSolverBlazorUI.Dtos;

namespace WordleSolverBlazorUI.Services
{
    public class WordleService : IWordleService
    {
        private readonly IHttpClientFactory _factory;
        private readonly HttpClient _httpClient;

        public WordleService(IHttpClientFactory factory)
        {
            _httpClient = factory.CreateClient("WordleClient");
        }

        public async Task<string> GetFirstGuessAsync()
        {
            var response = await _httpClient.GetStringAsync(Constants.GetFirstGuess);
            return response;
        }

        public async Task<string> GetNextGuessAsync(GetNextGuessDto dto)
        {
            var response = await _httpClient.PostAsJsonAsync(Constants.GetNextGuess, dto);
            var resultStr = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            var answer = JsonSerializer.Deserialize<NextGuessDto>(resultStr);
            return answer.guess;
        }
    }
}