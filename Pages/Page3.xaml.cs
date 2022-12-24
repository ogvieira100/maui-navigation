using maui_navigation.Models;

namespace maui_navigation.Pages;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavUtilities.Examine(Navigation);
    }

    private void btnGotoRootPage_Clicked(object sender, EventArgs e)
    {
		Navigation.PopToRootAsync();
    }

    private void btnGotoModalPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new ModalPage());
    }
}