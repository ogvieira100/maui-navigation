using maui_navigation.Models;

namespace maui_navigation.Pages;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavUtilities.Examine(Navigation);
    }

    private async void btnGotoPage2_Clicked(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new Page2());
        await Navigation.PushAsync(new Page2(new ViewModel.CustomerViewModel { Name = "Osmar" , Address = "Rua Tal" , City = "São Paulo" }));
        
    }
}