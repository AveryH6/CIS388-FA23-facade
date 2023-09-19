using System;

namespace facade;

public partial class MainPage : ContentPage
{
	int count = 0;

	public bool DidWin { get; set; } = false;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		
	}

    async void Button_Clicked(object sender, EventArgs e)
    {

		await Shell.Current.GoToAsync($"{nameof(GameOverPage)}?Result=won");

    }
}


