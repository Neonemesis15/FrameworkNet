using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Maestros.Producto
{
    public class MA_Producto
    {
        public string codigo { get; set; }
        public string codigoint { get; set; }
        public string nombre { get; set; }
        public string alias { get; set; }
        public string precio_venta { get; set; }
        public string precio_oferta { get; set; }
        public string stock { get; set; }
        public string promocion { get; set; }
        public string cod_categoria { get; set; }
        public string categoria { get; set; }
        public string cod_subcategoria { get; set; }
        public string subcategoria { get; set; }
        public string cod_familia { get; set; }
        public string familia { get; set; }
        public string cod_marca { get; set; }
        public string marca { get;set; }
        public string cod_tipo { get; set; }
        public string tipo { get; set; }
        public string cod_formato { get; set; }
        public string formato { get; set; }
        public string fecha_creacion { get; set; }
        public string creado_por { get; set; }
        public string fecha_modificacion { get; set; }
        public string modificado_por { get; set; }

    }
}
