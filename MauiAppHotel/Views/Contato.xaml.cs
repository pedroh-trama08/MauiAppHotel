namespace MauiAppHotel.Views;

public partial class Contato : ContentPage
{
	public Contato()
	{
		InitializeComponent();
	}

    private async void btnVoltar1_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}