using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              EEstrategy
    /// Creada Por:         Ing. Mauricio Ortiz
    /// Fecha de Creación:  05/05/2009
    /// Requerimientos No:  «Functional» SIGE-ARF-020 Gestión de Servicios
    ///                     «Functional» SIGE-ARF-065 Crear Servicio
    ///                     «Functional» SIGE-ARF-066 Consultar Servicio
    ///                     «Functional» SIGE-ARF-067 Actualizar Servicio
    ///                     «Functional» SIGE-ARF-068 Deshabilitar Servicio                         
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Estrategy
    ///                     Define el registro de Servicios usuadas por el Negocio para la ejecucion 
    ///                     de sus respectivas campañas y que deben ser articuladas en el Modulo de Planning 
    ///                     por la Aplicación SIGE. Esta opcion estara enmarcada dentro del Modulo Administrativo 
    ///                     y garantizara que durante la programación del Planning se articule toda la información 
    ///                     necesaria para su construcción    
    /// </summary>
    
    public class EEstrategy
    {
        private int lcodStrategy;
        private string lStrategyName;
        private string lStrategyDescription; 
        private string lcodCountry;
        private bool lStrategyStatus; 
        private string lStrategyCreateBy;
        private string lStrategyDateBy;
        private string lStrategyModiBy;
        private string lStrategyDateModiBy;

          public int  codStrategy 
            {
                get 
                    { 
                    return this.lcodStrategy; 
                    }

                set 
                    {
                    this.lcodStrategy = value;
                    }
            }

          public string StrategyName
          {
              get
              {
                  return this.lStrategyName;
              }

              set
              {
                  this.lStrategyName = value;
              }
          }

          public string StrategyDescription
          {
              get
              {
                  return this.lStrategyDescription;
              }

              set
              {
                  this.lStrategyDescription = value;
              }
          }

          public string codCountry
          {
              get
              {
                  return this.lcodCountry;
              }

              set
              {
                  this.lcodCountry = value;
              }
          }
          public bool StrategyStatus
          {
              get
              {
                  return this.lStrategyStatus;
              }

              set
              {
                  this.lStrategyStatus = value;
              }
          }

          public string StrategyCreateBy
          {
              get
              {
                  return this.lStrategyCreateBy;
              }

              set
              {
                  this.lStrategyCreateBy = value;
              }
          }

      

          public string StrategyDateBy
          {
              get
              {
                  return this.lStrategyDateBy;
              }

              set
              {
                  this.lStrategyDateBy = value;
              }
          }

          public string StrategyModiBy
          {
              get
              {
                  return this.lStrategyModiBy;
              }

              set
              {
                  this.lStrategyModiBy = value;
              }
          }

         public string StrategyDateModiBy
          {
              get
              {
                  return this.lStrategyDateModiBy;
              }

              set
              {
                  this.lStrategyDateModiBy = value;
              }
          }



    }
}
