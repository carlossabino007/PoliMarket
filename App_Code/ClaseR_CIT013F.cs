using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Descripción breve de ClaseR_CIT013F
/// </summary>
public class ClaseR_CIT013F : clsconexion
{
    string tabla = "tblCITO_RCIT013";

    protected string casoIPCreacion,casoResponsableCreacion,
        historiaPrevia,historiaPreviaResponsable,historiaPreviaIP,casoObservaciones,casoObservacionesIP,casoObservacionesResposable,casoRevisadoPorResponsable,casoRevisadoPorIP,
        sCultivoInmediato,sCultivoInmediatoResponsable,sCultivoInmediatoIP,
        sCultivo72Fitohemaglotuninina,sCultivo72FitohemaglotunininaResponsable,sCultivo72FitohemaglotunininaIP,
        sCultivo72Fitolaca,sCultivo72FitolacaResponsable,sCultivo72FitolacaIP,
        sCultivoMonocapa,sCultivoMonocapaResponsable,sCultivoMonocapaIP,
        sResiembra,sResiembraResponsable,sResiembraIP,
        sCartas,sCartasResponsable,sCartasIP,
        sObservaciones,sObservacionesResponsable,sObservacionesIP,
        cCultivoInmediato,cCultivoInmediatoResponsable,cCultivoInmediatoIP,
        cCultivo72Fitohemaglotuninina,cCultivo72FitohemaglotunininaResponsable,cCultivo72FitohemaglotunininaIP,
        cCultivo72Fitolaca,cCultivo72FitolacaResponsable,cCultivo72FitolacaIP,
        cCultivoMonocapa,cCultivoMonocapaResponsable,cCultivoMonocapaIP,
        cResiembra,cResiembraResponsable,cResiembraIP,
        cCartas,cCartasResponsable,cCartasResponsableIP,
        cObservaciones,cObservacionesResponsable,cObservacionesIP,
        entregadoResponsable,entregadoIP,
        entregadoAIPNombredeAquienSeLeEntrega,entregadoAResponsable,entregadoAIP,
        asignadoA,asignadoAResposable,asignadoAIP,
        recibeEnAnalisisResponsable,recibeEnAnalisisIP,
        fechaLimiteDeEntregaResponsable,fechaLimiteDeEntregaIP,
        fechaVencimientoResponsable,fechaVencimientoIP,
        confirmaRevisionResponsable,confirmaRevisionIP,
        analisisResultado,analisisResultadoResponsable,analisisResultadoIP,
        analisisObservaciones,analisisObservacionesResponsable,analisisObservacionesIP,
        primeraValidacionResponsable,primeraValidacionIP,
        segundaValidacionResponsable,segundaValidacionIP,
        copiaderespaldoResponsable,copiaderespaldoIP,verificaRespaldoResponsable,verificaRespaldoIP,
        cierraCasoResponsable,cierraCasoIP,
        reabreCasoResponsable,reabreCasoIP,
        tipoDeMuestraResponsable, tipoDeMuestraIP, fechaLimiteDeEntregaFijadaString, fechaVencimientoFijadaString,
        
        observacionesResultado, observacionesResultadoResponsable, observacionesResultadoIP,
        realizaResponsable,realizaIP,
        resultCoordDirectorTexto,resultCoordDirectorResponsable, resultCoordDirectorIP,
        casoObservaciones2, casoObservacionesIP2, casoObservacionesResposable2, sCultivoInmediato2, sCultivoInmediatoResponsable2, sCultivoInmediatoIP2, sCultivo72Fitohemaglotuninina2,
        sCultivo72FitohemaglotunininaResponsable2, sCultivo72FitohemaglotunininaIP2, sCultivo72Fitolaca2, sCultivo72FitolacaResponsable2, sCultivo72FitolacaIP2, sCultivoMonocapa2,
        sCultivoMonocapaResponsable2, sCultivoMonocapaIP2, sResiembra2, sResiembraResponsable2, sResiembraIP2, sCartas2, sCartasResponsable2, sCartasIP2, sObservaciones2,
        sObservacionesResponsable2, sObservacionesIP2, cCultivoInmediato2, cCultivoInmediatoResponsable2, cCultivoInmediatoIP2, cCultivo72Fitohemaglotuninina2,
        cCultivo72FitohemaglotunininaResponsable2, cCultivo72FitohemaglotunininaIP2, cCultivo72Fitolaca2, cCultivo72FitolacaResponsable2, cCultivo72FitolacaIP2, cCultivoMonocapa2,
        cCultivoMonocapaResponsable2, cCultivoMonocapaIP2, cResiembra2, cResiembraResponsable2, cResiembraIP2, cCartas2, cCartasResponsable2, cCartasResponsableIP2, cObservaciones2,
        cObservacionesResponsable2, cObservacionesIP2, analisisResultado2, analisisResultadoResponsable2, analisisResultadoIP2, analisisObservaciones2, analisisObservacionesResponsable2,
        analisisObservacionesIP2, observacionesResultado2, observacionesResultadoResponsable2, observacionesResultadoIP2;



    protected int idRCIT013, caso, entregado, recibeEnAnalisis, confirmaRevision, primeraValidacion, copiaderespaldo, verificaRespaldo, cierraCaso, estadoDelCaso, tipoDeMuestra, casoRevisadoPor, fechaLimiteDeEntrega, fechaVencimiento, segundaValidacion, reabreCaso, realiza;

    protected DateTime casoFechayHoraCreacion, historiaPreviaFechayHora, casoObservacionesFechayHora, sCultivo72FitohemaglotunininaFechayHora,
        sCultivo72FitolacaFechayHora, sCultivoMonocapaFechayResponsable, sResiembraFechayHora, sCartasFechayHora, sObservacionesFechayHora, cCultivoInmediatoFechayHora,
        cCultivo72FitohemaglotunininaFechayHora, cCultivo72FitolacaFechayHora, cCultivoMonocapaFechayHora, cResiembraFechayHora, cCartasResponsableFechayHora, cObservacionesFechayHora,
        entregadoFechayHora, entregadoAIPFechayHoraentregadoAIP, asignadoAFechayHora, recibeEnAnalisisFechayHora, fechaLimiteDeEntregaFechayHora, 
        fechaVencimientoFechayHora, analisisObservacionesFechayHora, analisisResultadoFechayHora, confirmaRevisionFechayHora, primeraValidacionFechayHora, segundaValidacionFechayHora,
        copiaderespaldoFechayHora, verificaRespaldoFechayHora, cierraCasoFechayHora, reabreCasoFechayHora, casoRevisadoPorFechayHora, tipoDeMuestraFechayHora, sCultivoInmediatoFechayHora,
        fechaLimiteDeEntregaFijada, fechaVencimientoFijada,observacionesResultadoFechayHora,realizaFechayHora,
        resultCoordDirectorFechayHora,
        casoObservacionesFechayHora2, sCultivoInmediatoFechayHora2, sCultivo72FitohemaglotunininaFechayHora2, sCultivo72FitolacaFechayHora2, sCultivoMonocapaFechayResponsable2,
        sResiembraFechayHora2, sCartasFechayHora2, sObservacionesFechayHora2, cCultivoInmediatoFechayHora2, cCultivo72FitohemaglotunininaFechayHora2, cCultivo72FitolacaFechayHora2,
        cCultivoMonocapaFechayHora2, cResiembraFechayHora2, cCartasResponsableFechayHora2, cObservacionesFechayHora2, analisisResultadoFechayHora2, analisisObservacionesFechayHora2,
        observacionesResultadoFechayHora2;

    





	public ClaseR_CIT013F(string casoIPCreacion,string casoResponsableCreacion,string historiaPrevia, string historiaPreviaResponsable,string historiaPreviaIP,string casoObservaciones,string casoObservacionesIP,
        string casoObservacionesResposable,int casoRevisadoPor,string casoRevisadoPorResponsable,string casoRevisadoPorIP,
        string sCultivoInmediato, string sCultivoInmediatoResponsable,string sCultivoInmediatoIP,string sCultivo72Fitohemaglotuninina,string sCultivo72FitohemaglotunininaResponsable,string sCultivo72FitohemaglotunininaIP,
        string sCultivo72Fitolaca,string sCultivo72FitolacaResponsable,string sCultivo72FitolacaIP,string sCultivoMonocapa,string sCultivoMonocapaResponsable, string sCultivoMonocapaIP,
        string sResiembra,string sResiembraResponsable,string sResiembraIP, string sCartas,string sCartasResponsable,string sCartasIP,string sObservaciones,string sObservacionesResponsable,string sObservacionesIP,
        string cCultivoInmediato,string cCultivoInmediatoResponsable,string cCultivoInmediatoIP,string cCultivo72Fitohemaglotuninina,string cCultivo72FitohemaglotunininaResponsable,string cCultivo72FitohemaglotunininaIP,
        string cCultivo72Fitolaca,string cCultivo72FitolacaResponsable,string cCultivo72FitolacaIP,string cCultivoMonocapa,string cCultivoMonocapaResponsable,string cCultivoMonocapaIP,string cResiembra, string cResiembraResponsable, string cResiembraIP,
        string cCartas,string cCartasResponsable,string cCartasResponsableIP,string cObservaciones, string cObservacionesResponsable,string cObservacionesIP, string entregadoResponsable,string entregadoIP,
        string entregadoAIPNombredeAquienSeLeEntrega,string entregadoAResponsable,string entregadoAIP,string asignadoA,string asignadoAResposable,string asignadoAIP, string  recibeEnAnalisisResponsable,string recibeEnAnalisisIP,
        string fechaLimiteDeEntregaResponsable,string fechaLimiteDeEntregaIP,string  fechaVencimientoResponsable,string fechaVencimientoIP, string confirmaRevisionResponsable,string confirmaRevisionIP,
        string analisisResultado,string analisisResultadoResponsable,string analisisResultadoIP, string analisisObservaciones,string analisisObservacionesResponsable,string analisisObservacionesIP,
        string primeraValidacionResponsable,string primeraValidacionIP, int segundaValidacion,string segundaValidacionResponsable,string segundaValidacionIP,string copiaderespaldoResponsable,string copiaderespaldoIP,string verificaRespaldoResponsable,string verificaRespaldoIP,
        string cierraCasoResponsable,string cierraCasoIP, int reabreCaso,string reabreCasoResponsable,string reabreCasoIP,
        int idRCIT013, int caso, int entregado,int recibeEnAnalisis,int confirmaRevision,int primeraValidacion,int copiaderespaldo,int verificaRespaldo,int cierraCaso,int estadoDelCaso,
        DateTime casoFechayHoraCreacion,DateTime historiaPreviaFechayHora,DateTime casoObservacionesFechayHora,DateTime sCultivo72FitohemaglotunininaFechayHora,
        DateTime sCultivo72FitolacaFechayHora,DateTime sCultivoMonocapaFechayResponsable,DateTime sResiembraFechayHora,DateTime sCartasFechayHora,DateTime sObservacionesFechayHora,DateTime cCultivoInmediatoFechayHora,
        DateTime cCultivo72FitohemaglotunininaFechayHora,DateTime cCultivo72FitolacaFechayHora,DateTime cCultivoMonocapaFechayHora,DateTime cResiembraFechayHora,DateTime cCartasResponsableFechayHora,DateTime cObservacionesFechayHora,
        DateTime entregadoFechayHora,DateTime entregadoAIPFechayHoraentregadoAIP,DateTime asignadoAFechayHora,DateTime recibeEnAnalisisFechayHora,int  fechaLimiteDeEntrega,DateTime fechaLimiteDeEntregaFechayHora, int fechaVencimiento,
        DateTime fechaVencimientoFechayHora, DateTime analisisObservacionesFechayHora, DateTime analisisResultadoFechayHora, DateTime confirmaRevisionFechayHora,DateTime primeraValidacionFechayHora,DateTime segundaValidacionFechayHora,
        DateTime copiaderespaldoFechayHora,DateTime verificaRespaldoFechayHora,DateTime cierraCasoFechayHora,DateTime reabreCasoFechayHora,   DateTime casoRevisadoPorFechayHora,int tipoDeMuestra, string tipoDeMuestraResponsable, string tipoDeMuestraIP, DateTime tipoDeMuestraFechayHora,
        DateTime sCultivoInmediatoFechayHora, string fechaLimiteDeEntregaFijadaString, string fechaVencimientoFijadaString, DateTime fechaLimiteDeEntregaFijada, DateTime fechaVencimientoFijada,
        string observacionesResultado, string observacionesResultadoResponsable, string observacionesResultadoIP, DateTime observacionesResultadoFechayHora,
        int realiza, string realizaResponsable, string realizaIP, DateTime realizaFechayHora,
        string resultCoordDirectorTexto, string resultCoordDirectorResponsable, string resultCoordDirectorIP, DateTime resultCoordDirectorFechayHora,
        
        string casoObservaciones2, string casoObservacionesIP2, string casoObservacionesResposable2, string sCultivoInmediato2, string sCultivoInmediatoResponsable2, string sCultivoInmediatoIP2, string sCultivo72Fitohemaglotuninina2,
        string sCultivo72FitohemaglotunininaResponsable2, string  sCultivo72FitohemaglotunininaIP2,string  sCultivo72Fitolaca2, string sCultivo72FitolacaResponsable2, string sCultivo72FitolacaIP2, string sCultivoMonocapa2,
        string sCultivoMonocapaResponsable2, string sCultivoMonocapaIP2, string sResiembra2, string sResiembraResponsable2, string sResiembraIP2, string sCartas2, string sCartasResponsable2, string sCartasIP2, string sObservaciones2,
        string sObservacionesResponsable2, string sObservacionesIP2, string cCultivoInmediato2, string cCultivoInmediatoResponsable2, string cCultivoInmediatoIP2, string cCultivo72Fitohemaglotuninina2,
        string cCultivo72FitohemaglotunininaResponsable2, string cCultivo72FitohemaglotunininaIP2, string cCultivo72Fitolaca2, string cCultivo72FitolacaResponsable2, string cCultivo72FitolacaIP2, string cCultivoMonocapa2,
        string cCultivoMonocapaResponsable2, string cCultivoMonocapaIP2, string cResiembra2, string cResiembraResponsable2, string cResiembraIP2, string cCartas2, string cCartasResponsable2, string cCartasResponsableIP2, string cObservaciones2,
        string cObservacionesResponsable2, string cObservacionesIP2, string analisisResultado2, string analisisResultadoResponsable2, string analisisResultadoIP2, string analisisObservaciones2, string analisisObservacionesResponsable2,
        string analisisObservacionesIP2, string observacionesResultado2, string observacionesResultadoResponsable2, string observacionesResultadoIP2,
        DateTime casoObservacionesFechayHora2, DateTime sCultivoInmediatoFechayHora2, DateTime sCultivo72FitohemaglotunininaFechayHora2, DateTime sCultivo72FitolacaFechayHora2, DateTime sCultivoMonocapaFechayResponsable2,
        DateTime sResiembraFechayHora2, DateTime sCartasFechayHora2, DateTime sObservacionesFechayHora2, DateTime cCultivoInmediatoFechayHora2, DateTime cCultivo72FitohemaglotunininaFechayHora2, DateTime cCultivo72FitolacaFechayHora2,
        DateTime cCultivoMonocapaFechayHora2, DateTime cResiembraFechayHora2, DateTime cCartasResponsableFechayHora2, DateTime cObservacionesFechayHora2, DateTime analisisResultadoFechayHora2, DateTime analisisObservacionesFechayHora2,
        DateTime observacionesResultadoFechayHora2
        )
        //54STR Y  18DATET
	{
	
        this.casoIPCreacion=casoIPCreacion;
        this.casoResponsableCreacion=casoResponsableCreacion;
        this.historiaPrevia=historiaPrevia;
        this.historiaPreviaResponsable=historiaPreviaResponsable;
        this.historiaPreviaIP=historiaPreviaIP;
        this.casoObservaciones=casoObservaciones;
        this.casoObservacionesIP=casoObservacionesIP;
        this.casoObservacionesResposable=casoObservacionesResposable;
        this.casoRevisadoPor=casoRevisadoPor;
        this.casoRevisadoPorResponsable=casoRevisadoPorResponsable;
        this.casoRevisadoPorIP=casoRevisadoPorIP;
        this.sCultivoInmediato=sCultivoInmediato;
        this.sCultivoInmediatoResponsable=sCultivoInmediatoResponsable;
        this.sCultivoInmediatoIP=sCultivoInmediatoIP;
        this.sCultivo72Fitohemaglotuninina=sCultivo72Fitohemaglotuninina;
        this.sCultivo72FitohemaglotunininaResponsable=sCultivo72FitohemaglotunininaResponsable;
        this.sCultivo72FitohemaglotunininaIP=sCultivo72FitohemaglotunininaIP;
        this.sCultivo72Fitolaca=sCultivo72Fitolaca;
        this.sCultivo72FitolacaResponsable=sCultivo72FitolacaResponsable;
        this.sCultivo72FitolacaIP=sCultivo72FitolacaIP;
        this.sCultivoMonocapa=sCultivoMonocapa;
        this.sCultivoMonocapaResponsable=sCultivoMonocapaResponsable;
        this.sCultivoMonocapaIP=sCultivoMonocapaIP;
        this.sResiembra=sResiembra;
        this.sResiembraResponsable=sResiembraResponsable;
        this.sResiembraIP=sResiembraIP;
        this.sCartas=sCartas;
        this.sCartasResponsable=sCartasResponsable;
        this.sCartasIP=sCartasIP;
        this.sObservaciones=sObservaciones;
        this.sObservacionesResponsable=sObservacionesResponsable;
        this.sObservacionesIP=sObservacionesIP;
        this.cCultivoInmediato=cCultivoInmediato;
        this.cCultivoInmediatoResponsable=cCultivoInmediatoResponsable;
        this.cCultivoInmediatoIP=cCultivoInmediatoIP;
        this.cCultivo72Fitohemaglotuninina=cCultivo72Fitohemaglotuninina;
        this.cCultivo72FitohemaglotunininaResponsable=cCultivo72FitohemaglotunininaResponsable;
        this.cCultivo72FitohemaglotunininaIP=cCultivo72FitohemaglotunininaIP;
        this.cCultivo72Fitolaca=cCultivo72Fitolaca;
        this.cCultivo72FitolacaResponsable=cCultivo72FitolacaResponsable;
        this.cCultivo72FitolacaIP=cCultivo72FitolacaIP;
        this.cCultivoMonocapa=cCultivoMonocapa;
        this.cCultivoMonocapaResponsable=cCultivoMonocapaResponsable;
        this.cCultivoMonocapaIP=cCultivoMonocapaIP;
        this.cResiembra=cResiembra;
        this.cResiembraResponsable=cResiembraResponsable;
        this.cResiembraIP=cResiembraIP;
        this.cCartas=cCartas;
        this.cCartasResponsable=cCartasResponsable;
        this.cCartasResponsableIP=cCartasResponsableIP;
        this.cObservaciones=cObservaciones;
        this.cObservacionesResponsable=cObservacionesResponsable;
        this.cObservacionesIP=cObservacionesIP;
        this.entregadoResponsable=entregadoResponsable;
        this.entregadoIP=entregadoIP;
        this.entregadoAIPNombredeAquienSeLeEntrega=entregadoAIPNombredeAquienSeLeEntrega;
        this.entregadoAResponsable=entregadoAResponsable;
        this.entregadoAIP=entregadoAIP;
        this.asignadoA=asignadoA;
        this.asignadoAResposable=asignadoAResposable;
        this.asignadoAIP=asignadoAIP;
        this.recibeEnAnalisisResponsable=recibeEnAnalisisResponsable;
        this.recibeEnAnalisisIP=recibeEnAnalisisIP;
        this.fechaLimiteDeEntregaResponsable=fechaLimiteDeEntregaResponsable;
        this.fechaLimiteDeEntregaIP=fechaLimiteDeEntregaIP;
        this.fechaVencimientoResponsable=fechaVencimientoResponsable;
        this.fechaVencimientoIP=fechaVencimientoIP;
        this.confirmaRevisionResponsable=confirmaRevisionResponsable;
        this.confirmaRevisionIP=confirmaRevisionIP;
        this.analisisResultado=analisisResultado;
        this.analisisResultadoResponsable=analisisResultadoResponsable;
        this.analisisResultadoIP=analisisResultadoIP;
        this.analisisObservaciones=analisisObservaciones;
        this.analisisObservacionesResponsable=analisisObservacionesResponsable;
        this.analisisObservacionesIP=analisisObservacionesIP;
        this.primeraValidacionResponsable=primeraValidacionResponsable;
        this.primeraValidacionIP=primeraValidacionIP;
        this.segundaValidacion=segundaValidacion;
        this.segundaValidacionResponsable=segundaValidacionResponsable;
        this.segundaValidacionIP=segundaValidacionIP;
        this.copiaderespaldoResponsable=copiaderespaldoResponsable;
        this.copiaderespaldoIP=copiaderespaldoIP;
        this.verificaRespaldoResponsable=verificaRespaldoResponsable;
        this.verificaRespaldoIP=verificaRespaldoIP;
        this.cierraCasoResponsable=cierraCasoResponsable;
        this.cierraCasoIP=cierraCasoIP;
        this.reabreCaso=reabreCaso;
        this.reabreCasoResponsable=reabreCasoResponsable;
        this.reabreCasoIP=reabreCasoIP;
        this.tipoDeMuestraResponsable=tipoDeMuestraResponsable;
        this.tipoDeMuestraIP = tipoDeMuestraIP;

        //int
        this.idRCIT013=idRCIT013;
        this.caso=caso;
        this.entregado=entregado;
        this.recibeEnAnalisis=recibeEnAnalisis;
        this.confirmaRevision=confirmaRevision;
        this.primeraValidacion=primeraValidacion;
        this.copiaderespaldo=copiaderespaldo;
        this.verificaRespaldo=verificaRespaldo;
        this.cierraCaso=cierraCaso;
        this.estadoDelCaso=estadoDelCaso;
        //DateTime
        this.casoFechayHoraCreacion=casoFechayHoraCreacion;
        this.historiaPreviaFechayHora=historiaPreviaFechayHora;
        this.casoObservacionesFechayHora=casoObservacionesFechayHora;
        this.sCultivo72FitohemaglotunininaFechayHora=sCultivo72FitohemaglotunininaFechayHora;
        this.sCultivo72FitolacaFechayHora=sCultivo72FitolacaFechayHora;
        this.sCultivoMonocapaFechayResponsable=sCultivoMonocapaFechayResponsable;
        this.sResiembraFechayHora=sResiembraFechayHora;
        this.sCartasFechayHora=sCartasFechayHora;
        this.sObservacionesFechayHora=sObservacionesFechayHora;
        this.cCultivoInmediatoFechayHora=cCultivoInmediatoFechayHora;
        this.cCultivo72FitohemaglotunininaFechayHora=cCultivo72FitohemaglotunininaFechayHora;
        this.cCultivo72FitolacaFechayHora=cCultivo72FitolacaFechayHora;
        this.cCultivoMonocapaFechayHora=cCultivoMonocapaFechayHora;
        this.cResiembraFechayHora=cResiembraFechayHora;
        this.cCartasResponsableFechayHora=cCartasResponsableFechayHora;
        this.cObservacionesFechayHora=cObservacionesFechayHora;
        this.entregadoFechayHora=entregadoFechayHora;
        this.entregadoAIPFechayHoraentregadoAIP=entregadoAIPFechayHoraentregadoAIP;
        this.asignadoAFechayHora=asignadoAFechayHora;
        this.recibeEnAnalisisFechayHora=recibeEnAnalisisFechayHora;
        this.fechaLimiteDeEntrega=fechaLimiteDeEntrega;
        this.fechaLimiteDeEntregaFechayHora=fechaLimiteDeEntregaFechayHora;
        this.fechaVencimiento=fechaVencimiento;
        this.fechaVencimientoFechayHora=fechaVencimientoFechayHora;
        this.analisisObservacionesFechayHora=analisisObservacionesFechayHora;
        this.analisisResultadoFechayHora=analisisResultadoFechayHora;
        this.confirmaRevisionFechayHora=confirmaRevisionFechayHora;
        this.primeraValidacionFechayHora=primeraValidacionFechayHora;
        this.segundaValidacionFechayHora=segundaValidacionFechayHora;
        this.copiaderespaldoFechayHora=copiaderespaldoFechayHora;
        this.verificaRespaldoFechayHora=verificaRespaldoFechayHora;
        this.cierraCasoFechayHora=cierraCasoFechayHora;
        this.reabreCasoFechayHora=reabreCasoFechayHora;
        this.tipoDeMuestraFechayHora = tipoDeMuestraFechayHora;
        this.sCultivoInmediatoFechayHora = sCultivoInmediatoFechayHora;

        this.fechaLimiteDeEntregaFijadaString = fechaLimiteDeEntregaFijadaString;
        this.fechaVencimientoFijadaString = fechaVencimientoFijadaString;

        this.fechaLimiteDeEntregaFijada = fechaLimiteDeEntregaFijada;
        this.fechaVencimientoFijada=fechaVencimientoFijada;

        this.observacionesResultado=observacionesResultado;
        this.observacionesResultadoResponsable=observacionesResultadoResponsable;
        this.observacionesResultadoIP=observacionesResultadoIP;
        this.observacionesResultadoFechayHora = observacionesResultadoFechayHora;

        this.realiza=realiza;
        this.realizaResponsable=realizaResponsable;
        this.realizaIP=realizaIP;
        this.realizaFechayHora = realizaFechayHora;


        this.resultCoordDirectorTexto=resultCoordDirectorTexto;
        this.resultCoordDirectorResponsable=resultCoordDirectorResponsable;
        this.resultCoordDirectorIP=resultCoordDirectorIP;
        this.resultCoordDirectorFechayHora = resultCoordDirectorFechayHora;


this.casoObservaciones2=casoObservaciones2;
this.casoObservacionesIP2=casoObservacionesIP2;
this.casoObservacionesResposable2=casoObservacionesResposable2;
this.sCultivoInmediato2=sCultivoInmediato2;
this.sCultivoInmediatoResponsable2=sCultivoInmediatoResponsable2;
this.sCultivoInmediatoIP2=sCultivoInmediatoIP2;
this.sCultivo72Fitohemaglotuninina2=sCultivo72Fitohemaglotuninina2;
this.sCultivo72FitohemaglotunininaResponsable2=sCultivo72FitohemaglotunininaResponsable2;
this.sCultivo72FitohemaglotunininaIP2=sCultivo72FitohemaglotunininaIP2;
this.sCultivo72Fitolaca2=sCultivo72Fitolaca2;
this.sCultivo72FitolacaResponsable2=sCultivo72FitolacaResponsable2;
this.sCultivo72FitolacaIP2=sCultivo72FitolacaIP2;
this.sCultivoMonocapa2=sCultivoMonocapa2;
this.sCultivoMonocapaResponsable2=sCultivoMonocapaResponsable2;
this.sCultivoMonocapaIP2=sCultivoMonocapaIP2;
this.sResiembra2=sResiembra2;
this.sResiembraResponsable2=sResiembraResponsable2;
this.sResiembraIP2=sResiembraIP2;
this.sCartas2=sCartas2;
this.sCartasResponsable2=sCartasResponsable2;
this.sCartasIP2=sCartasIP2;
this.sObservaciones2=sObservaciones2;
this.sObservacionesResponsable2=sObservacionesResponsable2;
this.sObservacionesIP2=sObservacionesIP2;
this.cCultivoInmediato2=cCultivoInmediato2;
this.cCultivoInmediatoResponsable2=cCultivoInmediatoResponsable2;
this.cCultivoInmediatoIP2=cCultivoInmediatoIP2;
this.cCultivo72Fitohemaglotuninina2=cCultivo72Fitohemaglotuninina2;
this.cCultivo72FitohemaglotunininaResponsable2=cCultivo72FitohemaglotunininaResponsable2;
this.cCultivo72FitohemaglotunininaIP2=cCultivo72FitohemaglotunininaIP2;
this.cCultivo72Fitolaca2=cCultivo72Fitolaca2;
this.cCultivo72FitolacaResponsable2=cCultivo72FitolacaResponsable2;
this.cCultivo72FitolacaIP2=cCultivo72FitolacaIP2;
this.cCultivoMonocapa2=cCultivoMonocapa2;
this.cCultivoMonocapaResponsable2=cCultivoMonocapaResponsable2;
this.cCultivoMonocapaIP2=cCultivoMonocapaIP2;
this.cResiembra2=cResiembra2;
this.cResiembraResponsable2=cResiembraResponsable2;
this.cResiembraIP2=cResiembraIP2;
this.cCartas2=cCartas2;
this.cCartasResponsable2=cCartasResponsable2;
this.cCartasResponsableIP2=cCartasResponsableIP2;
this.cObservaciones2=cObservaciones2;
this.cObservacionesResponsable2=cObservacionesResponsable2;
this.cObservacionesIP2=cObservacionesIP2;
this.analisisResultado2=analisisResultado2;
this.analisisResultadoResponsable2=analisisResultadoResponsable2;
this.analisisResultadoIP2=analisisResultadoIP2;
this.analisisObservaciones2=analisisObservaciones2;
this.analisisObservacionesResponsable2=analisisObservacionesResponsable2;
this.analisisObservacionesIP2=analisisObservacionesIP2;
this.observacionesResultado2=observacionesResultado2;
this.observacionesResultadoResponsable2=observacionesResultadoResponsable2;
this.observacionesResultadoIP2=observacionesResultadoIP2;


//
this.casoObservacionesFechayHora2=casoObservacionesFechayHora2;
this.sCultivoInmediatoFechayHora2=sCultivoInmediatoFechayHora2;
this.sCultivo72FitohemaglotunininaFechayHora2=sCultivo72FitohemaglotunininaFechayHora2;
this.sCultivo72FitolacaFechayHora2=sCultivo72FitolacaFechayHora2;
this.sCultivoMonocapaFechayResponsable2=sCultivoMonocapaFechayResponsable2;
this.sResiembraFechayHora2=sResiembraFechayHora2;
this.sCartasFechayHora2=sCartasFechayHora2;
this.sObservacionesFechayHora2=sObservacionesFechayHora2;
this.cCultivoInmediatoFechayHora2=cCultivoInmediatoFechayHora2;
this.cCultivo72FitohemaglotunininaFechayHora2=cCultivo72FitohemaglotunininaFechayHora2;
this.cCultivo72FitolacaFechayHora2=cCultivo72FitolacaFechayHora2;
this.cCultivoMonocapaFechayHora2=cCultivoMonocapaFechayHora2;
this.cResiembraFechayHora2=cResiembraFechayHora2;
this.cCartasResponsableFechayHora2=cCartasResponsableFechayHora2;
this.cObservacionesFechayHora2=cObservacionesFechayHora2;
this.analisisResultadoFechayHora2=analisisResultadoFechayHora2;
this.analisisObservacionesFechayHora2=analisisObservacionesFechayHora2;
this.observacionesResultadoFechayHora2 = observacionesResultadoFechayHora2;





	}



    public string CasoIPCreacion   { set { casoIPCreacion = value; }  get { return casoIPCreacion ; } }
    public string CasoResponsableCreacion  { set { casoResponsableCreacion = value; } get { return casoResponsableCreacion ; }}
    public string HistoriaPrevia { set { historiaPrevia = value; } get { return historiaPrevia ; } }
    public string HistoriaPreviaResponsable { set { historiaPreviaResponsable = value; } get { return historiaPreviaResponsable ; }}
    public string HistoriaPreviaIP {set { historiaPreviaIP = value; }get { return historiaPreviaIP ; }}
    public string CasoObservaciones { set { casoObservaciones = value; } get { return casoObservaciones ; }}
    public string CasoObservacionesIP  {set { casoObservacionesIP = value; } get { return casoObservacionesIP ; } }
    public string CasoObservacionesResposable {set { casoObservacionesResposable = value; } get { return casoObservacionesResposable ; } }
    public int    CasoRevisadoPor { set { casoRevisadoPor = value; } get { return casoRevisadoPor ; }}
    public string CasoRevisadoPorResponsable {set { casoRevisadoPorResponsable = value; } get { return casoRevisadoPorResponsable ; } }
    public string CasoRevisadoPorIP {set { casoRevisadoPorIP = value; } get { return casoRevisadoPorIP ; }}
    public string SCultivoInmediato { set { sCultivoInmediato = value; }get { return sCultivoInmediato ; }}
    public string SCultivoInmediatoResponsable{ set { sCultivoInmediatoResponsable = value; }  get { return sCultivoInmediatoResponsable ; }}
    public string SCultivoInmediatoIP{ set { sCultivoInmediatoIP = value; }get { return sCultivoInmediatoIP ; }}
    public string SCultivo72Fitohemaglotuninina { set { sCultivo72Fitohemaglotuninina = value; }get { return sCultivo72Fitohemaglotuninina ; }}
    public string SCultivo72FitohemaglotunininaResponsable{ set { sCultivo72FitohemaglotunininaResponsable = value; } get { return sCultivo72FitohemaglotunininaResponsable ; }}
    public string SCultivo72FitohemaglotunininaIP {set { sCultivo72FitohemaglotunininaIP = value; }get { return sCultivo72FitohemaglotunininaIP ; } }
    public string SCultivo72Fitolaca{ set { sCultivo72Fitolaca = value; } get { return sCultivo72Fitolaca ; }}
    public string SCultivo72FitolacaResponsable{set { sCultivo72FitolacaResponsable = value; } get { return sCultivo72FitolacaResponsable ; }}
    public string SCultivo72FitolacaIP{set { sCultivo72FitolacaIP = value; }get { return sCultivo72FitolacaIP ; } }
    public string SCultivoMonocapa{set { sCultivoMonocapa = value; } get { return sCultivoMonocapa ; } }
    public string SCultivoMonocapaResponsable{ set { sCultivoMonocapaResponsable = value; }get { return sCultivoMonocapaResponsable ; }}
    public string SCultivoMonocapaIP{set { sCultivoMonocapaIP = value; } get { return sCultivoMonocapaIP ; }}
    public string SResiembra { set { sResiembra = value; } get { return sResiembra ; } }
    public string SResiembraResponsable{set { sResiembraResponsable = value; } get { return sResiembraResponsable; }}
    public string SResiembraIP { set { sResiembraIP = value; } get { return sResiembraIP; }}
    public string SCartas {set { sCartas = value; } get { return sCartas; }}
    public string SCartasResponsable {set { sCartasResponsable = value; }get { return sCartasResponsable; }}
    public string SCartasIP {set { sCartasIP = value; }get { return sCartasIP; } }
    public string SObservaciones {set { sObservaciones = value; } get { return sObservaciones; } }
    public string SObservacionesResponsable { set { sObservacionesResponsable = value; }   get { return sObservacionesResponsable; } }
    public string SObservacionesIP{set { sObservacionesIP = value; } get { return sObservacionesIP; }}
    public string CCultivoInmediato{ set { cCultivoInmediato = value; } get { return cCultivoInmediato; }}
    public string CCultivoInmediatoResponsable{ set { cCultivoInmediatoResponsable = value; } get { return cCultivoInmediatoResponsable; }}
    public string CCultivoInmediatoIP {set { cCultivoInmediatoIP = value; } get { return cCultivoInmediatoIP; }}
    public string CCultivo72Fitohemaglotuninina{set { cCultivo72Fitohemaglotuninina = value; } get { return cCultivo72Fitohemaglotuninina; }}
    public string CCultivo72FitohemaglotunininaResponsable { set { cCultivo72FitohemaglotunininaResponsable = value; } get { return cCultivo72FitohemaglotunininaResponsable; }}
    public string CCultivo72FitohemaglotunininaIP { set { cCultivo72FitohemaglotunininaIP = value; } get { return cCultivo72FitohemaglotunininaIP; } }
    public string CCultivo72Fitolaca {set { cCultivo72Fitolaca = value; } get { return cCultivo72Fitolaca; } }
    public string CCultivo72FitolacaResponsable{ set { cCultivo72FitolacaResponsable = value; } get { return cCultivo72FitolacaResponsable; } }
    public string CCultivo72FitolacaIP { set { cCultivo72FitolacaIP = value; } get { return cCultivo72FitolacaIP; } }
    public string CCultivoMonocapa{set { cCultivoMonocapa = value; } get { return cCultivoMonocapa; } }
    public string CCultivoMonocapaResponsable { set { cCultivoMonocapaResponsable = value; } get { return cCultivoMonocapaResponsable; } }
    public string CCultivoMonocapaIP {set { cCultivoMonocapaIP = value; }  get { return cCultivoMonocapaIP; }}
    public string CResiembra {set { cResiembra = value; } get { return cResiembra; } }
    public string CResiembraResponsable {set { cResiembraResponsable = value; }get { return cResiembraResponsable; } }
    public string CResiembraIP { set { cResiembraIP = value; }get { return cResiembraIP; } }
    public string CCartas {set { cCartas = value; } get { return cCartas; }}          
    public string CCartasResponsable  { set { cCartasResponsable = value; } get { return cCartasResponsable; }}          
    public string CCartasResponsableIP{set { cCartasResponsableIP = value; } get { return cCartasResponsableIP; } }          
    public string CObservaciones { set { cObservaciones = value; } get { return cObservaciones; }}          
    public string CObservacionesResponsable { set { cObservacionesResponsable = value; }  get { return cObservacionesResponsable; } }          
    public string CObservacionesIP{ set { cObservacionesIP = value; }get { return cObservacionesIP; }}          
    public string EntregadoResponsable { set { entregadoResponsable = value; }get { return entregadoResponsable; }}          
    public string EntregadoIP{ set { entregadoIP = value; } get { return entregadoIP; }}          
    public string EntregadoAIPNombredeAquienSeLeEntrega  { set { entregadoAIPNombredeAquienSeLeEntrega = value; } get { return entregadoAIPNombredeAquienSeLeEntrega; } }          
    public string EntregadoAResponsable { set { entregadoAResponsable = value; } get { return entregadoAResponsable; }}          
    public string EntregadoAIP { set { entregadoAIP = value; }get { return entregadoAIP; }}          
    public string AsignadoA{set { asignadoA = value; } get { return asignadoA; }}          
    public string AsignadoAResposable { set { asignadoAResposable = value; } get { return asignadoAResposable; } }          
    public string AsignadoAIP  {  set { asignadoAIP = value; } get { return asignadoAIP; } }          
    public string RecibeEnAnalisisResponsable {  set { recibeEnAnalisisResponsable = value; } get { return recibeEnAnalisisResponsable; } }          
    public string RecibeEnAnalisisIP {set { recibeEnAnalisisIP = value; } get { return recibeEnAnalisisIP; } }          
    public string FechaLimiteDeEntregaResponsable{set { fechaLimiteDeEntregaResponsable = value; } get { return fechaLimiteDeEntregaResponsable; } }          
    public string FechaLimiteDeEntregaIP { set { fechaLimiteDeEntregaIP = value; }  get { return fechaLimiteDeEntregaIP; } }          
    public string FechaVencimientoResponsable { set { fechaVencimientoResponsable = value; } get { return fechaVencimientoResponsable; }}          
    public string FechaVencimientoIP { set { fechaVencimientoIP = value; } get { return fechaVencimientoIP; }}          
    public string ConfirmaRevisionResponsable{set { confirmaRevisionResponsable = value; } get { return confirmaRevisionResponsable; }}          
    public string ConfirmaRevisionIP {  set { confirmaRevisionIP = value; } get { return confirmaRevisionIP; } }          
    public string AnalisisResultado {set { analisisResultado = value; }get { return analisisResultado; }}          
    public string AnalisisResultadoResponsable {set { analisisResultadoResponsable = value; }get { return analisisResultadoResponsable; }}          
    public string AnalisisResultadoIP {set { analisisResultadoIP = value; }get { return analisisResultadoIP; }}          
    public string AnalisisObservaciones {set { analisisObservaciones = value; }get { return analisisObservaciones; }}          
    public string AnalisisObservacionesResponsable {set { analisisObservacionesResponsable = value; }get { return analisisObservacionesResponsable; }}          
    public string AnalisisObservacionesIP {set { analisisObservacionesIP = value; }get { return analisisObservacionesIP; }}          
    public string PrimeraValidacionResponsable {set { primeraValidacionResponsable = value; }get { return primeraValidacionResponsable; }}
    public string PrimeraValidacionIP { set { primeraValidacionIP = value; } get { return primeraValidacionIP; } }          
    public int    SegundaValidacion {set { segundaValidacion = value; }get { return segundaValidacion; }}          
    public string SegundaValidacionResponsable {set { segundaValidacionResponsable = value; }get { return segundaValidacionResponsable; }}          
    public string SegundaValidacionIP {set { segundaValidacionIP = value; }get { return segundaValidacionIP; }}          
    public string CopiaderespaldoResponsable {set { copiaderespaldoResponsable = value; }get { return copiaderespaldoResponsable; }}          
    public string CopiaderespaldoIP {set { copiaderespaldoIP = value; }get { return copiaderespaldoIP; }}          
    public string VerificaRespaldoResponsable {set { verificaRespaldoResponsable = value; }get { return verificaRespaldoResponsable; }}          
    public string VerificaRespaldoIP {set { verificaRespaldoIP = value; }get { return verificaRespaldoIP; }}          
    public string CierraCasoResponsable {set {  cierraCasoResponsable = value; }get { return cierraCasoResponsable; }}          
    public string CierraCasoIP {set {  cierraCasoIP = value; }get { return cierraCasoIP; }}          
    public int    ReabreCaso {set {  reabreCaso = value; }get { return reabreCaso; }}          
    public string ReabreCasoResponsable {set {  reabreCasoResponsable = value; }get { return reabreCasoResponsable; }}          
    public string ReabreCasoIP {set {  reabreCasoIP = value; }get { return reabreCasoIP; }}          
    public string TipoDeMuestraResponsable {set {  tipoDeMuestraResponsable = value; }get { return tipoDeMuestraResponsable; }}          
    public string TipoDeMuestraIP {set {  tipoDeMuestraIP = value; }get { return tipoDeMuestraIP; }}          


    //Int
    public int IdRCIT013 {set {  idRCIT013 = value; }get { return idRCIT013; }}          
    public int Caso {set {  caso = value; }get { return caso; }}          
    public int Entregado {set {  entregado = value; }get { return entregado; }}          
    public int RecibeEnAnalisis {set {  recibeEnAnalisis = value; }get { return recibeEnAnalisis; }}          
    public int ConfirmaRevision {set {  confirmaRevision = value; }get { return confirmaRevision; }}          
    public int PrimeraValidacion {set {  primeraValidacion = value; }get { return primeraValidacion; }}          
    public int Copiaderespaldo {set {  copiaderespaldo = value; }get { return copiaderespaldo; }}          
    public int VerificaRespaldo {set {  verificaRespaldo = value; }get { return verificaRespaldo; }}          
    public int CierraCaso {set {  cierraCaso = value; }get { return cierraCaso; }}          
    public int EstadoDelCaso {set {  estadoDelCaso = value; }get { return estadoDelCaso; }}
    public int TipoDeMuestra { set { tipoDeMuestra = value; } get { return tipoDeMuestra; } }          
    
    //DateTime    
    public DateTime  CasoFechayHoraCreacion {set {  casoFechayHoraCreacion = value; }get { return casoFechayHoraCreacion; }}          
    public DateTime  HistoriaPreviaFechayHora {set {  historiaPreviaFechayHora = value; }get { return historiaPreviaFechayHora; }}          
    public DateTime  CasoObservacionesFechayHora {set {  casoObservacionesFechayHora = value; }get { return casoObservacionesFechayHora; }}          
    public DateTime  SCultivo72FitohemaglotunininaFechayHora {set {  sCultivo72FitohemaglotunininaFechayHora = value; }get { return sCultivo72FitohemaglotunininaFechayHora; }}          
    public DateTime  SCultivo72FitolacaFechayHora {set {  sCultivo72FitolacaFechayHora = value; }get { return sCultivo72FitolacaFechayHora; }}          
    public DateTime  SCultivoMonocapaFechayResponsable {set {  sCultivoMonocapaFechayResponsable = value; }get { return sCultivoMonocapaFechayResponsable; }}          
    public DateTime  SResiembraFechayHora {set {  sResiembraFechayHora = value; }get { return sResiembraFechayHora; }}          
    public DateTime  SCartasFechayHora {set {  sCartasFechayHora = value; }get { return sCartasFechayHora; }}          
    public DateTime  SObservacionesFechayHora {set {  sObservacionesFechayHora = value; }get { return sObservacionesFechayHora; }}          
    public DateTime  CCultivoInmediatoFechayHora {set {  cCultivoInmediatoFechayHora = value; }get { return cCultivoInmediatoFechayHora; }}          
    public DateTime  CCultivo72FitohemaglotunininaFechayHora {set {  cCultivo72FitohemaglotunininaFechayHora = value; }get { return cCultivo72FitohemaglotunininaFechayHora; }}          
    public DateTime  CCultivo72FitolacaFechayHora {set {  cCultivo72FitolacaFechayHora = value; }get { return cCultivo72FitolacaFechayHora; }}          
    public DateTime  CCultivoMonocapaFechayHora {set {  cCultivoMonocapaFechayHora = value; }get { return cCultivoMonocapaFechayHora; }}          
    public DateTime  CResiembraFechayHora {set {  cResiembraFechayHora = value; }get { return cResiembraFechayHora; }}          
    public DateTime  CCartasResponsableFechayHora {set {  cCartasResponsableFechayHora = value; }get { return cCartasResponsableFechayHora; }}          
    public DateTime  CObservacionesFechayHora {set {  cObservacionesFechayHora = value; }get { return cObservacionesFechayHora; }}          
    public DateTime  EntregadoFechayHora {set {  entregadoFechayHora = value; }get { return entregadoFechayHora; }}          
    public DateTime  EntregadoAIPFechayHoraentregadoAIP {set {  entregadoAIPFechayHoraentregadoAIP = value; }get { return entregadoAIPFechayHoraentregadoAIP; }}          
    public DateTime  AsignadoAFechayHora {set {  asignadoAFechayHora = value; }get { return asignadoAFechayHora; }}          
    public DateTime  RecibeEnAnalisisFechayHora {set {  recibeEnAnalisisFechayHora = value; }get { return recibeEnAnalisisFechayHora; }}          
    public int       FechaLimiteDeEntrega {set {  fechaLimiteDeEntrega = value; }get { return fechaLimiteDeEntrega; }}          
    public DateTime  FechaLimiteDeEntregaFechayHora {set {  fechaLimiteDeEntregaFechayHora = value; }get { return fechaLimiteDeEntregaFechayHora; }}          
    public int       FechaVencimiento {set {  fechaVencimiento = value; }get { return fechaVencimiento; }}          
    public DateTime  FechaVencimientoFechayHora {set {  fechaVencimientoFechayHora = value; }get { return fechaVencimientoFechayHora; }}          
    public DateTime  AnalisisObservacionesFechayHora {set {  analisisObservacionesFechayHora = value; }get { return analisisObservacionesFechayHora; }}          
    public DateTime  AnalisisResultadoFechayHora {set {  analisisResultadoFechayHora = value; }get { return analisisResultadoFechayHora; }}          
    public DateTime  ConfirmaRevisionFechayHora {set {  confirmaRevisionFechayHora = value; }get { return confirmaRevisionFechayHora; }}          
    public DateTime  PrimeraValidacionFechayHora {set {  primeraValidacionFechayHora = value; }get { return primeraValidacionFechayHora; }}          
    public DateTime  SegundaValidacionFechayHora {set {  segundaValidacionFechayHora = value; }get { return segundaValidacionFechayHora; }}          
    public DateTime  CopiaderespaldoFechayHora {set {  copiaderespaldoFechayHora = value; }get { return copiaderespaldoFechayHora; }}          
    public DateTime  VerificaRespaldoFechayHora {set {  verificaRespaldoFechayHora = value; }get { return verificaRespaldoFechayHora; }}          
    public DateTime  CierraCasoFechayHora {set {  cierraCasoFechayHora = value; }get { return cierraCasoFechayHora; }}          
    public DateTime  ReabreCasoFechayHora {set {  reabreCasoFechayHora = value; }get { return reabreCasoFechayHora; }}
    public DateTime  CasoRevisadoPorFechayHora { set { casoRevisadoPorFechayHora = value; } get { return casoRevisadoPorFechayHora; } }
    public DateTime  TipoDeMuestraFechayHora { set { tipoDeMuestraFechayHora = value; } get { return tipoDeMuestraFechayHora; } }
    public DateTime  SCultivoInmediatoFechayHora { set { sCultivoInmediatoFechayHora = value; } get { return sCultivoInmediatoFechayHora; } }

    public string FechaLimiteDeEntregaFijadaString { set { fechaLimiteDeEntregaFijadaString = value; } get { return fechaLimiteDeEntregaFijadaString; } }
    public string FechaVencimientoFijadaString { set { fechaVencimientoFijadaString = value; } get { return fechaVencimientoFijadaString; } }

    public DateTime FechaLimiteDeEntregaFijada { set { fechaLimiteDeEntregaFijada = value; } get { return fechaLimiteDeEntregaFijada; } }
    public DateTime FechaVencimientoFijada { set { fechaVencimientoFijada = value; } get { return fechaVencimientoFijada; } }

    public string ObservacionesResultado { set { observacionesResultado = value; } get { return observacionesResultado; } }
    public string ObservacionesResultadoResponsable { set { observacionesResultadoResponsable = value; } get { return observacionesResultadoResponsable; } }
    public string ObservacionesResultadoIP { set { observacionesResultadoIP = value; } get { return observacionesResultadoIP; } }

    public DateTime ObservacionesResultadoFechayHora { set { observacionesResultadoFechayHora = value; } get { return observacionesResultadoFechayHora; } }


    public int Realiza {set {  realiza = value; }get { return realiza; }}          
    public string RealizaResponsable {set {  realizaResponsable = value; }get { return realizaResponsable; }}          
    public string RealizaIP {set {  realizaIP = value; }get { return realizaIP; }}          
    public DateTime RealizaFechayHora {set {  realizaFechayHora = value; }get { return realizaFechayHora; }}    


    public string ResultCoordDirectorTexto {set {  resultCoordDirectorTexto = value; }get { return resultCoordDirectorTexto; }}          
    public string ResultCoordDirectorResponsable {set {  resultCoordDirectorResponsable = value; }get { return resultCoordDirectorResponsable; }}          
    public string ResultCoordDirectorIP {set {  resultCoordDirectorIP = value; }get { return resultCoordDirectorIP; }}          
    public DateTime ResultCoordDirectorFechayHora {set {  resultCoordDirectorFechayHora = value; }get { return resultCoordDirectorFechayHora; }}



    public string  CasoObservaciones2 { set { casoObservaciones2 = value; } get { return casoObservaciones2; } }
    public string  CasoObservacionesIP2 { set {  casoObservacionesIP2= value; } get { return casoObservacionesIP2; } }
    public string  CasoObservacionesResposable2 { set { casoObservacionesResposable2 = value; } get { return casoObservacionesResposable2; } }
    public string  SCultivoInmediato2 { set {  sCultivoInmediato2= value; } get { return sCultivoInmediato2; } }
    public string  SCultivoInmediatoResponsable2 { set {  sCultivoInmediatoResponsable2= value; } get { return sCultivoInmediatoResponsable2; } }
    public string  SCultivoInmediatoIP2{ set {sCultivoInmediatoIP2  = value; } get { return sCultivoInmediatoIP2; } }
    public string  SCultivo72Fitohemaglotuninina2 { set {  sCultivo72Fitohemaglotuninina2= value; } get { return sCultivo72Fitohemaglotuninina2; } }
    public string  SCultivo72FitohemaglotunininaResponsable2{ set {  sCultivo72FitohemaglotunininaResponsable2= value; } get { return sCultivo72FitohemaglotunininaResponsable2; } }
    public string  SCultivo72FitohemaglotunininaIP2{ set { sCultivo72FitohemaglotunininaIP2 = value; } get { return sCultivo72FitohemaglotunininaIP2; } }
    public string  SCultivo72Fitolaca2{ set {  sCultivo72Fitolaca2= value; } get { return sCultivo72Fitolaca2; } }
    public string  SCultivo72FitolacaResponsable2{ set {  sCultivo72FitolacaResponsable2= value; } get { return sCultivo72FitolacaResponsable2; } }
    public string  SCultivo72FitolacaIP2{ set {  sCultivo72FitolacaIP2= value; } get { return sCultivo72FitolacaIP2; } }
    public string  SCultivoMonocapa2{ set {  sCultivoMonocapa2= value; } get { return sCultivoMonocapa2; } }
    public string  SCultivoMonocapaResponsable2{ set {  sCultivoMonocapaResponsable2= value; } get { return sCultivoMonocapaResponsable2; } }
    public string  SCultivoMonocapaIP2{ set {  sCultivoMonocapaIP2= value; } get { return sCultivoMonocapaIP2; } }
    public string  SResiembra2{ set {  sResiembra2= value; } get { return sResiembra2; } }
    public string  SResiembraResponsable2{ set {  sResiembraResponsable2= value; } get { return sResiembraResponsable2; } }
    public string  SResiembraIP2{ set {  sResiembraIP2= value; } get { return sResiembraIP2; } }
    public string  SCartas2{ set {  sCartas2= value; } get { return sCartas2; } }
    public string  SCartasResponsable2{ set {  sCartasResponsable2= value; } get { return sCartasResponsable2; } }
    public string  SCartasIP2{ set {  sCartasIP2= value; } get { return sCartasIP2; } }
    public string  SObservaciones2{ set {  sObservaciones2= value; } get { return sObservaciones2; } }
    public string  SObservacionesResponsable2{ set {  sObservacionesResponsable2= value; } get { return sObservacionesResponsable2; } }
    public string  SObservacionesIP2{ set {  sObservacionesIP2= value; } get { return sObservacionesIP2; } }
    public string  CCultivoInmediato2{ set {  cCultivoInmediato2= value; } get { return cCultivoInmediato2; } }
    public string  CCultivoInmediatoResponsable2{ set {  cCultivoInmediatoResponsable2= value; } get { return cCultivoInmediatoResponsable2; } }
    public string  CCultivoInmediatoIP2{ set {  cCultivoInmediatoIP2= value; } get { return cCultivoInmediatoIP2; } }
    public string  CCultivo72Fitohemaglotuninina2{ set {  cCultivo72Fitohemaglotuninina2= value; } get { return cCultivo72Fitohemaglotuninina2; } }
    public string  CCultivo72FitohemaglotunininaResponsable2{ set {  cCultivo72FitohemaglotunininaResponsable2= value; } get { return cCultivo72FitohemaglotunininaResponsable2; } }
    public string  CCultivo72FitohemaglotunininaIP2 { set { cCultivo72FitohemaglotunininaIP2 = value; } get { return cCultivo72FitohemaglotunininaIP2; } }
    public string  CCultivo72Fitolaca2 { set { cCultivo72Fitolaca2 = value; } get { return cCultivo72Fitolaca2; } }
    public string  CCultivo72FitolacaResponsable2   { set {  cCultivo72FitolacaResponsable2  = value; } get { return cCultivo72FitolacaResponsable2; } }
    public string  CCultivo72FitolacaIP2   { set {    cCultivo72FitolacaIP2= value; } get { return cCultivo72FitolacaIP2; } }
    public string  CCultivoMonocapa2   { set {    cCultivoMonocapa2= value; } get { return cCultivoMonocapa2; } }
    public string  CCultivoMonocapaResponsable2   { set {    cCultivoMonocapaResponsable2= value; } get { return cCultivoMonocapaResponsable2; } }
    public string  CCultivoMonocapaIP2   { set {    cCultivoMonocapaIP2= value; } get { return cCultivoMonocapaIP2; } }
    public string  CResiembra2   { set {    cResiembra2= value; } get { return cResiembra2; } }
    public string  CResiembraResponsable2   { set {    cResiembraResponsable2= value; } get { return cResiembraResponsable2; } }
    public string  CResiembraIP2   { set {    cResiembraIP2= value; } get { return cResiembraIP2; } }
    public string  CCartas2   { set {    cCartas2= value; } get { return cCartas2; } }
    public string  CCartasResponsable2   { set {    cCartasResponsable2= value; } get { return cCartasResponsable2; } }
    public string  CCartasResponsableIP2   { set {    cCartasResponsableIP2= value; } get { return cCartasResponsableIP2; } }
    public string  CObservaciones2   { set {    cObservaciones2= value; } get { return cObservaciones2; } }
    public string  CObservacionesResponsable2   { set {    cObservacionesResponsable2= value; } get { return cObservacionesResponsable2; } }
    public string  CObservacionesIP2   { set {    cObservacionesIP2= value; } get { return cObservacionesIP2; } }
    public string  AnalisisResultado2   { set {    analisisResultado2= value; } get { return analisisResultado2; } }
    public string  AnalisisResultadoResponsable2   { set {    analisisResultadoResponsable2= value; } get { return analisisResultadoResponsable2; } }
    public string  AnalisisResultadoIP2  { set {    analisisResultadoIP2= value; } get { return analisisResultadoIP2; } }
    public string  AnalisisObservaciones2   { set {    analisisObservaciones2= value; } get { return analisisObservaciones2; } }
    public string  AnalisisObservacionesResponsable2   { set {    analisisObservacionesResponsable2= value; } get { return analisisObservacionesResponsable2; } }
    public string  AnalisisObservacionesIP2   { set {    analisisObservacionesIP2= value; } get { return analisisObservacionesIP2; } }
    public string  ObservacionesResultado2   { set {    observacionesResultado2= value; } get { return observacionesResultado2; } }
    public string  ObservacionesResultadoResponsable2   { set {    observacionesResultadoResponsable2= value; } get { return observacionesResultadoResponsable2; } }
    public string  ObservacionesResultadoIP2   { set {    observacionesResultadoIP2= value; } get { return observacionesResultadoIP2; } }

    public DateTime  CasoObservacionesFechayHora2{ set {    casoObservacionesFechayHora2= value; } get { return casoObservacionesFechayHora2; } }
    public DateTime  SCultivoInmediatoFechayHora2 { set {    sCultivoInmediatoFechayHora2= value; } get { return sCultivoInmediatoFechayHora2; } }
    public DateTime  SCultivo72FitohemaglotunininaFechayHora2 { set {    sCultivo72FitohemaglotunininaFechayHora2= value; } get { return sCultivo72FitohemaglotunininaFechayHora2; } }    
    public DateTime  SCultivo72FitolacaFechayHora2 { set {    sCultivo72FitolacaFechayHora2= value; } get { return sCultivo72FitolacaFechayHora2; } }
    public DateTime  SCultivoMonocapaFechayResponsable2 { set {    sCultivoMonocapaFechayResponsable2= value; } get { return sCultivoMonocapaFechayResponsable2; } }
    public DateTime  SResiembraFechayHora2 { set {    sResiembraFechayHora2= value; } get { return sResiembraFechayHora2; } }
    public DateTime  SCartasFechayHora2 { set {    sCartasFechayHora2= value; } get { return sCartasFechayHora2; } }
    public DateTime  SObservacionesFechayHora2 { set {    sObservacionesFechayHora2= value; } get { return sObservacionesFechayHora2; } }
    public DateTime  CCultivoInmediatoFechayHora2 { set {    cCultivoInmediatoFechayHora2= value; } get { return cCultivoInmediatoFechayHora2; } }
    public DateTime  CCultivo72FitohemaglotunininaFechayHora2 { set {    cCultivo72FitohemaglotunininaFechayHora2= value; } get { return cCultivo72FitohemaglotunininaFechayHora2; } }
    public DateTime  CCultivo72FitolacaFechayHora2 { set {    cCultivo72FitolacaFechayHora2= value; } get { return cCultivo72FitolacaFechayHora2; } }
    public DateTime  CCultivoMonocapaFechayHora2 { set {    cCultivoMonocapaFechayHora2= value; } get { return cCultivoMonocapaFechayHora2; } }
    public DateTime  CResiembraFechayHora2 { set {    cResiembraFechayHora2= value; } get { return cResiembraFechayHora2; } }
    public DateTime  CCartasResponsableFechayHora2 { set {    cCartasResponsableFechayHora2= value; } get { return cCartasResponsableFechayHora2; } }
    public DateTime  CObservacionesFechayHora2 { set {    cObservacionesFechayHora2= value; } get { return cObservacionesFechayHora2; } }
    public DateTime  AnalisisResultadoFechayHora2 { set {   analisisResultadoFechayHora2 = value; } get { return analisisResultadoFechayHora2; } }
    public DateTime AnalisisObservacionesFechayHora2 { set { analisisObservacionesFechayHora2 = value; } get { return analisisObservacionesFechayHora2; } }
    public DateTime ObservacionesResultadoFechayHora2 { set { observacionesResultadoFechayHora2 = value; } get { return observacionesResultadoFechayHora2; } }



    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        //string
        fila["caso"] = int.Parse(Caso.ToString());
        fila["casoIPCreacion"] = CasoIPCreacion;
        fila["casoResponsableCreacion"] = CasoResponsableCreacion;
        fila["casoFechayHoraCreacion"] = CasoFechayHoraCreacion;
        fila["tipoDeMuestra"] = int.Parse(TipoDeMuestra.ToString());
        fila["tipoDeMuestraResponsable"] = TipoDeMuestraResponsable;
        fila["tipoDeMuestraIP"] = TipoDeMuestraIP;
        fila["tipoDeMuestraFechayHora"] = TipoDeMuestraFechayHora;
        fila["estadoDelCaso"] = int.Parse(EstadoDelCaso.ToString());

        //fila["historiaPrevia"] = HistoriaPrevia;
        //fila["casoObservaciones"] = CasoObservaciones;
        //fila["casoRevisadoPorResponsable"] = CasoRevisadoPorResponsable;
        //fila["sCultivoInmediato"] = SCultivoInmediato;
        //fila["sCultivo72Fitohemaglotuninina"] = SCultivo72Fitohemaglotuninina;
        //fila["sCultivo72Fitolaca"] = SCultivo72Fitolaca;
        //fila["sCultivoMonocapa"] = SCultivoMonocapa;
        //fila["sResiembra"] = SResiembra;
        //fila["sCartas"] = SCartas;
        //fila["sObservaciones"] = SObservaciones;
        //fila["cCultivoInmediato"] = CCultivoInmediato;
        //fila["cCultivo72Fitohemaglotuninina"] = CCultivo72Fitohemaglotuninina;
        //fila["cCultivo72Fitolaca"] = CCultivo72Fitolaca;
        //fila["cCultivoMonocapa"] = CCultivoMonocapa;
        //fila["cResiembra"] = CResiembra;
        //fila["cCartas"] = CCartas;
        //fila["cObservaciones"] = CObservaciones;
        //fila["entregadoResponsable"] = EntregadoResponsable;
        //fila["entregadoAResponsable"] = EntregadoAResponsable;
        //fila["asignadoA"] = AsignadoA;
        //fila["recibeEnAnalisisResponsable"] = RecibeEnAnalisisResponsable;
        //fila["fechaLimiteDeEntregaFechayHoraString"] = FechaLimiteDeEntregaFechayHoraString; 
        //fila["fechaVencimientoFechayHoraString"] = FechaVencimientoFechayHoraString; 
        //fila["confirmaRevisionResponsable"] = ConfirmaRevisionResponsable;
        //fila["analisisResultado"] = AnalisisResultado;
        //fila["analisisObservaciones"] = AnalisisObservaciones;
        //fila["primeraValidacionResponsable"] = PrimeraValidacionResponsable;
        //fila["segundaValidacionResponsable"] = SegundaValidacionResponsable;
        //fila["copiaderespaldoResponsable"] = CopiaderespaldoResponsable;
        //fila["verificaRespaldoResponsable"] = VerificaRespaldoResponsable;
        //fila["cierraCasoResponsable"] = CierraCasoResponsable;
        //fila["reabreCasoResponsable"] = ReabreCasoResponsable;
                

        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }


    public bool Existe(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["caso"].ToString()) == valor)
            {
                TipoDeMuestra = int.Parse(fila["tipoDeMuestra"].ToString());
                HistoriaPrevia = fila["historiaPrevia"].ToString();
                CasoObservaciones = fila["casoObservaciones"].ToString();
                CasoRevisadoPor = int.Parse(fila["casoRevisadoPor"].ToString());
                CasoRevisadoPorResponsable = fila["casoRevisadoPorResponsable"].ToString();
                SCultivoInmediato = fila["sCultivoInmediato"].ToString();
                SCultivo72Fitohemaglotuninina = fila["sCultivo72Fitohemaglotuninina"].ToString();
                SCultivo72Fitolaca = fila["sCultivo72Fitolaca"].ToString();
                SCultivoMonocapa = fila["sCultivoMonocapa"].ToString();
                SResiembra = fila["sResiembra"].ToString();
                SCartas = fila["sCartas"].ToString();
                SObservaciones = fila["sObservaciones"].ToString();
                CCultivoInmediato = fila["cCultivoInmediato"].ToString();
                CCultivo72Fitohemaglotuninina = fila["cCultivo72Fitohemaglotuninina"].ToString();
                CCultivo72Fitolaca = fila["cCultivo72Fitolaca"].ToString();
                CCultivoMonocapa = fila["cCultivoMonocapa"].ToString();
                CResiembra = fila["cResiembra"].ToString();
                CCartas = fila["cCartas"].ToString();
                CObservaciones = fila["cObservaciones"].ToString();
                Entregado = int.Parse(fila["entregado"].ToString());
                EntregadoResponsable = fila["entregadoResponsable"].ToString();
                EntregadoAIPNombredeAquienSeLeEntrega = fila["entregadoAIPNombredeAquienSeLeEntrega"].ToString();
                AsignadoA = fila["asignadoA"].ToString();
                RecibeEnAnalisis = int.Parse(fila["recibeEnAnalisis"].ToString());
                RecibeEnAnalisisResponsable = fila["recibeEnAnalisisResponsable"].ToString();
                FechaLimiteDeEntrega = int.Parse(fila["fechaLimiteDeEntrega"].ToString());
                //  FechaLimiteDeEntregaFijada  // No porque es datetime, traigo mejor al string
                FechaLimiteDeEntregaFijadaString = fila["fechaLimiteDeEntregaFijadaString"].ToString();
                FechaVencimiento = int.Parse(fila["fechaVencimiento"].ToString());
                // FechaVencimientoFijada // No porque es datetime, traigo mejor al string
                FechaVencimientoFijadaString = fila["fechaVencimientoFijadaString"].ToString();

                Realiza = int.Parse(fila["realiza"].ToString());
                RealizaResponsable = fila["realizaResponsable"].ToString();

                ConfirmaRevision = int.Parse(fila["confirmaRevision"].ToString());
                ConfirmaRevisionResponsable = fila["confirmaRevisionResponsable"].ToString();
                AnalisisResultado = fila["analisisResultado"].ToString();
                AnalisisObservaciones = fila["analisisObservaciones"].ToString();
                PrimeraValidacion = int.Parse(fila["primeraValidacion"].ToString());
                PrimeraValidacionResponsable = fila["primeraValidacionResponsable"].ToString();
                SegundaValidacion = int.Parse(fila["segundaValidacion"].ToString());
                SegundaValidacionResponsable = fila["segundaValidacionResponsable"].ToString();
                Copiaderespaldo = int.Parse(fila["copiaderespaldo"].ToString());
                CopiaderespaldoResponsable = fila["copiaderespaldoResponsable"].ToString();
                VerificaRespaldo = int.Parse(fila["verificaRespaldo"].ToString());
                VerificaRespaldoResponsable = fila["verificaRespaldoResponsable"].ToString();
                CierraCaso = int.Parse(fila["cierraCaso"].ToString());
                CierraCasoResponsable = fila["cierraCasoResponsable"].ToString();
                ReabreCaso = int.Parse(fila["reabreCaso"].ToString());
                ReabreCasoResponsable = fila["reabreCasoResponsable"].ToString();
                ObservacionesResultado = fila["ObservacionesResultado"].ToString();
                EstadoDelCaso = int.Parse(fila["estadoDelCaso"].ToString());

                
                ResultCoordDirectorTexto = fila["resultCoordDirectorTexto"].ToString();
                ResultCoordDirectorResponsable = fila["resultCoordDirectorResponsable"].ToString();
                ResultCoordDirectorIP = fila["resultCoordDirectorIP"].ToString();

                CasoObservaciones2 =fila["CasoObservaciones2"].ToString();
                SCultivoInmediato2 =fila["sCultivoInmediato2"].ToString();
                SCultivo72Fitohemaglotuninina2 =fila["sCultivo72Fitohemaglotuninina2"].ToString();
                SCultivo72Fitolaca2 =fila["sCultivo72Fitolaca2"].ToString();
                SCultivoMonocapa2 =fila["sCultivoMonocapa2"].ToString();
                SResiembra2 =fila["sResiembra2"].ToString();
                SCartas2 =fila["sCartas2"].ToString();
                SObservaciones2 =fila["sObservaciones2"].ToString();
                CCultivoInmediato2 =fila["cCultivoInmediato2"].ToString();
                CCultivo72Fitohemaglotuninina2 =fila["cCultivo72Fitohemaglotuninina2"].ToString();
                CCultivo72Fitolaca2 =fila["cCultivo72Fitolaca2"].ToString();
                CCultivoMonocapa2 =fila["cCultivoMonocapa2"].ToString();
                CResiembra2 =fila["cResiembra2"].ToString();
                CCartas2 =fila["cCartas2"].ToString();
                CObservaciones2 =fila["cObservaciones2"].ToString();
                AnalisisResultado2 =fila["analisisResultado2"].ToString();
                AnalisisObservaciones2 =fila["analisisObservaciones2"].ToString();
                ObservacionesResultado2 = fila["observacionesResultado2"].ToString();

                //DateTime

                fechaLimiteDeEntregaFechayHora = DateTime.Parse(fila[("fechaLimiteDeEntregaFechayHora")].ToString());
                FechaVencimiento = int.Parse(fila["fechaVencimiento"].ToString());

                ConfirmaRevisionResponsable = fila["confirmaRevisionResponsable"].ToString();
                AnalisisResultado = fila["analisisResultado"].ToString();
                AnalisisObservaciones = fila["analisisObservaciones"].ToString();
                PrimeraValidacionResponsable = fila["primeraValidacionResponsable"].ToString();
                SegundaValidacionResponsable = fila["segundaValidacionResponsable"].ToString();
                CopiaderespaldoResponsable = fila["copiaderespaldoResponsable"].ToString();
                VerificaRespaldoResponsable = fila["verificaRespaldoResponsable"].ToString();
                CierraCasoResponsable = fila["cierraCasoResponsable"].ToString();
                ReabreCasoResponsable = fila["reabreCasoResponsable"].ToString();
                

                //Int
                
                IdRCIT013 = int.Parse(fila["idRCIT013"].ToString());
                EstadoDelCaso = int.Parse(fila["estadoDelCaso"].ToString());
                return true;

            }
        }
        return false;
    }

    public bool ExisteSoloRevisoElCodigo(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["caso"].ToString()) == valor)
            {
                return true;
            }
        }
        return false;
    }





    public bool actualizarINICIALESTiporDeMuestra(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["caso"].ToString()) == valor)
            {
                fila["tipoDeMuestra"] = int.Parse(TipoDeMuestra.ToString());
                fila["tipoDeMuestraIP"] = TipoDeMuestraIP;
                fila["tipoDeMuestraResponsable"] = TipoDeMuestraResponsable;
                fila["tipoDeMuestraFechayHora"] = TipoDeMuestraFechayHora;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }

    public bool ActualizarINICIALESHistoriaPrevia(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["caso"].ToString()) == valor)
            {
                fila["historiaPrevia"] = HistoriaPrevia;
                fila["historiaPreviaIP"] = HistoriaPreviaIP;
                fila["historiaPreviaResponsable"] = HistoriaPreviaResponsable;
                fila["historiaPreviaFechayHora"] = HistoriaPreviaFechayHora;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }

    public bool actualizarINICIALESObservaciones(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["caso"].ToString()) == valor)
            {
                fila["casoObservaciones"] = CasoObservaciones;
                fila["casoObservacionesIP"] = CasoObservacionesIP;
                fila["casoObservacionesResposable"] = CasoObservacionesResposable;
                fila["casoObservacionesFechayHora"] = CasoObservacionesFechayHora;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }

    // DOS
    public bool actualizarINICIALESObservaciones2(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["caso"].ToString()) == valor)
            {
                fila["casoObservaciones2"] = CasoObservaciones2;
                fila["casoObservacionesIP2"] = CasoObservacionesIP2;
                fila["casoObservacionesResposable2"] = CasoObservacionesResposable2;
                fila["casoObservacionesFechayHora2"] = CasoObservacionesFechayHora2;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }


   public bool actualizarINICIALESRevisadoPorIniciales(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["caso"].ToString()) == valor)
            {
                fila["casoRevisadoPor"] = CasoRevisadoPor;
                fila["casoRevisadoPorResponsable"] = CasoRevisadoPorResponsable;
                fila["casoRevisadoPorIP"] = CasoRevisadoPorIP;
                fila["casoRevisadoPorFechayHora"] = CasoRevisadoPorFechayHora;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }

   public bool actualizarSIEMBRACultivoInmediato(int valor)
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["sCultivoInmediato"] = SCultivoInmediato;
               fila["sCultivoInmediatoResponsable"] = SCultivoInmediatoResponsable;
               fila["sCultivoInmediatoIP"] = SCultivoInmediatoIP;
               fila["sCultivoInmediatoFechayHora"] = SCultivoInmediatoFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }
    //DOS
   public bool actualizarSIEMBRACultivoInmediato2(int valor)
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["sCultivoInmediato2"] = SCultivoInmediato2;
               fila["sCultivoInmediatoResponsable2"] = SCultivoInmediatoResponsable2;
               fila["sCultivoInmediatoIP2"] = SCultivoInmediatoIP2;
               fila["sCultivoInmediatoFechayHora2"] = SCultivoInmediatoFechayHora2;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }


   public bool actualizarSIEMBRACultivo72Fitohemaglotuninina(int valor)
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["sCultivo72Fitohemaglotuninina"] = SCultivo72Fitohemaglotuninina;
               fila["sCultivo72FitohemaglotunininaResponsable"] = SCultivo72FitohemaglotunininaResponsable;
               fila["sCultivo72FitohemaglotunininaIP"] = SCultivo72FitohemaglotunininaIP;
               fila["sCultivo72FitohemaglotunininaFechayHora"] = SCultivo72FitohemaglotunininaFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }
    //DOS
   public bool actualizarSIEMBRACultivo72Fitohemaglotuninina2(int valor)
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["sCultivo72Fitohemaglotuninina2"] = SCultivo72Fitohemaglotuninina2;
               fila["sCultivo72FitohemaglotunininaResponsable2"] = SCultivo72FitohemaglotunininaResponsable2;
               fila["sCultivo72FitohemaglotunininaIP2"] = SCultivo72FitohemaglotunininaIP2;
               fila["sCultivo72FitohemaglotunininaFechayHora2"] = SCultivo72FitohemaglotunininaFechayHora2;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }



   public bool actualizarSIEMBRACultivo72Fitolaca(int valor)
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["sCultivo72Fitolaca"] = SCultivo72Fitolaca;
               fila["sCultivo72FitolacaResponsable"] = SCultivo72FitolacaResponsable;
               fila["sCultivo72FitolacaIP"] = SCultivo72FitolacaIP;
               fila["sCultivo72FitolacaFechayHora"] = SCultivo72FitolacaFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }
    //DOS
   public bool actualizarSIEMBRACultivo72Fitolaca2(int valor)
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["sCultivo72Fitolaca2"] = SCultivo72Fitolaca2;
               fila["sCultivo72FitolacaResponsable2"] = SCultivo72FitolacaResponsable2;
               fila["sCultivo72FitolacaIP2"] = SCultivo72FitolacaIP2;
               fila["sCultivo72FitolacaFechayHora2"] = SCultivo72FitolacaFechayHora2;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }

   public bool actualizarSIEMBRACultivoMonocapa(int valor)
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["sCultivoMonocapa"] = SCultivoMonocapa;
               fila["sCultivoMonocapaResponsable"] = SCultivoMonocapaResponsable;
               fila["sCultivoMonocapaIP"] = SCultivoMonocapaIP;
               fila["sCultivoMonocapaFechayResponsable"] = SCultivoMonocapaFechayResponsable;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }
    //DOS
   public bool actualizarSIEMBRACultivoMonocapa2(int valor)
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["sCultivoMonocapa2"] = SCultivoMonocapa2;
               fila["sCultivoMonocapaResponsable2"] = SCultivoMonocapaResponsable2;
               fila["sCultivoMonocapaIP2"] = SCultivoMonocapaIP;
               fila["sCultivoMonocapaFechayResponsable2"] = SCultivoMonocapaFechayResponsable2;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }


   public bool actualizarSIEMBRAResiembra(int valor) //OK
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["sResiembra"] = SResiembra;
               fila["sResiembraResponsable"] = SResiembraResponsable;
               fila["sResiembraIP"] = SResiembraIP;
               fila["sResiembraFechayHora"] = SResiembraFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }

    //DOS
   public bool actualizarSIEMBRAResiembra2(int valor) //OK
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["sResiembra2"] = SResiembra2;
               fila["sResiembraResponsable2"] = SResiembraResponsable2;
               fila["sResiembraIP2"] = SResiembraIP2;
               fila["sResiembraFechayHora2"] = SResiembraFechayHora2;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }


   public bool actualizarSIEMBRACartas(int valor)  //ok
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["sCartas"] = SCartas;
               fila["sCartasResponsable"] = SCartasResponsable;
               fila["sCartasIP"] = SCartasIP;
               fila["sCartasFechayHora"] = SCartasFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }

    //DOS
   public bool actualizarSIEMBRACartas2(int valor)  //ok
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["sCartas2"] = SCartas2;
               fila["sCartasResponsable2"] = SCartasResponsable2;
               fila["sCartasIP2"] = SCartasIP2;
               fila["sCartasFechayHora2"] = SCartasFechayHora2;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }

   public bool actualizarSIREMBRAObservaciones(int valor)  //ok
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["sObservaciones"] = SObservaciones;
               fila["sObservacionesResponsable"] = SObservacionesResponsable;
               fila["sObservacionesIP"] = SObservacionesIP;
               fila["sObservacionesFechayHora"] = SObservacionesFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }

    //DOS
   public bool actualizarSIREMBRAObservaciones2(int valor)  //ok
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["sObservaciones2"] = SObservaciones2;
               fila["sObservacionesResponsable2"] = SObservacionesResponsable2;
               fila["sObservacionesIP2"] = SObservacionesIP2;
               fila["sObservacionesFechayHora2"] = SObservacionesFechayHora2;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }



    //////
   public bool actualizarCOSECHACultivoInmediato(int valor)  //OK
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["cCultivoInmediato"] = CCultivoInmediato;
               fila["cCultivoInmediatoResponsable"] = CCultivoInmediatoResponsable;
               fila["cCultivoInmediatoIP"] = CCultivoInmediatoIP;
               fila["cCultivoInmediatoFechayHora"] = CCultivoInmediatoFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }

    //DOS
   public bool actualizarCOSECHACultivoInmediato2(int valor)  //OK
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["cCultivoInmediato2"] = CCultivoInmediato2;
               fila["cCultivoInmediatoResponsable2"] = CCultivoInmediatoResponsable2;
               fila["cCultivoInmediatoIP2"] = CCultivoInmediatoIP2;
               fila["cCultivoInmediatoFechayHora2"] = CCultivoInmediatoFechayHora2;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }

   public bool actualizarCULTIVOCultivo72Fitohemaglotuninina(int valor)  //OK
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["cCultivo72Fitohemaglotuninina"] = CCultivo72Fitohemaglotuninina;
               fila["cCultivo72FitohemaglotunininaResponsable"] = CCultivo72FitohemaglotunininaResponsable;
               fila["cCultivo72FitohemaglotunininaIP"] = CCultivo72FitohemaglotunininaIP;
               fila["cCultivo72FitohemaglotunininaFechayHora"] = CCultivo72FitohemaglotunininaFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }
    //DOS 
   public bool actualizarCULTIVOCultivo72Fitohemaglotuninina2(int valor)  //OK
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["cCultivo72Fitohemaglotuninina2"] = CCultivo72Fitohemaglotuninina2;
               fila["cCultivo72FitohemaglotunininaResponsable2"] = CCultivo72FitohemaglotunininaResponsable2;
               fila["cCultivo72FitohemaglotunininaIP2"] = CCultivo72FitohemaglotunininaIP2;
               fila["cCultivo72FitohemaglotunininaFechayHora2"] = CCultivo72FitohemaglotunininaFechayHora2;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }



   public bool actualizarCULTIVOCultivo72Fitolaca(int valor) //OK
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["cCultivo72Fitolaca"] = CCultivo72Fitolaca;
               fila["cCultivo72FitolacaResponsable"] = CCultivo72FitolacaResponsable;
               fila["cCultivo72FitolacaIP"] = CCultivo72FitolacaIP;
               fila["cCultivo72FitolacaFechayHora"] = CCultivo72FitolacaFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }

    //DOS
   public bool actualizarCULTIVOCultivo72Fitolaca2(int valor) //OK
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["cCultivo72Fitolaca2"] = CCultivo72Fitolaca2;
               fila["cCultivo72FitolacaResponsable2"] = CCultivo72FitolacaResponsable2;
               fila["cCultivo72FitolacaIP2"] = CCultivo72FitolacaIP2;
               fila["cCultivo72FitolacaFechayHora2"] = CCultivo72FitolacaFechayHora2;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }


   public bool actualizarCULTIVOCultivoMonocapa(int valor)  // OK
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["cCultivoMonocapa"] = CCultivoMonocapa;
               fila["cCultivoMonocapaResponsable"] = CCultivoMonocapaResponsable;
               fila["cCultivoMonocapaIP"] = CCultivoMonocapaIP;
               fila["cCultivoMonocapaFechayHora"] = CCultivoMonocapaFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }
    //DOS
   public bool actualizarCULTIVOCultivoMonocapa2(int valor)  // OK
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["cCultivoMonocapa2"] = CCultivoMonocapa2;
               fila["cCultivoMonocapaResponsable2"] = CCultivoMonocapaResponsable2;
               fila["cCultivoMonocapaIP2"] = CCultivoMonocapaIP2;
               fila["cCultivoMonocapaFechayHora2"] = CCultivoMonocapaFechayHora2;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }


   public bool actualizarCULTIVOResiembra(int valor) //OK
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["cResiembra"] = CResiembra;
               fila["cResiembraResponsable"] = CResiembraResponsable;
               fila["cResiembraIP"] = CResiembraIP;
               fila["cResiembraFechayHora"] = CResiembraFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }

    //DOS
   public bool actualizarCULTIVOResiembra2(int valor) //OK
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["cResiembra2"] = CResiembra2;
               fila["cResiembraResponsable2"] = CResiembraResponsable2;
               fila["cResiembraIP2"] = CResiembraIP2;
               fila["cResiembraFechayHora2"] = CResiembraFechayHora2;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }

   public bool actualizarCULTIVOCartas(int valor)  //ok
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["cCartas"] = CCartas;
               fila["cCartasResponsable"] = CCartasResponsable;
               fila["cCartasResponsableIP"] = CCartasResponsableIP;
               fila["cCartasResponsableFechayHora"] = CCartasResponsableFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }

    //DOS
   public bool actualizarCULTIVOCartas2(int valor)  //ok
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["cCartas2"] = CCartas2;
               fila["cCartasResponsable2"] = CCartasResponsable2;
               fila["cCartasResponsableIP2"] = CCartasResponsableIP2;
               fila["cCartasResponsableFechayHora2"] = CCartasResponsableFechayHora2;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }

   public bool actualizarCULTIVOObservaciones(int valor)  //ok
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["cObservaciones"] = CObservaciones;
               fila["cObservacionesResponsable"] = CObservacionesResponsable;
               fila["cObservacionesIP"] = CObservacionesIP;
               fila["cObservacionesFechayHora"] = CObservacionesFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }

    //DOS
   public bool actualizarCULTIVOObservaciones2(int valor)  //ok
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["cObservaciones2"] = CObservaciones;
               fila["cObservacionesResponsable2"] = CObservacionesResponsable;
               fila["cObservacionesIP2"] = CObservacionesIP;
               fila["cObservacionesFechayHora2"] = CObservacionesFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }

   public bool actualizarEntregado(int valor)  // OK
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["entregado"] = Entregado;
               fila["entregadoResponsable"] = EntregadoResponsable;
               fila["entregadoIP"] = EntregadoIP;
               fila["entregadoFechayHora"] = EntregadoFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }

   public bool actualizarEntregadoA(int valor)   //OK
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["entregadoAIPNombredeAquienSeLeEntrega"] = EntregadoAIPNombredeAquienSeLeEntrega;
               fila["entregadoAResponsable"] = EntregadoAResponsable;
               fila["entregadoAIP"] = EntregadoAIP;
               fila["entregadoAIPFechayHoraentregadoAIP"] = EntregadoAIPFechayHoraentregadoAIP;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }

   public bool actualizarAsignadoA(int valor)   //OK
   {
       conectar(tabla);
       DataRow fila;   // es un nuevo  registro Fila de datos
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["asignadoA"] = AsignadoA;
               fila["asignadoAResposable"] = AsignadoAResposable;
               fila["asignadoAIP"] = AsignadoAIP;
               fila["asignadoAFechayHora"] = AsignadoAFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }


   public bool actualizarRecibeEnAnalis(int valor)   // OK
   {
       conectar(tabla);
       DataRow fila;   
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["recibeEnAnalisis"] = RecibeEnAnalisis;
               fila["recibeEnAnalisisResponsable"] = RecibeEnAnalisisResponsable;
               fila["recibeEnAnalisisIP"] = RecibeEnAnalisisIP;
               fila["recibeEnAnalisisFechayHora"] = RecibeEnAnalisisFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }

   public bool actualizarFechaLimiteDeEntrega(int valor)   // ok
   {
       conectar(tabla);
       DataRow fila;
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["fechaLimiteDeEntrega"] = FechaLimiteDeEntrega;
               //fila["fechaLimiteDeEntregaFijada"] = FechaLimiteDeEntregaFijada;
               fila["fechaLimiteDeEntregaFijadaString"] = FechaLimiteDeEntregaFijadaString;
               fila["fechaLimiteDeEntregaResponsable"] = FechaLimiteDeEntregaResponsable;
               fila["fechaLimiteDeEntregaIP"] = FechaLimiteDeEntregaIP;
               fila["fechaLimiteDeEntregaFechayHora"] = FechaLimiteDeEntregaFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }


   public bool actualizarFechaLimiteDeEntregaHora(int valor)   // ok
   {
       conectar(tabla);
       DataRow fila;
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["fechaLimiteDeEntregaFijada"] = FechaLimiteDeEntregaFijada;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }


   public bool actualizarFechaVencimiento(int valor)   // ok
   {
       conectar(tabla);
       DataRow fila;
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["fechaVencimiento"] = FechaVencimiento;
               fila["fechaVencimientoResponsable"] = FechaVencimientoResponsable;
               fila["fechaVencimientoFijadaString"] = FechaVencimientoFijadaString;
               fila["fechaVencimientoIP"] = FechaVencimientoIP;
               fila["fechaVencimientoFechayHora"] = FechaVencimientoFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }


   public bool actualizarFechaVencimientoFechaDesignada(int valor)   // ok
   {
       conectar(tabla);
       DataRow fila;
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["fechaVencimientoFijada"] = FechaVencimientoFijada;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }



   public bool actualizarRealiza(int valor)   // OK
   {
       conectar(tabla);
       DataRow fila;
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["realiza"] = Realiza;
               fila["realizaResponsable"] = RealizaResponsable;
               fila["realizaIP"] = RealizaIP;
               fila["realizaFechayHora"] = RealizaFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }





   public bool actualizarConfirmaRevision(int valor)   // OK
   {
       conectar(tabla);
       DataRow fila;
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["confirmaRevision"] = ConfirmaRevision;
               fila["confirmaRevisionResponsable"] = ConfirmaRevisionResponsable;
               fila["confirmaRevisionIP"] = ConfirmaRevisionIP;
               fila["confirmaRevisionFechayHora"] = ConfirmaRevisionFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }


   public bool actualizaAnalisisResultado(int valor)   //  OK
   {
       conectar(tabla);
       DataRow fila;
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["analisisResultado"] = AnalisisResultado;
               fila["analisisResultadoResponsable"] = AnalisisResultadoResponsable;
               fila["analisisResultadoIP"] = AnalisisResultadoIP;
               fila["analisisResultadoFechayHora"] = AnalisisResultadoFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }
    //DOS
   public bool actualizaAnalisisResultado2(int valor)   //  OK
   {
       conectar(tabla);
       DataRow fila;
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["analisisResultado2"] = AnalisisResultado2;
               fila["analisisResultadoResponsable2"] = AnalisisResultadoResponsable2;
               fila["analisisResultadoIP2"] = AnalisisResultadoIP2;
               fila["analisisResultadoFechayHora2"] = AnalisisResultadoFechayHora2;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }


   public bool actualizaAnalisisObservaciones(int valor)   //  OK
   {
       conectar(tabla);
       DataRow fila;
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["analisisObservaciones"] = AnalisisObservaciones;
               fila["analisisObservacionesResponsable"] = AnalisisObservacionesResponsable;
               fila["analisisObservacionesIP"] = AnalisisObservacionesIP;
               fila["analisisObservacionesFechayHora"] = AnalisisObservacionesFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }

    //DOS
   public bool actualizaAnalisisObservaciones2(int valor)   //  OK
   {
       conectar(tabla);
       DataRow fila;
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["analisisObservaciones2"] = AnalisisObservaciones2;
               fila["analisisObservacionesResponsable2"] = AnalisisObservacionesResponsable2;
               fila["analisisObservacionesIP2"] = AnalisisObservacionesIP2;
               fila["analisisObservacionesFechayHora2"] = AnalisisObservacionesFechayHora2;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }

   public bool actualizaPrimeraValidacion(int valor)   //  OK
   {
       conectar(tabla);
       DataRow fila;
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["primeraValidacion"] = PrimeraValidacion;
               fila["primeraValidacionResponsable"] = PrimeraValidacionResponsable;
               fila["primeraValidacionIP"] = PrimeraValidacionIP;
               fila["primeraValidacionFechayHora"] = PrimeraValidacionFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }

   public bool actualizaSegundaValidacion(int valor)   //  
   {
       conectar(tabla);
       DataRow fila;
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["segundaValidacion"] = SegundaValidacion;
               fila["segundaValidacionResponsable"] = SegundaValidacionResponsable;
               fila["segundaValidacionIP"] = SegundaValidacionIP;
               fila["segundaValidacionFechayHora"] = PrimeraValidacionFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }


   public bool actualizaCopiaderespaldo(int valor)   //  OK
   {
       conectar(tabla);
       DataRow fila;
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["copiaderespaldo"] = Copiaderespaldo;
               fila["copiaderespaldoResponsable"] = CopiaderespaldoResponsable;
               fila["copiaderespaldoIP"] = CopiaderespaldoIP;
               fila["CopiaderespaldoFechayHora"] = copiaderespaldoFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }

   public bool actualizaVerificaRespaldo(int valor)   //  OK
   {
       conectar(tabla);
       DataRow fila;
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["verificaRespaldo"] = VerificaRespaldo;
               fila["verificaRespaldoResponsable"] = VerificaRespaldoResponsable;
               fila["verificaRespaldoIP"] = VerificaRespaldoIP;
               fila["verificaRespaldoFechayHora"] = VerificaRespaldoFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }


   public bool actualizaCierraCaso(int valor)   //  OK
   {
       conectar(tabla);
       DataRow fila;
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["cierraCaso"] = CierraCaso;
               fila["cierraCasoResponsable"] = CierraCasoResponsable;
               fila["cierraCasoIP"] = CierraCasoIP;
               fila["cierraCasoFechayHora"] = CierraCasoFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }


   public bool actualizaReabreCaso(int valor)   //  OK
   {
       conectar(tabla);
       DataRow fila;
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["reabreCaso"] = ReabreCaso;
               fila["reabreCasoResponsable"] = ReabreCasoResponsable;
               fila["reabreCasoIP"] = ReabreCasoIP;
               fila["reabreCasoFechayHora"] = ReabreCasoFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }

   public bool actualizaObservacionesResultadoReporte(int valor)   //  OK
   {
       conectar(tabla);
       DataRow fila;
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["observacionesResultado"] = ObservacionesResultado;
               fila["observacionesResultadoResponsable"] = ObservacionesResultadoResponsable;
               fila["observacionesResultadoIP"] = ObservacionesResultadoIP;
               fila["observacionesResultadoFechayHora"] = ObservacionesResultadoFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }

    //DOS
   public bool actualizaObservacionesResultadoReporte2(int valor)   //  OK
   {
       conectar(tabla);
       DataRow fila;
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["observacionesResultado2"] = ObservacionesResultado2;
               fila["observacionesResultadoResponsable2"] = ObservacionesResultadoResponsable2;
               fila["observacionesResultadoIP2"] = ObservacionesResultadoIP2;
               fila["observacionesResultadoFechayHora2"] = ObservacionesResultadoFechayHora2;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }

   public bool actualizaEstadoDelCaso(int valor)   //  OK
   {
       conectar(tabla);
       DataRow fila;
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["estadoDelCaso"] = EstadoDelCaso;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }


      public bool actualizaResultCoordDirector(int valor)   //  OK
   {
       conectar(tabla);
       DataRow fila;
       int x = Data.Tables[tabla].Rows.Count - 1;
       for (int i = 0; i <= x; i++)
       {
           fila = Data.Tables[tabla].Rows[i];
           if (int.Parse(fila["caso"].ToString()) == valor)
           {
               fila["resultCoordDirectorTexto"] = ResultCoordDirectorTexto;
               fila["resultCoordDirectorResponsable"] = ResultCoordDirectorResponsable;
               fila["resultCoordDirectorIP"] = ResultCoordDirectorIP;
               fila["resultCoordDirectorFechayHora"] = ResultCoordDirectorFechayHora;
               AdaptadorDatos.Update(Data, tabla);
               return true;
           }
       } return false;
   }

}