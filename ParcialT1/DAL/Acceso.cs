using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Acceso
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public void Conectar()
        {
            cn.ConnectionString = @"Data Source=.;Initial Catalog=Consorcio;Integrated Security=True"; 
            cn.Open();
        }

        public void Desconectar()
        {
            cn.Close();
            cn.Dispose();
        }

        public int Escribir(string sp, SqlParameter[] parametro)
        {
            int fa = 0;
            Conectar();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;

            if (parametro != null)
            {
                cmd.Parameters.AddRange(parametro);
                fa = cmd.ExecuteNonQuery();
            }
            else
            {
                fa = cmd.ExecuteNonQuery();
            }
            cmd.Parameters.Clear();
            Desconectar();

            return fa;
        }

        public DataTable Leer(string sp, SqlParameter[] parametro)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            Conectar();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;

            if (parametro != null) {
                cmd.ExecuteReader();
            }

            adaptador.SelectCommand = cmd;
            adaptador.Fill(dt);

            Desconectar();
            return dt;

        }


    }
}
