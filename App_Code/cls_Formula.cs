using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class cls_Formula : clsconexion
{
    string tabla = "tblFormula";
    protected int idFormula, form_AreaALaQuePertenece, form_Estado, form_Usuario;
    protected string form_Codigo, form_NombreDeLaFormula, form_Observaciones, form_FechaCreacionString, form_IP, form_PC, form_HoraCreacionString;

    public cls_Formula(int idFormula, int form_AreaALaQuePertenece, int form_Estado, int form_Usuario,
        string form_Codigo, string form_NombreDeLaFormula, string form_Observaciones, string form_FechaCreacionString,
        string form_IP, string form_PC, string form_HoraCreacionString)
	{
        // int
        this.idFormula = idFormula;
        this.form_AreaALaQuePertenece = form_AreaALaQuePertenece;
        this.form_Estado=form_Estado;
        this.form_Usuario = form_Usuario;

        // string
        this.form_Codigo = form_Codigo;
        this.form_NombreDeLaFormula = form_NombreDeLaFormula;
        this.form_Observaciones = form_Observaciones;
        this.form_FechaCreacionString = form_FechaCreacionString;
        this.form_IP=form_IP;
        this.form_PC = form_PC;
        this.form_HoraCreacionString = form_HoraCreacionString;
	}

    public cls_Formula()
    {
    }



    public int IdFormula
    {
        set { idFormula = value; }
        get { return idFormula; }
    }


    public int Form_AreaALaQuePertenece
    {
        set { form_AreaALaQuePertenece = value; }
        get { return form_AreaALaQuePertenece; }
    }


    public int Form_Estado
    {
        set { form_Estado = value; }
        get { return form_Estado; }
    }


    public int Form_Usuario
    {
        set { form_Usuario = value; }
        get { return form_Usuario; }
    }


    public string Form_Codigo
    {
        set { form_Codigo = value; }
        get { return form_Codigo; }
    }


    public string Form_NombreDeLaFormula
    {
        set { form_NombreDeLaFormula = value; }
        get { return form_NombreDeLaFormula; }
    }


    public string Form_Observaciones
    {
        set { form_Observaciones = value; }
        get { return form_Observaciones; }
    }


    public string Form_FechaCreacionString
    {
        set { form_FechaCreacionString = value; }
        get { return form_FechaCreacionString; }
    }


    public string Form_IP
    {
        set { form_IP = value; }
        get { return form_IP; }
    }


    public string Form_PC
    {
        set { form_IP = value; }
        get { return form_IP; }
    }


    public string Form_HoraCreacionString
    {
        set { form_HoraCreacionString = value; }
        get { return form_HoraCreacionString; }
    }


    public bool existe(string valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (fila["form_Codigo"].ToString() == valor)
            {

                Form_NombreDeLaFormula = fila["form_NombreDeLaFormula"].ToString();
                Form_Estado = int.Parse(fila["form_Estado"].ToString());
                Form_Codigo = fila["form_Codigo"].ToString();

                return true;
            }
        } return false;
    }



    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["form_AreaALaQuePertenece"] = int.Parse(Form_AreaALaQuePertenece.ToString());
        fila["form_Estado"] = int.Parse(Form_Estado.ToString());
        fila["Form_Usuario"] = int.Parse(form_Usuario.ToString());

        fila["form_Codigo"] = Form_Codigo;
        fila["form_NombreDeLaFormula"] = Form_NombreDeLaFormula;
        fila["form_Observaciones"] = Form_Observaciones;
        fila["form_FechaCreacionString"] = Form_FechaCreacionString;
        fila["form_HoraCreacionString"] = Form_HoraCreacionString;
        fila["form_IP"] = Form_IP;
        fila["form_PC"] = Form_PC;
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);


        // Hago publico el nuevo código de Formula ID
        //IdFormula = int.Parse(fila["idFormula"].ToString());

    }


    //public bool actualizar(int valor)  // AUN NO ESTA CUADRADO ESTE METODO.. ESTA PENDIENTE
    //{
    //    conectar(tabla);
    //    DataRow fila;   // es un nuevo  registro Fila de datos
    //    int x = Data.Tables[tabla].Rows.Count - 1;
    //    for (int i = 0; i <= x; i++)
    //    {
    //        fila = Data.Tables[tabla].Rows[i];
    //        if (int.Parse(fila["medCodigoMedida"].ToString()) == valor)
    //        {
    //            fila["medDescripcion"] = MedDescripcion;
    //            fila["medAbreviatura"] = MedAbreviatura;
    //            AdaptadorDatos.Update(Data, tabla);
    //            return true;
    //        }
    //    } return false;
    //}

}