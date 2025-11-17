using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class cls_paso1_SeGrabaEnTablaGeneral : clsconexion
{
    //string tabla = "tblProductosEnInventario";
    string tabla = "tblProductosEnGeneral";
    

    protected int producto_Codigo, producto_CodMarca, producto_Presentacion, producto_Clasificacion, producto_CondicionAlmacenamiento, producto_UnidadMedida, producto_Estado, producto_Usuario, producto_AlarmaVencimientoNumDiasAntes;
    protected string producto_Descripcion, producto_RegistroSanitario, producto_Observaciones, producto_FechaCreacionString, producto_IP, producto_PC, producto_HoraCreacionString, producto_ModoDeConsumo;
    protected decimal producto_ValorUnidadDeMedida, producto_CantidadMinimaEnStock;
    protected int producto_RiesgoQuimico, producto_PeligroParaLaSalud, producto_RiesgoDeInflamabilidad, producto_PeligroEspecifico, producto_RiesgoPorReactividad, producto_RiesgoQuimico2;
    protected string producto_UsuarioString;
    protected int producto_Area;


    public cls_paso1_SeGrabaEnTablaGeneral(int producto_Codigo, int producto_CodMarca, int producto_Presentacion, int producto_Clasificacion,
        int producto_CondicionAlmacenamiento, int producto_UnidadMedida, int producto_Estado, int producto_Usuario,
        string producto_Descripcion, string producto_RegistroSanitario, string producto_Observaciones, string producto_FechaCreacionString,
        string producto_IP, string producto_PC, string producto_HoraCreacionString, string producto_ModoDeConsumo, decimal producto_ValorUnidadDeMedida, int producto_AlarmaVencimientoNumDiasAntes, decimal producto_CantidadMinimaEnStock,
        int producto_RiesgoQuimico, int producto_PeligroParaLaSalud, int producto_RiesgoDeInflamabilidad, int producto_PeligroEspecifico, int producto_RiesgoPorReactividad, int producto_RiesgoQuimico2,
        string producto_UsuarioString, int producto_Area)
    {
        // int
        this.producto_Codigo = producto_Codigo;
        this.producto_CodMarca = producto_CodMarca;
        this.producto_Presentacion = producto_Presentacion;
        this.producto_Clasificacion = producto_Clasificacion;
        this.producto_CondicionAlmacenamiento = producto_CondicionAlmacenamiento;
        this.producto_UnidadMedida = producto_UnidadMedida;
        this.producto_Estado = producto_Estado;
        this.producto_Usuario = producto_Usuario;
        this.producto_AlarmaVencimientoNumDiasAntes = producto_AlarmaVencimientoNumDiasAntes;

        //string
        this.producto_Descripcion = producto_Descripcion;
        this.producto_RegistroSanitario = producto_RegistroSanitario;
        this.producto_Observaciones = producto_Observaciones;
        this.producto_FechaCreacionString = producto_FechaCreacionString;
        this.producto_IP = producto_IP;
        this.producto_PC = producto_PC;
        this.producto_HoraCreacionString = producto_HoraCreacionString;

        this.producto_ModoDeConsumo = producto_ModoDeConsumo;

        // decimal
        this.producto_ValorUnidadDeMedida = producto_ValorUnidadDeMedida;
        this.producto_CantidadMinimaEnStock = producto_CantidadMinimaEnStock;

        //Nuevos
        this.producto_RiesgoQuimico = producto_RiesgoQuimico;
        this.producto_RiesgoQuimico2 = producto_RiesgoQuimico2;
        this.producto_PeligroParaLaSalud = producto_PeligroParaLaSalud;
        this.producto_RiesgoDeInflamabilidad = producto_RiesgoDeInflamabilidad;
        this.producto_PeligroEspecifico = producto_PeligroEspecifico;
        this.producto_RiesgoPorReactividad = producto_RiesgoPorReactividad;

        this.producto_UsuarioString = producto_UsuarioString;
        this.producto_Area = producto_Area;



    }

    public int Producto_Codigo
    {
        set { producto_Codigo = value; }
        get { return producto_Codigo; }
    }

    public int Producto_CodMarca
    {
        set { producto_CodMarca = value; }
        get { return producto_CodMarca; }
    }

    public int Producto_Presentacion
    {
        set { producto_Presentacion = value; }
        get { return producto_Presentacion; }
    }

    public int Producto_Clasificacion
    {
        set { producto_Clasificacion = value; }
        get { return producto_Clasificacion; }
    }

    public int Producto_CondicionAlmacenamiento
    {
        set { producto_CondicionAlmacenamiento = value; }
        get { return producto_CondicionAlmacenamiento; }
    }

    public int Producto_UnidadMedida
    {
        set { producto_UnidadMedida = value; }
        get { return producto_UnidadMedida; }
    }

    public int Producto_Estado
    {
        set { producto_Estado = value; }
        get { return producto_Estado; }
    }


    public int Producto_Usuario
    {
        set { producto_Usuario = value; }
        get { return producto_Usuario; }
    }

    public string Producto_Descripcion
    {
        set { producto_Descripcion = value; }
        get { return producto_Descripcion; }
    }

    public string Producto_RegistroSanitario
    {
        set { producto_RegistroSanitario = value; }
        get { return producto_RegistroSanitario; }
    }


    public string Producto_Observaciones
    {
        set { producto_Observaciones = value; }
        get { return producto_Observaciones; }
    }


    public string Producto_FechaCreacionString
    {
        set { producto_FechaCreacionString = value; }
        get { return producto_FechaCreacionString; }
    }



    public string Producto_IP
    {
        set { producto_IP = value; }
        get { return producto_IP; }
    }

    public string Producto_PC
    {
        set { producto_PC = value; }
        get { return producto_PC; }
    }

    public string Producto_HoraCreacionString
    {
        set { producto_HoraCreacionString = value; }
        get { return producto_HoraCreacionString; }
    }

    public string Producto_ModoDeConsumo
    {
        set { producto_ModoDeConsumo = value; }
        get { return producto_ModoDeConsumo; }
    }

    public decimal Producto_ValorUnidadDeMedida
    {
        set { producto_ValorUnidadDeMedida = value; }
        get { return producto_ValorUnidadDeMedida; }
    }


    public int Producto_AlarmaVencimientoNumDiasAntes
    {
        set { producto_AlarmaVencimientoNumDiasAntes = value; }
        get { return producto_AlarmaVencimientoNumDiasAntes; }
    }


    public decimal Producto_CantidadMinimaEnStock
    {
        set { producto_CantidadMinimaEnStock = value; }
        get { return producto_CantidadMinimaEnStock; }
    }


    // Nuevos


    public int Producto_RiesgoQuimico
    {
        set { producto_RiesgoQuimico = value; }
        get { return producto_RiesgoQuimico; }
    }

    public int Producto_RiesgoQuimico2
    {
        set { producto_RiesgoQuimico2 = value; }
        get { return producto_RiesgoQuimico2; }
    }

    public int Producto_PeligroParaLaSalud
    {
        set { producto_PeligroParaLaSalud = value; }
        get { return producto_PeligroParaLaSalud; }
    }

    public int Producto_RiesgoDeInflamabilidad
    {
        set { producto_RiesgoDeInflamabilidad = value; }
        get { return producto_RiesgoDeInflamabilidad; }
    }

    public int Producto_PeligroEspecifico
    {
        set { producto_PeligroEspecifico = value; }
        get { return producto_PeligroEspecifico; }
    }

    public int Producto_RiesgoPorReactividad
    {
        set { producto_RiesgoPorReactividad = value; }
        get { return producto_RiesgoPorReactividad; }
    }

    public string Producto_UsuarioString
    {
        set { producto_UsuarioString = value; }
        get { return producto_UsuarioString; }
    }


    public int Producto_Area
    {
        set { producto_Area = value; }
        get { return producto_Area; }
    }


    public bool existe(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["producto_Codigo"].ToString()) == valor)
            {
                //int
                Producto_Codigo = int.Parse(fila["producto_Codigo"].ToString());
                Producto_CodMarca = int.Parse(fila["producto_CodMarca"].ToString());
                Producto_Presentacion = int.Parse(fila["producto_Presentacion"].ToString());
                Producto_Clasificacion = int.Parse(fila["producto_Clasificacion"].ToString());
                Producto_CondicionAlmacenamiento = int.Parse(fila["producto_CondicionAlmacenamiento"].ToString());
                Producto_UnidadMedida = int.Parse(fila["producto_UnidadMedida"].ToString());
                Producto_Estado = int.Parse(fila["producto_Estado"].ToString());
                Producto_Usuario = int.Parse(fila["producto_Usuario"].ToString());
                // String
                Producto_Descripcion = fila["producto_Descripcion"].ToString();
                Producto_RegistroSanitario = fila["producto_RegistroSanitario"].ToString();
                Producto_RegistroSanitario = fila["producto_RegistroSanitario"].ToString();

                Producto_Observaciones = fila["producto_Observaciones"].ToString();
                Producto_FechaCreacionString = fila["producto_FechaCreacionString"].ToString();
                Producto_IP = fila["producto_IP"].ToString();
                Producto_PC = fila["producto_PC"].ToString();
                Producto_HoraCreacionString = fila["producto_HoraCreacionString"].ToString();
                //Prod_PerteneceAlEstudio = int.Parse(fila["prod_PerteneceAlEstudio"].ToString());
                Producto_ValorUnidadDeMedida = decimal.Parse(fila["producto_ValorUnidadDeMedida"].ToString());

                Producto_CantidadMinimaEnStock = decimal.Parse(fila["producto_CantidadMinimaEnStock"].ToString());

                Producto_ModoDeConsumo = fila["producto_ModoDeConsumo"].ToString();
                Producto_AlarmaVencimientoNumDiasAntes = int.Parse(fila["Producto_AlarmaVencimientoNumDiasAntes"].ToString());


                //Nuevos
                Producto_RiesgoQuimico = int.Parse(fila["producto_RiesgoQuimico"].ToString());
                Producto_RiesgoQuimico2 = int.Parse(fila["producto_RiesgoQuimico2"].ToString());
                Producto_PeligroParaLaSalud = int.Parse(fila["producto_PeligroParaLaSalud"].ToString());
                Producto_RiesgoDeInflamabilidad = int.Parse(fila["producto_RiesgoDeInflamabilidad"].ToString());
                Producto_PeligroEspecifico = int.Parse(fila["producto_PeligroEspecifico"].ToString());
                Producto_RiesgoPorReactividad = int.Parse(fila["Producto_RiesgoPorReactividad"].ToString());

                Producto_UsuarioString = fila["producto_UsuarioString"].ToString();
                Producto_Area = int.Parse(fila["producto_Area"].ToString());

                return true;
            }
        } return false;
    }


    public bool existePorID(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idProducto"].ToString()) == valor)
            {
                //int
                Producto_Codigo = int.Parse(fila["producto_Codigo"].ToString());
                Producto_CodMarca = int.Parse(fila["producto_CodMarca"].ToString());
                Producto_Presentacion = int.Parse(fila["producto_Presentacion"].ToString());
                Producto_Clasificacion = int.Parse(fila["producto_Clasificacion"].ToString());
                Producto_CondicionAlmacenamiento = int.Parse(fila["producto_CondicionAlmacenamiento"].ToString());
                Producto_UnidadMedida = int.Parse(fila["producto_UnidadMedida"].ToString());
                Producto_Estado = int.Parse(fila["producto_Estado"].ToString());
                Producto_Usuario = int.Parse(fila["producto_Usuario"].ToString());
                // String
                Producto_Descripcion = fila["producto_Descripcion"].ToString();
                Producto_RegistroSanitario = fila["producto_RegistroSanitario"].ToString();
                Producto_RegistroSanitario = fila["producto_RegistroSanitario"].ToString();

                Producto_Observaciones = fila["producto_Observaciones"].ToString();
                Producto_FechaCreacionString = fila["producto_FechaCreacionString"].ToString();
                Producto_IP = fila["producto_IP"].ToString();
                Producto_PC = fila["producto_PC"].ToString();
                Producto_HoraCreacionString = fila["producto_HoraCreacionString"].ToString();
                //Prod_PerteneceAlEstudio = int.Parse(fila["prod_PerteneceAlEstudio"].ToString());
                Producto_ValorUnidadDeMedida = decimal.Parse(fila["producto_ValorUnidadDeMedida"].ToString());

                Producto_CantidadMinimaEnStock = decimal.Parse(fila["producto_CantidadMinimaEnStock"].ToString());

                Producto_ModoDeConsumo = fila["producto_ModoDeConsumo"].ToString();
                Producto_AlarmaVencimientoNumDiasAntes = int.Parse(fila["Producto_AlarmaVencimientoNumDiasAntes"].ToString());


                //Nuevos
                Producto_RiesgoQuimico = int.Parse(fila["producto_RiesgoQuimico"].ToString());
                Producto_RiesgoQuimico2 = int.Parse(fila["producto_RiesgoQuimico2"].ToString());
                Producto_PeligroParaLaSalud = int.Parse(fila["producto_PeligroParaLaSalud"].ToString());
                Producto_RiesgoDeInflamabilidad = int.Parse(fila["producto_RiesgoDeInflamabilidad"].ToString());
                Producto_PeligroEspecifico = int.Parse(fila["producto_PeligroEspecifico"].ToString());
                Producto_RiesgoPorReactividad = int.Parse(fila["Producto_RiesgoPorReactividad"].ToString());

                Producto_UsuarioString = fila["producto_UsuarioString"].ToString();
                Producto_Area = int.Parse(fila["producto_Area"].ToString());

                return true;
            }
        } return false;
    }


    public bool existeConArea(int valor, int valorArea)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if ((int.Parse(fila["producto_Codigo"].ToString()) == valor) && (int.Parse(fila["producto_Area"].ToString()) == valorArea))
            {
                //int
                Producto_Codigo = int.Parse(fila["producto_Codigo"].ToString());
                Producto_CodMarca = int.Parse(fila["producto_CodMarca"].ToString());
                Producto_Presentacion = int.Parse(fila["producto_Presentacion"].ToString());
                Producto_Clasificacion = int.Parse(fila["producto_Clasificacion"].ToString());
                Producto_CondicionAlmacenamiento = int.Parse(fila["producto_CondicionAlmacenamiento"].ToString());
                Producto_UnidadMedida = int.Parse(fila["producto_UnidadMedida"].ToString());
                Producto_Estado = int.Parse(fila["producto_Estado"].ToString());
                Producto_Usuario = int.Parse(fila["producto_Usuario"].ToString());
                // String
                Producto_Descripcion = fila["producto_Descripcion"].ToString();
                Producto_RegistroSanitario = fila["producto_RegistroSanitario"].ToString();
                Producto_RegistroSanitario = fila["producto_RegistroSanitario"].ToString();

                Producto_Observaciones = fila["producto_Observaciones"].ToString();
                Producto_FechaCreacionString = fila["producto_FechaCreacionString"].ToString();
                Producto_IP = fila["producto_IP"].ToString();
                Producto_PC = fila["producto_PC"].ToString();
                Producto_HoraCreacionString = fila["producto_HoraCreacionString"].ToString();
                //Prod_PerteneceAlEstudio = int.Parse(fila["prod_PerteneceAlEstudio"].ToString());
                Producto_ValorUnidadDeMedida = decimal.Parse(fila["producto_ValorUnidadDeMedida"].ToString());

                Producto_CantidadMinimaEnStock = decimal.Parse(fila["producto_CantidadMinimaEnStock"].ToString());

                Producto_ModoDeConsumo = fila["producto_ModoDeConsumo"].ToString();
                Producto_AlarmaVencimientoNumDiasAntes = int.Parse(fila["Producto_AlarmaVencimientoNumDiasAntes"].ToString());


                //Nuevos
                Producto_RiesgoQuimico = int.Parse(fila["producto_RiesgoQuimico"].ToString());
                Producto_RiesgoQuimico2 = int.Parse(fila["producto_RiesgoQuimico2"].ToString());
                Producto_PeligroParaLaSalud = int.Parse(fila["producto_PeligroParaLaSalud"].ToString());
                Producto_RiesgoDeInflamabilidad = int.Parse(fila["producto_RiesgoDeInflamabilidad"].ToString());
                Producto_PeligroEspecifico = int.Parse(fila["producto_PeligroEspecifico"].ToString());
                Producto_RiesgoPorReactividad = int.Parse(fila["Producto_RiesgoPorReactividad"].ToString());

                Producto_UsuarioString = fila["producto_UsuarioString"].ToString();
                Producto_Area = int.Parse(fila["producto_Area"].ToString());

                return true;
            }
        } return false;
    }



    public void agregar()
    {

        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["producto_Codigo"] = int.Parse(Producto_Codigo.ToString());
        fila["producto_CodMarca"] = int.Parse(Producto_CodMarca.ToString());
        fila["producto_Presentacion"] = int.Parse(Producto_Presentacion.ToString());
        fila["producto_Clasificacion"] = int.Parse(Producto_Clasificacion.ToString());
        fila["producto_CondicionAlmacenamiento"] = int.Parse(Producto_CondicionAlmacenamiento.ToString());
        fila["producto_UnidadMedida"] = int.Parse(Producto_UnidadMedida.ToString());
        fila["producto_Estado"] = int.Parse(Producto_Estado.ToString());
        fila["producto_Usuario"] = int.Parse(Producto_Usuario.ToString());
        fila["producto_Descripcion"] = Producto_Descripcion;
        fila["producto_RegistroSanitario"] = Producto_RegistroSanitario;
        fila["producto_Observaciones"] = Producto_Observaciones;
        fila["producto_FechaCreacionString"] = Producto_FechaCreacionString;
        fila["producto_IP"] = Producto_IP;
        fila["producto_PC"] = Producto_PC;
        fila["producto_HoraCreacionString"] = Producto_HoraCreacionString;

        fila["producto_ModoDeConsumo"] = Producto_ModoDeConsumo;

        fila["producto_ValorUnidadDeMedida"] = System.Convert.ToDecimal(Producto_ValorUnidadDeMedida);

        fila["producto_AlarmaVencimientoNumDiasAntes"] = int.Parse(Producto_AlarmaVencimientoNumDiasAntes.ToString());

        fila["producto_CantidadMinimaEnStock"] = System.Convert.ToDecimal(Producto_CantidadMinimaEnStock);


        // Nuevos
        fila["producto_RiesgoQuimico"] = int.Parse(Producto_RiesgoQuimico.ToString());
        fila["producto_RiesgoQuimico2"] = int.Parse(Producto_RiesgoQuimico2.ToString());
        fila["producto_PeligroParaLaSalud"] = int.Parse(Producto_PeligroParaLaSalud.ToString());
        fila["producto_RiesgoDeInflamabilidad"] = int.Parse(Producto_RiesgoDeInflamabilidad.ToString());
        fila["producto_PeligroEspecifico"] = int.Parse(Producto_PeligroEspecifico.ToString());
        fila["producto_RiesgoPorReactividad"] = int.Parse(Producto_RiesgoPorReactividad.ToString());

        fila["producto_UsuarioString"] = Producto_UsuarioString;
        fila["producto_Area"] = int.Parse(Producto_Area.ToString());

        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }


    public bool devuelveDescripcionDelProductoEnElInventario(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["producto_Codigo"].ToString()) == valor)
            {
                Producto_Descripcion = fila["producto_Descripcion"].ToString();
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
            if (int.Parse(fila["producto_Codigo"].ToString()) == valor)
            {
                //fila["proCodigoCorto"] = ProCodigoCorto;
                fila["producto_ModoDeConsumo"] = Producto_ModoDeConsumo;
                //fila["areEstado"] = AreEstado;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }


    public bool actualizarporID(int valor, int valor2)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if ((int.Parse(fila["producto_Codigo"].ToString()) == valor) && (int.Parse(fila["producto_Area"].ToString()) == valor2))
            {
                //fila["proCodigoCorto"] = ProCodigoCorto;
                fila["producto_ModoDeConsumo"] = Producto_ModoDeConsumo;
                //fila["areEstado"] = AreEstado;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }



    public bool existePorCodigoYAreaDevuelveTipoConsumo(int valor, int valorArea)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if ((int.Parse(fila["producto_Codigo"].ToString()) == valor) && (int.Parse(fila["producto_Area"].ToString()) == valorArea))
            {

                Producto_Observaciones = fila["producto_Observaciones"].ToString();
                Producto_ModoDeConsumo = fila["producto_ModoDeConsumo"].ToString();
                return true;
            }
        } return false;
    }






}

