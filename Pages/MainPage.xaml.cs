
using ApiWoman.ViewModels;

namespace ApiWoman.Pages;

public partial class MainPage : ContentPage
{
	

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		AnimateElements();
		
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

