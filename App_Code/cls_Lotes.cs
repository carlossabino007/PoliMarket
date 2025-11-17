using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



public class cls_Lotes: clsconexion
{

    string tabla = "tblLote";
    protected int lotCodigoLote, lotAreaALaQuePertenece, lotUsuario, lotPresentacion, lotUnidadDeMedida, lotEstado, lotProductoAlQuePertenece;
    protected decimal lotExstenciaInicial, lotPor, lotCantidadMinimaEnExistencia, lotConsumoPorPrueba, lotValorProducto, lotEnStock;
    protected string lotCodigoLoteCatalogoMasLote, lotLoteEnString, lotCatalogoEnString, lotIP, lotPC, lotFechaCreacionString, lotHoraCreacionString, lotFechaVencimiento;

    public cls_Lotes(int lotCodigoLote, int lotAreaALaQuePertenece, int lotUsuario, int lotPresentacion, int lotUnidadDeMedida, int lotEstado, int lotProductoAlQuePertenece,
        decimal lotExstenciaInicial, decimal lotPor, decimal lotCantidadMinimaEnExistencia, decimal lotConsumoPorPrueba, decimal lotValorProducto, decimal lotEnStock,
        string lotLoteEnString, string lotCatalogoEnString, string lotIP, string lotPC, string lotFechaCreacionString, string lotHoraCreacionString, string lotFechaVencimiento,
        string lotCodigoLoteCatalogoMasLote)
	{
        //int
        this.lotCodigoLote = lotCodigoLote;
        this.lotAreaALaQuePertenece = lotAreaALaQuePertenece;
        this.lotUsuario = lotUsuario;
        this.lotPresentacion = lotPresentacion;
        this.lotUnidadDeMedida = lotUnidadDeMedida;
        this.lotEstado = lotEstado;
        this.lotProductoAlQuePertenece = lotProductoAlQuePertenece;

        // decimal
        this.lotExstenciaInicial = lotExstenciaInicial;
        this.lotPor = lotPor;
        this.lotCantidadMinimaEnExistencia = lotCantidadMinimaEnExistencia;
        this.lotConsumoPorPrueba = lotConsumoPorPrueba;
        this.lotValorProducto = lotValorProducto;
        this.lotEnStock = lotEnStock;

        //string
        this.lotLoteEnString = lotLoteEnString;
        this.lotCatalogoEnString = lotCatalogoEnString;
        this.lotIP = lotIP;
        this.lotPC = lotPC;
        this.lotFechaCreacionString = lotFechaCreacionString;
        this.lotHoraCreacionString = lotHoraCreacionString;
        this.lotFechaVencimiento = lotFechaVencimiento;
        this.lotCodigoLoteCatalogoMasLote = lotCodigoLoteCatalogoMasLote;
	}


    // int



    public int LotCodigoLote
    {
        set { lotCodigoLote = value; }
        get { return lotCodigoLote; }
    }

    public int LotAreaALaQuePertenece
    {
        set { lotAreaALaQuePertenece = value; }
        get { return lotAreaALaQuePertenece; }
    }

    public int LotUsuario
    {
        set { lotUsuario = value; }
        get { return lotUsuario; }
    }


    public int LotPresentacion
    {
        set { lotPresentacion = value; }
        get { return lotPresentacion; }
    }


    public int LotUnidadDeMedida
    {
        set { lotUnidadDeMedida = value; }
        get { return lotUnidadDeMedida; }
    }

    public int LotEstado
    {
        set { lotEstado = value; }
        get { return lotEstado; }
    }


    public int LotProductoAlQuePertenece
    {
        set { lotProductoAlQuePertenece = value; }
        get { return lotProductoAlQuePertenece; }
    }


    // Decimal
     public decimal  LotExstenciaInicial
    {
        set {  lotExstenciaInicial = value; }
        get { return  lotExstenciaInicial; }
    }

    public decimal LotPor
        {
            set {  lotPor = value; }
            get { return lotPor ; }
        }

    public decimal LotCantidadMinimaEnExistencia
        { 
            set {  lotCantidadMinimaEnExistencia = value; }
            get { return  lotCantidadMinimaEnExistencia; }
        }

    public decimal LotConsumoPorPrueba
        {
            set {  lotConsumoPorPrueba = value; }
            get { return lotConsumoPorPrueba; }
        }

    public decimal LotValorProducto
        {
            set { lotValorProducto = value; }
            get { return lotValorProducto; }
        }

    public decimal LotEnStock
        {
            set {  lotEnStock = value; }
            get { return lotEnStock; }
        }


    // string

     public string LotLoteEnString
    {
        set { lotLoteEnString = value; }
        get { return lotLoteEnString; }
    }

     public string LotCatalogoEnString
    {
        set { lotCatalogoEnString = value; }
        get { return lotCatalogoEnString; }
    }

     public string LotIp
    {
        set { lotIP = value; }
        get { return lotIP; }
    }

    public string LotPC
    {
        set { lotPC = value; }
        get { return lotPC; }
    }


    public string LotFechaCreacionString
    {
        set { lotFechaCreacionString = value; }
        get { return lotFechaCreacionString; }
    }

    public string LotHoraCreacionString
    {
        set { lotHoraCreacionString = value; }
        get { return lotHoraCreacionString; }
    }

    public string LotFechaVencimiento
    {
        set { lotFechaVencimiento = value; }
        get { return lotFechaVencimiento; }
    }

    public string LotCodigoLoteCatalogoMasLote
    {
        set { lotCodigoLoteCatalogoMasLote = value; }
        get { return lotCodigoLoteCatalogoMasLote; }
    }


    public bool existe(string valor1)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (fila["lotCodigoLoteCatalogoMasLote"].ToString().Equals(valor1))  // Si no es el mismo, si es diferente
            {
                    // int
                    LotCodigoLote = int.Parse(fila["lotCodigoLote"].ToString());
                    LotAreaALaQuePertenece = int.Parse(fila["lotAreaALaQuePertenece"].ToString());
                    LotUsuario = int.Parse(fila["lotUsuario"].ToString());
                    LotPresentacion = int.Parse(fila["lotPresentacion"].ToString());
                    LotUnidadDeMedida = int.Parse(fila["lotUnidadDeMedida"].ToString());
                    LotEstado = int.Parse(fila["lotEstado"].ToString());
                    LotProductoAlQuePertenece = int.Parse(fila["lotProductoAlQuePertenece"].ToString());
                    

                    //decimal
                    LotExstenciaInicial = decimal.Parse(fila["lotExstenciaInicial"].ToString());
                    LotPor = decimal.Parse(fila["lotPor"].ToString());
                    LotCantidadMinimaEnExistencia = decimal.Parse(fila["lotCantidadMinimaEnExistencia"].ToString());
                    LotConsumoPorPrueba = decimal.Parse(fila["lotConsumoPorPrueba"].ToString());
                    LotValorProducto = decimal.Parse(fila["lotValorProducto"].ToString());
                    LotEnStock = decimal.Parse(fila["lotEnStock"].ToString());

                    //string
                    LotLoteEnString = fila["lotLoteEnString"].ToString();
                    LotCatalogoEnString = fila["lotCatalogoEnString"].ToString();
                    LotCodigoLoteCatalogoMasLote = fila["LotCodigoLoteCatalogoMasLote"].ToString();
                    LotIp = fila["lotIp"].ToString();
                    LotPC = fila["lotPC"].ToString();
                    LotFechaCreacionString = fila["lotFechaCreacionString"].ToString();
                    return true;
                
            }
        } return false;
    }




    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();

        //  Se crea un ID automatica que lo uso para enlazar con la tabla productos y lo g
        //int

        fila["lotCodigoLote"] = int.Parse(LotCodigoLote.ToString());
        fila["lotAreaALaQuePertenece"] = int.Parse(LotAreaALaQuePertenece.ToString());
        fila["lotUsuario"] = int.Parse(LotUsuario.ToString());
        fila["lotPresentacion"] = int.Parse(LotPresentacion.ToString());
        fila["lotUnidadDeMedida"] = int.Parse(LotUnidadDeMedida.ToString());
        fila["lotEstado"] = int.Parse(LotEstado.ToString());
        fila["lotProductoAlQuePertenece"] = int.Parse(LotProductoAlQuePertenece.ToString());
        

        //decimal
        fila["lotExstenciaInicial"] = System.Convert.ToDecimal(LotExstenciaInicial);
        fila["lotPor"] = System.Convert.ToDecimal(LotPor);
        fila["lotCantidadMinimaEnExistencia"] = System.Convert.ToDecimal(LotCantidadMinimaEnExistencia);
        fila["lotConsumoPorPrueba"] = System.Convert.ToDecimal(LotConsumoPorPrueba);
        fila["lotValorProducto"] = System.Convert.ToDecimal(LotValorProducto);
        fila["lotEnStock"] = System.Convert.ToDecimal(LotEnStock);

        // string
        fila["lotLoteEnString"] = LotLoteEnString;
        fila["lotCatalogoEnString"] = LotCatalogoEnString;
        fila["lotCodigoLoteCatalogoMasLote"] = LotCodigoLoteCatalogoMasLote;
        fila["lotIP"] = LotIp;
        fila["lotPC"] = LotPC;
        fila["lotFechaCreacionString"] = LotFechaCreacionString;
        fila["lotHoraCreacionString"] = LotHoraCreacionString;
        fila["lotFechaVencimiento"] = LotFechaVencimiento;

        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }


    public bool devuelveDescripcionDelLote(string valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (fila["lotCodigoLoteCatalogoMasLote"].Equals(valor))
            {
                LotLoteEnString = fila["lotLoteEnString"].ToString();
                return true;
            }
        } return false;
    }




}