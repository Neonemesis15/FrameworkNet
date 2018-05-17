using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              EOPE_Reporte_Presencia
    /// Creada Por:         Joseph Gonzales
    /// Fecha de Creación:  31/10/2011
    /// </summary>
   
    public class EOPE_Reporte_Presencia
    {
        #region Atributos

        long lID;        
        int lPerson_id;
        string lId_Perfil;        
        string lId_Equipo;        
        string lId_Cliente;        
        string lId_PtoVenta;        
        string lId_Categoria;        
        string lId_Marca;
        string lId_OpcionPresencia;       
        string lFec_Reg_Cel;        
        string lLatitud;       
        string lLongitud;        
        string lOrigen;        
        string lTipo_Canal;        
        string lComentario;    
    
        long lId_Reg_Presencia;
        string lId_Pop;
        string lValor_Pop;
        string lId_Producto;
        string lPrecio;
        string lStock;
        string lId_Observacion;
        string lObservacion;
        
        #endregion

        
        #region Propiedades

        public long ID
        {
            get { return lID; }
            set { lID = value; }
        }

        public int Person_id
        {
            get { return lPerson_id; }
            set { lPerson_id = value; }
        }

        public string Id_Perfil
        {
            get { return lId_Perfil; }
            set { lId_Perfil = value; }
        }

        public string Id_Equipo
        {
            get { return lId_Equipo; }
            set { lId_Equipo = value; }
        }

        public string Id_Cliente
        {
            get { return lId_Cliente; }
            set { lId_Cliente = value; }
        }

        public string Id_PtoVenta
        {
            get { return lId_PtoVenta; }
            set { lId_PtoVenta = value; }
        }

        public string Id_Categoria
        {
            get { return lId_Categoria; }
            set { lId_Categoria = value; }
        }

        public string Id_Marca
        {
            get { return lId_Marca; }
            set { lId_Marca = value; }
        }

        public string Id_OpcionPresencia
        {
            get { return lId_OpcionPresencia; }
            set { lId_OpcionPresencia = value; }
        }

        public string Fec_Reg_Cel
        {
            get { return lFec_Reg_Cel; }
            set { lFec_Reg_Cel = value; }
        }

        public string Latitud
        {
            get { return lLatitud; }
            set { lLatitud = value; }
        }

        public string Longitud
        {
            get { return lLongitud; }
            set { lLongitud = value; }
        }

        public string Origen
        {
            get { return lOrigen; }
            set { lOrigen = value; }
        }

        public string Tipo_Canal
        {
            get { return lTipo_Canal; }
            set { lTipo_Canal = value; }
        }

        public string Comentario
        {
            get { return lComentario; }
            set { lComentario = value; }
        }

        public long ID_REG_PRESENCIA
        {
            get { return lId_Reg_Presencia; }
            set { lId_Reg_Presencia = value; }
        }

        public string Id_Pop
        {
          get { return lId_Pop; }
          set { lId_Pop = value; }
        }

        public string Valor_Pop
        {
          get { return lValor_Pop; }
          set { lValor_Pop = value; }
        }

        public string Id_Producto
        {
          get { return lId_Producto; }
          set { lId_Producto = value; }
        }

        public string Precio
        {
          get { return lPrecio; }
          set { lPrecio = value; }
        }

        public string Stock
        {
            get { return lStock; }
            set { lStock = value; }
        }

        public string Id_Observacion
        {
            get { return lId_Observacion; }
            set { lId_Observacion = value; }
        }

        public string Observacion
        {
            get { return lObservacion; }
            set { lObservacion = value; }
        }

        #endregion
    }
}
