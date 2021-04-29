using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    public class NSociedades
    {
        //Instanciamos nuestra clase DSociedades para poder utilizar sus miembros
        private DSociedades objDSociedades = new DSociedades();
        //
        //El uso de la clase StringBuilder nos ayudara a devolver los mensajes de las validaciones
        public readonly StringBuilder stringBuilder = new StringBuilder();

        public List<ESociedades> ObtenerSociedades()
        {
            return objDSociedades.ObtenerSociedades();
        }

        public ESociedades ObtenerSociedadPorID(short idSociedad)
        {
            stringBuilder.Clear();
            if (idSociedad < 0) stringBuilder.Append("Por favor seleccione una sociedad.");
            if (stringBuilder.Length == 0)
            {
                return objDSociedades.ObtenerSociedadPorID(idSociedad);
            }
            return null;
        }
    }
}
