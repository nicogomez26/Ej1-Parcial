using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Ubicacion
    {

		private int idUbicacion;

		public int IdUbicacion
		{
			get { return idUbicacion; }
			set { idUbicacion = value; }
		}

		private string descripcion;

		public string Descripcion
		{
			get { return descripcion; }
			set { descripcion = value; }
		}

		private double valorMts2;

		public double ValorMts2
		{
			get { return valorMts2; }
			set { valorMts2 = value; }
		}

	}
}
