using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using System.Data;
using System.Data.SqlClient;

namespace Lucky.Data.Common.JavaMovil
{
    public class D_Sincronizar_Bodega
    {
        private Conexion oConn;
        public D_Sincronizar_Bodega()
        {
            UserInterface oUserInterface = new UserInterface();
            oUserInterface = null;
        }

        public E_Sincronizar_Bodega Sincronizar(string equipo, string perfil, string cliente, string username)
        {
            oConn = new Conexion(2);
            SqlDataReader readerSinc = oConn.ejecutarDataReader("SP_JVM_SINCRONIZAR_BODEGA_02", equipo, perfil, cliente, username);

            List<E_Presencia> listaPresencia = new List<E_Presencia>();
            List<E_ParametroBodega> listaParametroBodega = new List<E_ParametroBodega>();
            List<E_Cluster> listaCluster = new List<E_Cluster>();
            List<E_Bodega> listaBodega = new List<E_Bodega>();
            List<E_Pregunta> listaPregunta = new List<E_Pregunta>();
            List<E_Opcion> listaOpcion = new List<E_Opcion>();

            while (readerSinc.Read())
            {
                E_Presencia ePresencia = new E_Presencia();
                ePresencia.Cod_Producto = readerSinc.GetValue(readerSinc.GetOrdinal("COD_PRODUCTO")).ToString().Trim();
                ePresencia.Prod_Nombre = readerSinc.GetValue(readerSinc.GetOrdinal("PRO_NOMBRE")).ToString().Trim();
                listaPresencia.Add(ePresencia);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                E_ParametroBodega eParametroBodega = new E_ParametroBodega();
                eParametroBodega.Codigo = readerSinc.GetValue(readerSinc.GetOrdinal("Codigo")).ToString().Trim();
                eParametroBodega.CodigoTabla = readerSinc.GetValue(readerSinc.GetOrdinal("CodigoTabla")).ToString().Trim();
                eParametroBodega.Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Descripcion")).ToString().Trim();
                listaParametroBodega.Add(eParametroBodega);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                E_Cluster eCluster = new E_Cluster();
                eCluster.Cod_cluster = readerSinc.GetValue(readerSinc.GetOrdinal("COD_CLUSTER")).ToString().Trim();
                eCluster.Pregunta = readerSinc.GetValue(readerSinc.GetOrdinal("PREGUNTA")).ToString().Trim();
                eCluster.Req_Cantidad = Convert.ToInt32(readerSinc.GetBoolean(readerSinc.GetOrdinal("Req_Cantidad")));
                listaCluster.Add(eCluster);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                E_Bodega eBodega = new E_Bodega();
                eBodega.CodCliente = readerSinc.GetValue(readerSinc.GetOrdinal("CodCliente")).ToString().Trim();
                eBodega.Nombre = readerSinc.GetValue(readerSinc.GetOrdinal("Nombre")).ToString().Trim();
                eBodega.Direccion = readerSinc.GetValue(readerSinc.GetOrdinal("Direccion")).ToString().Trim();
                listaBodega.Add(eBodega);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                E_Pregunta ePregunta = new E_Pregunta();
                ePregunta.Id_preg = readerSinc.GetValue(readerSinc.GetOrdinal("Id_preg")).ToString().Trim();
                //ePregunta.Id_Opcion = readerSinc.GetValue(readerSinc.GetOrdinal("IdSku")).ToString().Trim();
                ePregunta.Pregunta_Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Pregunta_Descripcion")).ToString().Trim();
                ePregunta.Show = readerSinc.GetValue(readerSinc.GetOrdinal("Show")).ToString().Trim();
                ePregunta.TipoPregunta = readerSinc.GetValue(readerSinc.GetOrdinal("TipoPregunta")).ToString().Trim();
                listaPregunta.Add(ePregunta);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                E_Opcion eOpcion = new E_Opcion();
                eOpcion.Id_Opcion = readerSinc.GetValue(readerSinc.GetOrdinal("Id_Opcion")).ToString().Trim();
                eOpcion.Id_Preg = readerSinc.GetValue(readerSinc.GetOrdinal("Id_Preg")).ToString().Trim();
                eOpcion.Opcion_Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Opcion_Descripcion")).ToString().Trim();
                listaOpcion.Add(eOpcion);
            }

            readerSinc.Close();

            foreach (E_Pregunta prg in listaPregunta)
            { 
                List<E_Opcion> listaOpciones = new List<E_Opcion>();
                foreach(E_Opcion opc in listaOpcion)
                {
                    if (prg.Id_preg.CompareTo(opc.Id_Preg) == 0)
                    {
                        listaOpciones.Add(opc);
                    }
                }
                prg.Id_Opcion = listaOpciones;
            }



            E_Sincronizar_Bodega eSincronizarBodega = new E_Sincronizar_Bodega();
            eSincronizarBodega.ListaBodega = listaBodega;
            eSincronizarBodega.ListaCluster = listaCluster;
            eSincronizarBodega.ListaParametroBodega = listaParametroBodega;
            eSincronizarBodega.ListaPregunta = listaPregunta;
            eSincronizarBodega.ListaPresencia = listaPresencia;
            //eSincronizarBodega.ListaOpcion = listaOpcion;

            return eSincronizarBodega;
        }
    }
}
