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

namespace ESPINOSA_MARINA
{
	/// <summary>
	/// Lógica de interacción para matrizClaves.xaml
	/// </summary>
	public partial class matrizClaves : Window
	{
		List<int> Alea = new List<int>();
		List<int> matrices = new List<int>();
		Random rnd = new Random();
		bool pulsoControl = false;

		public matrizClaves()
		{
			InitializeComponent();
			RellenarListaEnteros();
			RellenarGridEnteros();
		}

		private void RellenarGrid()
		{
			grd_coordenadas.RowDefinitions.Clear();
			grd_coordenadas.ColumnDefinitions.Clear();
			for (int i = 0; i < 9; i++)
			{
				grd_coordenadas.RowDefinitions.Add(new RowDefinition());
			}

			for (int i = 0; i < 9; i++)
			{
				grd_coordenadas.ColumnDefinitions.Add(new ColumnDefinition());
			}
		}

		private void RellenarListaEnteros()
		{
			int celdas = 8 * 8;
			for (int i = 0; i < celdas; i++) // Lista que relleno de 8*8 numeros aleatorios
			{

				int random = rnd.Next(100, 999); 
				if (!Alea.Contains(random)) // Solo lo añado si no está ya añadido (SIN REPETICIÓN)
					Alea.Add(random);				
			}

			// Si no se ha rellenado entero (porque había algun repetido que no se añadió), busco no repetidos hasta que se rellene entero
			if (Alea.Count < celdas)
			{
				do
				{
					int random2 = rnd.Next(100, 999); 
					if (!Alea.Contains(random2))
						Alea.Add(random2);
				} while (Alea.Count < celdas);
				
			}

		}

		private void RellenarGridEnteros()
		{
			for (int i = 0; i < grd_coordenadas.RowDefinitions.Count; i++)
			{
				for (int j = 0; j < grd_coordenadas.ColumnDefinitions.Count; j++)
				{
					// Si la fila es la 0 o si la columna es la 0 no valep
					if (i != 0 && j != 0)
					{
						TextBox tbxTmp = new TextBox();
						tbxTmp.IsReadOnly = true;
						tbxTmp.TextAlignment = TextAlignment.Center;
						tbxTmp.BorderBrush = new SolidColorBrush(Colors.Black);

						try
						{
							tbxTmp.Text = Alea[0].ToString();

							matrices.Add(Alea[0]);

							Alea.RemoveAt(0);

						}
						catch
						{
						}

						grd_coordenadas.Children.Add(tbxTmp);
						Grid.SetRow(tbxTmp, i);
						Grid.SetColumn(tbxTmp, j);


					}

				}
			}
		}



		private void Window_KeyDown(object sender, KeyEventArgs e)
		{

			// Si acabas de pulsar control pero no has pulsado ahora V, se desactiva el boolean
			if (e.Key != Key.V && pulsoControl == true)
			{
				pulsoControl = false;
			}

			// Activo el boolean si has pulsado control
			else if (e.Key == Key.RightCtrl || e.Key == Key.LeftCtrl)
			{
				pulsoControl = true;
			}


			string mensaje = "";
			matrices.Sort();
			for (int i = 0; i < matrices.Count; i++)
			{

				mensaje += string.Format("{0}\t", matrices[i]);

			}

			// Si acabas de pulsar control y pulsas V, es cuando sale el mensaje
			if (e.Key == Key.V && pulsoControl == true)
			{
				MessageBox.Show(mensaje);
				pulsoControl = false;
			}
		}


	}
}
