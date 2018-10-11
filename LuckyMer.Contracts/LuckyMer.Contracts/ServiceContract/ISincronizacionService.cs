using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace LuckyMer.Contracts.ServiceContract
{
    [ServiceContract()]
    public interface ISincronizacionService
    {
        [OperationContract()]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "Sincronizar", BodyStyle = WebMessageBodyStyle.Bare)]
        string Sincronizar(string DatosSincronizacion);

        [OperationContract()]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "SincronizarAuditoria")]
        string SincronizarAuditoria(string datosSincronizacionRq);
    }
}
