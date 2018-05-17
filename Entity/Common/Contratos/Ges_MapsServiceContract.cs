using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Lucky.CFG.JavaMovil;
using Lucky.Entity.Common.Servicio;

namespace Lucky.Entity.Common.Contratos
{

    public class Ges_MapsServiceRequest
    {

    }

    public class Obtener_Representatividad_Request
    {
        [JsonProperty("a")]
        public int tipo { get; set; }

        [JsonProperty("b")]
        public string codigo { get; set; }
    }

    public class Obtener_Representatividad_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_Representatividad representatividad { get; set; }
    }

    public class Obtener_PresenciaZonaDistrito_Request
    {
        [JsonProperty("a")]
        public int servicio { get; set; }

        [JsonProperty("b")]
        public string canal { get; set; }

        [JsonProperty("c")]
        public int codCliente { get; set; }

        [JsonProperty("d")]
        public int codciudad { get; set; }

        [JsonProperty("e")]
        public int codZona { get; set; }

        [JsonProperty("f")]
        public string codDistrito { get; set; }

        [JsonProperty("g")]
        public int reportsPlanning { get; set; }
    }

    public class Obtener_PresenciaZonaDistrito_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_PresenciaZonaDistrito> listaPresencia { get; set; }

        [JsonProperty("b")]
        public List<E_ElemVisibilidadZonaDistrito> listaElementosVisibilidad { get; set; }
    }

    public class Obtener_VentaZonaDistrito_Request
    {
        [JsonProperty("a")]
        public int tipo { get; set; }

        [JsonProperty("b")]
        public string codigo { get; set; }

        [JsonProperty("c")]
        public int reportsPlanning { get; set; }
    }

    public class Obtener_VentaZonaDistrito_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_VentasZonaDistrito> listaVentas { get; set; }
    }

    public class Obtener_PuntoVenta_Request
    {
        [JsonProperty("a")]
        public string codEquipo { get; set; }

        [JsonProperty("b")]
        public string codGenerador { get; set; }

        [JsonProperty("c")]
        public string reportsPlanning { get; set; }

        [JsonProperty("d")]
        public string codPais { get; set; }

        [JsonProperty("e")]
        public string codDepartamento { get; set; }

        [JsonProperty("f")]
        public string codProvincia { get; set; }

        [JsonProperty("g")]
        public string codSector { get; set; }

        [JsonProperty("h")]
        public string codDistrito { get; set; }
    }

    public class Obtener_PuntoVenta_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_PuntoVentaMapa> listaPuntosVenta { get; set; }
    }

    public class Obtener_Provincia_Por_CodDepartamento_Request
    {
        [JsonProperty("a")]
        public string codPais { get; set; }

        [JsonProperty("b")]
        public string codDepartamento { get; set; }
    }

    public class Obtener_Provincia_Por_CodDepartamento_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Provincia> listaProvincias { get; set; }
    }

    public class Obtener_Sector_Por_PaisDepartamentoProvincia_Request
    {
        [JsonProperty("a")]
        public string codPais { get; set; }

        [JsonProperty("b")]
        public string codDepartamento { get; set; }

        [JsonProperty("c")]
        public string codProvincia { get; set; }
    }

    public class Obtener_Sector_Por_PaisDepartamentoProvincia_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Sector> listaSector { get; set; }
    }

    public class Obtener_DatosPuntosVentaMapa_Request
    {
        [JsonProperty("a")]
        public string codPtoVenta { get; set; }
    }

    public class Obtener_DatosPuntosVentaMapa_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_PuntoVentaDatosMapa ptoVenta { get; set; }
    }

    public class Obtener_Presencia_PuntoVenta_Request
    {
        [JsonProperty("a")]
        public string codEquipo { get; set; }

        [JsonProperty("b")]
        public string reportsPlanning { get; set; }

        [JsonProperty("c")]
        public string codPtoVenta { get; set; }
    }

    public class Obtener_Presencia_PuntoVenta_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Presencia_PDV> listaPresenciaPDV { get; set; }
    }

    public class Obtener_ElemVisibilidad_PuntoVenta_Request
    {
        [JsonProperty("a")]
        public string codEquipo { get; set; }

        [JsonProperty("b")]
        public string reportsPlanning { get; set; }

        [JsonProperty("c")]
        public string codPtoVenta { get; set; }
    }

    public class Obtener_ElemVisibilidad_PuntoVenta_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_ElemVisibilidad_PDV> listaElemVisibilidadPDV { get; set; }
    }

    public class Obtener_Venta_PuntoVenta_Request
    {
        [JsonProperty("a")]
        public string codEquipo { get; set; }

        [JsonProperty("b")]
        public string reportsPlanning { get; set; }

        [JsonProperty("c")]
        public string codPtoVenta { get; set; }
    }

    public class Obtener_Venta_PuntoVenta_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Ventas_PDV> listaVentaPDV { get; set; }
    }

    public class Obtener_Foto_PuntoVenta_Request
    {
        [JsonProperty("a")]
        public string reportsPlanning { get; set; }

        [JsonProperty("b")]
        public string codPtoVenta { get; set; }
    }

    public class Obtener_Foto_PuntoVenta_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_Foto_PDV fotoPDV { get; set; }
    }

    public class Obtener_HistorialFoto_PuntoVenta_Request
    {
        [JsonProperty("a")]
        public string reportsPlanning { get; set; }

        [JsonProperty("b")]
        public string codPtoVenta { get; set; }
    }

    public class Obtener_HistorialFoto_PuntoVenta_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_HistorialFoto_PDV> listaHistorialFotoPDV { get; set; }
    }

    public class Obtener_Departamento_Por_CodPais_Request
    {
        [JsonProperty("a")]
        public string codPais { get; set; }
    }

    public class Obtener_Departamento_Por_CodPais_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Departamento> listaDeparamentos { get; set; }
    }

    public class Obtener_Distrito_Por_CodSector_Request
    {
        [JsonProperty("a")]
        public string codPais { get; set; }

        [JsonProperty("b")]
        public string codDepartamento { get; set; }

        [JsonProperty("c")]
        public string codProvincia { get; set; }

        [JsonProperty("d")]
        public string codSector { get; set; }
    }

    public class Obtener_Distrito_Por_CodSector_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Distrito> listaDistritos { get; set; }
    }


    public class PresenciaZonaDistritoMap_Request
    {
        [JsonProperty("a")]
        public string codCanal { get; set; }

        [JsonProperty("b")]
        public string codDepartamento { get; set; }

        [JsonProperty("c")]
        public string codProvincia { get; set; }

        [JsonProperty("d")]
        public string codCategoria { get; set; }

        [JsonProperty("e")]
        public string codProducto { get; set; }

        [JsonProperty("f")]
        public string codPeriodo { get; set; }

        [JsonProperty("g")]
        public string opcion { get; set; }

    }
    public class PresenciaZonaDistritoMap_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_PresenciaZonaDistritoMap> ListPresenciaZonaDistritoMap { get; set; }
    }
}

