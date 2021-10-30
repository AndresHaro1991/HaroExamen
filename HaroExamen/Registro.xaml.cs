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
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuarioCo.Text = usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {

            double interes = 90;
            double montoi = Convert.ToDouble(txtMontoI.Text);

            double diferencia = 1800 - montoi;
            double cuota = (diferencia / 3) + interes;
           

            if (montoi <=0 || montoi >1800)
            {
                DisplayAlert("Mensaje de Advertencia", "El monto inicial ingresado es menor a 0 o mayor a 1800", "Reintentar");
                txtMontoI.Text = "";
            }
            else
            {
                txtPagoM.Text = Convert.ToString(cuota);
            }
            

        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string usuario = lblUsuarioCo.Text;
            string cliente = txtNombres.Text;
            
            double montoi2 = Convert.ToDouble(txtMontoI.Text);
            double cuota = ((1800-montoi2)/3)+90;
            double pagof = cuota * 3 + montoi2;
            await DisplayAlert("Mensaje de Informacion", "Registro procesado Correctamente", "Resumen");

            await Navigation.PushAsync(new Resumen(usuario,cliente,pagof));
        }
    }
}