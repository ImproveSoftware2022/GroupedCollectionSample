using CommunityToolkit.Maui;
using GroupedCollectionSample.ViewModels;
using GroupedCollectionSample.Views;
using Microsoft.Extensions.Logging;

namespace GroupedCollectionSample;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
        var builder = MauiApp.CreateBuilder();

        builder.UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .UseMauiCommunityToolkit()
            .ConfigureMauiHandlers(handlers =>
            {

            });

        builder.Services.AddTransient<ListPage>();
        builder.Services.AddTransient<DetailPage>();
        builder.Services.AddTransient<ListViewModel>();
        builder.Services.AddTransient<DetailViewModel>();

        return builder.Build();

    }
}

