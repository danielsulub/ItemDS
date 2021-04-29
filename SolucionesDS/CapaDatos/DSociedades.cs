using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DSociedades
    {
        public List<ESociedades> ObtenerSociedades()
        {
            List<ESociedades> sociedades = new List<ESociedades>();
            using (SqlConnection cnx = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["conexBDConfig"])))
            {
                cnx.Open();
                const string sqlQuery = "SELECT s.IdSociedad, s.Codigo, s.Nombre, s.Activo FROM Sociedades As s WHERE s.Activo = 's' ORDER BY s.IdSociedad ASC";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    //Preguntamos si el dataReader fue devuelto con datos.
                    while (dataReader.Read())
                    {
                        //Instanciamos al objeto ESociedades para llenar sus propiedades.
                        ESociedades sociedad = new ESociedades
                        {
                            IdSociedad = Convert.ToInt16(dataReader["IdSociedad"]),
                            Codigo = Convert.ToInt16(dataReader["Codigo"]),
                            Nombre = Convert.ToString(dataReader["Nombre"]),
                            Activo = Convert.ToChar(dataReader["Activo"])
                        };
                        //Insertamos el objeto sociedad dentro de la lista sociedades
                        sociedades.Add(sociedad);
                    }
                }
            }
            return sociedades;
        }

        public ESociedades ObtenerSociedadPorID(short idSociedad)
        {
            using (SqlConnection cnx = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["conexBDConfig"])))
            {
                cnx.Open();
                const string sqlGetById = "SELECT TOP 1 s.IdSociedad, s.Codigo, s.Nombre, s.Activo FROM Sociedades As s WHERE s.IdSociedad = @idSociedad And s.Activo = 's'";
                using (SqlCommand cmd = new SqlCommand(sqlGetById, cnx))
                {
                    cmd.Parameters.AddWithValue("@idSociedad", idSociedad);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        ESociedades sociedad = new ESociedades
                        {
                            IdSociedad = Convert.ToInt16(dataReader["IdSociedad"]),
                            Codigo = Convert.ToInt16(dataReader["Codigo"]),
                            Nombre = Convert.ToString(dataReader["Nombre"]),
                            Activo = Convert.ToChar(dataReader["Activo"]),
                        };
                        return sociedad;
                    }
                }
            }
            return null;
        }
    }
}
