using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Configuration;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DImpresoras
    {
        public List<EImpresoras> ObtenerImpresoras()
        {
            List<EImpresoras> impresoras = new List<EImpresoras>();
            using (SqlConnection cnx = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["conexBDConfig"])))
            {
                cnx.Open();
                const string sqlQuery = "SELECT i.IdImpresora, i.Codigo, i.EsCompartido, i.DireccionIp, i.Nombre, i.Puerto FROM Impresoras As i ORDER BY i.IdImpresora ASC";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    //Preguntamos si el dataReader fue devuelto con datos.
                    while (dataReader.Read())
                    {
                        //Instanciamos al objeto EImpresoras para llenar sus propiedades.
                        EImpresoras impresora = new EImpresoras
                        {
                            IdImpresora = Convert.ToInt16(dataReader["IdImpresora"]),
                            Codigo = Convert.ToInt16(dataReader["Codigo"]),
                            EsCompartido = Convert.ToChar(dataReader["EsCompartido"]),
                            DireccionIp = Convert.ToString(dataReader["DireccionIp"]),
                            Nombre = Convert.ToString(dataReader["Nombre"]),
                            Puerto = Convert.ToString(dataReader["Puerto"])
                        };
                        //Insertamos el objeto impresora dentro de la lista impresoras
                        impresoras.Add(impresora);
                    }
                }
            }
            return impresoras;
        }

        public EImpresoras ObtenerImpresoraPorID(short idImpresora)
        {
            using (SqlConnection cnx = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["conexBDConfig"])))
            {
                cnx.Open();
                const string sqlGetById = "SELECT i.IdImpresora, i.Codigo, i.EsCompartido, i.DireccionIp, i.Nombre, i.Puerto FROM Impresoras As i WHERE i.IdImpresora = @idImpresora";
                using (SqlCommand cmd = new SqlCommand(sqlGetById, cnx))
                {
                    cmd.Parameters.AddWithValue("@idImpresora", idImpresora);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        EImpresoras impresora = new EImpresoras
                        {
                            IdImpresora = Convert.ToInt16(dataReader["IdImpresora"]),
                            Codigo = Convert.ToInt16(dataReader["Codigo"]),
                            EsCompartido = Convert.ToChar(dataReader["EsCompartido"]),
                            DireccionIp = Convert.ToString(dataReader["DireccionIp"]),
                            Nombre = Convert.ToString(dataReader["Nombre"]),
                            Puerto = Convert.ToString(dataReader["Puerto"])
                        };
                        return impresora;
                    }
                }
            }
            return null;
        }
    }
}
