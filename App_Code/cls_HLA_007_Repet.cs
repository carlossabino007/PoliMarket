using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class cls_HLA_007_Repet: clsconexion
{
    string tabla = "tblR_HLA_007_repet";
    protected int idHLA_007;
    protected int r_hla_007_tipoAnalisis;
    protected int r_hla_007_NumeroMuestra;
    protected int r_hla_007_TipoMuestraParte1;
    protected int r_hla_007_TipoMuestraParte2;
    protected int r_hla_007_Metodo;
    protected decimal r_hla_007_Abs260;
    protected decimal r_hla_007_Abs280;
    protected decimal r_hla_007_Abs260SobreAbs280;
    protected decimal r_hla_007_ngSobreUl;
    protected decimal r_hla_007_ngSobreUlFinal;
    protected decimal r_hla_007_FD;
    protected decimal r_hla_007_ADNaToamr;
    protected decimal r_hla_007_H2O;
    protected string r_hla_007_UsuarioQueRegistra;
    protected string r_hla_007_IP;
    protected DateTime r_hla_007_FechaSolamente;
    protected DateTime r_hla_007_FechaYHora;
    protected string r_hla_007_FechaEnString;
    protected int r_hla_007_Estado;

	public cls_HLA_007_Repet(int idHLA_007, int r_hla_007_tipoAnalisis, int r_hla_007_NumeroMuestra, int r_hla_007_TipoMuestraParte1,
    int r_hla_007_TipoMuestraParte2, int r_hla_007_Metodo, decimal r_hla_007_Abs260, decimal r_hla_007_Abs280,
    decimal r_hla_007_Abs260SobreAbs280, decimal r_hla_007_ngSobreUl, decimal r_hla_007_ngSobreUlFinal,
    decimal r_hla_007_FD, decimal r_hla_007_ADNaToamr, decimal r_hla_007_H2O, string r_hla_007_UsuarioQueRegistra,
    string r_hla_007_IP, DateTime r_hla_007_FechaSolamente, DateTime r_hla_007_FechaYHora,
    string r_hla_007_FechaEnString, int r_hla_007_Estado)
	{

    this.idHLA_007=idHLA_007;
    this.r_hla_007_tipoAnalisis=r_hla_007_tipoAnalisis;
    this.r_hla_007_NumeroMuestra=r_hla_007_NumeroMuestra;
    this.r_hla_007_TipoMuestraParte1=r_hla_007_TipoMuestraParte1;
    this.r_hla_007_TipoMuestraParte2=r_hla_007_TipoMuestraParte2;
    this.r_hla_007_Metodo=r_hla_007_Metodo;
    this.r_hla_007_Abs260=r_hla_007_Abs260;
    this.r_hla_007_Abs280=r_hla_007_Abs280;
    this.r_hla_007_Abs260SobreAbs280=r_hla_007_Abs260SobreAbs280;
    this.r_hla_007_ngSobreUl=r_hla_007_ngSobreUl;
    this.r_hla_007_ngSobreUlFinal=r_hla_007_ngSobreUlFinal;
    this.r_hla_007_FD=r_hla_007_FD;
    this.r_hla_007_ADNaToamr=r_hla_007_ADNaToamr;
    this.r_hla_007_H2O=r_hla_007_H2O;
    this.r_hla_007_UsuarioQueRegistra=r_hla_007_UsuarioQueRegistra;
    this.r_hla_007_IP=r_hla_007_IP;
    this.r_hla_007_FechaSolamente=r_hla_007_FechaSolamente;
    this.r_hla_007_FechaYHora=r_hla_007_FechaYHora;
    this.r_hla_007_FechaEnString = r_hla_007_FechaEnString;
    this.r_hla_007_Estado = r_hla_007_Estado;
	}

    public int IdHLA_007
    {
        set {  idHLA_007=idHLA_007 = value; }
        get { return idHLA_007; }
    }

    public int R_hla_007_tipoAnalisis
    {
        set {  r_hla_007_tipoAnalisis = value; }
        get { return r_hla_007_tipoAnalisis; }
    }

    public int R_hla_007_NumeroMuestra
    {
        set {  r_hla_007_NumeroMuestra = value; }
        get { return  r_hla_007_NumeroMuestra; }
    }

    public int R_hla_007_TipoMuestraParte1
    {
        set {  r_hla_007_TipoMuestraParte1 = value; }
        get { return r_hla_007_TipoMuestraParte1; }
    }

    public int R_hla_007_TipoMuestraParte2
    {
        set {  r_hla_007_TipoMuestraParte2 = value; }
        get { return r_hla_007_TipoMuestraParte2; }
    }

    public int R_hla_007_Metodo
    {
        set {  r_hla_007_Metodo = value; }
        get { return r_hla_007_Metodo; }
    }

    public decimal R_hla_007_Abs260
    {
        set {  r_hla_007_Abs260 = value; }
        get { return r_hla_007_Abs260 ; }
    }


    public decimal R_hla_007_Abs280
    {
        set {  r_hla_007_Abs280= value; }
        get { return r_hla_007_Abs280 ; }
    }


    public decimal R_hla_007_Abs260SobreAbs280
    {
        set {  r_hla_007_Abs260SobreAbs280 = value; }
        get { return r_hla_007_Abs260SobreAbs280; }
    }

    public decimal R_hla_007_ngSobreUl
    {
        set {  r_hla_007_ngSobreUl= value; }
        get { return r_hla_007_ngSobreUl; }
    }

    public decimal R_hla_007_ngSobreUlFinal
    {
        set { r_hla_007_ngSobreUlFinal = value; }
        get { return r_hla_007_ngSobreUlFinal; }
    }


    public decimal R_hla_007_FD
    {
        set { r_hla_007_FD = value; }
        get { return r_hla_007_FD; }
    }

    public decimal R_hla_007_ADNaToamr
    {
        set {  r_hla_007_ADNaToamr= value; }
        get { return r_hla_007_ADNaToamr; }
    }

    public decimal R_hla_007_H2O
    {
        set {  r_hla_007_H2O= value; }
        get { return r_hla_007_H2O; }
    }

    public string R_hla_007_UsuarioQueRegistra
    {
        set { r_hla_007_UsuarioQueRegistra = value; }
        get { return r_hla_007_UsuarioQueRegistra; }
    }

    public string R_hla_007_IP
    {
        set {  r_hla_007_IP= value; }
        get { return r_hla_007_IP; }
    }

    public DateTime R_hla_007_FechaSolamente
    {
        set {  r_hla_007_FechaSolamente= value; }
        get { return r_hla_007_FechaSolamente; }
    }

    public DateTime R_hla_007_FechaYHora
    {
        set {  r_hla_007_FechaYHora= value; }
        get { return r_hla_007_FechaYHora; }
    }

    public string R_hla_007_FechaEnString 
    {
        set {  r_hla_007_FechaEnString= value; }
        get { return r_hla_007_FechaEnString; }
    }


    public int R_hla_007_Estado
    {
        set { r_hla_007_Estado = value; }
        get { return r_hla_007_Estado; }
    }


      public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["R_hla_007_tipoAnalisis"] = int.Parse(r_hla_007_tipoAnalisis.ToString());
        fila["R_hla_007_NumeroMuestra"] = int.Parse(r_hla_007_NumeroMuestra.ToString());
        fila["R_hla_007_TipoMuestraParte1"] = int.Parse(r_hla_007_TipoMuestraParte1.ToString());
        fila["R_hla_007_TipoMuestraParte2"] = int.Parse(r_hla_007_TipoMuestraParte2.ToString());
        fila["R_hla_007_Metodo"] = int.Parse(r_hla_007_Metodo.ToString());
        fila["R_hla_007_Abs260"] = System.Convert.ToDecimal(r_hla_007_Abs260);
        fila["R_hla_007_Abs280"] = System.Convert.ToDecimal(r_hla_007_Abs280);
        fila["R_hla_007_Abs260SobreAbs280"] = System.Convert.ToDecimal(r_hla_007_Abs260SobreAbs280);
        fila["R_hla_007_ngSobreUl"] = System.Convert.ToDecimal(r_hla_007_ngSobreUl);
        fila["R_hla_007_ngSobreUlFinal"] = System.Convert.ToDecimal(r_hla_007_ngSobreUlFinal);
        fila["R_hla_007_FD"] = System.Convert.ToDecimal(r_hla_007_FD);
        fila["R_hla_007_ADNaToamr"] = System.Convert.ToDecimal(r_hla_007_ADNaToamr);
        fila["R_hla_007_H2O"] = System.Convert.ToDecimal(r_hla_007_H2O);
        fila["R_hla_007_UsuarioQueRegistra"] = r_hla_007_UsuarioQueRegistra;
        fila["R_hla_007_FechaSolamente"] = r_hla_007_FechaSolamente;
        fila["R_hla_007_FechaYHora"] = r_hla_007_FechaYHora;
        fila["R_hla_007_IP"] = r_hla_007_IP;
        fila["R_hla_007_FechaEnString"] = r_hla_007_FechaEnString;
        fila["R_hla_007_Estado"] = int.Parse(r_hla_007_Estado.ToString());
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);

    }


      public bool ExistePorElCodigoGenerado(string valor, int valorParte3)
      {
          conectar(tabla);
          DataRow fila;
          int x = Data.Tables[tabla].Rows.Count - 1;
          for (int i = 0; i <= x; i++)
          {
              fila = Data.Tables[tabla].Rows[i];
              if (fila["r_hla_007_NumeroMuestra"].ToString().Equals(valor))
              {
                  if (int.Parse(fila["r_hla_007_TipoMuestraParte2"].ToString()) == valorParte3)
                  {
                      IdHLA_007 = int.Parse(fila["idHLA_007"].ToString());
                      R_hla_007_tipoAnalisis = int.Parse(fila["r_hla_007_tipoAnalisis"].ToString());
                      R_hla_007_NumeroMuestra = int.Parse(fila["r_hla_007_NumeroMuestra"].ToString());
                      R_hla_007_TipoMuestraParte1 = int.Parse(fila["r_hla_007_TipoMuestraParte1"].ToString());
                      R_hla_007_TipoMuestraParte1 = int.Parse(fila["r_hla_007_TipoMuestraParte2"].ToString());
                      R_hla_007_Metodo = int.Parse(fila["r_hla_007_Metodo"].ToString());
                      R_hla_007_Abs260 = decimal.Parse(fila["r_hla_007_Abs260"].ToString());
                      R_hla_007_Abs280 = decimal.Parse(fila["r_hla_007_Abs280"].ToString());
                      R_hla_007_Abs260SobreAbs280 = decimal.Parse(fila["r_hla_007_Abs260SobreAbs280"].ToString());
                      R_hla_007_ngSobreUl = decimal.Parse(fila["r_hla_007_ngSobreUl"].ToString());
                      R_hla_007_ngSobreUlFinal = decimal.Parse(fila["r_hla_007_ngSobreUlFinal"].ToString());
                      R_hla_007_FD = decimal.Parse(fila["r_hla_007_FD"].ToString());
                      R_hla_007_ADNaToamr = decimal.Parse(fila["r_hla_007_ADNaToamr"].ToString());
                      R_hla_007_H2O = decimal.Parse(fila["r_hla_007_H2O"].ToString());
                      R_hla_007_UsuarioQueRegistra = fila["r_hla_007_UsuarioQueRegistra"].ToString();
                      R_hla_007_IP = fila["r_hla_007_IP"].ToString();
                      R_hla_007_FechaSolamente = DateTime.Parse(fila[("r_hla_007_FechaSolamente")].ToString());
                      R_hla_007_FechaYHora = DateTime.Parse(fila[("r_hla_007_FechaYHora")].ToString());
                      R_hla_007_FechaEnString = fila["r_hla_007_FechaEnString"].ToString();
                      R_hla_007_Estado = int.Parse(fila["r_hla_007_Estado"].ToString());
                      return true;
                  }
              }
          }

          return false;
      }












}