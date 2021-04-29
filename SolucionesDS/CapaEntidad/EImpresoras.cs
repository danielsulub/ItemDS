using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EImpresoras
    {
        public short IdImpresora { get; set; }
        public short Codigo { get; set; }
        public char EsCompartido { get; set; }
        public string DireccionIp { get; set; }
        public string Nombre { get; set; }
        public string Puerto { get; set; } 
    }
}
