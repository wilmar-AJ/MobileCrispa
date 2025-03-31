using ApiWoman.Pages;
using ApiWoman.ViewModels;

namespace ApiWoman;

public partial class MainPage : ContentPage
{
	

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		AnimateElements();
		BindingContext = vm;
	}

	private async void AnimateElements()
    {
        await Task.Delay(500);
        await LogoImage.FadeTo(1, 1000);
        await TitleLabel.FadeTo(1, 800);
        await SubtitleLabel.FadeTo(1, 800);
        await StartButton.FadeTo(1, 800);
    }

   
	
	
}

