using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using Lucky.Business.Common.Maestros.Producto;
//using Lucky.Entity.Common.Maestros.Producto;
using Lucky.Entity.Common.AppMobile;
using Lucky.Business.Common.AppMobile;


namespace Test
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //BL_Formato oBL_Formato = new BL_Formato();
            //List<MA_Formato> oListFormato = new List<MA_Formato>();
            //oListFormato = oBL_Formato.Get_Formatos();

            //BL_Tipo oBL_Tipo = new BL_Tipo();
            //List<MA_Tipo> oListTipo = new List<MA_Tipo>();
            //oListTipo = oBL_Tipo.Get_Tipos();
            /*
            BL_Producto oBL_Producto = new BL_Producto();
            MA_Producto oMA_Producto = new MA_Producto();

            oMA_Producto.codigo = "999";
            oMA_Producto.codigoint = "999";
            oMA_Producto.nombre = "999";
            oMA_Producto.alias = "999";
            oMA_Producto.precio_venta = "12";
            oMA_Producto.precio_oferta = "11";
            oMA_Producto.stock = "999";
            oMA_Producto.promocion = "999";
            oMA_Producto.cod_categoria = "999";
            oMA_Producto.cod_subcategoria = "999";
            oMA_Producto.cod_familia = "999";
            oMA_Producto.cod_marca = "999";
            oMA_Producto.cod_tipo = "999";
            oMA_Producto.cod_formato = "999";
            //oMA_Producto.fecha_creacion = "999";
            //oMA_Producto.creado_por = "999";
            //oMA_Producto.fecha_modificacion = "999";
            //oMA_Producto.modificado_por = "999";

            string codProducto = "";
            codProducto = oBL_Producto.Insert_Producto(oMA_Producto);

            */


            /////Test Conexión con Mysql
            // Ini
            BlUsuario blUsuario = new BlUsuario();
            List<Usuario> lstUsuario = blUsuario.usuarioQry();
            // Fin



        }
    }
}
