using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// Descripción breve de Poli_Usuario01
/// </summary>
public class cls_Poli_Usuario01: cls_Poli_clsconexion
{
    string tabla = "EMPLEADO";
    protected int id_empleado;
    protected string nombre, cargo, email, telefono, usuario, password;
    protected DateTime fecha_contratacion;
    protected Boolean activo;

	public cls_Poli_Usuario01(int id_empleado, string nombre, string cargo, string email, string telefono, string usuario, string password, DateTime fecha_contratacion, Boolean activo)
	{
        this.id_empleado = id_empleado;
        this.nombre = nombre;
        this.cargo = cargo;
        this.email = email;
        this.telefono = telefono;
        this.usuario = usuario;
        this.password = password;
        this.fecha_contratacion = fecha_contratacion;
        this.activo = activo;
	}

    public int Id_empleado { set { id_empleado = value; } get { return id_empleado; } }
    public string Nombre { set { nombre = value; } get { return nombre; } }
    public string Cargo { set { cargo = value; } get { return cargo; } }
    public string Email { set { email = value; } get { return email; } }
    public string Telefono { set { telefono = value; } get { return telefono; } }
    public string Usuario { set { usuario = value; } get { return usuario; } }
    public string Password { set { password = value; } get { return password; } }
    public DateTime Fecha_contratacion { set { fecha_contratacion = value; } get { return fecha_contratacion; } }
    public Boolean Activo { set { activo = value; } get { return activo; } }


    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();

        fila["Nombre"] = nombre;
        fila["Cargo"] = cargo;
        fila["Email"] = email;
        fila["Telefono"] = telefono;
        fila["Fecha_contratacion"] = fecha_contratacion;
        fila["Usuario"] = usuario;
        fila["Password"] = password;
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
            if (fila["Usuario"].ToString() == valor)
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
            if (fila["Usuario"].ToString() == valor)
            {

                fila["nombre"] = Nombre;
                fila["email"] = Email;
                fila["Telefono"] = telefono;
                fila["Fecha_contratacion"] = fecha_contratacion;
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
            if (fila["Usuario"].ToString() == valor)
            {
                fila["nombre"] = Nombre;
                fila["email"] = Email;
                fila["Telefono"] = telefono;
                fila["Fecha_contratacion"] = fecha_contratacion;
                //  ProcDet_Cantidad = int.Parse(fila["procDet_Cantidad"].ToString());
                //MovCorreo_FechaGuiaDateCortoString = fila["movCorreo_FechaGuiaDateCortoString"].ToString();
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }

}