using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Sincronizar
    {
        [JsonProperty("a")]
        public List<E_Estado> listaEstado { get; set; }

        [JsonProperty("b")]
        public List<E_Motivo> listaMotivo { get; set; }

        [JsonProperty("c")]
        public List<E_NoVisita> listaNoVisita { get; set; }

        [JsonProperty("d")]
        public List<E_Reporte> ListaReporte { get; set; }

        [JsonProperty("e")]
        public List<E_Opc_Reporte> ListaOpcionReporte { get; set; }

        [JsonProperty("f")]
        public List<E_PuntoVenta> listaPuntoVenta { get; set; }
       
        [JsonProperty("g")]
        public List<E_Categoria> listaCategoria { get; set; }

        [JsonProperty("h")]
        public List<E_Producto> listaProducto { get; set; }

        [JsonProperty("i")]
        public List<E_Material_Apoyo> listaTipoMaterialApoyo { get; set; }

        [JsonProperty("j")]
        public List<E_Observacion> listaObservacion { get; set; }

        [JsonProperty("k")]
        public List<E_Marca> listaMarca { get; set; }

        [JsonProperty("l")]
        public List<E_Promocion_Mov> listaPromocion { get; set; }

        [JsonProperty("m")]
        public List<E_Cluster> listaCluster { get; set; }

        [JsonProperty("n")]
        public List<E_Familia> listaFamilia { get; set; }

        [JsonProperty("o")]
        public List<E_SubFamilia> listaSubFamilia { get; set; }

        [JsonProperty("p")]
        public List<E_Actividad> listaActividad { get; set; }

        [JsonProperty("q")]
        public List<E_Grupo_Objetivo> listaGrupoObjetivo { get; set; }

        [JsonProperty("r")]
        public List<E_Cond_Exhib> listaCondExhib { get; set; }

        [JsonProperty("s")]
        public List<E_Obj_Marca> listaObjxMarca { get; set; }

        [JsonProperty("t")]
        public List<E_Servicio> listaServicio { get; set; }

        [JsonProperty("u")]
        public List<E_Competidora> listaCompetidora { get; set; }

        [JsonProperty("v")]
        public List<E_Motivo_Reporte> listaMotivoReporte { get; set; }

        [JsonProperty("w")]
        public List<E_Opc_Pedido> listaOpcionPedido { get; set; }

        [JsonProperty("x")]
        public List<E_Datos_Presencia> listaDatosPresencia { get; set; }

        [JsonProperty("y")]
        public List<E_Distribuidora> listaDistribuidora { get; set; }   

        [JsonProperty("z")]
        public List<E_Distribuidora_PtoVenta> listaDistribuidoraPtoVenta { get; set; }

        [JsonProperty("aa")]
        public List<E_Ubicacion> listaUbicacion { get; set; }

        [JsonProperty("ab")]
        public List<E_Posicion> listaPosicion { get; set; }

        [JsonProperty("ac")]
        public List<E_SubCategoria> listaSubCategoria { get; set; }

        [JsonProperty("ad")]
        public List<E_SubMarca> listaSubMarca { get; set; }

        [JsonProperty("ae")]
        public List<E_Presentacion> listaPresentacion { get; set; }

        [JsonProperty("af")]
        public List<E_Fase> listaFase { get; set; }

        [JsonProperty("ag")]
        public List<E_Segmento> listaSegmento { get; set; }

        [JsonProperty("ah")]//Add 20/06/2012 PSA
        public List<E_Exhibicion> listaExhibicion { get; set; }

        [JsonProperty("ai")]//Add 05/07/2012 PSA
        public List<E_Motivo_Observacion> listaMotivo_Observacion { get; set; }

        [JsonProperty("aj")] //Add 25/07/2012 PSA
        public List<E_Marcaje_Precio> listaMarcaje_Precio{get; set; }

        [JsonProperty("ak")] //Add 25/07/2012 PSA
        public List<E_Capacitacion> listaCapacitacion { get; set; }

        [JsonProperty("al")] //Add 25/07/2012 PSA
        public List<E_Status> listaStatus { get; set; }

        [JsonProperty("am")] //Add 25/07/2012 PSA
        public List<E_Incidencia> listaIncidencias { get; set; }

        [JsonProperty("an")] //Add 25/07/2012 PSA
        public List<E_Credito> listaCredito { get; set; }

        [JsonProperty("ao")] //Add 29/08/2012 JGONZALES
        public List<E_Canal_x_Cliente> listaCanal { get; set; }

        [JsonProperty("ap")] //Add 29/08/2012 JGONZALES
        public List<E_Departamento_x_Canal> listaDepartamentoXCanal { get; set; }

        [JsonProperty("aq")] //Add 29/08/2012 JGONZALES
        public List<E_Provincia_x_Canal> listaProvinciaXCanal { get; set; }

        [JsonProperty("ar")]//Add 04/09/2012 PSalas
        public List<E_Perfil> listaPerfil { get; set; }

        [JsonProperty("as")]//Add 04/09/2012 PSalas
        public List<E_TPerfil> listaTipoPerfil { get; set; }

    }
}