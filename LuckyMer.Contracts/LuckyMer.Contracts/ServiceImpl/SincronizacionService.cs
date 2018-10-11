using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Business.Common.JavaMovil;
using LuckyMer.Contracts.ServiceContract;
using Lucky.CFG.JavaMovil;
using Lucky.Entity.Common.Application.JavaMovil;

namespace LuckyMer.Contracts.ServiceImpl
{
    public class SincronizacionService : ISincronizacionService
    {
        private readonly static SincronizarBLL sincronizarBLL = new SincronizarBLL();

        public string Sincronizar(string DatosSincr)
        {
            DataContract.SincronizacionServiceRequest request = HelperJson.Deserialize<DataContract.SincronizacionServiceRequest>(DatosSincr);
            DataContract.SincronizacionServiceResponse response = new DataContract.SincronizacionServiceResponse();
            try
            {
                ESincronizar eSincronizar = sincronizarBLL.Sincronizar(request.Person_Id, request.Cliente_Id, request.Id_Equipo);
                response.Sincronizar = eSincronizar;
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.SincronizacionServiceResponse>(response);
            return responseJSON;
        }


        public string SincronizarAuditoria(string datosSincronizacionRq)
        {
            DataContract.SincronizacionServiceAuditoriaRequest request = HelperJson.Deserialize<DataContract.SincronizacionServiceAuditoriaRequest>(datosSincronizacionRq);
            DataContract.SincronizacionServiceAuditoriaResponse response = new DataContract.SincronizacionServiceAuditoriaResponse();
            try
            {
                ESincronizarAuditoria eSincronizar = sincronizarBLL.SincronizarAudtioria(request.Person_Id, request.Id_Equipo);
                response.Sincronizar = eSincronizar;
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.SincronizacionServiceAuditoriaResponse>(response);
            return responseJSON;
        }
    }
}
