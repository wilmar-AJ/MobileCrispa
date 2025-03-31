using System.Text.Json;
using ApiWoman.Models;
using ApiWoman.Services.Interfaces;

namespace ApiWoman.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient = new();

       public async Task<List<UserModel>> GetFemaleUsersAsync()
        {
            string url = "https://randomuser.me/api/?results=10&gender=female";
            var response = await _httpClient.GetStringAsync(url);

            var json = JsonDocument.Parse(response);
            var users = new List<UserModel>();

            foreach (var user in json.RootElement.GetProperty("results").EnumerateArray())
            {
                users.Add(new UserModel
                {
                    FullName = $"{user.GetProperty("name").GetProperty("first").GetString() ?? ""} {user.GetProperty("name").GetProperty("last").GetString() ?? ""}",
                    Age = user.GetProperty("dob").GetProperty("age").GetInt32(),
                    Email = user.GetProperty("email").GetString() ?? "No disponible",
                    Gender = user.GetProperty("gender").GetString() ?? "Desconocido",
                    ProfilePicture = user.GetProperty("picture").GetProperty("large").GetString() ?? "default_profile.png"
                });
            }

            return users;
        }

    }
}
