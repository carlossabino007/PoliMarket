using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public class clsconexion
{

    protected SqlDataReader reader;
    protected SqlDataAdapter AdaptadorDatos;
    protected DataSet data;
    protected SqlConnection oconeccion = new SqlConnection();


    public clsconexion()
    {

    }

    public void conectar(string tabla)
    {
        string strConeccion = ConfigurationManager.ConnectionStrings["BaseWebKardexConnectionString2"].ConnectionString;
        oconeccion.ConnectionString = strConeccion;
        oconeccion.Open();
        AdaptadorDatos = new SqlDataAdapter("select * from " + tabla, oconeccion);
        SqlCommandBuilder ejecutacomandos = new SqlCommandBuilder(AdaptadorDatos);
        Data = new DataSet();
        AdaptadorDatos.Fill(Data, tabla);
        oconeccion.Close();
    }


    public DataSet Data
    {
        set { data = value; }
        get { return data; }
    }

    public SqlDataReader DataReader
    {
        set { reader = value; }
        get { return reader; }
    }









}