using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using Lucky.Data.Common.JavaMovil;
using Lucky.Business.Common.Exceptions;

namespace Lucky.Business.Common.JavaMovil
{
    public class SincronizarBLL
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(SincronizarBLL));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly DSincronizar dSincronizar = new DSincronizar();
        private static readonly D_Sincronizar_Bodega  dSincronizarBodega = new D_Sincronizar_Bodega();

        public Lucky.Entity.Common.Application.JavaMovil.ESincronizar Sincronizar(string person_id, string cliente, string equipo)
        {
            Lucky.Entity.Common.Application.JavaMovil.ESincronizar esincronizar = null;
            try
            {
                using (System.Transactions.TransactionScope tx = new System.Transactions.TransactionScope())
                {
                    esincronizar = dSincronizar.Sincronizar(person_id, cliente, equipo);
                    tx.Complete();
                }
                if (esincronizar == null)
                {
                    throw new NegocioAmbienteException();
                }
            }
            catch (Exception ex)
            {
                log.Error("[SincronizarBLL] [Sincronizar] :"+ ex.Message);
                throw new NegocioAmbienteException();
            }

            return esincronizar;
        }

        public Lucky.Entity.Common.Application.JavaMovil.ESincronizarAuditoria SincronizarAudtioria(string person_id, string equipo)
        {
            Lucky.Entity.Common.Application.JavaMovil.ESincronizarAuditoria esincronizar = null;
            try
            {
                using (System.Transactions.TransactionScope tx = new System.Transactions.TransactionScope())
                {
                    esincronizar = dSincronizar.SincronizarAuditoria(person_id, equipo);
                    tx.Complete();
                }
                if (esincronizar == null)
                {
                    throw new NegocioAmbienteException();
                }
            }
            catch (Exception ex)
            {
                log.Error("[SincronizarBLL] [SincronizarAuditoria] :" + ex.Message);
                throw new NegocioAmbienteException();
            }

            return esincronizar;
        }

        public Lucky.Entity.Common.Application.JavaMovil.E_Sincronizar_Bodega SincronizarBodega(string equipo, string perfil, string cliente, string username)
        {
            Lucky.Entity.Common.Application.JavaMovil.E_Sincronizar_Bodega esincronizarbodega = null;
            try
            {
                using (System.Transactions.TransactionScope tx = new System.Transactions.TransactionScope())
                {
                    esincronizarbodega = dSincronizarBodega.Sincronizar(equipo, perfil, cliente, username);
                    tx.Complete();
                }
                if (esincronizarbodega == null)
                {
                    throw new NegocioAmbienteException();
                }
            }
            catch (Exception ex)
            {
                log.Error("[SincronizarBLL] [SincronizarBodega] :" + ex.Message);
                throw new NegocioAmbienteException();
            }

            return esincronizarbodega;
        }
        
        //Add 16/03/2012 pSalas. Sincronizar Android (Prueba)
        public Lucky.Entity.Common.Application.JavaMovil.ESincronizar Sincronizar_Android() {
            Lucky.Entity.Common.Application.JavaMovil.ESincronizar oESincronizar = null;
            try
            {
                using (System.Transactions.TransactionScope tx = new System.Transactions.TransactionScope())
                {
                    oESincronizar = dSincronizar.Sincronizar_Android();
                    tx.Complete();
                }
                if (oESincronizar == null)
                {
                    throw new NegocioAmbienteException();
                }
            }
            catch (Exception ex)
            {
                log.Error("[SincronizarBLL] [SincronizarAndroid] :" + ex.Message);
                throw new NegocioAmbienteException();
            }

            return oESincronizar;
        }

    }
}