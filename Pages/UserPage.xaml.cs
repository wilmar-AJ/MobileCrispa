using ApiWoman.ViewModels;

namespace ApiWoman.Pages;

public partial class UserPage : ContentPage
{
    private readonly MainViewModel _viewModel;

    public UserPage(MainViewModel vm)
    {
        InitializeComponent();
        _viewModel = vm;
        BindingContext  = vm;
       
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.LoadUsersAsync(); 
    }

    
    
}
