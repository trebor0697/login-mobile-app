using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_INTEC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogInPage : ContentPage
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        async private void ButtonClicked1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (emailEntry.Text) || String.IsNullOrEmpty(passwordEntry.Text))
            {
                await DisplayAlert("Error", "Campos email y/o contraseña no pueden estar vacío", "Ok");

            }
            else 
            {
                await DisplayAlert("Bienvenido", "Hola " + emailEntry.Text, "Ok");
                await Navigation.PushModalAsync(new HomePage());

            }
        }

        async void ButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RegistrationPage());
        }
    }
}