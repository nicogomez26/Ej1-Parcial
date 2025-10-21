using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Mp_Ubicacion
    {
        Acceso acc = new Acceso();

        public int Agregar(BE.Ubicacion ubicacion)
        {
            int fa = 0;

            SqlParameter[] parametro = new SqlParameter[2];
            parametro[1] = new SqlParameter("descipcion", ubicacion.Descripcion);
            parametro[2] = new SqlParameter("valorMts2", ubicacion.ValorMts2);

            fa = acc.Escribir("crearUbicacion", parametro);

            return fa;
        }

        public int Editar(BE.Ubicacion ubicacion)
        {

            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[2];
            parametro[1] = new SqlParameter("descipcion", ubicacion.Descripcion);
            parametro[2] = new SqlParameter("valorMts2", ubicacion.ValorMts2);

            fa = acc.Escribir("editarUbicacion", parametro);

            return fa;
        }

        public int Eliminar(BE.Ubicacion ubicacion)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("@nuevoIdUbicacion", ubicacion.IdUbicacion);

            fa = acc.Escribir("eliminarUbicacion", parametro);

            return fa;
        }

        public List<BE.Ubicacion> Listar()
        {
            List<BE.Ubicacion> ubicaciones = new List<BE.Ubicacion>();
            DataTable tabla = acc.Leer("listarUbicaciones", null);
            foreach (DataRow dr in tabla.Rows)
            {
                BE.Ubicacion ubicacion = new BE.Ubicacion();
                ubicacion.IdUbicacion = int.Parse(dr["Id_Ubicacion"].ToString());
                ubicacion.Descripcion = dr["Descripcion"].ToString();
                ubicacion.ValorMts2 = double.Parse(dr["Valor_Mts2"].ToString());

                ubicaciones.Add(ubicacion);
            }
            return ubicaciones;
        }
    }
}
