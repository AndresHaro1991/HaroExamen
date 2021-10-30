using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HaroExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario,string cliente, double pagof)
        {
            InitializeComponent();
            lblUsuarioCo.Text = usuario;
            txtCliente.Text = cliente;
            txtTotal.Text = Convert.ToString(pagof);

        }
    }
}