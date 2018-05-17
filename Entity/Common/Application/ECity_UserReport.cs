using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              ECity_UserReport
    /// Creada Por:         Ing. Magaly Jiménez
    /// Fecha de Creación:  08/10/2010
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Registra ciudades en maestro de asignación de informes a usuarios
    /// Modificación: se modifica campo cod_City  por cod_Oficina
    /// 29/10/2010 Magaly Jiménez
    /// </summary>
    /// 
    public class ECity_UserReport
    {
        public ECity_UserReport()
        {
            //Se define el constructor por defecto
        }
        private long lid_City_UserRepor;
        private int lid_userinforme;
        private long lcod_Oficina;
        private bool lCity_UserRepor_Status;
        private string lCity_UserRepor_CreateBy; 
        private DateTime lCity_UserRepor_DateBy;
        private string lCity_UserRepor_ModiBy;
        private DateTime lCity_UserRepor_DateModiBy;


        public long id_City_UserRepor
        {
            get { return this.lid_City_UserRepor; }
            set { this.lid_City_UserRepor = value; }
        }
        
        public int id_userinforme
        {
            get { return this.lid_userinforme; }
            set { this.lid_userinforme = value; }
        }
        public long cod_Oficina
        {
            get { return this.lcod_Oficina; }
            set { this.lcod_Oficina = value; }
        }
        public bool City_UserRepor_Status
        {
            get { return this.lCity_UserRepor_Status; }
            set { this.lCity_UserRepor_Status = value; }
        }
        public string City_UserRepor_CreateBy
        {
            get { return this.lCity_UserRepor_CreateBy; }
            set { this.lCity_UserRepor_CreateBy = value; }
        }
        public DateTime City_UserRepor_DateBy
        {
            get { return this.lCity_UserRepor_DateBy; }
            set { this.lCity_UserRepor_DateBy = value; }
        }
        public string City_UserRepor_ModiBy
        {
            get { return this.lCity_UserRepor_ModiBy; }
            set { this.lCity_UserRepor_ModiBy = value; }
        }
        public DateTime City_UserRepor_DateModiBy
        {
            get { return this.lCity_UserRepor_DateModiBy; }
            set { this.lCity_UserRepor_DateModiBy = value; }
        }
    }
}
