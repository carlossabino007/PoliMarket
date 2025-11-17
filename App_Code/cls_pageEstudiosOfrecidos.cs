using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public class cls_pageEstudiosOfrecidos :  clsconexion
{
    string tabla = "tblEstudiosOfrecidos";

    protected int idProducto, proCodInterno, proGrupoADondePertenece, proEstado, proValor;
    protected string proCups, proSubDivisionCups, proDescripcion;
    protected int codAthenea;
   

	public cls_pageEstudiosOfrecidos(int proCodInterno, int proGrupoADondePertenece, int proEstado,
        string proCups, string proSubDivisionCups, string proDescripcion, int idProducto, int proValor, int codAthenea)
	{
        this.proCodInterno = proCodInterno;
        this.proGrupoADondePertenece = proGrupoADondePertenece;
        this.proEstado = proEstado;
        this.proCups = proCups;
        this.proSubDivisionCups = proSubDivisionCups;
        this.proDescripcion = proDescripcion;
        this.idProducto = idProducto;
        this.proValor = proValor;
        this.codAthenea=codAthenea;
        
	}

    public cls_pageEstudiosOfrecidos()
    {
    }


   
    public int ProCodInterno
    {
        set { proCodInterno = value; }
        get { return proCodInterno; }
    }

    public int ProGrupoADondePertenece
    {
        set { proGrupoADondePertenece = value; }
        get { return proGrupoADondePertenece; }
    }

    public int ProEstado
    {
        set { proEstado = value; }
        get { return proEstado; }
    }

    public string ProCups
    {
        set { proCups = value; }
        get { return proCups; }
    }

    public string ProSubDivisionCups
    {
        set { proSubDivisionCups = value; }
        get { return proSubDivisionCups; }
    }

    public string ProDescripcion
    {
        set { proDescripcion = value; }
        get { return proDescripcion; }
    }

    public int IdProducto
    {
        set { idProducto = value; }
        get { return idProducto; }
    }

    public int ProValor
    {
        set { proValor = value; }
        get { return proValor; }
    }

    public int CodAthenea
    {
        set { codAthenea = value; }
        get { return codAthenea; }
    }

  

    

    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["proCodInterno"] = int.Parse(ProCodInterno.ToString());
        fila["proGrupoADondePertenece"] = int.Parse(ProGrupoADondePertenece.ToString());
        fila["proEstado"] = int.Parse(ProEstado.ToString());
        fila["proCups"] = ProCups;
        fila["proSubDivisionCups"] = ProSubDivisionCups;
        fila["proDescripcion"] = ProDescripcion;
        fila["proValor"] = int.Parse(ProValor.ToString());
        fila["codAthenea"] = int.Parse(CodAthenea.ToString());
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }


    public bool existe(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["proCodInterno"].ToString()) == valor)
            {
                ProCodInterno = int.Parse(fila["proCodInterno"].ToString());
                ProGrupoADondePertenece = int.Parse(fila["proGrupoADondePertenece"].ToString());
                ProEstado = int.Parse(fila["proEstado"].ToString());
                ProCups = fila["proCups"].ToString();
                ProSubDivisionCups = fila["proSubDivisionCups"].ToString();
                ProDescripcion = fila["proDescripcion"].ToString();
                IdProducto = int.Parse(fila["idProducto"].ToString());
                ProValor=int.Parse(fila["proValor"].ToString());
                CodAthenea = int.Parse(fila["codAthenea"].ToString());
                return true;
            }
        } return false;
    }


    public bool ExisteSegunCodigoAthenea(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["codAthenea"].ToString()) == valor)
            {
                ProCodInterno = int.Parse(fila["proCodInterno"].ToString());
                ProGrupoADondePertenece = int.Parse(fila["proGrupoADondePertenece"].ToString());
                ProEstado = int.Parse(fila["proEstado"].ToString());
                ProCups = fila["proCups"].ToString();
                ProSubDivisionCups = fila["proSubDivisionCups"].ToString();
                ProDescripcion = fila["proDescripcion"].ToString();
                IdProducto = int.Parse(fila["idProducto"].ToString());
                ProValor = int.Parse(fila["proValor"].ToString());
                CodAthenea = int.Parse(fila["codAthenea"].ToString());
                return true;
            }
        } return false;
    }


    public bool existePorId(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idProducto"].ToString()) == valor)
            {
                ProCodInterno = int.Parse(fila["proCodInterno"].ToString());
                ProGrupoADondePertenece = int.Parse(fila["proGrupoADondePertenece"].ToString());
                ProEstado = int.Parse(fila["proEstado"].ToString());
                ProCups = fila["proCups"].ToString();
                ProSubDivisionCups = fila["proSubDivisionCups"].ToString();
                ProDescripcion = fila["proDescripcion"].ToString();
                IdProducto = int.Parse(fila["idProducto"].ToString());
                ProValor = int.Parse(fila["proValor"].ToString());
                CodAthenea = int.Parse(fila["codAthenea"].ToString());
                return true;
            }
        } return false;
    }

    public bool actualizar(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["proCodInterno"].ToString()) == valor)
            {
                fila["proGrupoADondePertenece"] = ProGrupoADondePertenece;
                fila["proEstado"] = ProEstado;
                fila["proCups"] = ProCups;
                fila["proSubDivisionCups"] = ProSubDivisionCups;
                fila["proDescripcion"] = ProDescripcion;
                fila["proValor"] = ProValor;
                fila["codAthenea"] = CodAthenea;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }

    public bool devuelveDescripcionEstudiosOfrecidos(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["proCodInterno"].ToString()) == valor)
            {
                ProDescripcion = fila["proDescripcion"].ToString();
                return true;
            }
        } return false;
    }


    public bool ExisteConAreaCitog(int valor,int area)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["codAthenea"].ToString()) == valor && int.Parse(fila["proGrupoADondePertenece"].ToString()) == area)
            {
                ProCodInterno = int.Parse(fila["proCodInterno"].ToString());
                ProGrupoADondePertenece = int.Parse(fila["proGrupoADondePertenece"].ToString());
                ProEstado = int.Parse(fila["proEstado"].ToString());
                ProCups = fila["proCups"].ToString();
                ProSubDivisionCups = fila["proSubDivisionCups"].ToString();
                ProDescripcion = fila["proDescripcion"].ToString();
                IdProducto = int.Parse(fila["idProducto"].ToString());
                ProValor = int.Parse(fila["proValor"].ToString());
                CodAthenea = int.Parse(fila["codAthenea"].ToString());
                return true;
            }
        } return false;
    }


    public bool ExisteSinAreaCitog(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["codAthenea"].ToString()) == valor)
            {
                ProCodInterno = int.Parse(fila["proCodInterno"].ToString());
                ProGrupoADondePertenece = int.Parse(fila["proGrupoADondePertenece"].ToString());
                ProEstado = int.Parse(fila["proEstado"].ToString());
                ProCups = fila["proCups"].ToString();
                ProSubDivisionCups = fila["proSubDivisionCups"].ToString();
                ProDescripcion = fila["proDescripcion"].ToString();
                IdProducto = int.Parse(fila["idProducto"].ToString());
                ProValor = int.Parse(fila["proValor"].ToString());
                CodAthenea = int.Parse(fila["codAthenea"].ToString());
                return true;
            }
        } return false;
    }

    public bool ExisteBuscPorAtheneaDevulveInterno(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["codAthenea"].ToString()) == valor)
            {
                ProCodInterno = int.Parse(fila["proCodInterno"].ToString());
                return true;
            }
        } return false;
    }


    public bool actualizarSubCUPs(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["proCodInterno"].ToString()) == valor)
            {
                fila["proSubDivisionCups"] = ProSubDivisionCups;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }

    public bool actualizarDescripcion(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["proCodInterno"].ToString()) == valor)
            {
                fila["proDescripcion"] = ProDescripcion;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }

    public bool actualizarValor(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["proCodInterno"].ToString()) == valor)
            {
                fila["proValor"] = ProValor;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }

    public bool actualizarCodAthenea(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["proCodInterno"].ToString()) == valor)
            {
                fila["codAthenea"] = CodAthenea;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }

    public bool actualizarGrupoAlQuepertenece(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["proCodInterno"].ToString()) == valor)
            {
                fila["proGrupoADondePertenece"] = ProGrupoADondePertenece;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }


    public int BuscarProdInternoLibre()
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        int numPosible=100;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["proCodInterno"].ToString()) == numPosible)
            {
                numPosible = numPosible + 1;
            }
            else 
            {
                return numPosible;
            }
        }
        return numPosible;

    }

}