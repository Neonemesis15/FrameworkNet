using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Clase               : Einfo_planning
/// Creada Por          : Ing. Magaly Andrea Jiménez
/// Fecha de Creación   : 03/06/2010
/// Requerimientos No   : <> 
/// Descripcion         : Define los atributos y propiedades de los mismos para la Clase Info_Planning
///                       permite al administrador del sistema gestionar los Informes de planning.
/// Modificación        : 28/07/2010 Se modifica comentario Clase : Einfo_planning , estaba como EProfiles, y fecha se coloca fecha de creación real Ing. Mauricio Ortiz
///                     : 28/07/2010 Se modifica tipo de dato para el campo id_planning de tipo int pasa a string . Ing Mauricio Ortiz
///                     : 13/04/2011 se agrega cod_SubChannel . Ing. Mauricio Ortiz
                       

/// </summary>

namespace Lucky.Entity.Common.Application
{
    public class Einfo_Planning
    {
        private int lid_infoplanning;
        private string lid_planning;
        private int lCompany_id;
        private int lReport_Id;
        private string lcod_Channel;
        private string lcod_SubChannel;
        private int lcod_Strategy;
        private string lcod_Country;
        private string lnom_reporte;
        private string lruta_reporte;
        private bool linfo_status;
        private string linfo_CreateBy;
        private DateTime linfo_dateBy;
        private string linfo_ModiBy;
        private DateTime linfo_DateModiby;

    public int id_infoplanning
        {
            get { return this.lid_infoplanning; }
            set { this.lid_infoplanning = value; }
        }

    public string id_planning
        {
            get { return this.lid_planning; }
            set { this.lid_planning = value; }
        }

    public int Company_id
    {
        get { return this.lCompany_id; }
        set { this.lCompany_id = value; }
    }
    public int Report_Id
    {
        get { return this.lReport_Id; }
        set { this.lReport_Id = value; }
    }
    public string cod_Channel
    {
        get { return this.lcod_Channel; }
        set { this.lcod_Channel = value; }
    }
    public string cod_SubChannel
    {
        get { return this.lcod_SubChannel; }
        set { this.lcod_SubChannel = value; }
    }
    public int cod_Strategy
    {
        get { return this.lcod_Strategy; }
        set { this.lcod_Strategy = value; }
    }
    public string cod_Country
    {
        get { return this.lcod_Country; }
        set { this.lcod_Country = value; }
    }
    public string nom_reporte
    {
        get { return this.lnom_reporte; }
        set { this.lnom_reporte = value; }
    }
    public string ruta_reporte
    {
        get { return this.lruta_reporte; }
        set { this.lruta_reporte = value; }
    }
    public bool info_status
    {
        get { return this.linfo_status; }
        set { this.linfo_status = value; }
    }
    public string info_CreateBy
    {
        get { return this.linfo_CreateBy; }
        set { this.linfo_CreateBy = value; }
    }
    public DateTime info_dateBy
    {
        get { return this.linfo_dateBy; }
        set { this.linfo_dateBy = value; }
    }
    public string info_ModiBy
    {
        get { return this.linfo_ModiBy; }
        set { this.linfo_ModiBy = value; }
    }
    public DateTime info_DateModiby
    {
        get { return this.linfo_DateModiby; }
        set { this.linfo_DateModiby = value; }
    }

    }

}
