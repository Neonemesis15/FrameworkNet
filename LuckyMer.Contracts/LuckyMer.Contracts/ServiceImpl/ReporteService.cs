using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Business.Common.JavaMovil;
using LuckyMer.Contracts.ServiceContract;
using Lucky.CFG.JavaMovil;

namespace LuckyMer.Contracts.ServiceImpl
{
    public class ReporteService : IReporteService
    {
        private readonly static BL_ReportesColgate_May reportesColgateBLL = new BL_ReportesColgate_May();

        public string ReporteColgateMayorista(string ListaReporte)
        {
            DataContract.ReporteServiceRequest request = HelperJson.Deserialize<DataContract.ReporteServiceRequest>(ListaReporte);
            DataContract.ReporteServiceResponse response = new DataContract.ReporteServiceResponse();
            try
            {
                //reportesColgateBLL.registrarPresencia_May(request.ListaReportePresencia, request.ListaReporteFotografico, request.Visita);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.ReporteServiceResponse>(response);
            return responseJSON;
        }
    }
}
