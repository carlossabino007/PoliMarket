using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public class clsContadores : clsconexion
{
    string tabla = "tblContadores";
    protected int conProveedores;  // Proveedores
    protected int conProductos_Reactivos;  // Reactivos para al stock del kardex
    protected int conAreasDeTrabajo;  // Areas de Trabajo en el laboratorio
    protected int conCodigoLote;  // Areas de Trabajo en el laboratorio
    protected int conMarcas;  // Marcas de productos
    protected int conClasificaciones;  // Clasificacion de los reactivos,productos
    protected int conPresentacion;  // Presentación de los productos/reactivos
    protected int conMedidas;   // Miligramos, Mililitros, etc
    protected int conGrupoAlQuePertenceElArea;  // los grupos de las tarifas de precios
    protected int conCondicionAlmacenamiento;
    protected int conFormula; // Cuando se crea la formula nueva

    protected int conCuandoCreaHeadEnElCorreo; // cada vez que se agrega uno nuevo. Head  el cual uso en el detalle.



    public clsContadores(int conProveedores, int conProductos_Reactivos, int conAreasDeTrabajo, int conCodigoLote, int conMarcas,
        int conClasificaciones, int conPresentacion, int conMedidas, int conGrupoAlQuePertenceElArea, int conCondicionAlmacenamiento, int conFormula,
        int conCuandoCreaHeadEnElCorreo)
    {
        this.conProveedores = conProveedores;
        this.conProductos_Reactivos = conProductos_Reactivos;
        this.conAreasDeTrabajo=conAreasDeTrabajo;
        this.conCodigoLote = conCodigoLote;
        this.conMarcas = conMarcas;
        this.conClasificaciones = conClasificaciones;
        this.conPresentacion = conPresentacion;
        this.conMedidas = conMedidas;
        this.conGrupoAlQuePertenceElArea=conGrupoAlQuePertenceElArea;
        this.conCondicionAlmacenamiento=conCondicionAlmacenamiento;


        this.conFormula = conFormula;
        this.conCuandoCreaHeadEnElCorreo = conCuandoCreaHeadEnElCorreo;

    }

    public int ConProveedores
    {
        set { conProveedores = value; }
        get { return conProveedores; }
    }

    public int ConProductos_Reactivos
    {
        set { conProductos_Reactivos = value; }
        get { return conProductos_Reactivos; }
    }

        public int ConAreasDeTrabajo
    {
        set { conAreasDeTrabajo = value; }
        get { return conAreasDeTrabajo; }
    }

    public int ConCodigoLote
    {
        set { conCodigoLote = value; }
        get { return conCodigoLote; }
    }


    public int ConMarcas
    {
        set { conMarcas = value; }
        get { return conMarcas; }
    }


    public int ConClasificaciones
    {
        set { conClasificaciones = value; }
        get { return conClasificaciones; }
    }


    public int ConPresentacion
    {
        set { conPresentacion = value; }
        get { return conPresentacion; }
    }


    public int ConMedidas
    {
        set { conMedidas = value; }
        get { return conMedidas; }
    }

        public int ConGrupoAlQuePertenceElArea
    {
        set { conGrupoAlQuePertenceElArea = value; }
        get { return conGrupoAlQuePertenceElArea; }
    }

        public int ConCondicionAlmacenamiento
    {
        set { conCondicionAlmacenamiento = value; }
        get { return conCondicionAlmacenamiento; }
    }


        public int ConFormula
        {
            set { conFormula = value; }
            get { return conFormula; }
        }


        public int ConCuandoCreaHeadEnElCorreo
        {
            set { conCuandoCreaHeadEnElCorreo = value; }
            get { return conCuandoCreaHeadEnElCorreo; }
        }

    


    public bool LeerContadores()
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            ConProveedores = int.Parse(fila["conProveedores"].ToString());
            ConProductos_Reactivos = int.Parse(fila["ConProductos_Reactivos"].ToString());
            ConAreasDeTrabajo = int.Parse(fila["conAreasDeTrabajo"].ToString());
            ConCodigoLote = int.Parse(fila["conCodigoLote"].ToString());
            ConMarcas = int.Parse(fila["conMarcas"].ToString());
            ConClasificaciones = int.Parse(fila["conClasificaciones"].ToString());
            ConPresentacion = int.Parse(fila["conPresentacion"].ToString());
            ConMedidas = int.Parse(fila["conMedidas"].ToString());
            ConGrupoAlQuePertenceElArea = int.Parse(fila["conGrupoAlQuePertenceElArea"].ToString());
            ConCondicionAlmacenamiento = int.Parse(fila["conCondicionAlmacenamiento"].ToString());
            ConFormula = int.Parse(fila["conFormula"].ToString());
            ConCuandoCreaHeadEnElCorreo = int.Parse(fila["conCuandoCreaHeadEnElCorreo"].ToString());
            

        }
        return true;
    }

    public bool actualizarProveedor()
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            fila["conProveedores"] = ConProveedores;
            AdaptadorDatos.Update(Data, tabla);

        } return true;
    }


    public bool actualizarFormula()
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            fila["conFormula"] = ConFormula;
            AdaptadorDatos.Update(Data, tabla);

        } return true;
    }





    public bool actualizarReactivos()
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            fila["conProductos_Reactivos"] = ConProductos_Reactivos;
            AdaptadorDatos.Update(Data, tabla);

        } return true;
    }


    public bool actualizarLotes()
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            fila["ConCodigoLote"] = ConCodigoLote;
            AdaptadorDatos.Update(Data, tabla);
        } return true;
    }


        public bool actualizarAreasDeTrabajo()
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            fila["conAreasDeTrabajo"] = ConAreasDeTrabajo;
            AdaptadorDatos.Update(Data, tabla);

        } return true;
    }


        public bool actualizarMarcas()
        {
            conectar(tabla);
            DataRow fila;
            int x = Data.Tables[tabla].Rows.Count - 1;
            for (int i = 0; i <= x; i++)
            {
                fila = Data.Tables[tabla].Rows[i];
                fila["conMarcas"] = ConMarcas;
                AdaptadorDatos.Update(Data, tabla);

            } return true;
        }


        public bool actualizarClasificaciones()
        {
            conectar(tabla);
            DataRow fila;
            int x = Data.Tables[tabla].Rows.Count - 1;
            for (int i = 0; i <= x; i++)
            {
                fila = Data.Tables[tabla].Rows[i];
                fila["conClasificaciones"] = ConClasificaciones;
                AdaptadorDatos.Update(Data, tabla);

            } return true;
        }


        public bool actualizarPresentacion()
        {
            conectar(tabla);
            DataRow fila;
            int x = Data.Tables[tabla].Rows.Count - 1;
            for (int i = 0; i <= x; i++)
            {
                fila = Data.Tables[tabla].Rows[i];
                fila["conPresentacion"] = ConPresentacion;
                AdaptadorDatos.Update(Data, tabla);

            } return true;
        }


        public bool actualizarMedidas()
        {
            conectar(tabla);
            DataRow fila;
            int x = Data.Tables[tabla].Rows.Count - 1;
            for (int i = 0; i <= x; i++)
            {
                fila = Data.Tables[tabla].Rows[i];
                fila["conMedidas"] = ConMedidas;
                AdaptadorDatos.Update(Data, tabla);

            } return true;
        }


        public bool actualizarGrupoAlQuePerteneceElArea()
        {
            conectar(tabla);
            DataRow fila;
            int x = Data.Tables[tabla].Rows.Count - 1;
            for (int i = 0; i <= x; i++)
            {
                fila = Data.Tables[tabla].Rows[i];
                fila["conGrupoAlQuePertenceElArea"] = ConGrupoAlQuePertenceElArea;
                AdaptadorDatos.Update(Data, tabla);

            } return true;
        }


        public bool actualizarconCondicionAlmacenamiento()
        {
            conectar(tabla);
            DataRow fila;
            int x = Data.Tables[tabla].Rows.Count - 1;
            for (int i = 0; i <= x; i++)
            {
                fila = Data.Tables[tabla].Rows[i];
                fila["conCondicionAlmacenamiento"] = ConCondicionAlmacenamiento; 
                AdaptadorDatos.Update(Data, tabla);

            } return true;
        }

        public bool actualizarContadorHeadCorreos()
        {
            conectar(tabla);
            DataRow fila;
            int x = Data.Tables[tabla].Rows.Count - 1;
            for (int i = 0; i <= x; i++)
            {
                fila = Data.Tables[tabla].Rows[i];
                fila["conCuandoCreaHeadEnElCorreo"] = ConCuandoCreaHeadEnElCorreo;
                AdaptadorDatos.Update(Data, tabla);

            } return true;
        }





}