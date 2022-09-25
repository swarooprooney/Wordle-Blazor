namespace WordleSolverBlazorUI.Dtos
{
    public class NextGuessDto
    {
        public List<string> possibleAnswers { get; set; }
        public string guess { get; set; }
    }
}