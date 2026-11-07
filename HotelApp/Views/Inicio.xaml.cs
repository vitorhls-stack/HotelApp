namespace HotelApp.Views;

public partial class Inicio : ContentPage
{
    public Inicio()
    {
        InitializeComponent();
    }

    private async void OnReservarClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ContratacaoHospedagem());
    }

    private async void OnSuitesClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Suites());
    }

    private async void OnSobreClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }
}