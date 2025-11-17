using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class consultaProductosPorFiltro
{

    A2_Conexion cn = new A2_Conexion();

	public consultaProductosPorFiltro()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}

    public DataTable FiltraProductosSegunDescripcion(string nom)
    {

        SqlDataAdapter da = new SqlDataAdapter("FiltraProductos", cn.getCn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.Add("@nom", SqlDbType.VarChar).Value = nom;
        DataTable tb = new DataTable();
        da.Fill(tb);
        return tb;
    }

    public DataTable listado()
    {
        SqlDataAdapter da = new SqlDataAdapter("select prod_codigo as Código, prod_Descripcion as Descripción from dbo.tblProductos", cn.getCn);
        DataTable tb = new DataTable();
        da.Fill(tb);
        return tb;
    }
}