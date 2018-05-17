using System;
using System.Data;
using Lucky.Entity.Common.Application;
using Lucky.Entity.Common.Security;
using Lucky.Entity.Common.Application.Security;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Clase:DNodeType
    /// Creada Por: Ing. Carlos Alberto Hernández Rincón
    /// Fecha de Creacion: 13/06/2009
    /// Descripcion: Define los Metodos transaccionales para la clase NodeType
    /// modificaciones: 26-06-09 se cambia el parametro idNodeComType por int . Ing. Mauricio Ortiz
    /// Requerimiento No: <>
    /// </summary>
    public class DNodeType
    {
         private Conexion oConn;
        public DNodeType()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }
        /// <summary>
        ///Metodo para Registrar Tipos de Node Comercial 
        /// </summary>
       

       public ENodeType RegistrarTypeNode(string snametypenode, bool bstatustypenode, string sCreatebytypenode,
            DateTime tDateBynodetype, string sModiBynodetype, DateTime tDateModiBynodetype) {
                DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_REGISTERTYPENODE", snametypenode, bstatustypenode, sCreatebytypenode,
                    tDateBynodetype, sModiBynodetype, tDateModiBynodetype);
                ENodeType oenodetype = new ENodeType();
                oenodetype.NodeComTypename= snametypenode;
                oenodetype.NodeComTypeStatus= bstatustypenode;
                oenodetype.NodeComTypeCreateBy= sCreatebytypenode;
                oenodetype.NodeComTypeDateBy= tDateBynodetype;
                oenodetype.NodeComTypeModiBy= sModiBynodetype;
                oenodetype.NodeComTypeDateModiBy= tDateModiBynodetype;
                return oenodetype;
                
                
         }
        /// <summary>
        ///Metodo para Consultar Tipos de Node Comercial 
        /// </summary>

       public DataTable ConsultarTypeNode(string snametypenode)
       {

           DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_CONSULTARTYPENODE", snametypenode);
           ENodeType oecnodetype = new ENodeType();
           if (dt != null)
           {
               if (dt.Rows.Count > 0)
               {
                   for (int i = 0; i <= dt.Rows.Count - 1; i++)
                   {
                       oecnodetype.idNodeComType = Convert.ToInt32(dt.Rows[i]["idNodeComType"].ToString().Trim());
                       oecnodetype.NodeComTypename = dt.Rows[i]["NodeComType_name"].ToString().Trim();
                       oecnodetype.NodeComTypeStatus = Convert.ToBoolean(dt.Rows[i]["NodeComType_Status"].ToString().Trim());
                       oecnodetype.NodeComTypeCreateBy = dt.Rows[i]["NodeComType_CreateBy"].ToString().Trim();
                       oecnodetype.NodeComTypeDateBy = Convert.ToDateTime(dt.Rows[i]["NodeComType_DateBy"].ToString().Trim());
                       oecnodetype.NodeComTypeModiBy = dt.Rows[i]["NodeComType_ModiBy"].ToString().Trim();
                       oecnodetype.NodeComTypeDateBy = Convert.ToDateTime(dt.Rows[i]["NodeComType_DateModiBy"].ToString().Trim());
                   }
               }
               return dt;

           }
           else
           {

               return null;
           }
       }
           
      

       /// <summary>
       ///Metodo para Actualizar Tipos de Node Comercial 
       /// </summary>


       public ENodeType ActualizarTypeNode(int iidtypenode, string snametypenode, bool bstatustypenode, string sModiBynodetype, DateTime tDateModiBynodetype)
       {
           DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_ACTUALIZARTYPENODE", iidtypenode, snametypenode, bstatustypenode,  sModiBynodetype, tDateModiBynodetype);
           ENodeType oeanodetype = new ENodeType();
           oeanodetype.idNodeComType = iidtypenode;
           oeanodetype.NodeComTypename = snametypenode;
           oeanodetype.NodeComTypeStatus = bstatustypenode;
           oeanodetype.NodeComTypeModiBy = sModiBynodetype;
           oeanodetype.NodeComTypeDateModiBy = tDateModiBynodetype;
           return oeanodetype;
        }

        
    
        
        
        
        
        }
        

    }

