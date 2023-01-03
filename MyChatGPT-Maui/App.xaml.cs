using FreshMvvm.Maui;
using MyChatGPT_Maui.PageModels;

namespace MyChatGPT_Maui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        var mainPage = FreshPageModelResolver.ResolvePageModel<HomePageModel>();
        MainPage = new FreshNavigationContainer(mainPage);
    }
}

