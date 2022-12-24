using maui_navigation.Models;

namespace maui_navigation.Pages;

public partial class ModalPage : ContentPage
{
	public ModalPage()
	{
		InitializeComponent();
	}

    protected override bool OnBackButtonPressed()
    {
        return true;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavUtilities.Examine(Navigation);
    }

    private void btnGotoModalPage_Clicked(object sender, EventArgs e)
    {
		Navigation.PopModalAsync();
    }
}