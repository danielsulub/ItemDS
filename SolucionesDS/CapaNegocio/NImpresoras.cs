using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class NImpresoras
    {
        //Instanciamos nuestra clase DImpresoras para poder utilizar sus miembros
        private DImpresoras objDImpresora = new DImpresoras();
        //
        //El uso de la clase StringBuilder nos ayudara a devolver los mensajes de las validaciones
        public readonly StringBuilder stringBuilder = new StringBuilder();

        public List<EImpresoras> ObtenerImpresoras()
        {
            return objDImpresora.ObtenerImpresoras();
        }

        public EImpresoras ObtenerImpresoraPorID(short idImpresora)
        {
            stringBuilder.Clear();
            if (idImpresora < 0) stringBuilder.Append("No se encontró la impresora.");
            if (stringBuilder.Length == 0)
            {
                return objDImpresora.ObtenerImpresoraPorID(idImpresora);
            }
            return null;
        }
    }
}
