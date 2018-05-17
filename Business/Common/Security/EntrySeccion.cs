﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Data.Common.Application;
using Lucky.Entity.Common.Application.Security;

namespace Lucky.Business.Common.Security
{
    /// <summary>
    /// Clase:EntrySeccion
    /// Creada Por: Ing. Carlos Alberto Hernandez Rincon
    /// Fecha de Creacion: 05/05/2009
    /// Descripcion: Valida los metodos del Negocio para el primer ingreso de usuarios
    /// Requerimiento No:
    /// </summary>
    public class EntrySeccion
    {
        public EntrySeccion() { 
        //Define el constructor por defecto
        
        
        
        }
        /// <summary>
        /// Metodo para verificar el primer acceso de usuario
        /// </summary>
      
        public EEntrySeccion PrimerAcceso(string sUser) {

            DUsuario odacces = new DUsuario();
            EEntrySeccion oeacces = odacces.PrimerAcceso(sUser);
            odacces = null;
            return oeacces;
        
        
        
        
        }
        /// <summary>
        /// Metodo para Registrar la primera seccion de usuario en SIGE
        /// </summary>
        public EEntrySeccion Register_PrimerSeccion(string sSeccionname, string sentryCreateBy, string sentryDateBy,
           string sentryModiBy, string sentryDatemod) {
               DUsuario odrseccion = new DUsuario();
               EEntrySeccion oeseccion = odrseccion.Register_PrimerSeccion(sSeccionname, sentryCreateBy, sentryDateBy, sentryModiBy, sentryDatemod);
               odrseccion = null;
               return oeseccion;
               
        
        
        }

    }
}
