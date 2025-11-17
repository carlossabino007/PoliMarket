using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Descripción breve de cls_Nuevo_ClienteEntidad
/// </summary>
public class cls_Nuevo_ClienteEntidad
{
    string tabla = "tblCondicionDeAlmacenamiento";
    protected int condAlmacenCodigo, condAlmacenEstado;
    protected string condAlmacenDescripcion, condAlmacenFechaCreacionString;
	public cls_Nuevo_ClienteEntidad()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}
}