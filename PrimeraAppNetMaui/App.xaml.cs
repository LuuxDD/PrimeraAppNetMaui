
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
            nuestraApp.Activated += SaludoDeBienvenida;
            nuestraApp.Deactivated += MensajeAppCerrada;
            nuestraApp.Resumed += MensajeRestaurada;
            nuestraApp.Deactivated += MensajeAppSuspendida;
            
            return nuestraApp;

        }

        private void MensajeAppSuspendida(object? sender, EventArgs e)
        {
            Debug.Print(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Ha Salidode la App pero todavia sigue en memoria");
        }

        private void MensajeRestaurada(object? sender, EventArgs e)
        {
            Debug.Print(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Ha vuelto a la App");
        }

        private void MensajeAppCerrada(object? sender, EventArgs e)
        {
            Debug.Print(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Esta cerrando la App");
        }

        private async void SaludoDeBienvenida(object? sender, EventArgs e)
        {
            await Application.Current.MainPage.DisplayAlert("Titulo","Bienvenida a Nuestra App", "Ok");
        }
    }
}
