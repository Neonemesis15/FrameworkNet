using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace LuckyMer.Contracts.ServiceContract
{
    [ServiceContract()]
    public interface IReporteService
    {
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "ReporteColgateMayorista")]
        string ReporteColgateMayorista(string DatosReporte);
    }
}
