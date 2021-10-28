using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DeberRene
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
           
            double valor1;
            double valor2;
            double valor3;
            double valor4;
            double nota1;
            double nota2;
            double notatotal;
            double NotaSeguimiento1 = Convert.ToDouble(txtseguimiento1.Text);
            double examen1 = Convert.ToDouble(txtexamen1.Text);
            double NotaSeguimiento2 = Convert.ToDouble(txtseguimiento2.Text);
            double examen2 = Convert.ToDouble(txtexamen2.Text);
            valor1 = NotaSeguimiento1 * 0.3;
            valor2 = examen1 * 0.2;
            valor3 = NotaSeguimiento2 * 0.3;
            valor4 = examen2*0.2;
            //txtPago.Text = cuota3.ToString();
            nota1 = valor1 + valor2;
            nota2 = valor3 + valor4;
            notatotal = nota1 + nota2;
            txttotal.Text = notatotal.ToString();
            if (notatotal >= 7) {
                await DisplayAlert("Mensaje", "Aprobado", "OK");

            }
           else if (notatotal >= 5 && notatotal<=6.9)
            {
                await DisplayAlert("Mensaje", "Complementario", "OK");

            }
           else if (notatotal < 5)
            {
                await DisplayAlert("Mensaje", "REPROBADO", "OK");

            }
        }
    }
}
