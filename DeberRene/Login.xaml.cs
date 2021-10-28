using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DeberRene
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            String sUsuario = txtUsuario.Text;
            String sContraseña = txtcontraseña.Text;

            if((sUsuario =="estudiante2021") && (sContraseña == "uisrael2021"))
            {
                Navigation.PushAsync(new MainPage());
            }

            else
            {

                lblResultado.Text = "El Usuario o la Contarseña es incorrecta";
            }


        }
    }
}