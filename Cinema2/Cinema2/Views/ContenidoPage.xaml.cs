using Cinema2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContenidoPage : ContentPage
	{
		public ContenidoPage ( Funcion funcion, Peliculas pelicula, int valor)
		{
            int total = valor * (funcion.Precio);
			InitializeComponent ();
            stackLayout.BindingContext = funcion;
            peliculasel.BindingContext = pelicula;
            miLabel.Text = Convert.ToString(valor);
            lbltotal.Text = Convert.ToString(total);
		}

        private void Confirmar(object sender, EventArgs e)
        {
            DisplayAlert("Reserva", "La reserva se ha generado correctamente", "Continuar");
        }
    }
}