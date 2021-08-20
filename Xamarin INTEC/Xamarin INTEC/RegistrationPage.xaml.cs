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
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        async private void ButtonClicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(name.Text) || String.IsNullOrEmpty(email.Text) || String.IsNullOrEmpty(password.Text) || String.IsNullOrEmpty(passwordConfirm.Text))
            {
                await DisplayAlert("Error", "Ningun campo puede estar vacio", "Ok");

            }
            else if (password.Text != passwordConfirm.Text)
            {
                await DisplayAlert("Error", "Las contraseñas deben ser iguales", "Ok");
            }
            else
            {
                await DisplayAlert("Bienvenido", "Hola " + name.Text, "Ok");
                await Navigation.PushModalAsync(new HomePage());
            }
        }
    }
}