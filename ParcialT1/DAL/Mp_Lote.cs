using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Mp_Lote
    {
        Acceso acc = new Acceso();

        public int Agregar(BE.Lote lote)
        {
            int fa = 0;

            SqlParameter[] parametro = new SqlParameter[4];
            parametro[1] = new SqlParameter("nombreProp",lote.NombreProp);
            parametro[2] = new SqlParameter("medidaFrente", lote.MedidaFrente);
            parametro[3] = new SqlParameter("medidaFondo",lote.MedidaFondo);
            parametro[4] = new SqlParameter("totalMts2",lote.TotalMts2);

            fa = acc.Escribir("crearLote", parametro);

            return fa;
        }

        public int Editar(BE.Lote lote) {

            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[4];
            parametro[1] = new SqlParameter("@nombrePago", lote.NombreProp);
            parametro[2] = new SqlParameter("@medidaFrente", lote.MedidaFrente);
            parametro[3] = new SqlParameter("@medidaFondo", lote.MedidaFondo);
            parametro[4] = new SqlParameter("@totalMts2", lote.TotalMts2);
            fa = acc.Escribir("editarLote", parametro);

            return fa;
        }

        public int Eliminar(BE.Lote lote)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("@nuevoNroLote", lote.NroLote);
            fa = acc.Escribir("eliminarLote", parametro);

            return fa;
        }

        public List<BE.Lote> Listar()
        {
            List<BE.Lote> lotes = new List<BE.Lote>();
            DataTable tabla = acc.Leer("listarLote", null);
            foreach (DataRow dr in tabla.Rows)
            {
                BE.Lote lote = new BE.Lote();
                lote.NroLote = int.Parse(dr["Nro_Lote"].ToString());
                lote.NombreProp = dr["Nombre_Propietario"].ToString();
                lote.MedidaFrente = double.Parse(dr["Medida_Frente"].ToString());
                lote.MedidaFondo = double.Parse(dr["Medida_Fondo"].ToString());
                lote.TotalMts2 = double.Parse(dr["Total_Mts2"].ToString());

                lotes.Add(lote);

            }
            return lotes;
        }
    }
}
