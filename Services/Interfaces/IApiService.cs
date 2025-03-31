using System;
using ApiWoman.Models;

namespace ApiWoman.Services.Interfaces;

public interface IApiService
{ 
    Task<List<UserModel>> GetWomenUsersAsync();
}
