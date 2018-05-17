using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    /// <summary>
    /// MOV - Movil
    /// GES - Gestion
    /// CAM - Campaña
    /// Author: Pablo Salas A.
    /// Fecha : 22/07/2012
    /// Description:
    /// </summary>
    public class E_MOV_GES_CAM_Equipo_Distribuidora
    {
        public string Cod_Equipo { get; set; }
        public string Cod_Reporte { get; set; }
        public string Cod_Distribuidora { get; set; }
        public bool Estado { get;set; }
    }
}
