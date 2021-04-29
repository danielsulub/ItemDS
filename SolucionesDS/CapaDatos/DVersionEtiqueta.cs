using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class DVersionEtiqueta
    {
        public List<EVersionEtiqueta> ObtenerVersionEtiqueta(short idSociedad)
        {
            List<EVersionEtiqueta> VersionEtiqueta = new List<EVersionEtiqueta>();
            using (SqlConnection cnx = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["conexBDConfig"])))
            {
                cnx.Open();
                const string sqlQuery = "SELECT v.IdVersionEtiqueta, v.IdSociedad, v.Codigo, v.Nombre FROM VersionEtiqueta As v WHERE v.IdSociedad = @idSociedad ORDER BY v.IdSociedad ASC";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@idSociedad", idSociedad);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    //Preguntamos si el dataReader fue devuelto con datos.
                    while (dataReader.Read())
                    {
                        //Instanciamos al objeto EVersionEtiqueta para llenar sus propiedades.
                        EVersionEtiqueta VersionEti = new EVersionEtiqueta
                        {
                            IdVersionEtiqueta = Convert.ToInt16(dataReader["IdVersionEtiqueta"]),
                            IdSociedad = Convert.ToInt16(dataReader["IdSociedad"]),
                            Codigo = Convert.ToInt16(dataReader["Codigo"]),
                            Nombre = Convert.ToString(dataReader["Nombre"])
                        };
                        //Insertamos el objeto VersionEtiqueta dentro de la lista VersionesEtiqueta
                        VersionEtiqueta.Add(VersionEti);
                    }
                }
            }
            return VersionEtiqueta;
        }

        public EVersionEtiqueta ObtenerVersionEtiquetaPorID(short idVersion)
        {
            using (SqlConnection cnx = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["conexBDConfig"])))
            {
                cnx.Open();
                const string sqlGetById = "SELECT TOP 1 v.IdVersionEtiqueta, v.IdSociedad, v.Codigo, v.Nombre FROM VersionEtiqueta As v WHERE v.IdVersionEtiqueta = @idVersion";
                using (SqlCommand cmd = new SqlCommand(sqlGetById, cnx))
                {
                    cmd.Parameters.AddWithValue("@idVersion", idVersion);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        EVersionEtiqueta version = new EVersionEtiqueta
                        {
                            IdVersionEtiqueta = Convert.ToInt16(dataReader["IdVersionEtiqueta"]),
                            IdSociedad = Convert.ToInt16(dataReader["IdSociedad"]),
                            Codigo = Convert.ToInt16(dataReader["Codigo"]),
                            Nombre = Convert.ToString(dataReader["Nombre"])
                        };
                        return version;
                    }
                }
            }
            return null;
        }
    }
}
