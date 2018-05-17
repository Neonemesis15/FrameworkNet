using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{  /// <summary>
    /// Clase:              EAD_Oficina
    /// Creada Por:         Ing. Magaly Jiménez
    /// Fecha de Creación:  29/10/2010
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Brand
    ///                     permite al administrador del sistema gestionar las Marcas, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar Oficinas
    /// </summary>

   public class EAD_Oficina
    {
       public EAD_Oficina()
        {
            //Se define el constructor por defecto
        }
       private long lcod_Oficina;
       private int lCompany_id;
       private string lName_Oficina;
       private string lAbreviatura;
       private int lOrden;
       private bool lOficina_Status;
       private string lOficina_CreateBy;
       private DateTime lOficina_DateBy;
       private string lOficina_ModiBy;
       private DateTime lOficina_DateModiBy;
/// <summary>
       /// Se adicionan campos nuevos Abreviatura y Orden.
       /// 25/02/2011 Magaly Jiménez
/// </summary>

       public long cod_Oficina
       {
           get { return this.lcod_Oficina; }
           set { this.lcod_Oficina = value; }
       }

       public int Company_id
       {
           get { return this.lCompany_id; }
           set { this.lCompany_id = value; }
       }

       public string Name_Oficina
       {
           get { return this.lName_Oficina; }
           set { this.lName_Oficina = value; }
       }

       public string Abreviatura
       {
           get { return this.lAbreviatura; }
           set { this.lAbreviatura = value; }
       }
       public int Orden
       {
           get { return this.lOrden; }
           set { this.lOrden = value; }
       }
       public bool Oficina_Status
       {
           get { return this.lOficina_Status; }
           set { this.lOficina_Status = value; }
       }

       public string Oficina_CreateBy
       {
           get { return this.lOficina_CreateBy; }
           set { this.lOficina_CreateBy = value; }
       }

       public DateTime Oficina_DateBy
       {
           get { return this.lOficina_DateBy; }
           set { this.lOficina_DateBy = value; }
       }

       public string Oficina_ModiBy
       {
           get { return this.lOficina_ModiBy; }
           set { this.lOficina_ModiBy = value; }
       }

       public DateTime Oficina_DateModiBy
       {
           get { return this.lOficina_DateModiBy; }
           set { this.lOficina_DateModiBy = value; }
       }


    }
}
