namespace PrimeraAppNetMaui.Pages;

public partial class PrimeraPagina : ContentPage
{
    private object bntInstituto;

    public PrimeraPagina()
	{
		InitializeComponent();
        btnInstituto.Clicked += btnInstituto_Clicked;
        btnCarrera.Clicked += async (s, a) =>
        {
            await Application.Current.MainPage.DisplayAlert("Carrera", "Tecnico Superior en Desarrollo", "Ok");
        };

    }

    private async void btnInstituto_Clicked(object? sender, EventArgs e)
    {
        await Application.Current.MainPage.DisplayAlert("Institucion", "Instituto Superior \"Sdor. Nestor Juan Zamaro \"", "Ok");
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Application.Current.MainPage.DisplayAlert("Ventana de Mensaje", "Hola Mundo y bienvenido a netMaui", "ok");
    }
}