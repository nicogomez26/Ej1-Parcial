using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Pago
    {

		private int nroPago;

		public int NroPago
		{
			get { return nroPago; }
			set { nroPago = value; }
		}

		private int nroLote;

		public int NroLote
		{
			get { return nroLote; }
			set { nroLote = value; }
		}

		private int ubicacion;

		public int Ubicacion
		{
			get { return ubicacion; }
			set { ubicacion = value; }
		}

		private double mts2Total;

		public double Mts2Total
		{
			get { return mts2Total; }
			set { mts2Total = value; }
		}

		private double precioMts2;

		public double PrecioMts2
		{
			get { return precioMts2; }
			set { precioMts2 = value; }
		}

		private double total;

		public double Total
		{
			get { return total; }
			set { total = value; }
		}

	}
}
