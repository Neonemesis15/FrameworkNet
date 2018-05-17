using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Visibilidad_Detalle
    {
        private string id_reg_visibilidad;
         [JsonProperty("a")]
        public string Id_reg_visibilidad
        {
            get { return id_reg_visibilidad; }
            set { id_reg_visibilidad = value; }
        }
        private string id_tipomaterial;
         [JsonProperty("b")]
        public string Id_tipomaterial
        {
            get { return id_tipomaterial; }
            set { id_tipomaterial = value; }
        }
        private string id_material;
         [JsonProperty("c")]
        public string Id_material
        {
            get { return id_material; }
            set { id_material = value; }
        }
        private string status;
         [JsonProperty("d")]
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        private string cantidad;
         [JsonProperty("e")]
        public string Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }


        private string foto;
        [JsonProperty("z")]
        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        
        
    }
    
   
}
