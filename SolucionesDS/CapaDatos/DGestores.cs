using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DGestores
    {
        public List<EGestores> ObtenerGestores()
        {
            List<EGestores> gestores = new List<EGestores>();
            using (SqlConnection cnx = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["conexBDConfig"])))
            {
                cnx.Open();
                const string sqlQuery = "SELECT g.IdGestor, g.Codigo, g.Nombre, g.Activo FROM Gestores As g WHERE Activo = 's' ORDER BY g.IdGestor ASC";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    //Preguntamos si el dataReader fue devuelto con datos.
                    while (dataReader.Read())
                    {
                        //Instanciamos al objeto EGestores para llenar sus propiedades.
                        EGestores gestor = new EGestores
                        {
                            IdGestor = Convert.ToInt16(dataReader["IdGestor"]),
                            Codigo = Convert.ToInt16(dataReader["Codigo"]),
                            Nombre = Convert.ToString(dataReader["Nombre"]),
                            Activo = Convert.ToChar(dataReader["Activo"])
                        };
                        //Insertamos el objeto gestor dentro de la lista gestores
                        gestores.Add(gestor);
                    }
                }
            }
            return gestores;
        }

        public EGestores ObtenerGestorPorID(short idGestor)
        {
            using (SqlConnection cnx = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["conexBDConfig"])))
            {
                cnx.Open();
                const string sqlGetById = "SELECT TOP 1 g.IdGestor, g.Codigo, g.Nombre, g.Activo FROM Gestores As g WHERE g.IdGestor = @idGestor And Activo = 's'";
                using (SqlCommand cmd = new SqlCommand(sqlGetById, cnx))
                {
                    cmd.Parameters.AddWithValue("@idGestor", idGestor);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        EGestores gestor = new EGestores
                        {
                            IdGestor = Convert.ToInt16(dataReader["IdGestor"]),
                            Codigo = Convert.ToInt16(dataReader["Codigo"]),
                            Nombre = Convert.ToString(dataReader["Nombre"]),
                            Activo = Convert.ToChar(dataReader["Activo"])
                        };
                        return gestor;
                    }
                }
            }
            return null;
        }
    }
}
