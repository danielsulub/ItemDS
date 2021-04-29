using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EFiltroExplorador
    {
        public short IdFiltroExplorador { get; set; }
        public short Codigo { get; set; }
        public string Tabla { get; set; }
        public string Columna { get; set; }
        public string Nombre { get; set; }
        public char Activo { get; set; }
    }
}
