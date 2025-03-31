using System.Net.Http.Json;
using System.Text.Json;
using ApiWoman.Models;
using ApiWoman.Services.Interfaces;

namespace ApiWoman.Services;

    public class ApiService : IApiService
    {

        private readonly HttpClient _httpClient = new();

        public async Task<List<UserModel>> GetWomenUsersAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<ApiResponse>("https://randomuser.me/api/?results=50&gender=female");

            return response?.Results.Select(u => new UserModel
            {
                FullName = $"{u.Name.First} {u.Name.Last}",
                Age = u.Dob.Age,
                Email = u.Email,
                Gender = u.Gender,
                ProfilePicture = u.Picture.Large 
            }).ToList() ?? new List<UserModel>();
        }

    }

