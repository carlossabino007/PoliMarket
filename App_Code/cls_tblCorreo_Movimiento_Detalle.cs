using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Descripción breve de cls_tblCorreo_Movimiento_Detalle
/// </summary>
public class cls_tblCorreo_Movimiento_Detalle : clsconexion
{
    string tabla = "tblCorreo_Movimiento_Detalle";

    #region "Atributos Privados";
    private int idMovCorreoDetalle;
    private int modCorreoDetalle_ItemEnCabeceraUsaclsContadorFK;
    private int modCorreoDetalle_TipoDeItem;
    private int modCorreoDetalle_Estado;
    private string modCorreoDetalle_Descripcion;
    #endregion

    #region "Constructor";
    public cls_tblCorreo_Movimiento_Detalle(int idMovCorreoDetalle, int modCorreoDetalle_ItemEnCabeceraUsaclsContadorFK, int modCorreoDetalle_TipoDeItem, int modCorreoDetalle_Estado,
        string modCorreoDetalle_Descripcion)
    {
        this.idMovCorreoDetalle = idMovCorreoDetalle;
        this.modCorreoDetalle_ItemEnCabeceraUsaclsContadorFK = modCorreoDetalle_ItemEnCabeceraUsaclsContadorFK;
        this.modCorreoDetalle_Estado = modCorreoDetalle_Estado;
        this.modCorreoDetalle_Descripcion = modCorreoDetalle_Descripcion;
    }
    #endregion

    #region "Propiedades"
    protected int IdMovCorreoDetalle
    {
        get { return idMovCorreoDetalle; }
        set { idMovCorreoDetalle = value; }
    }

    public int ModCorreoDetalle_ItemEnCabeceraUsaclsContadorFK
    {
        get { return modCorreoDetalle_ItemEnCabeceraUsaclsContadorFK; }
        set { modCorreoDetalle_ItemEnCabeceraUsaclsContadorFK = value; }
    }

    public int ModCorreoDetalle_TipoDeItem
    {
        get { return modCorreoDetalle_TipoDeItem; }
        set { modCorreoDetalle_TipoDeItem = value; }
    }

    public int ModCorreoDetalle_Estado
    {
        get { return modCorreoDetalle_Estado; }
        set { modCorreoDetalle_Estado = value; }
    }

     public string ModCorreoDetalle_Descripcion
    {
        get { return modCorreoDetalle_Descripcion; }
        set { modCorreoDetalle_Descripcion = value; }
    }
    #endregion

    



    #region "Métodos";
    public void agregar()
    {

        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["modCorreoDetalle_ItemEnCabeceraUsaclsContadorFK"] = int.Parse(ModCorreoDetalle_ItemEnCabeceraUsaclsContadorFK.ToString());
        fila["modCorreoDetalle_TipoDeItem"] = int.Parse(ModCorreoDetalle_TipoDeItem.ToString());
        fila["modCorreoDetalle_Estado"] = int.Parse(ModCorreoDetalle_Estado.ToString());
        fila["modCorreoDetalle_Descripcion"] = ModCorreoDetalle_Descripcion;
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }



    #endregion




}