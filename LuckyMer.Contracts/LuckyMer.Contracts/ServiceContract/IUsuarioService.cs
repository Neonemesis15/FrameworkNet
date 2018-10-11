using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace LuckyMer.Contracts.ServiceContract
{
    [ServiceContract()]
    public interface IUsuarioService
    {
        [OperationContract()]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "Login", BodyStyle = WebMessageBodyStyle.Bare)]
        string Login(string DatosAcceso);

        [OperationContract()]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "LoginAuditoria")]
        string LoginAuditoria(string DatosAcceso);
    }
}
