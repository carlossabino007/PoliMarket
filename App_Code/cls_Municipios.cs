using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public class cls_Municipios: clsconexion
{
    string tabla = "tblDestinosMunicipios";
    protected int desCodMunicipio, desCodigo, desDptoAlQuePertenece;
    protected string desNomMunicipio;

	public cls_Municipios(int desCodMunicipio, int desCodigo, int desDptoAlQuePertenece,
        string desNomMunicipio)
	{
        this.desCodMunicipio=desCodMunicipio;
        this.desDptoAlQuePertenece = desDptoAlQuePertenece;
        this.desNomMunicipio = desNomMunicipio;
	}


    public int DesCodMunicipio
    {
        set { desCodMunicipio = value; }
        get { return desCodMunicipio; }
    }

    public int DesDptoAlQuePertenece
    {
        set { desDptoAlQuePertenece = value; }
        get { return desDptoAlQuePertenece; }
    }

    public string DesNomMunicipio
    {
        set { desNomMunicipio = value; }
        get { return desNomMunicipio; }
    }


    public bool existe(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["desCodMunicipio"].ToString()) == valor)
            {
                DesNomMunicipio = fila["desNomMunicipio"].ToString();
                DesDptoAlQuePertenece = int.Parse(fila["desDptoAlQuePertenece"].ToString());  // Dpto
                return true;
            }
        } return false;
    }

    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["desCodMunicipio"] = int.Parse(DesCodMunicipio.ToString());
        fila["desDptoAlQuePertenece"] = int.Parse(DesDptoAlQuePertenece.ToString());
        fila["desNomMunicipio"] = DesNomMunicipio;
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }

    public bool existeCodDane(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["desCodMunicipio"].ToString()) == valor)
            {
                return true;
            }
        } return false;
    }

}