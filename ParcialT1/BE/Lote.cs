using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Lote
    {
		private int nroLote;

		public int NroLote
		{
			get { return nroLote; }
			set { nroLote = value; }
		}

		private string nombreProp;

		public string NombreProp
        {
			get { return nombreProp; }
			set { nombreProp = value; }
		}

		private double medidaFrente;

		public double MedidaFrente
		{
			get { return medidaFrente; }
			set { medidaFrente = value; }
		}

		private double medidaFondo;

		public double MedidaFondo
		{
			get { return medidaFondo; }
			set { medidaFondo = value; }
		}

		private double totalMts2;
			
		public double TotalMts2
		{
			get { return totalMts2; }
			set { totalMts2 = value; }
		}



	}
}
