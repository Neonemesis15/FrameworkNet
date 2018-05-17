using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using Lucky.Data.Common.JavaMovil;

namespace Lucky.Business.Common.JavaMovil
{
    public class BL_AppMovil
    {
        private static readonly D_AppMovil oD_Marcacion = new D_AppMovil();

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
                throw new Exception();
            }

        }

        public E_AppMovil_Sincronizar Sincronizar_Mov(string person_id, int cliente, string equipo)
        {
            Lucky.Entity.Common.Application.JavaMovil.E_AppMovil_Sincronizar esincronizar = null;
            try
            {
                //using (System.Transactions.TransactionScope tx = new System.Transactions.TransactionScope())
                //{
                esincronizar = oD_Marcacion.Sincronizar_Mov(person_id, cliente, equipo);
                //    tx.Complete();
                //}
                if (esincronizar == null)
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {                
                throw new Exception();
            }

            return esincronizar;
        }

        public void RegistrarPedido_Mov(List<E_Pedido_Cab> oE_Pedido_Cab)
        {
            try
            {
                //using (System.Transactions.TransactionScope tx = new System.Transactions.TransactionScope())
                //{
                oD_Marcacion.RegistrarPedido_Mov(oE_Pedido_Cab);
                //tx.Complete();
                //}                
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }


        public void Cobrar_Mov(int codigo)
        {
            try
            {
                //using (System.Transactions.TransactionScope tx = new System.Transactions.TransactionScope())
                //{
                oD_Marcacion.Cobrar_Mov(codigo);
                //tx.Complete();
                //}                
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }
    }
}
