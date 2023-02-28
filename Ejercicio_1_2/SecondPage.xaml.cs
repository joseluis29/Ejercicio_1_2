using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Ejercicio_1_2.Models;

namespace Ejercicio_1_2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }
        public SecondPage(String pnombre, String papellidos, String pedad, String pcorreo)

        {
            InitializeComponent();

            lbnombre.Text = pnombre;
            lbapellidos.Text = papellidos;
            lbedad.Text = pedad;
            lbcorreo.Text = pcorreo;

        }
    }
}