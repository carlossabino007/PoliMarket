using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class cls_Clientes_Laboratorios: clsconexion
{
    string tabla = "tblDestino";
    protected int idDestinoCorreos, destipDestCodigoAlQuePertenece, destipCiudadALaquePertenece, destipEstado;
    protected string desDescribeTipoDestino, destipObservaciones;
    protected int destipoTipoDocumento;
    protected string destipoNumeroDocumento;


    public cls_Clientes_Laboratorios(int idDestinoCorreos, int destipDestCodigoAlQuePertenece, int destipCiudadALaquePertenece, int destipEstado, string destipObservaciones,
        int destipoTipoDocumento, string destipoNumeroDocumento)
	{
        this.idDestinoCorreos =idDestinoCorreos;
        this.destipDestCodigoAlQuePertenece = destipDestCodigoAlQuePertenece;
        this.destipCiudadALaquePertenece = destipCiudadALaquePertenece;
        this.destipEstado = destipEstado;
        this.destipObservaciones = destipObservaciones;
        this.destipoTipoDocumento = destipoTipoDocumento;
        this.destipoNumeroDocumento = destipoNumeroDocumento;
	}


    public int IdDestinoCorreos
    {
        set { idDestinoCorreos = value; }
        get { return idDestinoCorreos; }
    }

    public int DestipDestCodigoAlQuePertenece
    {
        set { destipDestCodigoAlQuePertenece = value; }
        get { return destipDestCodigoAlQuePertenece; }
    }

    public int DestipEstado
    {
        set { destipEstado = value; }
        get { return destipEstado; }
    }


    public int DestipCiudadALaquePertenece
    {
        set { destipCiudadALaquePertenece = value; }
        get { return destipCiudadALaquePertenece; }
    }

    public string DesDescribeTipoDestino
    {
        set { desDescribeTipoDestino = value; }
        get { return desDescribeTipoDestino; }
    }


    public string DestipObservaciones
    {
        set { destipObservaciones = value; }
        get { return destipObservaciones; }
    }


        public int DestipoTipoDocumento
    {
        set { destipoTipoDocumento = value; }
        get { return destipoTipoDocumento; }
    }

        public string DestipoNumeroDocumento
    {
        set { destipoNumeroDocumento = value; }
        get { return destipoNumeroDocumento; }
    }

    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["DestipDestCodigoAlQuePertenece"] = int.Parse(destipDestCodigoAlQuePertenece.ToString());
        fila["DestipCiudadALaquePertenece"] = int.Parse(destipCiudadALaquePertenece.ToString());
        fila["DestipEstado"] = int.Parse(destipEstado.ToString());
        fila["DesDescribeTipoDestino"] = desDescribeTipoDestino;
        fila["DestipObservaciones"] = destipObservaciones;

        fila["DestipoTipoDocumento"] = int.Parse(destipoTipoDocumento.ToString());
        fila["DestipoNumeroDocumento"] = destipoNumeroDocumento;

        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }


    public bool ExisteCliente(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idDestinoCorreos"].ToString()) == valor)
            {
                DesDescribeTipoDestino = fila["desDescribeTipoDestino"].ToString();
                DestipDestCodigoAlQuePertenece = int.Parse(fila["destipDestCodigoAlQuePertenece"].ToString());
                DestipObservaciones = fila["destipObservaciones"].ToString();
                DestipEstado = int.Parse(fila["destipEstado"].ToString());
                DestipCiudadALaquePertenece = int.Parse(fila["destipCiudadALaquePertenece"].ToString());

                DestipoTipoDocumento = int.Parse(fila["destipoTipoDocumento"].ToString());
                DestipoNumeroDocumento = fila["destipoNumeroDocumento"].ToString();
                return true;
            }
        } return false;
    }


    public bool ActualizarCliente(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idDestinoCorreos"].ToString()) == valor)
            {
                fila["desDescribeTipoDestino"] = DesDescribeTipoDestino;
                fila["destipDestCodigoAlQuePertenece"] = DestipDestCodigoAlQuePertenece;
                fila["destipCiudadALaquePertenece"] = DestipCiudadALaquePertenece;
                fila["destipObservaciones"] = DestipObservaciones;
                fila["destipEstado"] = DestipEstado;

                fila["destipoTipoDocumento"] = DestipoTipoDocumento;
                fila["destipoNumeroDocumento"] = DestipoNumeroDocumento;



                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }

}