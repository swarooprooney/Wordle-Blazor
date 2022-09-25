namespace WordleSolverBlazorUI.Dtos
{
    public class GetNextGuessDto
    {
        public GetNextGuessDto()
        {
            redCharacters = new List<string>();
            yellowCharacters = new List<YellowCharacter>();
            greenCharacters = new List<GreenCharacter>();
        }
        public List<string> redCharacters { get; set; }
        public List<YellowCharacter> yellowCharacters { get; set; }
        public List<GreenCharacter> greenCharacters { get; set; }
    }

    public class GreenCharacter
    {
        public string character { get; set; }
        public int position { get; set; }
    }

    public class YellowCharacter
    {
        public string character { get; set; }
        public int position { get; set; }
    }
}