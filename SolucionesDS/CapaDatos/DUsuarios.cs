using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DUsuarios
    {
        public List<EUsuarios> ObtenerUsuarios()
        {
            List<EUsuarios> usuarios = new List<EUsuarios>();
            using (SqlConnection cnx = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["conexBDConfig"])))
            {
                cnx.Open();
                const string sqlQuery = "SELECT u.IdUsuario, u.IdSociedad, u.IdPerfil, u.Usuario, u.Password, u.Alias, u.Email, u.ListaPrecio, u.ImpuestoIVA, u.AccesoRapido, u.Activo FROM Usuarios As u WHERE u.Activo = 's'";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    //Preguntamos si el dataReader fue devuelto con datos.
                    while (dataReader.Read())
                    {
                        //Instanciamos al objeto EUsuarios para llenar sus propiedades.
                        EUsuarios usuario = new EUsuarios
                        {
                            IdUsuario = Convert.ToInt16(dataReader["IdUsuario"]),
                            IdSociedad = Convert.ToInt16(dataReader["IdSociedad"]),
                            IdPerfil = Convert.ToInt16(dataReader["IdPerfil"]),
                            Usuario = Convert.ToString(dataReader["Usuario"]),
                            Password = Convert.ToString(dataReader["Password"]),
                            Alias = Convert.ToString(dataReader["Alias"]),
                            Email = Convert.ToString(dataReader["Email"]),
                            ListaPrecio = Convert.ToString(dataReader["ListaPrecio"]),
                            ImpuestoIVA = Convert.ToString(dataReader["ImpuestoIVA"]),
                            AccesoRapido = Convert.ToChar(dataReader["AccesoRapido"]),
                            Activo = Convert.ToChar(dataReader["Activo"])
                        };
                        //Insertamos el objeto usuario dentro de la lista usuarios
                        usuarios.Add(usuario);
                    }
                }
            }
            return usuarios;
        }

        public EUsuarios ObtenerUsuarioPorID(string usuario, string password, short idSociedad)
        {
            using (SqlConnection cnx = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["conexBDConfig"])))
            {
                cnx.Open();
                const string sqlGetById = "SELECT TOP 1 u.IdUsuario, u.IdSociedad, u.IdPerfil, u.Usuario, u.Password, u.Alias, u.Email, u.ListaPrecio, u.ImpuestoIVA, u.AccesoRapido, u.Activo FROM Usuarios As u WHERE u.Usuario = @usuario and u.Password = @password and u.IdSociedad = @idSociedad and u.Activo = 's'";
                using (SqlCommand cmd = new SqlCommand(sqlGetById, cnx))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@idSociedad", idSociedad);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        EUsuarios user = new EUsuarios
                        {
                            IdUsuario = Convert.ToInt16(dataReader["IdUsuario"]),
                            IdSociedad = Convert.ToInt16(dataReader["IdSociedad"]),
                            IdPerfil = Convert.ToInt16(dataReader["IdPerfil"]),
                            Usuario = Convert.ToString(dataReader["Usuario"]),
                            Password = Convert.ToString(dataReader["Password"]),
                            Alias = Convert.ToString(dataReader["Alias"]),
                            Email = Convert.ToString(dataReader["Email"]),
                            ListaPrecio = Convert.ToString(dataReader["ListaPrecio"]),
                            ImpuestoIVA = Convert.ToString(dataReader["ImpuestoIVA"]),
                            AccesoRapido = Convert.ToChar(dataReader["AccesoRapido"]),
                            Activo = Convert.ToChar(dataReader["Activo"])
                        };
                        return user;
                    }
                }
            }
            return null;
        }

        public bool ValidarUsuario(string usuario, string password, short idSociedad)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["conexBDConfig"])))
                {
                    cnx.Open();
                    const string sqlGetById = "SELECT TOP 1 u.IdUsuario, u.IdSociedad, u.IdPerfil, u.Usuario, u.Password, u.Alias, u.Email, u.ListaPrecio, u.ImpuestoIVA, u.AccesoRapido, u.Activo FROM Usuarios As u WHERE u.Usuario = @usuario and u.Password = @password and u.IdSociedad = @idSociedad and u.Activo = 's'";
                    using (SqlCommand cmd = new SqlCommand(sqlGetById, cnx))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@idSociedad", idSociedad);
                        SqlDataReader dataReader = cmd.ExecuteReader();
                        if (dataReader.Read())
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
