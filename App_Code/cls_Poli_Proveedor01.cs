using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


/// <summary>
/// Descripción breve de cls_Poli_Proveedor01
/// </summary>
public class cls_Poli_Proveedor01: cls_Poli_clsconexion
{
    string tabla = "PROVEEDOR";
    protected string nit, nombre, contacto, telefono, email, direccion;
    protected Boolean activo;


	public cls_Poli_Proveedor01(string nit, string nombre, string contacto, string telefono, string email, string direccion, Boolean activo )
	{
        this.nit = nit;
        this.nombre = nombre;
        this.contacto=contacto;
        this.telefono = telefono;
        this.email = email;
        this.direccion = direccion;
        this.activo = activo;
	}

    public string Nit { set { nit = value; } get { return nit; } }
    public string Nombre { set { nombre = value; } get { return nombre; } }
    public string Contacto { set { contacto = value; } get { return contacto; } }
    public string Telefono { set { telefono = value; } get { return telefono; } }
    public string Email { set { email = value; } get { return email; } }
    public string Direccion { set { direccion = value; } get { return direccion; } }
    public Boolean Activo { set { activo = value; } get { return activo; } }

    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["Nit"] = nit;
        fila["Nombre"] = nombre;
        fila["Contacto"] = contacto;
        fila["Telefono"] = telefono;
        fila["Email"] = email;
        fila["Direccion"] = direccion;
        fila["Activo"] = activo;
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }


    public bool existeUsuario(string valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (fila["Nit"].ToString() == valor)
            {
                return true;
            }
        } return false;
    }


    public bool existeUsuarioYTraeTodo(string valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (fila["Nit"].ToString() == valor)
            {
                fila["nit"] = Nit;
                fila["nombre"] = Nombre;
                fila["contacto"] = Contacto;
                fila["telefono"] = telefono;
                fila["email"] = Email;
                fila["direccion"] = Direccion;
                //fila["activo"] = Activo;
                //  ProcDet_Cantidad = int.Parse(fila["procDet_Cantidad"].ToString());
                //MovCorreo_FechaGuiaDateCortoString = fila["movCorreo_FechaGuiaDateCortoString"].ToString();

                return true;
            }
        } return false;
    }


    public bool ActualizarDatos(string valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (fila["Nit"].ToString() == valor)
            {
                fila["nombre"] = Nombre;
                fila["contacto"] = Contacto;
                fila["telefono"] = Telefono;
                fila["email"] = Email;
                fila["direccion"] = Direccion;
                //fila["activo"] = Activo;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }
}