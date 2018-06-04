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
//---------------------------
using System.Text.RegularExpressions;

namespace ESPINOSA_MARINA
{
	/// <summary>
	/// Lógica de interacción para Propinas.xaml
	/// </summary>
	public partial class Propinas : Window
	{
		public Propinas()
		{
			InitializeComponent();
			tbx_ImporteFactura.Focus();
		}

		private void tbx_ImporteFactura_LostFocus(object sender, RoutedEventArgs e)
		{
			ImportesCalcular();


		}

		private void tbx_ImporteFactura_PreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			Regex regla = new Regex("[0-9,.]");
			if (!regla.IsMatch(e.Text))
				e.Handled = true;

			if (e.Text == "," && tbx_ImporteFactura.Text.Substring(tbx_ImporteFactura.Text.Length -1, 1) == ",")
			{
				e.Handled = true;
			}

			if (e.Text == ".")
			{
				MessageBox.Show("Debe usar la coma para los decimales");
				e.Handled = true;
			}
		}

		private void ImportesCalcular()
		{
			Importes importe = new Importes();

			try
			{
				importe.ImporteFactura = double.Parse(tbx_ImporteFactura.Text);

				tbx_ImporteFactura.Text = importe.ImporteFactura.ToString("0.00");

				if (rbt_bueno.IsChecked == true)
				{
					importe.Satisfacion1 = Importes.Satisfacion.Bueno;
					

					importe.CalcularPropina(10);
					importe.CalcularTotal();

					tbl_ImportePropina.Text = importe.ImportePropina.ToString("0.00");
					tbl_ImporteTotal.Text = importe.TotalPagar.ToString("0.00");

				}

				if (rbt_muybueno.IsChecked == true)
				{
					importe.Satisfacion1 = Importes.Satisfacion.MuyBueno;

					importe.CalcularPropina(15);
					importe.CalcularTotal();

					tbl_ImportePropina.Text = importe.ImportePropina.ToString("0.00");
					tbl_ImporteTotal.Text = importe.TotalPagar.ToString("0.00");

				}

				if (rbtExcelente.IsChecked == true)
				{
					importe.Satisfacion1 = Importes.Satisfacion.Excelente;

					importe.CalcularPropina(20);
					importe.CalcularTotal();

					tbl_ImportePropina.Text = importe.ImportePropina.ToString("0.00");
					tbl_ImporteTotal.Text = importe.TotalPagar.ToString("0.00");

				}
			}

			catch
			{
				if (tbx_ImporteFactura.Text != "0,00")
				{
					MessageBox.Show("Debe introducir un importe correcto");
				}

			}
		}

		private void rbt_muybueno_Checked(object sender, RoutedEventArgs e)
		{
			ImportesCalcular();
		}

	}
}
