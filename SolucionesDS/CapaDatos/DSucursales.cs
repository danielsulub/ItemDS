using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DSucursales
    {
        public List<ESucursales> ObtenerSucursales()
        {
            List<ESucursales> sucursales = new List<ESucursales>();
            using (SqlConnection cnx = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["conexBDSociedad"])))
            {
                cnx.Open();
                const string sqlQuery = "SELECT ow.WhsCode AS Codigo, ow.WhsName AS Nombre FROM OWHS AS ow ORDER BY ow.WhsCode ASC";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    //Preguntamos si el dataReader fue devuelto con datos.
                    while (dataReader.Read())
                    {
                        //Instanciamos al objeto ESucursales para llenar sus propiedades.
                        ESucursales sucursal = new ESucursales
                        {
                            Codigo = Convert.ToString(dataReader["Codigo"]),
                            Nombre = Convert.ToString(dataReader["Nombre"])
                        };
                        //Insertamos el objeto sucursal dentro de la lista sucursales
                        sucursales.Add(sucursal);
                    }
                }
            }
            return sucursales;
        }

        public ESucursales ObtenerSucursalPorID(short idSucursal)
        {
            using (SqlConnection cnx = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["conexBDSociedad"])))
            {
                cnx.Open();
                const string sqlGetById = "SELECT TOP 1 ow.WhsCode AS Codigo, ow.WhsName AS Nombre FROM OWHS AS ow WHERE ow.WhsCode = @idSucursal";
                using (SqlCommand cmd = new SqlCommand(sqlGetById, cnx))
                {
                    cmd.Parameters.AddWithValue("@idSucursal", idSucursal);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        ESucursales sucursal = new ESucursales
                        {
                            Codigo = Convert.ToString(dataReader["Codigo"]),
                            Nombre = Convert.ToString(dataReader["Nombre"])
                        };
                        return sucursal;
                    }
                }
            }
            return null;
        }

        public List<ESucursales> ObtenerSucursales(short idSociedad, short idGestor)
        {
            string cadenaConexion = ObtenerCadenaConexion(idSociedad, idGestor);
            if (string.IsNullOrWhiteSpace(cadenaConexion)) { return null; }
            List<ESucursales> sucursales = new List<ESucursales>();            
            using (SqlConnection cnx = new SqlConnection(cadenaConexion))
            {
                cnx.Open();
                const string sqlQuery = "SELECT ow.WhsCode AS Codigo, ow.WhsName AS Nombre FROM OWHS AS ow ORDER BY ow.WhsCode ASC";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    //Preguntamos si el dataReader fue devuelto con datos.
                    while (dataReader.Read())
                    {
                        //Instanciamos al objeto ESucursales para llenar sus propiedades.
                        ESucursales sucursal = new ESucursales
                        {
                            Codigo = Convert.ToString(dataReader["Codigo"]),
                            Nombre = Convert.ToString(dataReader["Nombre"])
                        };
                        //Insertamos el objeto sucursal dentro de la lista sucursales
                        sucursales.Add(sucursal);
                    }
                }
            }
            return sucursales;
        }

        public string ObtenerCadenaConexion(short idSociedad, short idGestor)
        {
            using (SqlConnection cnx = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["conexBDConfig"])))
            {
                cnx.Open();
                const string sqlGetById = "SELECT cg.Servidor, cg.NombreBD, cg.UsuarioBD, cg.PasswordBD FROM ConfiguracionGeneral As cg WHERE cg.IdSociedad = @idSociedad and cg.IdGestor = @idGestor";
                using (SqlCommand cmd = new SqlCommand(sqlGetById, cnx))
                {
                    cmd.Parameters.AddWithValue("@idSociedad", idSociedad);
                    cmd.Parameters.AddWithValue("@idGestor", idGestor);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    string cadenaConexion = string.Empty;
                    if (dataReader.Read())
                    {
                        string servidor = Convert.ToString(dataReader["Servidor"]);
                        string nombreBD = Convert.ToString(dataReader["NombreBD"]);
                        string usuarioBD = Convert.ToString(dataReader["UsuarioBD"]);
                        string passwordBD = Convert.ToString(dataReader["PasswordBD"]);
                        switch (idGestor)
                        {
                            case 0:
                                cadenaConexion = "Server=" + servidor + ";Database=" + nombreBD + ";User Id=" + usuarioBD + ";Password=" + passwordBD;
                                break;
                            case 1:
                                cadenaConexion = "DRIVER={HDBODBC};UID=" + usuarioBD + ";PWD=" + passwordBD + ";SERVERNODE=" + servidor + ";DATABASENAME=" + nombreBD;
                                break;
                        }                       
                        return cadenaConexion;
                    }
                }
            }
            return string.Empty;
        }

        public bool ExisteCambioConexBDSociedad(short idSociedad, short idGestor)
        {
            string conexBDSociedad = string.Empty;
            string conexBDSociedadSeleccionada = string.Empty;
            bool existeCambioConexion = false;
            conexBDSociedad = (Convert.ToString(ConfigurationManager.ConnectionStrings["conexBDSociedad"]));
            conexBDSociedadSeleccionada = ObtenerCadenaConexion(idSociedad, idGestor);
            existeCambioConexion = string.Equals(conexBDSociedad, conexBDSociedadSeleccionada, StringComparison.OrdinalIgnoreCase) ? false : true;
            return existeCambioConexion;
        }

        public bool EstablecerNuevaConexionBDSociedad(short idSociedad, short idGestor)
        {
            try
            {
                string conexBDSociedadSeleccionada = ObtenerCadenaConexion(idSociedad, idGestor);
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings["conexBDSociedad"].ConnectionString = conexBDSociedadSeleccionada;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("connectionStrings");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
