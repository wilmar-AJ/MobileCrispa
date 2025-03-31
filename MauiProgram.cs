// using Microsoft.Extensions.Logging;

// namespace ApiWoman;

// public static class MauiProgram
// {
// 	public static MauiApp CreateMauiApp()
// 	{
// 		var builder = MauiApp.CreateBuilder();
// 		builder
// 			.UseMauiApp<App>()
// 			.ConfigureFonts(fonts =>
// 			{
// 				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
// 				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
// 			});

// #if DEBUG
// 		builder.Logging.AddDebug();
// #endif

// 		return builder.Build();
// 	}
// }
using ApiWoman.Services;
using ApiWoman.Services.Interfaces;
using ApiWoman.ViewModels;
using ApiWoman.Pages;

namespace ApiWoman;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>()
               .ConfigureFonts(fonts =>
               {
                   fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
               });

        builder.Services.AddSingleton<IApiService, ApiService>();
        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddSingleton<UserPage>();

        return builder.Build();
    }
}
