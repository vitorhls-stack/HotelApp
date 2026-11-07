namespace HotelApp.Views;

public partial class Suites : ContentPage
{
    public Suites()
    {
        InitializeComponent();

        var app = (App)Application.Current!;
        cv_suites.ItemsSource = app.lista_quartos;
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}