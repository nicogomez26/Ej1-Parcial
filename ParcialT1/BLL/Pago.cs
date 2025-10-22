using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Pago
    {
        Mp_Pago mapper = new Mp_Pago();

        public int AgregarPago(BE.Pago pago)
        {
            int fa = 0;
            fa = mapper.Agregar(pago);

            return fa;

        }

        public int EditarPago(BE.Pago pago)
        {
            int fa = 0;
            fa = mapper.Editar(pago);

            return fa;
        }

        public int EliminarPago(BE.Pago pago)
        {
            int fa = 0;
            fa = mapper.Eliminar(pago);

            return fa;
        }

        public List<BE.Pago> ListarPago()
        {
            List<BE.Pago> pagos = mapper.Listar();
            return pagos;
        }
    }
}
