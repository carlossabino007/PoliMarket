using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// Descripción breve de ClaseR_CIT013F_Creacion
/// </summary>
public class ClaseR_CIT013F_Creacion : clsconexion
{

    string tabla = "tblCITO_RCIT013b";

     protected int idRCIT013;
     protected int caso;
     protected string casoIPCreacion;
     protected string casoResponsableCreacion;
     protected DateTime casoFechayHoraCreacion;
     protected int tipoDeMuestra;
     protected string tipoDeMuestraResponsable;
     protected string tipoDeMuestraIP;
     protected DateTime tipoDeMuestraFechayHora;
     protected int estadoDelCaso;
        

	public ClaseR_CIT013F_Creacion(int idRCIT013,int caso,string casoIPCreacion,string casoResponsableCreacion,DateTime casoFechayHoraCreacion,
     int tipoDeMuestra, string tipoDeMuestraResponsable, string tipoDeMuestraIP, DateTime tipoDeMuestraFechayHora, int estadoDelCaso)
	{
     this.idRCIT013=idRCIT013;
     this.caso=caso;
     this.casoIPCreacion=casoIPCreacion;
     this.casoResponsableCreacion=casoResponsableCreacion;
     this.casoFechayHoraCreacion=casoFechayHoraCreacion;
     this.tipoDeMuestra=tipoDeMuestra;
     this.tipoDeMuestraResponsable=tipoDeMuestraResponsable;
     this.tipoDeMuestraIP=tipoDeMuestraIP;
     this.tipoDeMuestraFechayHora = tipoDeMuestraFechayHora;
     this.estadoDelCaso = estadoDelCaso;
	}



    public int IdRCIT013
    { set { idRCIT013 = value; } get { return idRCIT013; } 
    }

    public int Caso
    { set { caso = value; } get { return caso; } 
    }

    public string CasoIPCreacion 
    { set { casoIPCreacion = value; }
      get { return casoIPCreacion; } 
    }
    public string CasoResponsableCreacion { set { casoResponsableCreacion = value; } get { return casoResponsableCreacion; } }
    public DateTime CasoFechayHoraCreacion { set { casoFechayHoraCreacion = value; } get { return casoFechayHoraCreacion; } }
    public int TipoDeMuestra { set { tipoDeMuestra = value; } get { return tipoDeMuestra; } }
    public string TipoDeMuestraResponsable { set { tipoDeMuestraResponsable = value; } get { return tipoDeMuestraResponsable; } }
    public string TipoDeMuestraIP { set { tipoDeMuestraIP = value; } get { return tipoDeMuestraIP; } }
    public DateTime TipoDeMuestraFechayHora { set { tipoDeMuestraFechayHora = value; } get { return tipoDeMuestraFechayHora; } }
    public int EstadoDelCaso { set { estadoDelCaso = value; } get { return estadoDelCaso; } }

 
    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["caso"] = int.Parse(Caso.ToString());
        fila["casoIPCreacion"] = CasoIPCreacion;
        fila["casoResponsableCreacion"] = CasoResponsableCreacion;
        fila["casoFechayHoraCreacion"] = CasoFechayHoraCreacion;
        fila["tipoDeMuestra"] = TipoDeMuestra;
        fila["tipoDeMuestraResponsable"] = TipoDeMuestraResponsable;
        fila["tipoDeMuestraIP"] = TipoDeMuestraIP;
        fila["tipoDeMuestraFechayHora"] = TipoDeMuestraFechayHora;
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }

}