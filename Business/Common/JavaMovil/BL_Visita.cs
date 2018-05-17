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
    public class BL_Visita
    {
        public BL_Visita() { }

        private static readonly ILog log = LogManager.GetLogger(typeof(BL_Visita));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_Visita oD_Visita = new D_Visita();


        public void registrarVisita(E_Visita oE_Visita) {            
            try
            {
                oD_Visita.RegistrarVisita(oE_Visita);
            }
            catch (Exception ex) {
                log.Error("[BL_Visita] [RegistrarVisita_Failed]:", ex);
            }
        }

        public void registrarVisita_Mov(E_Visita_Mov oE_Visita_Mov)
        {
            try
            {
                using (System.Transactions.TransactionScope tx = new System.Transactions.TransactionScope())
                {
                    oD_Visita.RegistrarVisita_Mov(oE_Visita_Mov);
                    tx.Complete();
                }                   
            }
            catch (Exception ex)
            {
                log.Error("[BL_Visita] [registrarVisita_Mov_Failed]:", ex);
                throw new Exception(); 
            }
        }
    
    }
}