using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace facade
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string secretColor;

        [ObservableProperty]
        private string currentGuess;

        public ObservableCollection<ColorGuess> Guesses { get; set; }

        public bool DidWin { get; set; } = false;

        //public string SecretColor { get; set; }

        public MainPageViewModel()
        {
            secretColor = "FACADE";
            currentGuess = "";

            Guesses = new ObservableCollection<ColorGuess>();

            //Guesses.Add(new ColorGuess("#beaded"));
            //Guesses.Add(new ColorGuess("#efaced"));

        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(GameOverPage)}?DidWin={DidWin}");
        }


        [RelayCommand]
        void AddLetter(string letter)
        {
            if (CurrentGuess.Length < 6)
            {
                CurrentGuess += letter;
            }
        }



        

        [RelayCommand]
        void Guess()
        {
            // if correct, then go to game over (DidWin=true)
            if (Guesses.Equals(SecretColor))
            {
                CurrentGuess = CurrentGuess.Substring(0, CurrentGuess.Length - 1);

            }
            // else if this is the 6th guess (and it's wrong)
            // then go to game over (DidWin=false)


            // Add this guess to the Guesses
            Guesses.Add(new ColorGuess(CurrentGuess));

            //if (Guesses.Equals(SecretColor))
                        //{
                
                        //}

        }

        [RelayCommand]
        void RemoveGuess()
        {
            if (CurrentGuess.Length != 0)
            {
                CurrentGuess = CurrentGuess.Substring(0, CurrentGuess.Length - 1);
            }
        }

        //[RelayCommand]
        //void RemoveGuess()
        //{
        //    if (CurrentGuess.Length != 0)
        //    {
        //        CurrentGuess = CurrentGuess.Substring(0, CurrentGuess.Length - 1);
        //    }
        //}


    }
}
