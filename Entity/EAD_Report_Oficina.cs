using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              EAD_Report_Oficina
    /// Creada Por:         Ing. Magaly Jiménez
    /// Fecha de Creación:  02/11/2010
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Brand
    ///                     permite al administrador del sistema gestionar las Marcas, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar asociación de repotes a oficinas.
    /// </summary>
    public class EAD_Report_Oficina
    {
        public EAD_Report_Oficina()
        {
            //Se define el constructor por defecto
        }
        private long lid_ReportOficina;
        private int lReport_Id;
        private long lcod_Oficina;
        private bool lReport_Oficina_Status;
        private string lReport_Oficina_CreateBy;
        private DateTime lReport_Oficina_DateBy;
        private string lReport_Oficina_ModiBy;
        private DateTime lReport_Oficina_DateModiBy;


        public long id_ReportOficina
        {
            get { return this.lid_ReportOficina; }
            set { this.lid_ReportOficina = value; }
        }
        public int Report_Id
        {
            get { return this.lReport_Id; }
            set { this.lReport_Id = value; }
        }

        public long cod_Oficina
        {
            get { return this.lcod_Oficina; }
            set { this.lcod_Oficina = value; }
        }

        public bool Report_Oficina_Status
        {
            get { return this.lReport_Oficina_Status; }
            set { this.lReport_Oficina_Status = value; }
        }

        public string Report_Oficina_CreateBy
        {
            get { return this.lReport_Oficina_CreateBy; }
            set { this.lReport_Oficina_CreateBy = value; }
        }

        public DateTime Report_Oficina_DateBy
        {
            get { return this.lReport_Oficina_DateBy; }
            set { this.lReport_Oficina_DateBy = value; }
        }

        public string Report_Oficina_ModiBy
        {
            get { return this.lReport_Oficina_ModiBy; }
            set { this.lReport_Oficina_ModiBy = value; }
        }

        public DateTime Report_Oficina_DateModiBy
        {
            get { return this.lReport_Oficina_DateModiBy; }
            set { this.lReport_Oficina_DateModiBy = value; }
        }
    }
}
