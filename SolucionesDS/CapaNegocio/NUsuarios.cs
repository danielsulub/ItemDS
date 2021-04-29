using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    public class NUsuarios
    {
        //Instanciamos nuestra clase DSociedades para poder utilizar sus miembros
        private DUsuarios objDUsuarios = new DUsuarios();
        //
        //El uso de la clase StringBuilder nos ayudara a devolver los mensajes de las validaciones
        public readonly StringBuilder stringBuilder = new StringBuilder();

        public List<EUsuarios> ObtenerUsuarios()
        {
            return objDUsuarios.ObtenerUsuarios();
        }

        public EUsuarios ObtenerUsuarioPorID(string usuario, string password, short idSociedad)
        {
            stringBuilder.Clear();
            if (string.IsNullOrWhiteSpace(usuario)) stringBuilder.Append("Favor de escribir un nombre de usuario.");
            if (string.IsNullOrWhiteSpace(password)) stringBuilder.Append("Favor de escribir el password de usuario.");
            if (stringBuilder.Length == 0)
            {
                return objDUsuarios.ObtenerUsuarioPorID(usuario, password, idSociedad);
            }
            return null;
        }

        public bool ValidarUsuario(string usuario, string password, short idSociedad)
        {
            return objDUsuarios.ValidarUsuario(usuario, password, idSociedad);
        }
    }
}
