using maui_navigation.Models;
using maui_navigation.ViewModel;

namespace maui_navigation.Pages;

public partial class Page2 : ContentPage
{
    public CustomerViewModel CustomerViewModel  { get; set; }
    public Page2()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavUtilities.Examine(Navigation);
    }
    public Page2(CustomerViewModel customerViewModel)
    {
        InitializeComponent();
        CustomerViewModel = customerViewModel;
        BindingContext = CustomerViewModel;
    }

    private async void btnGotoPage3_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page3());
    }



    private async void btnGotoPage1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}