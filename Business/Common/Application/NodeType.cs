using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Lucky.Data.Common.Application;
using Lucky.Entity.Common.Application;

namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase: NodeType
    /// Creada Por: Ing. Carlos Alberto Hernandez R
    /// Fecha de Creacion: 13/06/2009
    /// Descripcion: Define metodos del Megocio para tipos de Nodo COmercial
    /// Modificaciones : 26-06-09 se cambia el parametro idNodeComType por int . Ing. Mauricio Ortiz
    /// Requerimiento No <>
    /// </summary>


    public class NodeType
    {
        public NodeType() { 
        
            //Se define el Contructor por defecto
        
        
        
        }

        /// <summary>
        ///Metodo para Registrar Tipos de Node Comercial 
        /// </summary>


        public ENodeType RegistrarTypeNode(string snametypenode, bool bstatustypenode, string sCreatebytypenode,
             DateTime tDateBynodetype, string sModiBynodetype, DateTime tDateModiBynodetype) {
                DNodeType odnodetype = new DNodeType();
                ENodeType oenodetype = odnodetype.RegistrarTypeNode(snametypenode, bstatustypenode, sCreatebytypenode,
                    tDateBynodetype, sModiBynodetype, tDateModiBynodetype);
                odnodetype = null;
                return oenodetype;
              
            
        
        
        }


        /// <summary>
        ///Metodo para Consultar Tipos de Node Comercial 
        /// </summary>

        public DataTable ConsultarTypeNode(string snametypenode) { 

        DNodeType odcnodetype = new DNodeType();
        DataTable dt = odcnodetype.ConsultarTypeNode(snametypenode);
        return dt;

            }


        /// <summary>
        ///Metodo para Actualizar Tipos de Node Comercial 
        /// </summary>


        public ENodeType ActualizarTypeNode(int iidtypenode, string snametypenode, bool bstatustypenode, string sModiBynodetype, DateTime tDateModiBynodetype)
          
        {
            DNodeType odanodetype = new DNodeType();
            ENodeType oeanodetype = odanodetype.ActualizarTypeNode(iidtypenode, snametypenode, bstatustypenode, sModiBynodetype, tDateModiBynodetype);
            odanodetype = null;
            return oeanodetype;




        }




    }
}
