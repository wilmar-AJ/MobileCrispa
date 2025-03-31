using System.Collections.ObjectModel;
using ApiWoman.Models;
using ApiWoman.Services.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ApiWoman.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly IApiService _apiService;

        [ObservableProperty]
        private ObservableCollection<UserModel> _users = new();

        public MainViewModel(IApiService apiService)
        {
            _apiService = apiService;
        }

        [RelayCommand]
        public async Task LoadUsersAsync()
        {
            var users = await _apiService.GetFemaleUsersAsync();
            Users = new ObservableCollection<UserModel>(users);
        }

        [RelayCommand]
        public async Task NextAsync()
        {
            await Shell.Current.GoToAsync("UsersPage", true);
        }
    }
}
