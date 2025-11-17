using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class cls_Roles: clsconexion
{
    string tabla = "tblRoles";
    private int idRoles;
    private string rolNombreRol;
    private int rolEstado;


	public cls_Roles(int idRoles, string rolNombreRol,int rolEstado)
	{
        this.idRoles = idRoles;
        this.rolNombreRol=rolNombreRol;
        this.rolEstado = rolEstado;
	}


    public int IdRoles
    {
        get { return idRoles; }
    }

    public string RolNombreRol
    {
        get { return rolNombreRol; }
        set { rolNombreRol = value; }
    }

    public int RolEstado
    {
        get { return rolEstado; }
        set { rolEstado = value; }
    }

     public bool existe(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idRoles"].ToString()) == valor)
            {
                RolNombreRol = fila["rolNombreRol"].ToString();
                RolEstado = int.Parse(fila["rolEstado"].ToString());
                return true;
            }
        } return false;
    }


     public void agregar()
     {
         conectar(tabla);
         DataRow fila;
         fila = Data.Tables[tabla].NewRow();
         fila["rolEstado"] = int.Parse(RolEstado.ToString());
         fila["rolNombreRol"] = RolNombreRol;
         Data.Tables[tabla].Rows.Add(fila);
         AdaptadorDatos.Update(Data, tabla);
     }


     public bool actualizar(int valor)
     {
         conectar(tabla);
         DataRow fila;   // es un nuevo  registro Fila de datos
         int x = Data.Tables[tabla].Rows.Count - 1;
         for (int i = 0; i <= x; i++)
         {
             fila = Data.Tables[tabla].Rows[i];
             if (int.Parse(fila["idRoles"].ToString()) == valor)
             {
                 fila["rolEstado"] = RolEstado;
                 fila["rolNombreRol"] = RolNombreRol;
                 AdaptadorDatos.Update(Data, tabla);
                 return true;
             }
         } return false;
     }





}