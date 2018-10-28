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
	public partial class FuncionesPage : ContentPage
	{
        Peliculas globalpel;
		public FuncionesPage (Peliculas pelicula)
		{
			InitializeComponent ();
            BindingContext = pelicula;
            listFunciones.ItemsSource = pelicula.Funciones;
            globalpel = pelicula;
		}

        

        private async void Selected_Funcion(object sender, SelectedItemChangedEventArgs e)
        {
            int valor = Convert.ToInt32(MiEntry.Text);
            var funcion = e.SelectedItem as Funcion;
            await Navigation.PushAsync(new ContenidoPage(funcion, globalpel, valor));
        }
    }
}