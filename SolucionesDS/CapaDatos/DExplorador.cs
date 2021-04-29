using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DExplorador
    {
        public List<EExplorador> ObtenerArticulos(string datoBusqueda)
        {
            List<EExplorador> articulos = new List<EExplorador>();
            using (SqlConnection cnx = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["conexBDSociedad"])))
            {
                cnx.Open();
                const string sqlQuery = "SELECT oi.U_Status AS St, ot.ItmsGrpNam AS GrupoArticulos," +
                    "oi.ItemCode AS Sap, oi.FrgnName AS Codigo, oi.ItemName AS Descripcion," +
                    "om.FirmName AS Marca, CAST(it.Price * 1 AS DECIMAL(9, 2)) AS Precio, CAST (oit.OnHand AS DECIMAL(8, 2)) AS Existencia," +
                    "oi.U_Ubicacion_CEDIS AS UbicacionCedis, oi.U_Ubicacion_CEDIS AS UbicacionSucu, oi.SuppCatNum AS Fabricante, oi.CardCode AS Proveedor," +
                    "oi.CodeBars AS Barras, CAST(oit.MinStock AS SMALLINT) AS Minimo, CAST (oit.MaxStock AS SMALLINT) AS Maximo," +
                    "oi.U_Contenido AS Contenido FROM OITM AS oi " +
                    "INNER JOIN OITW AS oit " +
                    "ON oit.ItemCode = oi.ItemCode " +
                    "AND oit.WhsCode = 01 " +
                    "INNER JOIN ITM1 AS it " +
                    "ON it.ItemCode = oi.ItemCode " +
                    "AND it.PriceList = 5 " +
                    "INNER JOIN OMRC AS om " +
                    "ON om.FirmCode = oi.FirmCode " +
                    "INNER JOIN OITB AS ot " +
                    "ON oi.ItmsGrpCod = ot.ItmsGrpCod " +
                    "INNER JOIN OCRD AS oc " +
                    "ON oi.CardCode = oc.CardCode " +
                    "WHERE oi.ItemName LIKE @datoBusqueda";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@datoBusqueda", datoBusqueda);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    //Preguntamos si el dataReader fue devuelto con datos.
                    while (dataReader.Read())
                    {
                        //Instanciamos al objeto EExplorador para llenar sus propiedades.
                        EExplorador articulo = new EExplorador
                        {
                            St = Convert.ToString(dataReader["St"]),
                            GrupoArticulos = Convert.ToString(dataReader["GrupoArticulos"]),
                            Sap = Convert.ToString(dataReader["Sap"]),
                            Codigo = Convert.ToString(dataReader["Codigo"]),
                            Descripcion = Convert.ToString(dataReader["Descripcion"]),
                            Marca = Convert.ToString(dataReader["Marca"]),
                            Precio = Convert.ToString(dataReader["Precio"]),
                            Existencia = Convert.ToDecimal(dataReader["Existencia"]),
                            UbicacionCedis = Convert.ToString(dataReader["UbicacionCedis"]),
                            UbicacionSucu = Convert.ToString(dataReader["UbicacionSucu"]),
                            Fabricante = Convert.ToString(dataReader["Fabricante"]),
                            Proveedor = Convert.ToString(dataReader["Proveedor"]),
                            Barras = Convert.ToString(dataReader["Barras"]),
                            Minimo = Convert.ToDecimal(dataReader["Minimo"]),
                            Maximo = Convert.ToDecimal(dataReader["Maximo"]),
                            Contenido = Convert.ToString(dataReader["Contenido"])
                        };
                        //Insertamos el objeto articulo dentro de la lista articulos
                        articulos.Add(articulo);
                    }
                }
            }
            return articulos;
        }

        public EExplorador ObtenerArticuloPorID(short idArticulo)
        {
            using (SqlConnection cnx = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["conexBDSociedad"])))
            {
                cnx.Open();
                const string sqlGetById = "SELECT TOP 1 oi.U_Status AS St, ot.ItmsGrpNam AS GrupoArticulos," +
                    "oi.ItemCode AS Sap, oi.FrgnName AS Codigo, oi.ItemName AS Descripcion," +
                    "om.FirmName AS Marca, CAST(it.Price * 1 AS DECIMAL(9, 2)) AS Precio, CAST (oit.OnHand AS DECIMAL(8, 2)) AS Existencia," +
                    "oi.U_Ubicacion_CEDIS AS UbicacionCedis, oi.U_Ubicacion_CEDIS AS UbicacionSucu, oi.SuppCatNum AS Fabricante, oi.CardCode AS Proveedor," +
                    "oi.CodeBars AS Barras, CAST(oit.MinStock AS SMALLINT) AS Minimo, CAST (oit.MaxStock AS SMALLINT) AS Maximo," +
                    "oi.U_Contenido AS Contenido FROM OITM AS oi " +
                    "INNER JOIN OITW AS oit " +
                    "ON oit.ItemCode = oi.ItemCode " +
                    "AND oit.WhsCode = 01 " +
                    "INNER JOIN ITM1 AS it " +
                    "ON it.ItemCode = oi.ItemCode " +
                    "AND it.PriceList = 5 " +
                    "INNER JOIN OMRC AS om " +
                    "ON om.FirmCode = oi.FirmCode " +
                    "INNER JOIN OITB AS ot " +
                    "ON oi.ItmsGrpCod = ot.ItmsGrpCod " +
                    "INNER JOIN OCRD AS oc " +
                    "ON oi.CardCode = oc.CardCode " +
                    "WHERE oi.ItemCode = @idArticulo";
                using (SqlCommand cmd = new SqlCommand(sqlGetById, cnx))
                {
                    cmd.Parameters.AddWithValue("@idArticulo", idArticulo);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        EExplorador articulo = new EExplorador
                        {
                            St = Convert.ToString(dataReader["St"]),
                            GrupoArticulos = Convert.ToString(dataReader["GrupoArticulos"]),
                            Sap = Convert.ToString(dataReader["Sap"]),
                            Codigo = Convert.ToString(dataReader["Codigo"]),
                            Descripcion = Convert.ToString(dataReader["Descripcion"]),
                            Marca = Convert.ToString(dataReader["Marca"]),
                            Precio = Convert.ToString(dataReader["Precio"]),
                            Existencia = Convert.ToDecimal(dataReader["Existencia"]),
                            UbicacionCedis = Convert.ToString(dataReader["UbicacionCedis"]),
                            UbicacionSucu = Convert.ToString(dataReader["UbicacionSucu"]),
                            Fabricante = Convert.ToString(dataReader["Fabricante"]),
                            Proveedor = Convert.ToString(dataReader["Proveedor"]),
                            Barras = Convert.ToString(dataReader["Barras"]),
                            Minimo = Convert.ToDecimal(dataReader["Minimo"]),
                            Maximo = Convert.ToDecimal(dataReader["Maximo"]),
                            Contenido = Convert.ToString(dataReader["Contenido"])
                        };
                        return articulo;
                    }
                }
            }
            return null;
        }
    }
}
