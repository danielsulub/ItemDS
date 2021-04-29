using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    public class NExplorador
    {
        //Instanciamos nuestra clase DExplorador para poder utilizar sus miembros
        private DExplorador objDExplorador = new DExplorador();
        //
        //El uso de la clase StringBuilder nos ayudara a devolver los mensajes de las validaciones
        public readonly StringBuilder stringBuilder = new StringBuilder();

        public List<EExplorador> ObtenerArticulos(string datoBusqueda)
        {
            return objDExplorador.ObtenerArticulos(datoBusqueda);
        }

        public EExplorador ObtenerArticuloPorID(short idArticulo)
        {
            stringBuilder.Clear();
            if (idArticulo < 0) stringBuilder.Append("No se encontró el artículo.");
            if (stringBuilder.Length == 0)
            {
                return objDExplorador.ObtenerArticuloPorID(idArticulo);
            }
            return null;
        }
    }
}
