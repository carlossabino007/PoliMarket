using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public class cls_MOL_045_Head : clsconexion
{

    string tabla = "tblR_MOL_045_Head";
    protected int idCodigo;
    protected int codigoGenerado;
    protected DateTime fechaYHoraAislamiento;
    protected DateTime fechaAislamiento;
    protected string usuarioQueAisla;
    protected String iPdondeAisla;
    protected int estadoAisla;
    protected String kit;
    protected int codMetodoUtilizado;


    public cls_MOL_045_Head(int idCodigo, int codigoGenerado, DateTime fechaYHoraAislamiento,
    DateTime fechaAislamiento,string usuarioQueAisla, String iPdondeAisla,int estadoAisla,
    String kit, int codMetodoUtilizado)
	{
      this.idCodigo=idCodigo;
      this.codigoGenerado=codigoGenerado;
      this.fechaYHoraAislamiento=fechaYHoraAislamiento;
      this.fechaAislamiento = fechaAislamiento;
      this.usuarioQueAisla = usuarioQueAisla;
      this.iPdondeAisla = iPdondeAisla;
      this.estadoAisla = estadoAisla;
      this.kit = kit;
      this.codMetodoUtilizado = codMetodoUtilizado;
	}


    public int IdCodigo
    {
        set { idCodigo = value; }
        get { return idCodigo; }
    }

    public int CodigoGenerado
    {
        set { codigoGenerado=codigoGenerado = value; }
        get { return codigoGenerado; }
    }

    public DateTime FechaYHoraAislamiento
    {
        set { fechaYHoraAislamiento = value; }
        get { return fechaYHoraAislamiento; }
    }

    public DateTime FechaAislamiento
    {
        set { fechaAislamiento = value; }
        get { return fechaAislamiento; }
    }

    public String UsuarioQueAisla
    {
        set { usuarioQueAisla = value; }
        get { return usuarioQueAisla; }
    }

    public String IPdondeAisla
    {
        set { iPdondeAisla = value; }
        get { return iPdondeAisla; }
    }

    public int EstadoAisla
    {
        set { estadoAisla = value; }
        get { return estadoAisla; }
    }

    public String Kit
    {
        set { kit = value; }
        get { return kit; }
    }

  

    public int CodMetodoUtilizado
    {
        set { codMetodoUtilizado = value; }
        get { return codMetodoUtilizado; }
    }


    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["CodigoGenerado"] = int.Parse(codigoGenerado.ToString());
        fila["FechaYHoraAislamiento"] = fechaYHoraAislamiento;
        fila["FechaAislamiento"] = fechaAislamiento;
        fila["UsuarioQueAisla"] = usuarioQueAisla;
        fila["IPdondeAisla"] = iPdondeAisla;
        fila["EstadoAisla"] = int.Parse(estadoAisla.ToString());
        fila["Kit"] = kit;
        fila["CodMetodoUtilizado"] = codMetodoUtilizado;
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }


    public bool ExistePorElID(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idCodigo"].ToString()) == valor)
            {
                CodigoGenerado = int.Parse(fila["codigoGenerado"].ToString());
                FechaYHoraAislamiento = DateTime.Parse(fila[("fechaYHoraAislamiento")].ToString());
                FechaAislamiento = DateTime.Parse(fila[("fechaAislamiento")].ToString());
                UsuarioQueAisla = fila["usuarioQueAisla"].ToString();
                IPdondeAisla = fila["iPdondeAisla"].ToString();
                EstadoAisla = int.Parse(fila["estadoAisla"].ToString());
                Kit = fila["kit"].ToString();
                CodMetodoUtilizado = int.Parse(fila["codMetodoUtilizado"].ToString());
                return true;
            }
        } return false;
    }

    public bool ExistePorElCodigoGenerado(String valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (fila["codigoGenerado"].ToString().Equals(valor))
            {
                IdCodigo = int.Parse(fila["idCodigo"].ToString());
                FechaYHoraAislamiento = DateTime.Parse(fila[("fechaYHoraAislamiento")].ToString());
                FechaAislamiento = DateTime.Parse(fila[("fechaAislamiento")].ToString());
                UsuarioQueAisla = fila["usuarioQueAisla"].ToString();
                IPdondeAisla = fila["iPdondeAisla"].ToString();
                EstadoAisla = int.Parse(fila["estadoAisla"].ToString());
                Kit = fila["kit"].ToString();
                CodMetodoUtilizado = int.Parse(fila["codMetodoUtilizado"].ToString());
                return true;
            }
        } return false;
    }







}