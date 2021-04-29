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
    public class DMedidaEtiqueta
    {
        public List<EMedidaEtiqueta> ObtenerMedidaEtiqueta()
        {
            List<EMedidaEtiqueta> medidaEtiquetas = new List<EMedidaEtiqueta>();
            using (SqlConnection cnx = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["conexBDConfig"])))
            {
                cnx.Open();
                const string sqlQuery = "SELECT m.IdMedidaEtiqueta, m.Codigo, m.Nombre FROM MedidaEtiqueta As m ORDER BY m.IdMedidaEtiqueta ASC";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {                    
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    //Preguntamos si el dataReader fue devuelto con datos.
                    while (dataReader.Read())
                    {
                        //Instanciamos al objeto EMedidaEtiqueta para llenar sus propiedades.
                        EMedidaEtiqueta medidaEtiqueta = new EMedidaEtiqueta
                        {
                            IdMedidaEtiqueta = Convert.ToInt16(dataReader["IdMedidaEtiqueta"]),
                            Codigo = Convert.ToInt16(dataReader["Codigo"]),
                            Nombre = Convert.ToString(dataReader["Nombre"])
                        };
                        //Insertamos el objeto medidaEtiqueta dentro de la lista medidaEtiquetas
                        medidaEtiquetas.Add(medidaEtiqueta);
                    }
                }
            }
            return medidaEtiquetas;
        }

        public EMedidaEtiqueta ObtenerMedidaEtiquetaPorID(short idMedida)
        {
            using (SqlConnection cnx = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["conexBDConfig"])))
            {
                cnx.Open();
                const string sqlGetById = "SELECT TOP 1 m.IdMedidaEtiqueta, m.Codigo, m.Nombre FROM MedidaEtiqueta As m WHERE m.IdMedidaEtiqueta = @idMedida";
                using (SqlCommand cmd = new SqlCommand(sqlGetById, cnx))
                {
                    cmd.Parameters.AddWithValue("@idMedida", idMedida);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        EMedidaEtiqueta version = new EMedidaEtiqueta
                        {
                            IdMedidaEtiqueta = Convert.ToInt16(dataReader["IdMedidaEtiqueta"]),
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
