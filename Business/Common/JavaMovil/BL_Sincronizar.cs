using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using Lucky.Business.Common.Exceptions;
using Lucky.Entity.Common.Application.JavaMovil;
using Lucky.Data.Common.JavaMovil;

namespace Lucky.Business.Common.JavaMovil
{
    public class BL_Sincronizar
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_Sincronizar));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_Sincronizar dSincronizar = new D_Sincronizar();

        public E_Sincronizar Sincronizar_Mov(string person_id, int cliente, string equipo)
        {
            Lucky.Entity.Common.Application.JavaMovil.E_Sincronizar esincronizar = null;
            try
            {
                //using (System.Transactions.TransactionScope tx = new System.Transactions.TransactionScope())
                //{
                esincronizar = dSincronizar.Sincronizar_Mov(person_id, cliente, equipo);
                //    tx.Complete();
                //}
                if (esincronizar == null)
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                log.Error("[SincronizarBLL] [Sincronizar_Mov_Failed] :" + ex.Message);
                throw new Exception();
            }

            return esincronizar;
        }

        public E_SincronizarPreDatos SincronizarPreDatos_Mov(string person_id, int cliente, string equipo)
        {
            Lucky.Entity.Common.Application.JavaMovil.E_SincronizarPreDatos esincronizar = null;
            try
            {
                //using (System.Transactions.TransactionScope tx = new System.Transactions.TransactionScope())
                //{
                esincronizar = dSincronizar.SincronizarPreDatos_Mov(person_id, cliente, equipo);
                //    tx.Complete();
                //}
                if (esincronizar == null)
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                log.Error("[SincronizarBLL] [SincronizarPreDatos_Mov_Failed] :" + ex.Message);
                throw new Exception();
            }

            return esincronizar;
        }
    }
}
