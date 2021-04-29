using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    public class NGestores
    {
        //Instanciamos nuestra clase DGestores para poder utilizar sus miembros
        private DGestores objDGestor = new DGestores();
        //
        //El uso de la clase StringBuilder nos ayudara a devolver los mensajes de las validaciones
        public readonly StringBuilder stringBuilder = new StringBuilder();

        public List<EGestores> ObtenerGestores()
        {
            return objDGestor.ObtenerGestores();
        }

        public EGestores ObtenerGestorPorID(short idGestor)
        {
            stringBuilder.Clear();
            if (idGestor < 0) stringBuilder.Append("No se encontró el gestor.");
            if (stringBuilder.Length == 0)
            {
                return objDGestor.ObtenerGestorPorID(idGestor);
            }
            return null;
        }
    }
}
