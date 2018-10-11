using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using Lucky.Business.Common.Exceptions;
using Lucky.Entity.Common.Application.JavaMovil;
using Lucky.Data.Common.JavaMovil;
using Lucky.Data.Common.JavaMovil.Impl;

namespace Lucky.Business.Common.JavaMovil
{
    /// <summary>
    /// Class: BL_Sincronizar.cs
    /// Developed by: 
    /// - Pablo Salas Alvarez (PSA)
    /// Changes:
    /// - 2018-10-11 (PSA) Add comments.
    /// </summary>
    public class BL_Sincronizar
    {
        // Instancias el Objecto Ilog
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_Sincronizar));
        
        // Activar el Log por Debug
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;

        // Instanciar el Objeto D_Sincronizar 
        private static readonly D_Sincronizar dSincronizar = new D_Sincronizar();

        // Objeto String Result para capturar errores controlados
        String result;

        // Objecto Estado
        List<E_Estado> list;

        /// <summary>
        /// Retorna la información que se utilizará como Base de Datos para el App Mobile.
        /// </summary>
        /// <param name="person_id"> Identificador de Persona </param>
        /// <param name="cliente_id"> Identificador de Cliente </param>
        /// <param name="equipo_id"> Identificador de Equipo(Planning) </param>
        /// <returns>E_Sincronizar</returns>  Un Objecto E_Sincronizar que contiene toda la información q
        /// que necesita el App Mobile para funcionar.
        public E_Sincronizar Sincronizar_Mov(string person_id, int cliente_id, string equipo_id)
        {
            // Instanciar la Entidad E_Sincronizar
            E_Sincronizar esincronizar = new E_Sincronizar();

            try
            {
                // Llamar al método Sicronizar del Data Access
                esincronizar = dSincronizar.Sincronizar_Mov(person_id, cliente_id, equipo_id);
                
                // Lanzar una Excepción en caso la respuesta sea null
                if (esincronizar == null) throw new Exception();
            }
            catch (Exception ex)
            {
                log.Error("[SincronizarBL] [Sincronizar_Mov_Failed] :" + ex.Message);
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
