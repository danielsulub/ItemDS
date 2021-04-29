using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class NFiltroExplorador
    {
        //Instanciamos nuestra clase DFiltroExplorador para poder utilizar sus miembros
        private DFiltroExplorador objDDFiltroExplorador = new DFiltroExplorador();
        //
        //El uso de la clase StringBuilder nos ayudara a devolver los mensajes de las validaciones
        public readonly StringBuilder stringBuilder = new StringBuilder();

        public List<EFiltroExplorador> ObtenerFiltroExplorador()
        {
            return objDDFiltroExplorador.ObtenerFiltroExplorador();
        }

        public EFiltroExplorador ObtenerFiltroExploradorPorID(short idFiltro)
        {
            stringBuilder.Clear();
            if (idFiltro < 0) stringBuilder.Append("No se encontró el filtro.");
            if (stringBuilder.Length == 0)
            {
                return objDDFiltroExplorador.ObtenerFiltroExploradorPorID(idFiltro);
            }
            return null;
        }
    }
}
