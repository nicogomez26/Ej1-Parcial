using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Ubicacion
    {
        Mp_Ubicacion mapper = new Mp_Ubicacion();

        public int AgregarUbicacion(BE.Ubicacion ubi)
        {
            int fa = 0;
            fa = mapper.Agregar(ubi);

            return fa;

        }

        public int EditarUbicacion(BE.Ubicacion ubi)
        {
            int fa = 0;
            fa = mapper.Editar(ubi);

            return fa;
        }

        public int EliminarUbicacion(BE.Ubicacion ubi)
        {
            int fa = 0;
            fa = mapper.Eliminar(ubi);

            return fa;
        }

        public List<BE.Ubicacion> ListarUbicacion()
        {
            List<BE.Ubicacion> ubicaciones = mapper.Listar();
            return ubicaciones;
        }
    }
}
