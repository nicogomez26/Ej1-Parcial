using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Lote
    {
        Mp_Lote mapper = new Mp_Lote();

        public int AgregarLote(BE.Lote lote )
        {
            int fa = 0;
            fa = mapper.Agregar( lote );

            return fa;  

        }

        public int EditarLote(BE.Lote lote)
        {
            int fa = 0;
            fa = mapper.Editar(lote);

            return fa;
        }

        public int EliminarLote(BE.Lote lote)
        {
            int fa = 0;
            fa = mapper.Eliminar(lote);

            return fa;
        }

        public List<BE.Lote> ListarLote()
        {
            List<BE.Lote> lotes = mapper.Listar();
            return lotes;
        }


    }
}
