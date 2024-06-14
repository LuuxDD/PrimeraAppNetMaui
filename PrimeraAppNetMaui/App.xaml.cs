
using System.Diagnostics;

namespace PrimeraAppNetMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
           
           Window nuestraApp = base.CreateWindow(activationState);
            nuestraApp.Activated +=  SaludoDeBienvenida;
            nuestraApp.Destroying += async(s,a) => await MensajeAppCerrada(s,a);
            nuestraApp.Resumed += async (s, a) => await MensajeRestaurada (s,a);
            nuestraApp.Deactivated += async (s, a) => await MensajeAppSuspendida(s, a);
            
            return nuestraApp;

        }

        private async Task MensajeAppSuspendida(object? sender, EventArgs e)
        {
            Debug.Print(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Ha Salidode la App pero todavia sigue en memoria");
        }

        private async Task MensajeRestaurada(object? sender, EventArgs e)
        {
            Debug.Print(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Ha vuelto a la App");
        }

        private async Task MensajeAppCerrada(object? sender, EventArgs e)
        {
            Debug.Print(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Esta cerrando la App");
        }

        private async void SaludoDeBienvenida(object? sender, EventArgs e)
        {
            await Application.Current.MainPage.DisplayAlert("Titulo","Bienvenida a Nuestra App", "Ok");
        }
    }
}
