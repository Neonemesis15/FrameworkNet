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
    public class BL_Marcacion
    {
        public BL_Marcacion() { }


        private static readonly ILog log = LogManager.GetLogger(typeof(BL_Marcacion));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly  D_Marcacion oD_Marcacion = new D_Marcacion();
    
        public void registrarMarcacion(E_Marcacion oE_Marcacion){
            try{
                    oD_Marcacion.RegistrarMarcacion(oE_Marcacion);
            }
            catch(Exception ex){
                    log.Error("[BL_Marcacion] [RegistrarMarcacion_Failed]:", ex);
            }
        
        }

        public void RegistrarMarcacion_Mov(E_Marcacion oE_Marcacion)
        {
            try
            {
                //using (System.Transactions.TransactionScope tx = new System.Transactions.TransactionScope())
                //{
                    oD_Marcacion.RegistrarMarcacion_Mov(oE_Marcacion);
                    //tx.Complete();
                //}                
            }
            catch (Exception ex)
            {
                log.Error("[BL_Marcacion] [RegistrarMarcacion_Mov_Failed]:", ex);
                throw new Exception(); 
            }

        }
    }
}
