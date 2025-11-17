using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de cls_CreacionDeUsuariosComoObjeto
/// </summary>
public class cls_CreacionDeUsuariosComoObjeto
{
    public int rolLogueado;  //Codigo int del rol logueado
    public string usuarioLogueado;  //Nombre completo
    public int codUsuarioLogueado;  //ID del usuario logueado
    public string iPDeUsuarioLogueado;  //IP
    public string cadenaCodUsuarioLogueado;  // Usuario CSABINO, ejemplo, debe estar a mayuscula

    public cls_CreacionDeUsuariosComoObjeto(int rolLogueado, string usuarioLogueado, int codUsuarioLogueado, string iPDeUsuarioLogueado, string cadenaCodUsuarioLogueado)
	{
        this.rolLogueado = rolLogueado;
        this.usuarioLogueado = usuarioLogueado;
        this.codUsuarioLogueado = codUsuarioLogueado;
        this.iPDeUsuarioLogueado = iPDeUsuarioLogueado;
        this.cadenaCodUsuarioLogueado = cadenaCodUsuarioLogueado;
	}


    public cls_CreacionDeUsuariosComoObjeto()
    {
        
    }
    public int RolLogueado
    {
        set { rolLogueado = value; }
        get { return rolLogueado; }
    }

    public string UsuarioLogueado
    {
        set { usuarioLogueado = value; }
        get { return usuarioLogueado; }
    }

    public int CodUsuarioLogueado
    {
        set { codUsuarioLogueado = value; }
        get { return codUsuarioLogueado; }
    }
    
    public string IPDeUsuarioLogueado
    {
        set { iPDeUsuarioLogueado = value; }
        get { return iPDeUsuarioLogueado; }
    }

        public string CadenaCodUsuarioLogueado
    {
        set { cadenaCodUsuarioLogueado = value; }
        get { return cadenaCodUsuarioLogueado; }
    }




}