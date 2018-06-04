using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using System.Collections;

namespace ESPINOSA_MARINA
{
	/// <summary>
	/// Lógica de interacción para Seleccioname.xaml
	/// </summary>
	public partial class Seleccioname : Window
	{
		public Seleccioname()
		{
			InitializeComponent();
			RellenarOrigen();
			ListaCiudades();

		}
		List<string> ciudades = new List<string>();

		private void ListaCiudades()
		{
			ciudades.Add("Almería");
			ciudades.Add("Cádiz");
			ciudades.Add("Málaga");
			ciudades.Add("Sevilla");
			ciudades.Add("Huelva");
			ciudades.Add("Jaén");
			ciudades.Add("Córdoba");
			ciudades.Add("Granada");
		}

		public void RellenarOrigen()
		{
			btnReiniciar.IsEnabled = false;
			btnReiniciar.Foreground = Brushes.Gray;

			lblOrigen.Items.Clear();
			lblOrigen.Items.Add("Almería");
			lblOrigen.Items.Add("Cádiz");
			lblOrigen.Items.Add("Málaga");
			lblOrigen.Items.Add("Sevilla");
			lblOrigen.Items.Add("Huelva");
			lblOrigen.Items.Add("Jaén");
			lblOrigen.Items.Add("Córdoba");
			lblOrigen.Items.Add("Granada");

		}

		private void btnReiniciar_Click(object sender, RoutedEventArgs e)
		{
			lblDestino.Items.Clear();
			RellenarOrigen();

			btnMover.IsEnabled = true;
			btnCopiar.IsEnabled = true;
		}

		private void btnMover_Click(object sender, RoutedEventArgs e)
		{

			IList seleccionados = lblOrigen.SelectedItems;
			List<string> selecString = new List<string>();
			for (int i = 0; i < seleccionados.Count; i++)
			{
				selecString.Add(seleccionados[i].ToString());
			}

			for (int i = 0; i < selecString.Count; i++)
			{
				if (!lblDestino.Items.Contains(selecString[i]))
				{
					if (ciudades.Contains(selecString[i])) 
						lblDestino.Items.Add(selecString[i]);

				}
			}

			
			for (int i = 0; i < selecString.Count; i++)
			{

				lblOrigen.Items.Remove(selecString[i]); 

			}


			if (lblDestino.Items.Count != 0)
				btnReiniciar.IsEnabled = true;

			if (lblDestino.Items.Count == 0)
				btnReiniciar.IsEnabled = false;
		}

		private void btnCopiar_Click(object sender, RoutedEventArgs e)
		{

			IList seleccionados = lblOrigen.SelectedItems;
			List<string> selecString = new List<string>();

			for (int i = 0; i < seleccionados.Count; i++)
			{
				selecString.Add(seleccionados[i].ToString());
			}


			for (int i = 0; i < selecString.Count; i++)
			{
				if (!lblDestino.Items.Contains(selecString[i]))
				{
					if (ciudades.Contains(selecString[i])) 
						lblDestino.Items.Add(selecString[i]);

				}
			}

			// borro y vuelvo a añadir
			for (int i = 0; i < selecString.Count; i++)
			{
				string ciudad = selecString[i]; // lblOrigen.SelectedItems[i].ToString();

				if (ciudades.Contains(ciudad))
				{
					TextBlock tbx = new TextBlock();
					tbx.Text = ciudad;
					tbx.Foreground = Brushes.Red;

					lblOrigen.Items.Remove(selecString[i]);
					lblOrigen.Items.Add(tbx);
				}
				

			}


			if (lblDestino.Items.Count != 0)
				btnReiniciar.IsEnabled = true;

			if (lblDestino.Items.Count == 0)
				btnReiniciar.IsEnabled = false;


			if (lblOrigen.Items.IsEmpty == true)
			{
				btnCopiar.IsEnabled = false;
				btnMover.IsEnabled = false;
			}

			if (lblDestino.Items.Count == 8)
			{
				btnCopiar.IsEnabled = false;
				btnMover.IsEnabled = false;
			}

		}

	}
}
