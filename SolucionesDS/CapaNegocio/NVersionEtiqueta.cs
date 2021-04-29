using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class NVersionEtiqueta
    {
        //Instanciamos nuestra clase DVersionEtiqueta para poder utilizar sus miembros
        private DVersionEtiqueta objDVersion = new DVersionEtiqueta();
        //
        //El uso de la clase StringBuilder nos ayudara a devolver los mensajes de las validaciones
        public readonly StringBuilder stringBuilder = new StringBuilder();

        public List<EVersionEtiqueta> ObtenerVersionEtiqueta(short idSociedad)
        {
            return objDVersion.ObtenerVersionEtiqueta(idSociedad);
        }

        public EVersionEtiqueta ObtenerVersionEtiquetaPorID(short idVersion)
        {
            stringBuilder.Clear();
            if (idVersion < 0) stringBuilder.Append("No se encontró la versión de la etiqueta.");
            if (stringBuilder.Length == 0)
            {
                return objDVersion.ObtenerVersionEtiquetaPorID(idVersion);
            }
            return null;
        }
    }
}
