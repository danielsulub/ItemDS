using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    public class NSucursales
    {
        //Instanciamos nuestra clase DSucursales para poder utilizar sus miembros
        private DSucursales objDSucursal = new DSucursales();
        //
        //El uso de la clase StringBuilder nos ayudara a devolver los mensajes de las validaciones
        public readonly StringBuilder stringBuilder = new StringBuilder();

        public List<ESucursales> ObtenerSucursales()
        {
            return objDSucursal.ObtenerSucursales();
        }

        public ESucursales ObtenerSucursalPorID(short idSucursal)
        {
            stringBuilder.Clear();
            if (idSucursal < 0) stringBuilder.Append("No se encontró la sucursal.");
            if (stringBuilder.Length == 0)
            {
                return objDSucursal.ObtenerSucursalPorID(idSucursal);
            }
            return null;
        }

        public List<ESucursales> ObtenerSucursales(short idSociedad, short idGestor)
        {
            return objDSucursal.ObtenerSucursales(idSociedad, idGestor);
        }

        public bool ExisteCambioConexBDSociedad(short idSociedad, short idGestor)
        {
            return objDSucursal.ExisteCambioConexBDSociedad(idSociedad, idGestor);
        }

        public bool EstablecerNuevaConexionBDSociedad(short idSociedad, short idGestor)
        {
            return objDSucursal.EstablecerNuevaConexionBDSociedad(idSociedad, idGestor);
        }
    }
}
