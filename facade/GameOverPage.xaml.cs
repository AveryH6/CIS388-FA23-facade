namespace facade;

[QueryProperty("Result", "Result")]
public partial class GameOverPage : ContentPage
{



	//private string result;
	//public string Result {
	//	get => result;
	//	set
	//	{
	//		result = value;
	//		ResultLabel.Text = "You " + result;
	//	}
	//}

	public GameOverPage()
	{
		InitializeComponent();

		

	}

    async void Play_Again_Button_Clicked(object sender, EventArgs e)
    {

        await Shell.Current.GoToAsync(nameof(MainPage));

    }

}
