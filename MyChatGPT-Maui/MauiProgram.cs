using Microsoft.Extensions.Logging;
using MyChatGPT_Maui.PageModels;
using MyChatGPT_Maui.Pages;
using FreshMvvm.Maui.Extensions;
using MyChatGPT_Maui.Services.ClientInfoServices;

namespace MyChatGPT_Maui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
        builder.Services.AddTransient<HomePage>();
        builder.Services.AddTransient<HomePageModel>();

        builder.Services.AddTransient<DataPage>();
        builder.Services.AddTransient<DataPageModel>();

        builder.Services.AddSingleton<IClientInfoServices, ClientInfoServices>();

		MauiApp mauiApp = builder.Build();

        mauiApp.UseFreshMvvm();

        return mauiApp;
	}
}

