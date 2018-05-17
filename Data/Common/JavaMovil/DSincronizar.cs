using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using System.Data;
using System.Data.SqlClient;

namespace Lucky.Data.Common.JavaMovil
{
    public class DSincronizar
    {
        private Conexion oConn;
        public DSincronizar()
        {
            UserInterface oUserInterface = new UserInterface();
            oUserInterface = null;
        }

        public ESincronizar Sincronizar(string person_id, string cliente, string equipo)
        {
            oConn = new Conexion(2);
            SqlDataReader readerSinc = oConn.ejecutarDataReader("SP_JVM_SINCRONIZAR", equipo, cliente, person_id);

            List<EPuntoVenta> listaPuntoVenta = new List<EPuntoVenta>();
            List<EReporte> listaReporte = new List<EReporte>();
            List<ECategoria> listaCategoria = new List<ECategoria>();
            List<EMarca> listaMarca = new List<EMarca>();
            List<EProducto> listaProducto = new List<EProducto>();
            List<EEstado> listaEstado = new List<EEstado>();
            List<EMotivo> listaMotivo = new List<EMotivo>();
            List<EParametro> listaParametro = new List<EParametro>();
            //Add Joseph Gonzales 07/03/2012
            List<E_Empresa> listaEmpresa = new List<E_Empresa>();
            List<E_Observacion> listaObservacion = new List<E_Observacion>();
            List<E_Promocion> listaPromocion = new List<E_Promocion>();
            List<E_Tipo_Material_POP> listaTipoMaterialPOP = new List<E_Tipo_Material_POP>();
            List<E_Material_POP> listaMaterialPOP = new List<E_Material_POP>();
            List<E_Cluster> listaCluster = new List<E_Cluster>();   //Add 27/03/2012 pSalas
            List<E_NoVisita> listaNoVisita = new List<E_NoVisita>();

            while (readerSinc.Read())
            {
                EPuntoVenta ePuntoVenta = new EPuntoVenta();
                ePuntoVenta.Codigo = readerSinc.GetValue(readerSinc.GetOrdinal("Codigo")).ToString().Trim();
                ePuntoVenta.RazonSocial = readerSinc.GetValue(readerSinc.GetOrdinal("RazSocial")).ToString().Trim();
                ePuntoVenta.Direccion = readerSinc.GetValue(readerSinc.GetOrdinal("Direccion")).ToString().Trim();
                ePuntoVenta.NombreCadena = readerSinc.GetValue(readerSinc.GetOrdinal("NomCadena")).ToString().Trim();
                ePuntoVenta.NombreCanal = readerSinc.GetValue(readerSinc.GetOrdinal("NomCanal")).ToString().Trim();
                ePuntoVenta.TipoMercado = readerSinc.GetValue(readerSinc.GetOrdinal("TipMercado")).ToString().Trim();
                ePuntoVenta.CodigoCadena = readerSinc.GetValue(readerSinc.GetOrdinal("Id_Cadena")).ToString().Trim();//Add 29/03/2012 pSalas
                listaPuntoVenta.Add(ePuntoVenta);
            }
            
            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                EReporte eReporte = new EReporte();
                eReporte.IdOpReporte = readerSinc.GetValue(readerSinc.GetOrdinal("IdOpReporte")).ToString().Trim();
                eReporte.IdCanal = readerSinc.GetValue(readerSinc.GetOrdinal("IdCanal")).ToString().Trim();
                eReporte.IdReporte = readerSinc.GetValue(readerSinc.GetOrdinal("IdReporte")).ToString().Trim();
                eReporte.IdTipoReporte = readerSinc.GetValue(readerSinc.GetOrdinal("IdTipoReporte")).ToString().Trim();
                eReporte.VistaCategoria = readerSinc.GetBoolean(readerSinc.GetOrdinal("VistaCategoria")) ? 1 : 0;
                eReporte.VistaCategoria = readerSinc.GetBoolean(readerSinc.GetOrdinal("VistaCategoria")) ? 1 : 0;
                eReporte.VistaMarca = readerSinc.GetBoolean(readerSinc.GetOrdinal("VistaMarca")) ? 1 : 0;
                eReporte.VistaSubMarca = readerSinc.GetBoolean(readerSinc.GetOrdinal("VistaSubMarca")) ? 1 : 0;
                eReporte.VistaFamilia = readerSinc.GetBoolean(readerSinc.GetOrdinal("VistaFamilia")) ? 1 : 0;
                eReporte.VistaProducto = readerSinc.GetBoolean(readerSinc.GetOrdinal("VistaProducto")) ? 1 : 0;
                listaReporte.Add(eReporte);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                ECategoria eCategoria = new ECategoria();
                eCategoria.IdReporte = readerSinc.GetValue(readerSinc.GetOrdinal("IdReporte")).ToString().Trim();
                eCategoria.IdCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("IdCategoria")).ToString().Trim();
                eCategoria.CategoriaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("Nombre")).ToString().Trim().Replace("&amp;","y");
                eCategoria.LongitudCadena = readerSinc.GetValue(readerSinc.GetOrdinal("LongCad")).ToString().Trim();
                listaCategoria.Add(eCategoria);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                EMarca eMarca = new EMarca();
                eMarca.IdReporte = readerSinc.GetValue(readerSinc.GetOrdinal("IdReporte")).ToString().Trim();
                eMarca.IdMarca = readerSinc.GetValue(readerSinc.GetOrdinal("IdMarca")).ToString().Trim();
                eMarca.Nombre = readerSinc.GetValue(readerSinc.GetOrdinal("Nombre")).ToString().Trim().Replace("&amp;", "y");
                eMarca.IdCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("IdCategoria")).ToString().Trim();
                eMarca.LongitudCad = readerSinc.GetValue(readerSinc.GetOrdinal("LongCad")).ToString().Trim();
                eMarca.MarcaPropia = readerSinc.GetValue(readerSinc.GetOrdinal("MarPropio")).ToString().Trim();
                listaMarca.Add(eMarca);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                EProducto eProducto = new EProducto();
                eProducto.IdReporte = readerSinc.GetValue(readerSinc.GetOrdinal("IdReporte")).ToString().Trim();
                eProducto.IdSKU = readerSinc.GetValue(readerSinc.GetOrdinal("IdSku")).ToString().Trim();
                eProducto.CodigoProducto = readerSinc.GetValue(readerSinc.GetOrdinal("IdProducto")).ToString().Trim();
                eProducto.NombreProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Nombre")).ToString().Trim().Replace("&amp;", "y");
                eProducto.CategoriaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("IdCategoria")).ToString().Trim();
                eProducto.MarcaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("IdMarca")).ToString().Trim();
                eProducto.FamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("IdFamilia")).ToString().Trim();
                eProducto.SubFamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("IdSubFamilia")).ToString().Trim();
                eProducto.FlagMandatorio = readerSinc.GetValue(readerSinc.GetOrdinal("FlagMandatorio")).ToString().Trim();
                eProducto.Propio = readerSinc.GetValue(readerSinc.GetOrdinal("Propio")).ToString().Trim();//Add 12/03/2012 para saber si el Producto es Propio o de la Competencia. pSalas.
                eProducto.Id_Cliente = readerSinc.GetValue(readerSinc.GetOrdinal("Id_Cliente")).ToString().Trim();//Add 14/03/2012 
                listaProducto.Add(eProducto);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                EEstado eEstado = new EEstado();
                eEstado.Codigo = readerSinc.GetValue(readerSinc.GetOrdinal("Codigo")).ToString().Trim();
                eEstado.Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Descripcion")).ToString().Trim();
                listaEstado.Add(eEstado);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                EMotivo eMotivo = new EMotivo();
                eMotivo.Codigo = readerSinc.GetValue(readerSinc.GetOrdinal("Codigo")).ToString().Trim();
                eMotivo.CodigoEstado = readerSinc.GetValue(readerSinc.GetOrdinal("CodEstado")).ToString().Trim();
                eMotivo.Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Descripcion")).ToString().Trim();
                listaMotivo.Add(eMotivo);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                EParametro eParametro = new EParametro();
                eParametro.CodigoTabla = readerSinc.GetInt32(readerSinc.GetOrdinal("CodigoTabla"));
                eParametro.Codigo = readerSinc.GetValue(readerSinc.GetOrdinal("Codigo")).ToString().Trim();
                eParametro.Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Descripcion")).ToString().Trim();
                eParametro.Valor = readerSinc.GetValue(readerSinc.GetOrdinal("valor")).ToString().Trim();
                listaParametro.Add(eParametro);
            }

            //Add Joseph Gonzales 07/03/2012
            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                E_Observacion eObservacion = new E_Observacion();
                eObservacion.Codigo = readerSinc.GetValue(readerSinc.GetOrdinal("ID_OBS")).ToString().Trim();
                eObservacion.Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("OBS_DESCRIPCION")).ToString().Trim();
                listaObservacion.Add(eObservacion);
            }

            //Add Joseph Gonzales 07/03/2012
            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                E_Tipo_Material_POP eTipoMaterialPOP = new E_Tipo_Material_POP();
                eTipoMaterialPOP.Codigo = readerSinc.GetValue(readerSinc.GetOrdinal("ID_TMATERIAL")).ToString().Trim();
                eTipoMaterialPOP.Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("TM_DESCRIPCION")).ToString().Trim();
                listaTipoMaterialPOP.Add(eTipoMaterialPOP);
            }

            //Add Joseph Gonzales 07/03/2012
            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                E_Material_POP eMaterialPOP = new E_Material_POP();
                //eMaterialPOP.PtoVenta = readerSinc.GetValue(readerSinc.GetOrdinal("ID_PTOVENTA")).ToString().Trim();
                eMaterialPOP.CodTipoMaterial = readerSinc.GetValue(readerSinc.GetOrdinal("ID_TMATERIAL")).ToString().Trim();
                eMaterialPOP.CodPOP = readerSinc.GetValue(readerSinc.GetOrdinal("ID_POP")).ToString().Trim();
                eMaterialPOP.DescPOP = readerSinc.GetValue(readerSinc.GetOrdinal("POP_DESCRIPCION")).ToString().Trim();
                eMaterialPOP.Propio = readerSinc.GetValue(readerSinc.GetOrdinal("PROPIO")).ToString().Trim();
                listaMaterialPOP.Add(eMaterialPOP);
            }

            //Add Joseph Gonzales 07/03/2012
            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                E_Promocion ePromocion = new E_Promocion();
                //ePromocion.CodEmpresa = readerSinc.GetValue(readerSinc.GetOrdinal("ID_CLIENTE")).ToString().Trim();
                ePromocion.CodPromocion = readerSinc.GetValue(readerSinc.GetOrdinal("ID_PROMOCION")).ToString().Trim();
                ePromocion.DescPromocion = readerSinc.GetValue(readerSinc.GetOrdinal("NOMBRE")).ToString().Trim();
                //ePromocion.CodCadena = readerSinc.GetValue(readerSinc.GetOrdinal("ID_CADENA")).ToString().Trim();//Add 29/03/2012 pSalas 
                listaPromocion.Add(ePromocion);
            }

            //Add Joseph Gonzales 07/03/2012
            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                E_Empresa eEmpresa = new E_Empresa();
                eEmpresa.Codigo = readerSinc.GetValue(readerSinc.GetOrdinal("ID_COMPETIDORA")).ToString().Trim();
                eEmpresa.Nombre = readerSinc.GetValue(readerSinc.GetOrdinal("COM_NOMBRE")).ToString().Trim().Replace("&amp;", "y");
                listaEmpresa.Add(eEmpresa);
            }

            //Sincroniza Cluster pSalas 27/03/2012
            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                E_Cluster eCluster = new E_Cluster();
                eCluster.Cod_cluster = readerSinc.GetValue(readerSinc.GetOrdinal("COD_CLUSTER")).ToString().Trim();
                eCluster.Pregunta = readerSinc.GetValue(readerSinc.GetOrdinal("PREGUNTA")).ToString().Trim();
                //eCluster.Req_Cantidad = readerSinc.GetValue(readerSinc.GetOrdinal("REQ_CANTIDAD")).ToString().Trim();
                listaCluster.Add(eCluster);
            }

            //Sincroniza Motivo de No Visita pSalas 27/03/2012
            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                E_NoVisita eNoVisita = new E_NoVisita();
                eNoVisita.Id_noVisita = readerSinc.GetValue(readerSinc.GetOrdinal("ID_NOVISITA")).ToString().Trim();
                eNoVisita.Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("DESCRIPCION")).ToString().Trim();
                listaNoVisita.Add(eNoVisita);
            }


            readerSinc.Close();

            ESincronizar eSincronizar = new ESincronizar();
            eSincronizar.ListaPuntoVenta = listaPuntoVenta;
            eSincronizar.ListaOpcionReporte = listaReporte;
            eSincronizar.listaCategoria = listaCategoria;
            eSincronizar.listaMarca = listaMarca;
            eSincronizar.listaProducto = listaProducto;
            eSincronizar.listaEstado = listaEstado;
            eSincronizar.listaMotivo = listaMotivo;
            eSincronizar.listaParametro = listaParametro;
            eSincronizar.listaObservacion = listaObservacion;
            eSincronizar.listaPromocion = listaPromocion;
            eSincronizar.listaEmpresa = listaEmpresa;
            eSincronizar.listaTipoMaterialPOP = listaTipoMaterialPOP;
            eSincronizar.listaMaterialPOP = listaMaterialPOP;
            eSincronizar.listaCluster = listaCluster;       //Add pSalas 27/03/2012
            eSincronizar.listaNoVisita = listaNoVisita;     //Add pSalas 27/03/2012

            return eSincronizar;


        }

        public ESincronizarAuditoria SincronizarAuditoria(string person_id, string equipo)
        {
            oConn = new Conexion(2);
            SqlDataReader readerSinc = oConn.ejecutarDataReader("SP_JVM_AUDITORIA_SINCRONIZAR", equipo, person_id);

            List<ECliente> listaCliente = new List<ECliente>();
            List<EReporteAuditoria> listaReporte = new List<EReporteAuditoria>();
            List<ECanal> listaCanal = new List<ECanal>();
            List<EPuntoVentaAuditoria> listaPtoVenta = new List<EPuntoVentaAuditoria>();
            List<EEstado> listaEstado = new List<EEstado>();
            List<EMotivo> listaMotivo = new List<EMotivo>();
            List<EParametro> listaParametro = new List<EParametro>();
            
            while (readerSinc.Read())
            {
                ECliente eCliente = new ECliente();
                eCliente.Codigo = readerSinc.GetValue(readerSinc.GetOrdinal("ID")).ToString().Trim();
                eCliente.RazonSocial = readerSinc.GetValue(readerSinc.GetOrdinal("NOMBRE")).ToString().Trim();
                listaCliente.Add(eCliente);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                EReporteAuditoria eReporte = new EReporteAuditoria();
                eReporte.Codigo = readerSinc.GetValue(readerSinc.GetOrdinal("ID")).ToString().Trim();
                eReporte.Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("DSC")).ToString().Trim();
                eReporte.TipoReporte = readerSinc.GetValue(readerSinc.GetOrdinal("TIPO")).ToString().Trim();
                listaReporte.Add(eReporte);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                ECanal eCanal = new ECanal();
                eCanal.Codigo = readerSinc.GetValue(readerSinc.GetOrdinal("ID")).ToString().Trim();
                eCanal.Nombre = readerSinc.GetValue(readerSinc.GetOrdinal("NOMBRE")).ToString().Trim();
                listaCanal.Add(eCanal);
            }
            
            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                EPuntoVentaAuditoria ePuntoVenta = new EPuntoVentaAuditoria();
                ePuntoVenta.Codigo = readerSinc.GetValue(readerSinc.GetOrdinal("Codigo")).ToString().Trim();
                ePuntoVenta.RazonSocial = readerSinc.GetValue(readerSinc.GetOrdinal("RazSocial")).ToString().Trim();
                ePuntoVenta.Direccion = readerSinc.GetValue(readerSinc.GetOrdinal("Direccion")).ToString().Trim();                
                ePuntoVenta.NombreCanal = readerSinc.GetValue(readerSinc.GetOrdinal("NomCanal")).ToString().Trim();
                ePuntoVenta.TipoMercado = readerSinc.GetValue(readerSinc.GetOrdinal("TipMercado")).ToString().Trim();
                listaPtoVenta.Add(ePuntoVenta);
            }
            
            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                EEstado eEstado = new EEstado();
                eEstado.Codigo = readerSinc.GetValue(readerSinc.GetOrdinal("Codigo")).ToString().Trim();
                eEstado.Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Descripcion")).ToString().Trim();
                listaEstado.Add(eEstado);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                EMotivo eMotivo = new EMotivo();
                eMotivo.Codigo = readerSinc.GetValue(readerSinc.GetOrdinal("Codigo")).ToString().Trim();
                eMotivo.CodigoEstado = readerSinc.GetValue(readerSinc.GetOrdinal("CodEstado")).ToString().Trim();
                eMotivo.Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Descripcion")).ToString().Trim();
                listaMotivo.Add(eMotivo);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                EParametro eParametro = new EParametro();
                eParametro.CodigoTabla = readerSinc.GetInt32(readerSinc.GetOrdinal("CodigoTabla"));
                eParametro.Codigo = readerSinc.GetValue(readerSinc.GetOrdinal("Codigo")).ToString().Trim();
                eParametro.Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Descripcion")).ToString().Trim();
                eParametro.Valor = readerSinc.GetValue(readerSinc.GetOrdinal("valor")).ToString().Trim();
                listaParametro.Add(eParametro);
            }
            readerSinc.Close();

            ESincronizarAuditoria eSincronizar = new ESincronizarAuditoria();
            eSincronizar.listaCanal = listaCanal;
            eSincronizar.ListaCliente = listaCliente;
            eSincronizar.listaEstado = listaEstado;
            eSincronizar.listaMotivo = listaMotivo;
            eSincronizar.listaParametro = listaParametro;
            eSincronizar.listaPtoVenta = listaPtoVenta;
            eSincronizar.ListaReporte = listaReporte;
            return eSincronizar;

        }

        //Add pSalas 16/03/2012 Sincronizar Android
        public ESincronizar Sincronizar_Android()
        {
            oConn = new Conexion(2);
            SqlDataReader readerSinc = oConn.ejecutarDataReader("SP_JVM_SINCRONIZAR_ANDROID");
            List<EPuntoVenta> listaPuntoVenta = new List<EPuntoVenta>();
            while (readerSinc.Read())
            {
                EPuntoVenta ePuntoVenta = new EPuntoVenta();
                ePuntoVenta.Codigo = readerSinc.GetValue(readerSinc.GetOrdinal("Codigo")).ToString().Trim();
                ePuntoVenta.RazonSocial = readerSinc.GetValue(readerSinc.GetOrdinal("RazSocial")).ToString().Trim();
                ePuntoVenta.Direccion = readerSinc.GetValue(readerSinc.GetOrdinal("Direccion")).ToString().Trim();
                ePuntoVenta.NombreCadena = readerSinc.GetValue(readerSinc.GetOrdinal("NomCadena")).ToString().Trim();
                ePuntoVenta.NombreCanal = readerSinc.GetValue(readerSinc.GetOrdinal("NomCanal")).ToString().Trim();
                ePuntoVenta.TipoMercado = readerSinc.GetValue(readerSinc.GetOrdinal("TipMercado")).ToString().Trim();
                listaPuntoVenta.Add(ePuntoVenta);
            }
            readerSinc.Close();

            ESincronizar eSincronizar = new ESincronizar();
            eSincronizar.ListaPuntoVenta = listaPuntoVenta;
            return eSincronizar;
        }

      

    }
}
