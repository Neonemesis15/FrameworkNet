using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using Lucky.Data.Common.JavaMovil;
using Lucky.Business.Common.Exceptions;
using log4net;

namespace Lucky.Business.Common.JavaMovil
{
    public class BL_Registrar_Motivo
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_Registrar_Motivo));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_Registrar_Motivo oD_Registrar_Motivo = new D_Registrar_Motivo();

        public void RegistrarMotivoColgateBodega_Mov(E_Registro_MotivoFase oE_Registro_MotivoFase)
        {
            try
            {
                //using (System.Transactions.TransactionScope tx = new System.Transactions.TransactionScope())
                //{
                    oD_Registrar_Motivo.RegistrarMotivoColgateBodega_Mov(oE_Registro_MotivoFase);
                    //tx.Complete();
                //}
            }
            catch (Exception ex)
            {
                log.Error("[BL_Registrar_Motivo] [RegistrarMotivoColgateBodega_Mov_Failed]:", ex);
                throw new Exception();
            }

        }
    }
}