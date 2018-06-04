using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPINOSA_MARINA
{
	class Importes
	{
		public enum Satisfacion { Bueno, MuyBueno, Excelente }

		Satisfacion _satisfacion;
		double _importeFactura;
		double _importePropina;
		double _TotalPagar;

		public Satisfacion Satisfacion1
		{
			get { return _satisfacion; }
			set { _satisfacion = value; }
		}
		public double ImporteFactura
		{
			get { return _importeFactura; }
			set {
					if (_importeFactura != value)
					{
						if (value < 0)
							_importeFactura = 0;
						else
							_importeFactura = value;
					}
				
				 }
		}

		public double ImportePropina
		{
			get { return _importePropina; }

			set
			{
				if (_importePropina != value)
				{
					if (value < 0)
						_importePropina = 0;
					else
						_importePropina = value;
				}
			}
		}

		public double TotalPagar
		{
			get { return _TotalPagar; }
			set
			{
				if (_TotalPagar != value)
				{
					if (value < 0)
						_TotalPagar = 0;
					else
						_TotalPagar = value;
				}
			}
		}

		public void CalcularPropina(int porcentaje)
		{
			double porc = Math.Round(((double)porcentaje / 100), 2);
			this.ImportePropina = Math.Round(porc * this.ImporteFactura, 2);
		}

		public void CalcularTotal()
		{
			this.TotalPagar = Math.Round(this.ImporteFactura + this.ImportePropina, 2);
		
		}

	}
}
