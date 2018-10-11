using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace LuckyMer.Contracts.ServiceContract
{
    [ServiceContract()]
    public interface IEstadoService
    {
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "RegistrarVisita", BodyStyle = WebMessageBodyStyle.Bare)]
        string RegistrarVisita(string DatosAcceso);

        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "RegistrarMarcacion", BodyStyle = WebMessageBodyStyle.Bare)]
        string RegistrarMarcacion(string DatosAcceso);
    }
}