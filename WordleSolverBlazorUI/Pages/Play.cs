
using Microsoft.AspNetCore.Components;
using WordleSolverBlazorUI.Dtos;
using WordleSolverBlazorUI.Services;

namespace WordleSolverBlazorUI.Pages
{

    public partial class Play
    {
        private string firstGuess = string.Empty;
        private string secondGuess = string.Empty;
        private string thirdGuess = string.Empty;
        private string fourthGuess = string.Empty;
        private string fifthGuess = string.Empty;
        private string sixthGuess = string.Empty;

        private string cssBtn1 = "btn-danger";
        private string cssBtn2 = "btn-danger";
        private string cssBtn3 = "btn-danger";
        private string cssBtn4 = "btn-danger";
        private string cssBtn5 = "btn-danger";
        private string cssBtn6 = "btn-danger";
        private string cssBtn7 = "btn-danger";
        private string cssBtn8 = "btn-danger";
        private string cssBtn9 = "btn-danger";
        private string cssBtn10 = "btn-danger";
        private string cssBtn11 = "btn-danger";
        private string cssBtn12 = "btn-danger";
        private string cssBtn13 = "btn-danger";
        private string cssBtn14 = "btn-danger";
        private string cssBtn15 = "btn-danger";
        private string cssBtn16 = "btn-danger";
        private string cssBtn17 = "btn-danger";
        private string cssBtn18 = "btn-danger";
        private string cssBtn19 = "btn-danger";
        private string cssBtn20 = "btn-danger";
        private string cssBtn21 = "btn-danger";
        private string cssBtn22 = "btn-danger";
        private string cssBtn23 = "btn-danger";
        private string cssBtn24 = "btn-danger";
        private string cssBtn25 = "btn-danger";
        private string cssBtn26 = "btn-danger";
        private string cssBtn27 = "btn-danger";
        private string cssBtn28 = "btn-danger";
        private string cssBtn29 = "btn-danger";
        private string cssBtn30 = "btn-danger";


        [Inject] public IWordleService WordleService { get; set; }

        private GetNextGuessDto dto;

        protected override async Task OnInitializedAsync()
        {
            dto = new GetNextGuessDto();

            firstGuess = await WordleService.GetFirstGuessAsync();
            foreach (var ch in firstGuess)
            {
                dto.redCharacters.Add(ch.ToString());
            }
        }

        public async Task GetGuess()
        {
            var response = await WordleService.GetNextGuessAsync(dto);
            foreach (var ch in response)
            {
                dto.redCharacters.Add(ch.ToString());
            }
            if (string.IsNullOrEmpty(secondGuess))
            {
                secondGuess = response;
                return;
            }

            if (string.IsNullOrEmpty(thirdGuess))
            {
                thirdGuess = response;
                return;
            }

            if (string.IsNullOrEmpty(fourthGuess))
            {
                fourthGuess = response;
                return;
            }

            if (string.IsNullOrEmpty(fifthGuess))
            {
                fifthGuess = response;
                return;
            }

            if (!string.IsNullOrEmpty(sixthGuess)) return;
            sixthGuess = response;
        }

        private void ChangeColor(int buttonId)
        {
            switch (buttonId)
            {
                case 1 when cssBtn1 == "btn-danger":
                    cssBtn1 = "btn-warning";
                    TurnYellow(buttonId, firstGuess);
                    return;
                case 1 when cssBtn1 == "btn-warning":
                    cssBtn1 = "btn-success";
                    TurnGreen(buttonId, firstGuess);
                    return;
                case 1 when cssBtn1 == "btn-success":
                    cssBtn1 = "btn-danger";
                    TurnRed(buttonId, firstGuess);
                    return;
                case 2 when cssBtn2 == "btn-danger":
                    cssBtn2 = "btn-warning";
                    TurnYellow(buttonId, firstGuess);
                    return;
                case 2 when cssBtn2 == "btn-warning":
                    cssBtn2 = "btn-success";
                    TurnGreen(buttonId, firstGuess);
                    return;
                case 2 when cssBtn2 == "btn-success":
                    cssBtn2 = "btn-danger";
                    TurnRed(buttonId, firstGuess);
                    return;
                case 3 when cssBtn3 == "btn-danger":
                    cssBtn3 = "btn-warning";
                    TurnYellow(buttonId, firstGuess);
                    return;
                case 3 when cssBtn3 == "btn-warning":
                    cssBtn3 = "btn-success";
                    TurnGreen(buttonId, firstGuess);
                    return;
                case 3 when cssBtn3 == "btn-success":
                    cssBtn3 = "btn-danger";
                    TurnRed(buttonId, firstGuess);
                    return;
                case 4 when cssBtn4 == "btn-danger":
                    cssBtn4 = "btn-warning";
                    TurnYellow(buttonId, firstGuess);
                    return;
                case 4 when cssBtn4 == "btn-warning":
                    cssBtn4 = "btn-success";
                    TurnGreen(buttonId, firstGuess);
                    return;
                case 4 when cssBtn4 == "btn-success":
                    cssBtn4 = "btn-danger";
                    TurnRed(buttonId, firstGuess);
                    return;
                case 5 when cssBtn5 == "btn-danger":
                    cssBtn5 = "btn-warning";
                    TurnYellow(buttonId, firstGuess);
                    return;
                case 5 when cssBtn5 == "btn-warning":
                    cssBtn5 = "btn-success";
                    TurnGreen(buttonId, firstGuess);
                    return;
                case 5 when cssBtn5 == "btn-success":
                    cssBtn5 = "btn-danger";
                    TurnRed(buttonId, firstGuess);
                    return;
                case 6 when cssBtn6 == "btn-danger":
                    cssBtn6 = "btn-warning";
                    TurnYellow(buttonId % 5, secondGuess);
                    return;
                case 6 when cssBtn6 == "btn-warning":
                    cssBtn6 = "btn-success";
                    TurnGreen(buttonId % 5, secondGuess);
                    return;
                case 6 when cssBtn6 == "btn-success":
                    cssBtn6 = "btn-danger";
                    TurnRed(buttonId % 5, secondGuess);
                    return;
                case 7 when cssBtn7 == "btn-danger":
                    cssBtn7 = "btn-warning";
                    TurnYellow(buttonId % 5, secondGuess);
                    return;
                case 7 when cssBtn7 == "btn-warning":
                    cssBtn7 = "btn-success";
                    TurnGreen(buttonId % 5, secondGuess);
                    return;
                case 7 when cssBtn7 == "btn-success":
                    cssBtn7 = "btn-danger";
                    TurnRed(buttonId % 5, secondGuess);
                    return;
                case 8 when cssBtn8 == "btn-danger":
                    cssBtn8 = "btn-warning";
                    TurnYellow(buttonId % 5, secondGuess);
                    return;
                case 8 when cssBtn8 == "btn-warning":
                    cssBtn8 = "btn-success";
                    TurnGreen(buttonId % 5, secondGuess);
                    return;
                case 8 when cssBtn8 == "btn-success":
                    cssBtn8 = "btn-danger";
                    TurnRed(buttonId % 5, secondGuess);
                    return;
                case 9 when cssBtn9 == "btn-danger":
                    cssBtn9 = "btn-warning";
                    TurnYellow(buttonId % 5, secondGuess);
                    return;
                case 9 when cssBtn9 == "btn-warning":
                    cssBtn9 = "btn-success";
                    TurnGreen(buttonId % 5, secondGuess);
                    return;
                case 9 when cssBtn9 == "btn-success":
                    cssBtn9 = "btn-danger";
                    TurnRed(buttonId % 5, secondGuess);
                    return;
                case 10 when cssBtn10 == "btn-danger":
                    cssBtn10 = "btn-warning";
                    TurnYellow(5, secondGuess);
                    return;
                case 10 when cssBtn10 == "btn-warning":
                    cssBtn10 = "btn-success";
                    TurnGreen(5, secondGuess);
                    return;
                case 10 when cssBtn10 == "btn-success":
                    cssBtn10 = "btn-danger";
                    TurnRed(5, secondGuess);
                    return;
                case 11 when cssBtn11 == "btn-danger":
                    cssBtn11 = "btn-warning";
                    TurnYellow(buttonId % 5, thirdGuess);
                    return;
                case 11 when cssBtn11 == "btn-warning":
                    cssBtn11 = "btn-success";
                    TurnGreen(buttonId % 5, thirdGuess);
                    return;
                case 11 when cssBtn11 == "btn-success":
                    cssBtn11 = "btn-danger";
                    TurnRed(buttonId % 5, thirdGuess);
                    return;
                case 12 when cssBtn12 == "btn-danger":
                    cssBtn12 = "btn-warning";
                    TurnYellow(buttonId % 5, thirdGuess);
                    return;
                case 12 when cssBtn12 == "btn-warning":
                    cssBtn12 = "btn-success";
                    TurnGreen(buttonId % 5, thirdGuess);
                    return;
                case 12 when cssBtn12 == "btn-success":
                    cssBtn12 = "btn-danger";
                    TurnRed(buttonId % 5, thirdGuess);
                    return;
                case 13 when cssBtn13 == "btn-danger":
                    cssBtn13 = "btn-warning";
                    TurnYellow(buttonId % 5, thirdGuess);
                    return;
                case 13 when cssBtn13 == "btn-warning":
                    cssBtn13 = "btn-success";
                    TurnGreen(buttonId % 5, thirdGuess);
                    return;
                case 13 when cssBtn13 == "btn-success":
                    cssBtn13 = "btn-danger";
                    TurnRed(buttonId % 5, thirdGuess);
                    return;
                case 14 when cssBtn14 == "btn-danger":
                    cssBtn14 = "btn-warning";
                    TurnYellow(buttonId % 5, thirdGuess);
                    return;
                case 14 when cssBtn14 == "btn-warning":
                    cssBtn14 = "btn-success";
                    TurnGreen(buttonId % 5, thirdGuess);
                    return;
                case 14 when cssBtn14 == "btn-success":
                    cssBtn14 = "btn-danger";
                    TurnRed(buttonId % 5, thirdGuess);
                    return;
                case 15 when cssBtn15 == "btn-danger":
                    cssBtn15 = "btn-warning";
                    TurnYellow(5, thirdGuess);
                    return;
                case 15 when cssBtn15 == "btn-warning":
                    cssBtn15 = "btn-success";
                    TurnGreen(5, thirdGuess);
                    return;
                case 15 when cssBtn15 == "btn-success":
                    cssBtn15 = "btn-danger";
                    TurnRed(5, thirdGuess);
                    return;
                case 16 when cssBtn16 == "btn-danger":
                    cssBtn16 = "btn-warning";
                    TurnYellow(buttonId % 5, fourthGuess);
                    return;
                case 16 when cssBtn16 == "btn-warning":
                    cssBtn16 = "btn-success";
                    TurnGreen(buttonId % 5, fourthGuess);
                    return;
                case 16 when cssBtn16 == "btn-success":
                    cssBtn16 = "btn-danger";
                    TurnRed(buttonId % 5, fourthGuess);
                    return;
                case 17 when cssBtn17 == "btn-danger":
                    cssBtn17 = "btn-warning";
                    TurnYellow(buttonId % 5, fourthGuess);
                    return;
                case 17 when cssBtn17 == "btn-warning":
                    cssBtn17 = "btn-success";
                    TurnGreen(buttonId % 5, fourthGuess);
                    return;
                case 17 when cssBtn17 == "btn-success":
                    cssBtn17 = "btn-danger";
                    TurnRed(buttonId % 5, fourthGuess);
                    return;
                case 18 when cssBtn18 == "btn-danger":
                    cssBtn18 = "btn-warning";
                    TurnYellow(buttonId % 5, fourthGuess);
                    return;
                case 18 when cssBtn18 == "btn-warning":
                    cssBtn18 = "btn-success";
                    TurnGreen(buttonId % 5, fourthGuess);
                    return;
                case 18 when cssBtn18 == "btn-success":
                    cssBtn18 = "btn-danger";
                    TurnRed(buttonId % 5, fourthGuess);
                    return;
                case 19 when cssBtn19 == "btn-danger":
                    cssBtn19 = "btn-warning";
                    TurnYellow(buttonId % 5, fourthGuess);
                    return;
                case 19 when cssBtn19 == "btn-warning":
                    cssBtn19 = "btn-success";
                    TurnGreen(buttonId % 5, fourthGuess);
                    return;
                case 19 when cssBtn19 == "btn-success":
                    cssBtn19 = "btn-danger";
                    TurnRed(buttonId % 5, fourthGuess);
                    return;
                case 20 when cssBtn20 == "btn-danger":
                    cssBtn20 = "btn-warning";
                    TurnYellow(5, fourthGuess);
                    return;
                case 20 when cssBtn20 == "btn-warning":
                    cssBtn20 = "btn-success";
                    TurnGreen(5, fourthGuess);
                    return;
                case 20 when cssBtn20 == "btn-success":
                    cssBtn20 = "btn-danger";
                    TurnRed(5, fourthGuess);
                    return;
                case 21 when cssBtn21 == "btn-danger":
                    cssBtn21 = "btn-warning";
                    TurnYellow(buttonId % 5, fifthGuess);
                    return;
                case 21 when cssBtn21 == "btn-warning":
                    cssBtn21 = "btn-success";
                    TurnGreen(buttonId % 5, fifthGuess);
                    return;
                case 21 when cssBtn21 == "btn-success":
                    cssBtn21 = "btn-danger";
                    TurnRed(buttonId % 5, fifthGuess);
                    return;
                case 22 when cssBtn22 == "btn-danger":
                    cssBtn22 = "btn-warning";
                    TurnYellow(buttonId % 5, fifthGuess);
                    return;
                case 22 when cssBtn22 == "btn-warning":
                    cssBtn22 = "btn-success";
                    TurnGreen(buttonId % 5, fifthGuess);
                    return;
                case 22 when cssBtn22 == "btn-success":
                    cssBtn22 = "btn-danger";
                    TurnRed(buttonId % 5, fifthGuess);
                    return;
                case 23 when cssBtn23 == "btn-danger":
                    cssBtn23 = "btn-warning";
                    TurnYellow(buttonId % 5, fifthGuess);
                    return;
                case 23 when cssBtn23 == "btn-warning":
                    cssBtn23 = "btn-success";
                    TurnGreen(buttonId % 5, fifthGuess);
                    return;
                case 23 when cssBtn23 == "btn-success":
                    cssBtn23 = "btn-danger";
                    TurnRed(buttonId % 5, fifthGuess);
                    return;
                case 24 when cssBtn24 == "btn-danger":
                    cssBtn24 = "btn-warning";
                    TurnYellow(buttonId % 5, fifthGuess);
                    return;
                case 24 when cssBtn24 == "btn-warning":
                    cssBtn24 = "btn-success";
                    TurnGreen(buttonId % 5, fifthGuess);
                    return;
                case 24 when cssBtn24 == "btn-success":
                    cssBtn24 = "btn-danger";
                    TurnRed(buttonId % 5, fifthGuess);
                    return;
                case 25 when cssBtn25 == "btn-danger":
                    cssBtn25 = "btn-warning";
                    TurnYellow(5, fifthGuess);
                    return;
                case 25 when cssBtn25 == "btn-warning":
                    cssBtn25 = "btn-success";
                    TurnGreen(5, fifthGuess);
                    return;
                case 25 when cssBtn25 == "btn-success":
                    cssBtn25 = "btn-danger";
                    TurnRed(5, fifthGuess);
                    return;
                case 26 when cssBtn26 == "btn-danger":
                    cssBtn26 = "btn-warning";
                    TurnYellow(buttonId % 5, sixthGuess);
                    return;
                case 26 when cssBtn26 == "btn-warning":
                    cssBtn26 = "btn-success";
                    TurnGreen(buttonId % 5, sixthGuess);
                    return;
                case 26 when cssBtn26 == "btn-success":
                    cssBtn26 = "btn-danger";
                    TurnRed(buttonId % 5, sixthGuess);
                    return;
                case 27 when cssBtn27 == "btn-danger":
                    cssBtn27 = "btn-warning";
                    TurnYellow(buttonId % 5, fifthGuess);
                    return;
                case 27 when cssBtn27 == "btn-warning":
                    cssBtn27 = "btn-success";
                    TurnGreen(buttonId % 5, fifthGuess);
                    return;
                case 27 when cssBtn27 == "btn-success":
                    cssBtn27 = "btn-danger";
                    TurnRed(buttonId % 5, fifthGuess);
                    return;
                case 28 when cssBtn28 == "btn-danger":
                    cssBtn28 = "btn-warning";
                    TurnYellow(buttonId % 5, fifthGuess);
                    return;
                case 28 when cssBtn28 == "btn-warning":
                    cssBtn28 = "btn-success";
                    TurnGreen(buttonId % 5, fifthGuess);
                    return;
                case 28 when cssBtn28 == "btn-success":
                    cssBtn28 = "btn-danger";
                    TurnRed(buttonId % 5, fifthGuess);
                    return;
                case 29 when cssBtn29 == "btn-danger":
                    cssBtn29 = "btn-warning";
                    TurnYellow(buttonId % 5, fifthGuess);
                    return;
                case 29 when cssBtn29 == "btn-warning":
                    cssBtn29 = "btn-success";
                    TurnGreen(buttonId % 5, fifthGuess);
                    return;
                case 29 when cssBtn29 == "btn-success":
                    cssBtn29 = "btn-danger";
                    TurnRed(buttonId % 5, fifthGuess);
                    return;
                case 30 when cssBtn30 == "btn-danger":
                    cssBtn30 = "btn-warning";
                    TurnYellow(5, fifthGuess);
                    return;
                case 30 when cssBtn30 == "btn-warning":
                    cssBtn30 = "btn-success";
                    TurnGreen(5, fifthGuess);
                    return;
                case 30 when cssBtn30 == "btn-success":
                    cssBtn30 = "btn-danger";
                    TurnRed(5, fifthGuess);
                    return;
            }
        }

        private void TurnRed(int buttonId, string guess)
        {
            var itemToRemove = dto.greenCharacters.SingleOrDefault(x =>
                x.character == guess[buttonId - 1].ToString() && x.position == buttonId - 1);
            if (itemToRemove != null)
            {
                dto.greenCharacters.Remove(itemToRemove);
            }

            dto.redCharacters.Add(guess[buttonId - 1].ToString());
        }

        private void TurnGreen(int buttonId, string guess)
        {
            dto.greenCharacters.Add(new GreenCharacter
            {
                character = guess[buttonId - 1].ToString(),
                position = buttonId - 1
            });
            var itemToRemove = dto.yellowCharacters.SingleOrDefault(x =>
                x.character == guess[buttonId - 1].ToString() && x.position == buttonId - 1);
            if (itemToRemove != null)
            {
                dto.yellowCharacters.Remove(itemToRemove);
            }
        }

        private void TurnYellow(int buttonId, string guess)
        {
            dto.redCharacters.Remove(guess[buttonId - 1].ToString());
            dto.yellowCharacters.Add(new YellowCharacter()
            {
                character = guess[buttonId - 1].ToString(),
                position = buttonId - 1
            });
        }
    }
}