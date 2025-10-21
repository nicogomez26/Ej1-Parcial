using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Mp_Pago
    {
        Acceso acc = new Acceso();

        public int Agregar(BE.Pago pago)
        {
            int fa = 0;

            SqlParameter[] parametro = new SqlParameter[5];
            parametro[1] = new SqlParameter("idUbicacion", pago.NroLote);
            parametro[2] = new SqlParameter("idUbicacion", pago.Ubicacion);
            parametro[3] = new SqlParameter("totalMts2", pago.Mts2Total);
            parametro[4] = new SqlParameter("precioMts2", pago.PrecioMts2);
            parametro[5] = new SqlParameter("total", pago.Total);

            fa = acc.Escribir("crearPago", parametro);

            return fa;
        }

        public int Editar(BE.Pago pago)
        {

            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[5];
            parametro[1] = new SqlParameter("idUbicacion", pago.NroLote);
            parametro[2] = new SqlParameter("idUbicacion", pago.Ubicacion);
            parametro[3] = new SqlParameter("totalMts2", pago.Mts2Total);
            parametro[4] = new SqlParameter("precioMts2", pago.PrecioMts2);
            parametro[5] = new SqlParameter("total", pago.Total);

            fa = acc.Escribir("editarPago", parametro);

            return fa;
        }

        public int Eliminar(BE.Pago pago)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("@nuevoNroPago", pago.NroPago);

            fa = acc.Escribir("eliminarPago", parametro);

            return fa;
        }

        public List<BE.Pago> Listar()
        {
            List<BE.Pago> pagos = new List<BE.Pago>();
            DataTable tabla = acc.Leer("listarPago", null);
            foreach (DataRow dr in tabla.Rows)
            {
                BE.Pago pago = new BE.Pago();
                pago.NroPago = int.Parse(dr["Nro_Pago"].ToString());
                pago.NroLote = int.Parse(dr["Nro_Lote"].ToString());
                pago.Ubicacion = int.Parse(dr["Ubicacion"].ToString());
                pago.Mts2Total = double.Parse(dr["Mts2_Totales"].ToString());
                pago.PrecioMts2 = double.Parse(dr["Precio_Mts2"].ToString());
                pago.Total= double.Parse(dr["Total"].ToString());

                pagos.Add(pago);

            }
            return pagos;
        }
    }
}
