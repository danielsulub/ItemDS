using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace CapaDatos
{
    public class DFiltroExplorador
    {
        public List<EFiltroExplorador> ObtenerFiltroExplorador()
        {
            List<EFiltroExplorador> filtros = new List<EFiltroExplorador>();
            using (SqlConnection cnx = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["conexBDConfig"])))
            {
                cnx.Open();
                const string sqlQuery = "SELECT f.IdFiltroExplorador, f.Codigo, f.Tabla, f.Columna, f.Nombre, f.Activo FROM FiltroExplorador As f WHERE f.Activo = 's' ORDER BY f.IdFiltroExplorador ASC";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    //Preguntamos si el dataReader fue devuelto con datos.
                    while (dataReader.Read())
                    {
                        //Instanciamos al objeto EFiltroExplorador para llenar sus propiedades.
                        EFiltroExplorador filtro = new EFiltroExplorador
                        {
                            IdFiltroExplorador = Convert.ToInt16(dataReader["IdFiltroExplorador"]),
                            Codigo = Convert.ToInt16(dataReader["Codigo"]),
                            Tabla = Convert.ToString(dataReader["Tabla"]),
                            Columna = Convert.ToString(dataReader["Columna"]),
                            Nombre = Convert.ToString(dataReader["Nombre"]),
                            Activo = Convert.ToChar(dataReader["Activo"])
                        };
                        //Insertamos el objeto filtro dentro de la lista filtros
                        filtros.Add(filtro);
                    }
                }
            }
            return filtros;
        }

        public EFiltroExplorador ObtenerFiltroExploradorPorID(short idFiltro)
        {
            using (SqlConnection cnx = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["conexBDConfig"])))
            {
                cnx.Open();
                const string sqlGetById = "SELECT f.IdFiltroExplorador, f.Codigo, f.Tabla, f.Columna, f.NombreFiltro, f.Activo FROM FiltroExplorador As f WHERE f.IdFiltroExplorador = @idFiltro And f.Activo = 's'";
                using (SqlCommand cmd = new SqlCommand(sqlGetById, cnx))
                {
                    cmd.Parameters.AddWithValue("@idFiltro", idFiltro);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        EFiltroExplorador filtro = new EFiltroExplorador
                        {
                            IdFiltroExplorador = Convert.ToInt16(dataReader["IdFiltroExplorador"]),
                            Codigo = Convert.ToInt16(dataReader["Codigo"]),
                            Tabla = Convert.ToString(dataReader["Tabla"]),
                            Columna = Convert.ToString(dataReader["Columna"]),
                            Nombre = Convert.ToString(dataReader["Nombre"]),
                            Activo = Convert.ToChar(dataReader["Activo"])
                        };
                        return filtro;
                    }
                }
            }
            return null;
        }
    }
}
