using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LuckyMer.Contracts.ServiceContract;
using Lucky.Entity.Common.Application.JavaMovil;
using Lucky.CFG.JavaMovil;
using Lucky.Business.Common.JavaMovil;

namespace LuckyMer.Contracts.ServiceImpl
{
    public class UsuarioService : IUsuarioService
    {
        private readonly static UsuarioBLL usuarioBLL = new UsuarioBLL();
        public string Login(string DatosAcceso)
        {
            DataContract.UsuarioServiceRequest request = HelperJson.Deserialize<DataContract.UsuarioServiceRequest>(DatosAcceso);
            DataContract.UsuarioServiceResponse response = new DataContract.UsuarioServiceResponse();
            try
            {
                EUsuario usuario = usuarioBLL.Login(request.Usuario, request.Password);
                response.Usuario = usuario;
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "Usuario y/o password inválido.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.UsuarioServiceResponse>(response);
            return responseJSON;
        }

        public string LoginAuditoria(string DatosAcceso)
        {
            DataContract.UsuarioServiceRequest request = HelperJson.Deserialize<DataContract.UsuarioServiceRequest>(DatosAcceso);
            DataContract.UsuarioAuditoriaServiceResponse response = new DataContract.UsuarioAuditoriaServiceResponse();
            try
            {
                EUsuarioAuditoria usuario = usuarioBLL.LoginAuditoria(request.Usuario, request.Password);
                response.Usuario = usuario;
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Usuario y/o password inválido.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.UsuarioAuditoriaServiceResponse>(response);
            return responseJSON;
        }
    }
}
