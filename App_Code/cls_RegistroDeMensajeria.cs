using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public class cls_RegistroDeMensajeria: clsconexion
{
    string tabla = "tblTomaDeMuestras";
    protected int idRegistroTomaDeMuestras, tomaDeMuestras_temperaturaLlegada, tomaDeMuestras_EntidadFK, tomaDeMuestras_EmpresaTransportadoraFK;
    protected string tomaDeMuestras_NumeroGuia, tomaDeMuestras_Observaciones, tomaDeMuestras_HoraLLegadaEnString;
    protected DateTime tomaDeMuestras_FechaHoraLLegadaDateTime, tomaDeMuestras_FechaHoraLLegadaSoloDate;
    protected string tomaDeMuestrasQuienRegistra;


    public cls_RegistroDeMensajeria(int idRegistroTomaDeMuestras, int tomaDeMuestras_temperaturaLlegada, int tomaDeMuestras_EntidadFK, 
        int tomaDeMuestras_EmpresaTransportadoraFK,
        string tomaDeMuestras_NumeroGuia, string tomaDeMuestras_Observaciones, DateTime tomaDeMuestras_FechaHoraLLegadaDateTime, string tomaDeMuestras_HoraLLegadaEnString, DateTime tomaDeMuestras_FechaHoraLLegadaSoloDate,
        string tomaDeMuestrasQuienRegistra)
	{
        //int
        this.idRegistroTomaDeMuestras = idRegistroTomaDeMuestras;
        this.tomaDeMuestras_temperaturaLlegada = tomaDeMuestras_temperaturaLlegada;
        this.tomaDeMuestras_EntidadFK = tomaDeMuestras_EntidadFK;
        this.tomaDeMuestras_EmpresaTransportadoraFK = tomaDeMuestras_EmpresaTransportadoraFK;

        //string
        this.tomaDeMuestras_NumeroGuia = tomaDeMuestras_NumeroGuia;
        this.tomaDeMuestras_Observaciones = tomaDeMuestras_Observaciones;
        this.tomaDeMuestras_HoraLLegadaEnString = tomaDeMuestras_HoraLLegadaEnString;

        //Datetime
        this.tomaDeMuestras_FechaHoraLLegadaDateTime = tomaDeMuestras_FechaHoraLLegadaDateTime;
        this.tomaDeMuestras_FechaHoraLLegadaSoloDate = tomaDeMuestras_FechaHoraLLegadaSoloDate;

        this.tomaDeMuestrasQuienRegistra = tomaDeMuestrasQuienRegistra;


	}


   
    // int
    public int IdRegistroTomaDeMuestras
    {
        set { idRegistroTomaDeMuestras = value; }
        get { return idRegistroTomaDeMuestras; }
    }

    public int TomaDeMuestras_temperaturaLlegada
    {
        set { tomaDeMuestras_temperaturaLlegada = value; }
        get { return tomaDeMuestras_temperaturaLlegada; }
    }

    public int TomaDeMuestras_EntidadFK
    {
        set { tomaDeMuestras_EntidadFK = value; }
        get { return tomaDeMuestras_EntidadFK; }
    }

    public int TomaDeMuestras_EmpresaTransportadoraFK
    {
        set { tomaDeMuestras_EmpresaTransportadoraFK = value; }
        get { return tomaDeMuestras_EmpresaTransportadoraFK; }
    }

    //string
    public string TomaDeMuestras_NumeroGuia
    {
        set { tomaDeMuestras_NumeroGuia = value; }
        get { return tomaDeMuestras_NumeroGuia; }
    }

    public string TomaDeMuestras_Observaciones
    {
        set { tomaDeMuestras_Observaciones = value; }
        get { return tomaDeMuestras_Observaciones; }
    }


    public string TomaDeMuestras_HoraLLegadaEnString
    {
        set { tomaDeMuestras_HoraLLegadaEnString = value; }
        get { return tomaDeMuestras_HoraLLegadaEnString; }
    }


     //DateTime
    public  DateTime TomaDeMuestras_FechaHoraLLegadaDateTime
    {
        set { tomaDeMuestras_FechaHoraLLegadaDateTime = value; }
        get { return tomaDeMuestras_FechaHoraLLegadaDateTime; }
    }


    public DateTime TomaDeMuestras_FechaHoraLLegadaSoloDate
    {
        set { tomaDeMuestras_FechaHoraLLegadaSoloDate = value; }
        get { return tomaDeMuestras_FechaHoraLLegadaSoloDate; }
    }


    public String TomaDeMuestrasQuienRegistra
    {
        set { tomaDeMuestrasQuienRegistra = value; }
        get { return tomaDeMuestrasQuienRegistra; }
    }


    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        //int
        fila["tomaDeMuestras_temperaturaLlegada"] = int.Parse(TomaDeMuestras_temperaturaLlegada.ToString());
        fila["tomaDeMuestras_EntidadFK"] = int.Parse(TomaDeMuestras_EntidadFK.ToString());
        fila["tomaDeMuestras_EmpresaTransportadoraFK"] = int.Parse(TomaDeMuestras_EmpresaTransportadoraFK.ToString());
        //string
        fila["tomaDeMuestras_NumeroGuia"] = TomaDeMuestras_NumeroGuia;
        fila["tomaDeMuestras_Observaciones"] = TomaDeMuestras_Observaciones;
        fila["tomaDeMuestras_HoraLLegadaEnString"] = TomaDeMuestras_HoraLLegadaEnString;
        // datetime
       fila["tomaDeMuestras_FechaHoraLLegadaDateTime"] = TomaDeMuestras_FechaHoraLLegadaDateTime;
       fila["tomaDeMuestras_FechaHoraLLegadaSoloDate"] = TomaDeMuestras_FechaHoraLLegadaSoloDate;
       fila["tomaDeMuestrasQuienRegistra"] = TomaDeMuestrasQuienRegistra;
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }

    public bool existePorGuia(string valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (fila["tomaDeMuestras_NumeroGuia"].ToString().Equals(valor))
            {
                IdRegistroTomaDeMuestras = int.Parse(fila["idRegistroTomaDeMuestras"].ToString());
                TomaDeMuestras_temperaturaLlegada = int.Parse(fila["tomaDeMuestras_temperaturaLlegada"].ToString());
                TomaDeMuestras_EntidadFK = int.Parse(fila["tomaDeMuestras_EntidadFK"].ToString());
                TomaDeMuestras_EmpresaTransportadoraFK = int.Parse(fila["tomaDeMuestras_EmpresaTransportadoraFK"].ToString());
                TomaDeMuestras_NumeroGuia = fila["tomaDeMuestras_NumeroGuia"].ToString();
                TomaDeMuestras_Observaciones = fila["tomaDeMuestras_Observaciones"].ToString();
                TomaDeMuestras_HoraLLegadaEnString = fila["tomaDeMuestras_HoraLLegadaEnString"].ToString();

                TomaDeMuestras_FechaHoraLLegadaDateTime = DateTime.Parse(fila[("tomaDeMuestras_FechaHoraLLegadaDateTime")].ToString());
                TomaDeMuestras_FechaHoraLLegadaSoloDate = DateTime.Parse(fila[("tomaDeMuestras_FechaHoraLLegadaSoloDate")].ToString());
                TomaDeMuestrasQuienRegistra = fila["tomaDeMuestrasQuienRegistra"].ToString();
                return true;

            }
        } return false;
    }


}