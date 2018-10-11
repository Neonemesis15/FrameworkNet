using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LuckyMer.Contracts.ServiceContract;
using Lucky.Entity.Common.Application.JavaMovil;
using Lucky.Business.Common.JavaMovil;
using Lucky.CFG.JavaMovil;

namespace LuckyMer.Contracts.ServiceImpl
{
    public class EstadoService : IEstadoService
    {
        public static BL_Visita blVisita = new BL_Visita();
        public static BL_Marcacion blMarcacion = new BL_Marcacion();

        public string RegistrarMarcacion(string DatosMarcacion)
        {
            DataContract.RegistrarMarcacionRequest request = HelperJson.Deserialize<DataContract.RegistrarMarcacionRequest>(DatosMarcacion);
            DataContract.RegistrarMarcacionResponse response = new DataContract.RegistrarMarcacionResponse();
            try
            {
                blMarcacion.registrarMarcacion(obtenerMarcacion(request));
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.RegistrarMarcacionResponse>(response);
            return responseJSON;
        }

        public string RegistrarVisita(string DatosVisita)
        {
            DataContract.RegistrarVisitaRequest request = HelperJson.Deserialize<DataContract.RegistrarVisitaRequest>(DatosVisita);
            DataContract.RegistrarVisitaResponse response = new DataContract.RegistrarVisitaResponse();
            try
            {
                blVisita.registrarVisita(obtenerVisita(request));
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.RegistrarVisitaResponse>(response);
            return responseJSON;
        }

        private E_Visita obtenerVisita(DataContract.RegistrarVisitaRequest request)
        {
            E_Visita visit = new E_Visita();
            visit.ClienteId = request.ClienteId;
            visit.ClientPDV_Code = request.ClientPDV_Code;
            visit.EquipoId = request.EquipoId;
            visit.FechaFin = request.FechaFin;
            visit.FechaIni = request.FechaIni;
            visit.LatitudFin = request.LatitudFin;
            visit.LatitudInicio = request.LatitudInicio;
            visit.LongitudFin = request.LongitudFin;
            visit.LongitudInicio = request.LongitudInicio;
            visit.NoVisitaId = request.NoVisitaId;
            visit.OrigenFin = request.OrigenFin;
            visit.OrigenInicio = request.OrigenInicio;
            visit.PerfilId = request.PerfilId;
            visit.PersonId = request.PersonId;
            return visit;
        }

        private E_Marcacion obtenerMarcacion(DataContract.RegistrarMarcacionRequest request)
        {
            E_Marcacion marcacion = new E_Marcacion();
            marcacion.ClienteId = request.ClienteId;
            marcacion.EquipoId = request.EquipoId;
            marcacion.EstadoId = request.EstadoId;
            marcacion.FechaFin = request.FechaFin;
            marcacion.FechaIni = request.FechaIni;
            marcacion.LatitudFin = request.LatitudFin;
            marcacion.LatitudInicio = request.LatitudInicio;
            marcacion.LongitudFin = request.LongitudFin;
            marcacion.LongitudInicio = request.LongitudInicio;            
            marcacion.OrigenFin = request.OrigenFin;
            marcacion.OrigenInicio = request.OrigenInicio;
            marcacion.MotivoId = request.MotivoId;
            marcacion.PerfilId = request.PerfilId;
            marcacion.PersonId = request.PersonId;
            return marcacion;
        }
    }
}
