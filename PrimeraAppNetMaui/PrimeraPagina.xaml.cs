namespace PrimeraAppNetMaui;

public partial class PrimeraPagina : ContentPage
{
    private object bntInstituto;

    public PrimeraPagina()
	{
		InitializeComponent();
        bntInstituto.Clicked += btnInstituto_Clicked;
        btnCarrera.Clicked += async (s, a ) => 
        {

        }

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Application.Current.MainPage.DisplayAlert("Ventana de Mensaje", "Hola Mundo y bienvenido a netMaui", "ok");
    }
}