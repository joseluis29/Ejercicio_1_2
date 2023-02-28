using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Ejercicio_1_2.Models;
using Xamarin.Forms;

namespace Ejercicio_1_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

     
        private async void b_enviar_Clicked(object sender, EventArgs e)
        {
            var emple = new Models.datos
            {
               
                nombre = TNombre.Text,
                apellidos= TApellidos.Text,
                edad = TEdad.Text,
                correo= TCorreo.Text
            };


            var segunda = new SecondPage();
            segunda.BindingContext = emple;
            await Navigation.PushAsync(segunda);
        }
    }
}
