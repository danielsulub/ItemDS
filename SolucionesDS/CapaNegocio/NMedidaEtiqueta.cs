using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class NMedidaEtiqueta
    {
        //Instanciamos nuestra clase DMedidaEtiqueta para poder utilizar sus miembros
        private DMedidaEtiqueta objDVersion = new DMedidaEtiqueta();
        //
        //El uso de la clase StringBuilder nos ayudara a devolver los mensajes de las validaciones
        public readonly StringBuilder stringBuilder = new StringBuilder();

        public List<EMedidaEtiqueta> ObtenerMedidaEtiqueta()
        {
            return objDVersion.ObtenerMedidaEtiqueta();
        }

        public EMedidaEtiqueta ObtenerMedidaEtiquetaPorID(short idMedida)
        {
            stringBuilder.Clear();
            if (idMedida < 0) stringBuilder.Append("No se encontró la medida de la etiqueta.");
            if (stringBuilder.Length == 0)
            {
                return objDVersion.ObtenerMedidaEtiquetaPorID(idMedida);
            }
            return null;
        }

    }
}
