using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Collections;

namespace Lucky.Entity.Common.Servicio
{
    public class E_InformesCanje
    {
        //public E_InformesCanje() {
        //    getDatosTotalImplementadoObjetivos = new List<GetDatosTotalImplementadoObjetivos>();
        //    getCharColumn3DStacked = new List<CharColumn3DStacked>();
        //    getDatosPorVisita = new List<GetDatosPorVisita>();
        //    getDatosPorAcumulado = new List<GetDatosPorAcumulado>();
        //    getDatosPorMerma = new List<GetDatosPorMerma>();
        //    getDatosMatImpl = new List<GetDatosMatImpl>();
        //    getDatosBodeImplFrec = new List<GetDatosBodeImplFrec>();
        //}
        ////1 - Objetivos de la Implementacion
        //[JsonProperty("a")]
        //public List<GetDatosTotalImplementadoObjetivos> getDatosTotalImplementadoObjetivos { get; set; }
        //[JsonProperty("b")]
        //public List<CharColumn3DStacked> getCharColumn3DStacked { get; set; }
        
        ////2 - Resultado de la Evolucion de la Implementacion
        //[JsonProperty("c")]
        //public List<GetDatosPorVisita> getDatosPorVisita { get; set; }
        //[JsonProperty("d")]
        //public List<GetDatosPorAcumulado> getDatosPorAcumulado { get; set; }
        
        ////3 -  Status de las Mermas
        //[JsonProperty("e")]
        //public List<GetDatosPorMerma> getDatosPorMerma { get; set; }
        
        ////4 - Material de Implementacion
        //[JsonProperty("f")]
        //public List<GetDatosMatImpl> getDatosMatImpl { get; set; }
        
        ////5 - Cantidad de Bodegas Implementadas según Frecuencia
        //[JsonProperty("g")]
        //public List<GetDatosBodeImplFrec> getDatosBodeImplFrec { get; set; }
        
    }
    #region Analisis de Implementacion

    #region 1 - Objetivos de la Implementacion
    //Grafico 1 - Objetivos de la Implementacion
    //Barra Total
    public class GetDatosTotalImplementadoObjetivos
    {
        [JsonProperty("a")]
        public string nombre { get; set; }
        [JsonProperty("b")]
        public int valor { get; set; }
        [JsonProperty("c")]
        public double porcentaje { get; set; }
        [JsonProperty("d")]
        public double PorcentajeEfectividad { get; set; }
        [JsonProperty("e")]
        public string fecha { get; set; }

    }
    //Barra Detalles
    public class CharColumn3DStacked
    {
        [JsonProperty("a")]
        public string Visita { get; set; }
        [JsonProperty("b")]
        public double Objetivo { get; set; }
        [JsonProperty("c")]
        public double Implementado { get; set; }
    }
    //Mapa Implementacion 15/10/2012 psa
    public class GetDatosDetalleImplementacionObjetivo
    {
        [JsonProperty("codPDV")]
        public string codPDV { get; set; }
        [JsonProperty("latitud")]
        public double latitud { get; set; }
        [JsonProperty("longitud")]
        public double longitud { get; set; }
        [JsonProperty("info_pdv")]
        public string info_pdv { get; set; }
        [JsonProperty("nombre_pdv")]
        public string nombre_pdv { get; set; }
        [JsonProperty("fase_pdv")]
        public string fase_pdv { get; set; }
        [JsonProperty("pie_pdv")]
        public string pie_pdv { get; set; }//Mostrar los Motivos por el cual el Punto de Venta no está Implementado.
        [JsonProperty("url_imagen_pdv")]
        public string url_imagen_pdv { get; set; }
    }
   
    #endregion

    #region 2 - Resultado de la Evolucion de la Implementacion
    //Grafico 2-1 - Barra Por Visita
    public class GetDatosPorVisita
    {
        [JsonProperty("a")]
        public string Visita { set; get; }
        [JsonProperty("b")]
        public int Total { set; get; }
        [JsonProperty("c")]
        public double Porcentaje { set; get; }
    }
    //Grafico 2-2 - Barra Acumulado al final de la Actividad
    public class GetDatosPorAcumulado
    {
        [JsonProperty("a")]
        public string Visita { get; set; }
        [JsonProperty("b")]
        public double Porcentaje_1 { get; set; }
        [JsonProperty("c")]
        public double Porcentaje_2 { get; set; }
        [JsonProperty("d")]
        public double Porcentaje_3 { get; set; }
    }
    #endregion

    #region 3 -  Status de las Mermas
    //Grafico 3 - Mermas acumuladas al Final de la actividad (Expresado en Unid.)
    public class GetDatosPorMerma
    {
        [JsonProperty("a")]
        public string TipoMerma { get; set; }
        [JsonProperty("b")]
        public double Total { get; set; }
        [JsonProperty("c")]
        public double Porcentaje { get; set; }
    }
    #endregion

    #region 4 - Material de Implementacion
    public class GetDatosMatImpl {
        [JsonProperty("a")]
        public string Material { get; set; }
        [JsonProperty("b")]
        public double Porcentaje { get; set; }
    }
    #endregion

    #region 5 - Cantidad de Bodegas Implementadas según Frecuencia
    public class GetDatosBodeImplFrec {
        [JsonProperty("a")]
        public string Frecuencia { get; set; }
        [JsonProperty("b")]
        public int Objetivo { get; set; }
        [JsonProperty("c")]
        public int Implementados { get; set; }
        [JsonProperty("d")]//Add 18/10/2012. Psa. 
        public string Porcentaje_Frecuencia { get; set; }
    }
    #endregion

    #region 6 - Cuadro Resumen 
    //Add 17/10/2012. psa. Mostrar Grafico Resumen
    public class GetDatosPorResumeImp_RazNoImpl {
        [JsonProperty("a")] //Número del Cuadro Resumen(Puede existir varios cuadros resumen este parametro agrupará a cada uno de ellos.)
        public string Codigo { get; set; }
        [JsonProperty("b")] //Nombre del Item
        public string Nombre { get; set; }
        [JsonProperty("c")] //Valor del Item
        public string Valor { get; set; }
    }
    #endregion
    #endregion

    #region Analisis de Stock
    // 1 - Grafico de Stock
    public class GetDatosPorCantStock {
        [JsonProperty("a")]
        public string nombre { get; set; }
        [JsonProperty("b")]
        public int valor { get; set; }
        [JsonProperty("c")]
        public double porcentaje { get; set; }
    }
    // 2 - Grafico Cantidad Total de Platos Vendidos
    public class GetDatosPorCantTotalPlatosVendidos {
        [JsonProperty("a")]
        public string nombre { get; set; }
        [JsonProperty("b")]
        public int valor { get; set; }
        [JsonProperty("c")]//Add 26/10/2012
        public string porcentaje { get; set; }
        [JsonProperty("d")]
        public string cantidad_pdv { get; set; }
    }
    // 3 - Mostrar Mapa para Reporte de Stock. Add:16/10/2012 psa :/
    public class GetDatosPorDetalleStockVenVsObj {
        [JsonProperty("codPDV")]
        public string codPDV { get; set; }
        [JsonProperty("latitud")]
        public double latitud { get; set; }
        [JsonProperty("longitud")]
        public double longitud { get; set; }
        [JsonProperty("info_pdv")]
        public string info_pdv { get; set; }
        [JsonProperty("nombre_pdv")]
        public string nombre_pdv { get; set; }
        [JsonProperty("estadoPlato_pdv")]
        public string estadoPlato_pdv { get; set; }
        [JsonProperty("pie_pdv")]
        public string pie_pdv { get; set; }//Mostrar los Motivos por el cual el Punto de Venta no está Implementado.
        [JsonProperty("url_imagen_pdv")]
        public string url_imagen_pdv { get; set; }
    }
    #endregion

    #region Analisis de Merma
    // 1 - Cantidad de Merma / Participacion por Tipo de Merma
    public class GetDatosPorTipMerma {
        public string TipoMerma { get; set; }
        public int valor { get; set; }
        public double porcentaje { get; set; }
    }
    #endregion


}
