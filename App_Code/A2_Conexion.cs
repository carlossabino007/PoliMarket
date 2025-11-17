using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

public class A2_Conexion
{
    private SqlConnection cn;

    public A2_Conexion()
    {
        cn = new SqlConnection("server=CITODB; Database=BaseWebKardex; Persist Security Info=True;User ID=root;Password=root");
    }

    public SqlConnection getCn
    {
        get
        {
            return cn;
        }

    }



}