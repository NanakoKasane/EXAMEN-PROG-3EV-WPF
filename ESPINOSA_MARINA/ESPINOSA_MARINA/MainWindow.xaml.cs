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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ESPINOSA_MARINA
{
	/// <summary>
	/// Lógica de interacción para MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void prop2_Click(object sender, RoutedEventArgs e)
		{			
			statusbar.Items.Clear();
			statusbar.Items.Add("Propinas");

			Propinas prop = new Propinas();
			prop.ShowDialog();
		}

		private void matriz2_Click(object sender, RoutedEventArgs e)
		{
			statusbar.Items.Clear();
			statusbar.Items.Add("Matriz Claves");

			matrizClaves mat = new matrizClaves();
			mat.ShowDialog();
		}

		private void selec2_Click(object sender, RoutedEventArgs e)
		{
			statusbar.Items.Clear();
			statusbar.Items.Add("Seleccióname");

			Seleccioname sel = new Seleccioname();
			sel.ShowDialog();
		}
	}
}
