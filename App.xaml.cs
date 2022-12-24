using maui_navigation.Pages;

namespace maui_navigation;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		var pageNav = new NavigationPage(new Page1());
		MainPage = pageNav;
	}
}
