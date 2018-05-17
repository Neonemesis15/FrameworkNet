using System;
using Lucky.Data.Common.Application.Control;
using Lucky.Entity.Common.Application.Control;
using Lucky.Business.Common.Application;

namespace Lucky.Business.Common.Application.Control
{
    /// <summary>
    /// Esta clase es utilizada para dar información sobre la cuenta a la cual 
    /// le llegarán los errores de la aplicación.
    /// </summary>
    public class MensajeriaError
    {
        public MensajeriaError()
        {
            //
            // TODO: agregar aquí la lógica del constructor
            //
        }
        public Lucky.Business.Common.Application.Aplicacion Aplicacion
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        /// <summary>
        /// Permite obtener los datos necesarios para desatar un error de mensajeria.
        /// </summary>
        /// <param name="sOriCod">Código de origen.</param>
        /// <param name="sModCod">Código de módulo</param>
        /// <returns></returns>
        public EMensajeriaError obtener(string sCountry)
        {
            DMensajeriaError odMensajeriaError = new DMensajeriaError();
            EMensajeriaError oeMensajeriaError = odMensajeriaError.obtenerPK(sCountry);
            odMensajeriaError = null;
            return oeMensajeriaError;
        }
    }
}