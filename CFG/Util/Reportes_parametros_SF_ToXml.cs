using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Web;
using System.Xml.Linq;

 
namespace Lucky.CFG.Util
{
    public class Reportes_parametros_SF_ToXml
    {
        //  Crear Xml Act
        public bool createXml(Reportes_parametros_SF oReportes_parametros_SF, string path)
        {
            using (XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;

                writer.WriteStartDocument();
                writer.WriteStartElement("consulta");

                int id = 1;//inicialisamos la clave de los elementos en uno
                writer.WriteStartElement("parametros");
                writer.WriteAttributeString("id", id.ToString());
                writer.WriteAttributeString("id_servicio", oReportes_parametros_SF.Id_servicio.ToString());
                writer.WriteAttributeString("id_canal", oReportes_parametros_SF.Id_canal.ToString());
                writer.WriteAttributeString("id_compañia", oReportes_parametros_SF.Id_compania.ToString());
                writer.WriteAttributeString("id_reporte", oReportes_parametros_SF.Id_reporte.ToString());
                writer.WriteAttributeString("id_user", oReportes_parametros_SF.Id_user);
                writer.WriteAttributeString("id_oficina", oReportes_parametros_SF.Id_oficina.ToString());
                writer.WriteAttributeString("id_corporacion", oReportes_parametros_SF.Id_corporacion.ToString());
                writer.WriteAttributeString("id_cadena", oReportes_parametros_SF.Id_cadena.ToString());
                writer.WriteAttributeString("id_puntosDeVenta", oReportes_parametros_SF.Id_puntoDeVenta.ToString());
                //foreach (string puntoDeVenta in oReportes_parametros_SF.ListPuntoDeVenta) {
                //    writer.WriteAttributeString("id_puntoDeVenta", puntoDeVenta);
                //}
                writer.WriteAttributeString("id_fuerzaVenta", oReportes_parametros_SF.Id_fuerzaVenta);
                writer.WriteAttributeString("id_supervisor", oReportes_parametros_SF.Id_supervisor);
                writer.WriteAttributeString("id_categoria", oReportes_parametros_SF.Id_categoria);
                writer.WriteAttributeString("id_marca", oReportes_parametros_SF.Id_marca);
                writer.WriteAttributeString("id_familias", oReportes_parametros_SF.Id_familias);
                //foreach (string familia in oReportes_parametros_SF.ListFamilia) {
                //    writer.WriteAttributeString("id_familia", familia);
                //}
                writer.WriteAttributeString("id_subfamilias", oReportes_parametros_SF.Id_subfamilias);
                //foreach (string subfamilia in oReportes_parametros_SF.ListSubfamilia) {
                //    writer.WriteAttributeString("id_subfamilia", subfamilia);
                //}
                writer.WriteAttributeString("id_productos", oReportes_parametros_SF.Id_productos);
                //foreach (string producto in oReportes_parametros_SF.ListProductos) {
                //    writer.WriteAttributeString("id_producto", producto);
                //}
                writer.WriteAttributeString("id_año", oReportes_parametros_SF.Id_year);
                writer.WriteAttributeString("id_mes", oReportes_parametros_SF.Id_month);
                writer.WriteAttributeString("id_periodo", oReportes_parametros_SF.Id_periodo);
                writer.WriteAttributeString("id_dias", oReportes_parametros_SF.Id_dias);
                //foreach (string dia in oReportes_parametros_SF.ListDias) {
                //    writer.WriteAttributeString("id_dia", dia);
                //}
                writer.WriteAttributeString("descripcion", oReportes_parametros_SF.Descripcion);

                writer.WriteEndElement();

                writer.WriteEndElement();

                writer.WriteEndDocument();

                writer.Close();
            }

            return false;
        }

        //  Adicionando
        //public bool addToXml(Reportes_parametros oReportsPtros, string path)
        //{
        //    string url = path;
        //    // Crea una instancia del documento XML, y lee la data del XML.
        //    XmlDocument doc = new XmlDocument();
        //    doc.Load(url);

        //    //  Crear un nuevo elemento.
        //    XmlElement newElem = doc.CreateElement("parametros");

        //    //Obtenemos el maximo id 
        //    int id = 0;
        //    Reportes_parametros[] vector = Get_AllParametros(path);

        //    if (vector.Length != 0)
        //    {
        //        int mayor = vector[0].Id;
        //        for (int i = 0; i < vector.Length; i++)
        //        {
        //            if (vector[i].Id > mayor)
        //            {
        //                mayor = vector[i].Id;
        //            }
        //        }
        //        id = mayor + 1;
        //    }
        //    else
        //    {
        //        id = 1;
        //    }
        //    //end maximo id

        //    // Agrega el atributo id Reporte.
        //    XmlAttribute newAttr0 = doc.CreateAttribute("id");//es el id que identifica a los nodos del doc XML
        //    newAttr0.Value = id.ToString();
        //    newElem.Attributes.Append(newAttr0);

        //    XmlAttribute newAttr = doc.CreateAttribute("id_servicio");
        //    newAttr.Value = oReportsPtros.Id_servicio.ToString();
        //    newElem.Attributes.Append(newAttr);

        //    XmlAttribute newAttr2 = doc.CreateAttribute("id_canal");
        //    newAttr2.Value = oReportsPtros.Id_canal.ToString();
        //    newElem.Attributes.Append(newAttr2);

        //    XmlAttribute newAttr3 = doc.CreateAttribute("id_compañia");
        //    newAttr3.Value = oReportsPtros.Id_compañia.ToString();
        //    newElem.Attributes.Append(newAttr3);

        //    XmlAttribute newAttr4 = doc.CreateAttribute("id_reporte");
        //    newAttr4.Value = oReportsPtros.Id_reporte.ToString();
        //    newElem.Attributes.Append(newAttr4);

        //    XmlAttribute newAttr5 = doc.CreateAttribute("id_user");
        //    newAttr5.Value = oReportsPtros.Id_user;
        //    newElem.Attributes.Append(newAttr5);

        //    XmlAttribute newAttr6 = doc.CreateAttribute("id_oficina");
        //    newAttr6.Value = oReportsPtros.Id_oficina.ToString();
        //    newElem.Attributes.Append(newAttr6);

        //    XmlAttribute newAttr7 = doc.CreateAttribute("id_punto_venta");
        //    newAttr7.Value = oReportsPtros.Id_punto_venta;
        //    newElem.Attributes.Append(newAttr7);

        //    XmlAttribute newAttr8 = doc.CreateAttribute("id_producto_categoria");
        //    newAttr8.Value = oReportsPtros.Id_producto_categoria;
        //    newElem.Attributes.Append(newAttr8);

        //    XmlAttribute newAttr9 = doc.CreateAttribute("id_producto_marca");
        //    newAttr9.Value = oReportsPtros.Id_producto_marca;
        //    newElem.Attributes.Append(newAttr9);

        //    XmlAttribute newAttr10 = doc.CreateAttribute("id_producto_familia");
        //    newAttr10.Value = oReportsPtros.Id_producto_familia;
        //    newElem.Attributes.Append(newAttr10);

        //    XmlAttribute newAttr11 = doc.CreateAttribute("id_año");
        //    newAttr11.Value = oReportsPtros.Id_año;
        //    newElem.Attributes.Append(newAttr11);

        //    XmlAttribute newAttr12 = doc.CreateAttribute("id_mes");
        //    newAttr12.Value = oReportsPtros.Id_mes;
        //    newElem.Attributes.Append(newAttr12);

        //    XmlAttribute newAttr13 = doc.CreateAttribute("id_periodo");
        //    newAttr13.Value = oReportsPtros.Id_periodo.ToString();
        //    newElem.Attributes.Append(newAttr13);

        //    XmlAttribute newAttr14 = doc.CreateAttribute("descripcion");
        //    newAttr14.Value = oReportsPtros.Descripcion;
        //    newElem.Attributes.Append(newAttr14);

        //    XmlAttribute newAttr15 = doc.CreateAttribute("id_tipoactividad");
        //    newAttr15.Value = oReportsPtros.Id_tipoactividad;
        //    newElem.Attributes.Append(newAttr15);

        //    XmlAttribute newAttr16 = doc.CreateAttribute("fecha_inicio");
        //    newAttr16.Value = oReportsPtros.Fecha_inicio;
        //    newElem.Attributes.Append(newAttr16);

        //    XmlAttribute newAttr17 = doc.CreateAttribute("fecha_fin");
        //    newAttr17.Value = oReportsPtros.Fecha_fin;
        //    newElem.Attributes.Append(newAttr17);

        //    XmlAttribute newAttr18 = doc.CreateAttribute("id_tipoReporte");
        //    newAttr18.Value = oReportsPtros.Id_tipoReporte;
        //    newElem.Attributes.Append(newAttr18);

        //    XmlAttribute newAttr19 = doc.CreateAttribute("id_subCategoria");
        //    newAttr19.Value = oReportsPtros.Id_subCategoria;
        //    newElem.Attributes.Append(newAttr19);

        //    XmlAttribute newAttr20 = doc.CreateAttribute("id_subMarca");
        //    newAttr20.Value = oReportsPtros.Id_subMarca;
        //    newElem.Attributes.Append(newAttr20);

        //    XmlAttribute newAttr21 = doc.CreateAttribute("skuProducto");
        //    newAttr21.Value = oReportsPtros.SkuProducto;
        //    newElem.Attributes.Append(newAttr21);

        //    //Se Agrega nuevos parametros Ing. Carlos Hernandez 30/04/2011
        //    XmlAttribute newAttr22 = doc.CreateAttribute("icadena");
        //    newAttr22.Value = oReportsPtros.Icadena.ToString();
        //    newElem.Attributes.Append(newAttr22);


        //    //Se Agrega nuevos parametros Ing. Carlos Hernandez 30/04/2011
        //    XmlAttribute newAttr23 = doc.CreateAttribute("inegocio");
        //    newAttr23.Value = oReportsPtros.Inegocio.ToString();
        //    newElem.Attributes.Append(newAttr23);

        //    //Se Agrega nuevos parametros Ing. Renato Castillo 06/09/2011
        //    XmlAttribute newAttr24 = doc.CreateAttribute("id_Semana");
        //    newAttr24.Value = oReportsPtros.Id_Semana.ToString();
        //    newElem.Attributes.Append(newAttr24);

        //    //Este agrega mas elementos 
        //    //////// Crea los nodos hijos. Este codigo demustra las varias vias para agregar.
        //    //////newElem.InnerXml = "<id_oficina></id_oficina><id_punto_venta></id_punto_venta>" +
        //    //////                   "<id_producto_categoria></id_producto_categoria><id_producto_marca></id_producto_marca>" +
        //    //////                   "<Id_producto_familia></Id_producto_familia><id_año></id_año>" +
        //    //////                   "<id_mes></id_mes><id_periodo></id_periodo>"+
        //    //////                   "<descripcion></descripcion>";
        //    //////   //primera forma                             
        //    //////XmlText txtNode = doc.CreateTextNode(oReportsPtros.Id_oficina.ToString());
        //    //////newElem.FirstChild.AppendChild(txtNode);
        //    //////newElem.AppendChild(doc.CreateWhitespace("\r\n")); // Salto de linea

        //    ////////segunda forma
        //    //////newElem["id_punto_venta"].InnerText = oReportsPtros.Id_punto_venta;
        //    //////newElem["id_producto_categoria"].InnerText = oReportsPtros.Id_producto_categoria;
        //    //////newElem["id_producto_marca"].InnerText = oReportsPtros.Id_producto_marca;
        //    //////newElem["Id_producto_familia"].InnerText = oReportsPtros.Id_producto_familia;
        //    //////newElem["id_año"].InnerText = oReportsPtros.Id_año;
        //    //////newElem["id_mes"].InnerText = oReportsPtros.Id_mes;
        //    //////newElem["id_periodo"].InnerText = oReportsPtros.Id_periodo.ToString();
        //    //////newElem["descripcion"].InnerText = oReportsPtros.Descripcion.ToString();

        //    // Agrega el nuevo elemento al final de la lista del nodo parametros.
        //    doc.DocumentElement.AppendChild(newElem);

        //    // Guarda el XML modificado a un archivo  en formato Unicode.
        //    doc.PreserveWhitespace = true;
        //    XmlTextWriter wrtr = new XmlTextWriter(url, Encoding.UTF8);
        //    doc.WriteTo(wrtr);
        //    wrtr.Close();

        //    return true;

        //}
        //
        // Add act
        public bool addToXml(Reportes_parametros_SF oReportes_parametros_SF, string path)
        {
            string url = path;
            // Crea una instancia del documento XML, y lee la data del XML.
            XmlDocument doc = new XmlDocument();
            doc.Load(url);

            //  Crear un nuevo elemento.
            XmlElement newElem = doc.CreateElement("parametros");

            //Obtenemos el maximo id 
            int id = 0;
            Reportes_parametros_SF[] vector = Get_AllParametros(path);

            if (vector.Length != 0)
            {
                int mayor = vector[0].Id;
                for (int i = 0; i < vector.Length; i++)
                {
                    if (vector[i].Id > mayor)
                    {
                        mayor = vector[i].Id;
                    }
                }
                id = mayor + 1;
            }
            else
            {
                id = 1;
            }
            //end maximo id

            // Agrega el atributo id Reporte.
            XmlAttribute newAttr0 = doc.CreateAttribute("id");//es el id que identifica a los nodos del doc XML
            newAttr0.Value = id.ToString();
            newElem.Attributes.Append(newAttr0);

            XmlAttribute newAttr = doc.CreateAttribute("id_servicio");
            newAttr.Value = oReportes_parametros_SF.Id_servicio.ToString();
            newElem.Attributes.Append(newAttr);

            XmlAttribute newAttr2 = doc.CreateAttribute("id_canal");
            newAttr2.Value = oReportes_parametros_SF.Id_canal.ToString();
            newElem.Attributes.Append(newAttr2);

            XmlAttribute newAttr3 = doc.CreateAttribute("id_compañia");
            newAttr3.Value = oReportes_parametros_SF.Id_compania.ToString();
            newElem.Attributes.Append(newAttr3);

            XmlAttribute newAttr4 = doc.CreateAttribute("id_reporte");
            newAttr4.Value = oReportes_parametros_SF.Id_reporte.ToString();
            newElem.Attributes.Append(newAttr4);

            XmlAttribute newAttr5 = doc.CreateAttribute("id_user");
            newAttr5.Value = oReportes_parametros_SF.Id_user;
            newElem.Attributes.Append(newAttr5);

            XmlAttribute newAttr6 = doc.CreateAttribute("id_oficina");
            newAttr6.Value = oReportes_parametros_SF.Id_oficina.ToString();
            newElem.Attributes.Append(newAttr6);
            //corporacion
            XmlAttribute newAttr18 = doc.CreateAttribute("id_corporacion");
            newAttr18.Value = oReportes_parametros_SF.Id_corporacion.ToString();
            newElem.Attributes.Append(newAttr18);
            //cadena
            XmlAttribute newAttr19 = doc.CreateAttribute("id_cadena");
            newAttr19.Value = oReportes_parametros_SF.Id_cadena.ToString();
            newElem.Attributes.Append(newAttr19);
            
            //puntoDeVenta
            XmlAttribute newAttr7 = doc.CreateAttribute("id_puntosDeVenta");
            newAttr7.Value = oReportes_parametros_SF.Id_puntoDeVenta;
            newElem.Attributes.Append(newAttr7);
            
            //fuerzaDeVenta
            XmlAttribute newAttr20 = doc.CreateAttribute("id_fuerzaVenta");
            newAttr20.Value = oReportes_parametros_SF.Id_fuerzaVenta;
            newElem.Attributes.Append(newAttr20);

            //supervisor
            XmlAttribute newAttr21 = doc.CreateAttribute("id_supervisor");
            newAttr21.Value = oReportes_parametros_SF.Id_supervisor;
            newElem.Attributes.Append(newAttr21);

            //foreach (string id_PuntoVenta in oReportes_parametros_SF.ListPuntoDeVenta)
            //{
            //    XmlAttribute newAttr7 = doc.CreateAttribute("id_punto_venta");
            //    newAttr7.Value = id_PuntoVenta;
            //    newElem.Attributes.Append(newAttr7);
            //}


            XmlAttribute newAttr8 = doc.CreateAttribute("id_categoria");
            newAttr8.Value = oReportes_parametros_SF.Id_categoria;
            newElem.Attributes.Append(newAttr8);

            XmlAttribute newAttr9 = doc.CreateAttribute("id_marca");
            newAttr9.Value = oReportes_parametros_SF.Id_marca;
            newElem.Attributes.Append(newAttr9);

            XmlAttribute newAttr10 = doc.CreateAttribute("id_familias");
            newAttr10.Value = oReportes_parametros_SF.Id_familias;
            newElem.Attributes.Append(newAttr10);
           
            //foreach (string id_familia in oReportes_parametros_SF.ListFamilia)
            //{
            //    XmlAttribute newAttr10 = doc.CreateAttribute("id_producto_familia");
            //    newAttr10.Value = id_familia;
            //    newElem.Attributes.Append(newAttr10);
            //}


                XmlAttribute newAttr11 = doc.CreateAttribute("id_subfamilias");
                newAttr11.Value = oReportes_parametros_SF.Id_subfamilias;
                newElem.Attributes.Append(newAttr11);
         


            //foreach (string id_subfamilia in oReportes_parametros_SF.ListSubfamilia)
            //{
            //    XmlAttribute newAttr11 = doc.CreateAttribute("id_producto_subfamilia");
            //    newAttr11.Value = id_subfamilia;
            //    newElem.Attributes.Append(newAttr11);
            //}


                XmlAttribute newAttr12 = doc.CreateAttribute("id_productos");
                newAttr12.Value = oReportes_parametros_SF.Id_productos;
                newElem.Attributes.Append(newAttr12);

            //foreach (string id_producto in oReportes_parametros_SF.ListProductos)
            //{
            //    XmlAttribute newAttr12 = doc.CreateAttribute("id_producto");
            //    newAttr12.Value = id_producto;
            //    newElem.Attributes.Append(newAttr12);
            //}

            XmlAttribute newAttr13 = doc.CreateAttribute("id_año");
            newAttr13.Value = oReportes_parametros_SF.Id_year;
            newElem.Attributes.Append(newAttr13);

            XmlAttribute newAttr14 = doc.CreateAttribute("id_mes");
            newAttr14.Value = oReportes_parametros_SF.Id_month;
            newElem.Attributes.Append(newAttr14);

            XmlAttribute newAttr15 = doc.CreateAttribute("id_periodo");
            newAttr15.Value = oReportes_parametros_SF.Id_periodo.ToString();
            newElem.Attributes.Append(newAttr15);


            XmlAttribute newAttr16 = doc.CreateAttribute("id_dias");
            newAttr16.Value = oReportes_parametros_SF.Id_dias;
            newElem.Attributes.Append(newAttr16);
            
            //foreach (string id_dia in oReportes_parametros_SF.ListDias) {
            //    XmlAttribute newAttr16 = doc.CreateAttribute("id_dia");
            //    newAttr16.Value = id_dia;
            //    newElem.Attributes.Append(newAttr16);
            //}
            

            XmlAttribute newAttr17 = doc.CreateAttribute("descripcion");
            newAttr17.Value = oReportes_parametros_SF.Descripcion;
            newElem.Attributes.Append(newAttr17);

            #region 
            //XmlAttribute newAttr15 = doc.CreateAttribute("id_tipoactividad");
            //newAttr15.Value = oReportes_parametros_SF.Id_tipoactividad;
            //newElem.Attributes.Append(newAttr15);

            //XmlAttribute newAttr16 = doc.CreateAttribute("fecha_inicio");
            //newAttr16.Value = oReportes_parametros_SF.Fecha_inicio;
            //newElem.Attributes.Append(newAttr16);

            //XmlAttribute newAttr17 = doc.CreateAttribute("fecha_fin");
            //newAttr17.Value = oReportes_parametros_SF.Fecha_fin;
            //newElem.Attributes.Append(newAttr17);

            //XmlAttribute newAttr18 = doc.CreateAttribute("id_tipoReporte");
            //newAttr18.Value = oReportes_parametros_SF.Id_tipoReporte;
            //newElem.Attributes.Append(newAttr18);

            //XmlAttribute newAttr19 = doc.CreateAttribute("id_subCategoria");
            //newAttr19.Value = oReportes_parametros_SF.Id_subCategoria;
            //newElem.Attributes.Append(newAttr19);

            //XmlAttribute newAttr20 = doc.CreateAttribute("id_subMarca");
            //newAttr20.Value = oReportes_parametros_SF.Id_subMarca;
            //newElem.Attributes.Append(newAttr20);

            //XmlAttribute newAttr21 = doc.CreateAttribute("skuProducto");
            //newAttr21.Value = oReportes_parametros_SF.SkuProducto;
            //newElem.Attributes.Append(newAttr21);

            ////Se Agrega nuevos parametros Ing. Carlos Hernandez 30/04/2011
            //XmlAttribute newAttr22 = doc.CreateAttribute("icadena");
            //newAttr22.Value = oReportes_parametros_SF.Icadena.ToString();
            //newElem.Attributes.Append(newAttr22);


            ////Se Agrega nuevos parametros Ing. Carlos Hernandez 30/04/2011
            //XmlAttribute newAttr23 = doc.CreateAttribute("inegocio");
            //newAttr23.Value = oReportes_parametros_SF.Inegocio.ToString();
            //newElem.Attributes.Append(newAttr23);

            ////Se Agrega nuevos parametros Ing. Renato Castillo 06/09/2011
            //XmlAttribute newAttr24 = doc.CreateAttribute("id_Semana");
            //newAttr24.Value = oReportes_parametros_SF.Id_Semana.ToString();
            //newElem.Attributes.Append(newAttr24);

            //Este agrega mas elementos 
            //////// Crea los nodos hijos. Este codigo demustra las varias vias para agregar.
            //////newElem.InnerXml = "<id_oficina></id_oficina><id_punto_venta></id_punto_venta>" +
            //////                   "<id_producto_categoria></id_producto_categoria><id_producto_marca></id_producto_marca>" +
            //////                   "<Id_producto_familia></Id_producto_familia><id_año></id_año>" +
            //////                   "<id_mes></id_mes><id_periodo></id_periodo>"+
            //////                   "<descripcion></descripcion>";
            //////   //primera forma                             
            //////XmlText txtNode = doc.CreateTextNode(oReportes_parametros_SF.Id_oficina.ToString());
            //////newElem.FirstChild.AppendChild(txtNode);
            //////newElem.AppendChild(doc.CreateWhitespace("\r\n")); // Salto de linea

            ////////segunda forma
            //////newElem["id_punto_venta"].InnerText = oReportes_parametros_SF.Id_punto_venta;
            //////newElem["id_producto_categoria"].InnerText = oReportes_parametros_SF.Id_producto_categoria;
            //////newElem["id_producto_marca"].InnerText = oReportes_parametros_SF.Id_producto_marca;
            //////newElem["Id_producto_familia"].InnerText = oReportes_parametros_SF.Id_producto_familia;
            //////newElem["id_año"].InnerText = oReportes_parametros_SF.Id_año;
            //////newElem["id_mes"].InnerText = oReportes_parametros_SF.Id_mes;
            //////newElem["id_periodo"].InnerText = oReportes_parametros_SF.Id_periodo.ToString();
            //////newElem["descripcion"].InnerText = oReportes_parametros_SF.Descripcion.ToString();
            #endregion
            
            // Agrega el nuevo elemento al final de la lista del nodo parametros.
            doc.DocumentElement.AppendChild(newElem);

            // Guarda el XML modificado a un archivo  en formato Unicode.
            doc.PreserveWhitespace = true;
            XmlTextWriter wrtr = new XmlTextWriter(url, Encoding.UTF8);
            doc.WriteTo(wrtr);
            wrtr.Close();

            return true;

        }


        //public List<Reportes_parametros> Get_Parametros(Reportes_parametros oReportsPtros, string path)
        //{
        //    // Creamos la lista genérica de Personas
        //    List<Reportes_parametros> oListReportes_parametros = new List<Reportes_parametros>();

        //    string url = path; //"Path o Url de nuestro XML";
        //    // Abrimos el elemto XmlTextReader usando la sentencia using, 
        //    // que se encargará de cerrar todos los recursos que use el objeto

        //    XmlReaderSettings settings = new XmlReaderSettings();
        //    settings.IgnoreWhitespace = false;

        //    using (XmlTextReader reader = new XmlTextReader(url))
        //    {

        //        // Con estas dos sentencias, no situamos en el primer elemento
        //        // de nuestro fichero XML (raíz)
        //        reader.MoveToContent();
        //        //reader.ReadStartElement();

        //        // Ahora viene el típico bucle del que sólo saldremos cuando se termine
        //        // el fichero XML
        //        while (reader.Read())
        //        {
        //            // Si el reader está en un elemento y ese elemento se llama "parametros"
        //            // (en nuestro ejemplo todos los elementos se llaman parametros)
        //            if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "parametros"))
        //            {
        //                // Creamos un objeto del tipo Reportes_parametros
        //                Reportes_parametros oReportes_parametros = new Reportes_parametros();

        //                // Aquí viene el alma de nuestro algoritmo
        //                // Viajamos desde el primer al último atributo

        //                int id = 0, id_reporte = 0, id_servicio = 0, id_compañia = 0, id_oficina = 0, id_periodo = 0, icadena = 0, inegocio = 0;
        //                string id_user = String.Empty, id_canal = String.Empty,
        //                    id_punto_venta = String.Empty, id_producto_categoria = String.Empty,
        //                    id_producto_marca = String.Empty, id_producto_familia = String.Empty, id_año = String.Empty,
        //                    id_mes = String.Empty, descripcion = String.Empty, id_tipoactividad = String.Empty, fecha_fin = String.Empty, fecha_inicio = String.Empty,
        //                    id_tipoReporte = String.Empty, id_subCategoria = String.Empty, id_subMarca = String.Empty, skuProducto = String.Empty;
        //                for (int i = 0; i < reader.AttributeCount; i++)
        //                {
        //                    // Nos movemos al atributo que nos corresponde.
        //                    // Es muy importante observar que siempre se mueve de los atributos previos a los
        //                    // posteriores, pues el XmlTextReader sólo sabe ir hacia delante.
        //                    reader.MoveToAttribute(i);
        //                    {
        //                        // Según sea el nombre del atributo, colocamos su valor en una u otra
        //                        // propiedad de nuestro objeto parametros
        //                        switch (reader.Name)
        //                        {
        //                            case "id":
        //                                id = Convert.ToInt32(reader.Value);
        //                                break;
        //                            case "id_servicio":
        //                                id_servicio = Convert.ToInt32(reader.Value);
        //                                break;
        //                            case "id_canal":
        //                                id_canal = reader.Value;
        //                                break;
        //                            case "id_compañia":
        //                                id_compañia = Convert.ToInt32(reader.Value);
        //                                break;
        //                            case "id_reporte":
        //                                id_reporte = Convert.ToInt32(reader.Value);
        //                                break;
        //                            case "id_user":
        //                                id_user = reader.Value;
        //                                break;
        //                            case "id_oficina":
        //                                id_oficina = Convert.ToInt32(reader.Value);
        //                                break;
        //                            case "id_punto_venta":
        //                                id_punto_venta = reader.Value;
        //                                break;
        //                            case "id_producto_categoria":
        //                                id_producto_categoria = reader.Value;
        //                                break;
        //                            case "id_producto_marca":
        //                                id_producto_marca = reader.Value;
        //                                break;
        //                            case "id_producto_familia":
        //                                id_producto_familia = reader.Value;
        //                                break;
        //                            case "id_año":
        //                                id_año = reader.Value;
        //                                break;
        //                            case "id_mes":
        //                                id_mes = reader.Value;
        //                                break;
        //                            case "id_periodo":
        //                                id_periodo = Convert.ToInt32(reader.Value);
        //                                break;
        //                            case "descripcion":
        //                                descripcion = reader.Value;
        //                                break;
        //                            case "id_tipoactividad":
        //                                id_tipoactividad = reader.Value;
        //                                break;
        //                            case "fecha_inicio":
        //                                fecha_inicio = reader.Value;
        //                                break;
        //                            case "fecha_fin":
        //                                fecha_fin = reader.Value;
        //                                break;
        //                            case "id_tipoReporte":
        //                                id_tipoReporte = reader.Value;
        //                                break;
        //                            case "id_subCategoria":
        //                                id_subCategoria = reader.Value;
        //                                break;
        //                            case "id_subMarca":
        //                                id_subMarca = reader.Value;
        //                                break;
        //                            case "skuProducto":
        //                                skuProducto = reader.Value;
        //                                break;
        //                            case "icadena":
        //                                icadena = Convert.ToInt32(reader.Value);
        //                                break;
        //                            case "inegocio":
        //                                inegocio = Convert.ToInt32(reader.Value);
        //                                break;
        //                        }
        //                    }
        //                }

        //                if (id_servicio == oReportsPtros.Id_servicio && id_canal == oReportsPtros.Id_canal && id_compañia == oReportsPtros.Id_compañia && id_reporte == oReportsPtros.Id_reporte && id_user == oReportsPtros.Id_user)
        //                {
        //                    oReportes_parametros.Id = id;
        //                    oReportes_parametros.Id_servicio = id_servicio;
        //                    oReportes_parametros.Id_canal = id_canal;
        //                    oReportes_parametros.Id_compañia = id_compañia;
        //                    oReportes_parametros.Id_reporte = id_reporte;
        //                    oReportes_parametros.Id_user = id_user;

        //                    oReportes_parametros.Id_oficina = id_oficina;
        //                    oReportes_parametros.Id_punto_venta = id_punto_venta;
        //                    oReportes_parametros.Id_producto_categoria = id_producto_categoria;
        //                    oReportes_parametros.Id_producto_marca = id_producto_marca;
        //                    oReportes_parametros.Id_producto_familia = id_producto_familia;
        //                    oReportes_parametros.Id_año = id_año;
        //                    oReportes_parametros.Id_mes = id_mes;
        //                    oReportes_parametros.Id_periodo = id_periodo;
        //                    oReportes_parametros.Descripcion = descripcion;
        //                    oReportes_parametros.Id_tipoactividad = id_tipoactividad;
        //                    oReportes_parametros.Fecha_inicio = fecha_inicio;
        //                    oReportes_parametros.Fecha_fin = fecha_fin;
        //                    oReportes_parametros.Id_tipoReporte = id_tipoReporte;
        //                    oReportes_parametros.Id_subCategoria = id_subCategoria;
        //                    oReportes_parametros.Id_subMarca = id_subMarca;
        //                    oReportes_parametros.SkuProducto = skuProducto;
        //                    oReportes_parametros.Icadena = icadena;
        //                    oReportes_parametros.Inegocio = inegocio;

        //                    oListReportes_parametros.Add(oReportes_parametros);
        //                }

        //                //break; solo si desea buscar un elemento
        //            }
        //        }
        //        reader.Close();
        //    }

        //    // Devolvemos el listado genérico
        //    return oListReportes_parametros;
        //}

        public List<Reportes_parametros_SF> Get_Parametros(Reportes_parametros_SF oReportsPtros, string path)
        {
            // Creamos la lista genérica de Personas
            List<Reportes_parametros_SF> oListReportes_parametros = new List<Reportes_parametros_SF>();

            string url = path; //"Path o Url de nuestro XML";
            // Abrimos el elemto XmlTextReader usando la sentencia using, 
            // que se encargará de cerrar todos los recursos que use el objeto

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = false;

            using (XmlTextReader reader = new XmlTextReader(url))
            {

                // Con estas dos sentencias, no situamos en el primer elemento
                // de nuestro fichero XML (raíz)
                reader.MoveToContent();
                //reader.ReadStartElement();

                // Ahora viene el típico bucle del que sólo saldremos cuando se termine
                // el fichero XML
                while (reader.Read())
                {
                    // Si el reader está en un elemento y ese elemento se llama "parametros"
                    // (en nuestro ejemplo todos los elementos se llaman parametros)
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "parametros"))
                    {
                        // Creamos un objeto del tipo Reportes_parametros
                        //Reportes_parametros oReportes_parametros = new Reportes_parametros();
                        Reportes_parametros_SF oReportes_parametros_SF = new Reportes_parametros_SF();


                        // Aquí viene el alma de nuestro algoritmo
                        // Viajamos desde el primer al último atributo

                        int id = 0,
                          id_reporte = 0,
                          id_servicio = 0,
                          id_compañia = 0,
                          id_oficina = 0,
                          id_periodo = 0;
                        string id_user = String.Empty,
                            id_canal = String.Empty,
                            id_producto_categoria = String.Empty,
                            id_producto_marca = String.Empty,
                            id_year = String.Empty,
                            id_month = String.Empty,
                            descripcion = String.Empty,
                            id_corporacion = String.Empty,
                            id_cadena = String.Empty,
                            id_fuerzaVenta = String.Empty,
                            id_supervisor = String.Empty,
                            id_puntosDeVenta = String.Empty,
                            id_familias = String.Empty,
                            id_subfamilias = String.Empty,
                            id_productos = String.Empty,
                            id_dias = String.Empty;

                        List<string> listPuntoDeVenta = new List<string>(),
                                        listFamilia = new List<string>(),
                                        listSubfamilia = new List<string>(),
                                        listProductos = new List<string>(),
                                        listDias = new List<string>();
                        
                        
                        for (int i = 0; i < reader.AttributeCount; i++)
                        {
                            // Nos movemos al atributo que nos corresponde.
                            // Es muy importante observar que siempre se mueve de los atributos previos a los
                            // posteriores, pues el XmlTextReader sólo sabe ir hacia delante.
                            reader.MoveToAttribute(i);
                            {
                                // Según sea el nombre del atributo, colocamos su valor en una u otra
                                // propiedad de nuestro objeto parametros
                                switch (reader.Name)
                                {
                                    case "id":
                                        id = Convert.ToInt32(reader.Value);
                                        break;
                                    case "id_servicio":
                                        id_servicio = Convert.ToInt32(reader.Value);
                                        break;
                                    case "id_canal":
                                        id_canal = reader.Value;
                                        break;
                                    case "id_compañia":
                                        id_compañia = Convert.ToInt32(reader.Value);
                                        break;
                                    case "id_reporte":
                                        id_reporte = Convert.ToInt32(reader.Value);
                                        break;
                                    case "id_user":
                                        id_user = reader.Value;
                                        break;
                                    case "id_oficina":
                                        id_oficina = Convert.ToInt32(reader.Value);
                                        break;
                                    case "id_corporacion":
                                        id_corporacion = reader.Value;
                                        break;
                                    case "id_cadena":
                                        id_cadena = reader.Value;
                                        break;
                                    case "id_puntosDeVenta":
                                        id_puntosDeVenta = reader.Value;
                                        //listPuntoDeVenta.Add(id_punto_venta.ToString()); -- cambiar por id_puntosDeVentas
                                        break;
                                    case "id_fuerzaVenta":
                                        id_fuerzaVenta = reader.Value;
                                        break;
                                    case "id_supervisor":
                                        id_supervisor = reader.Value;
                                        break;
                                    case "id_categoria":
                                        id_producto_categoria = reader.Value;
                                        break;
                                    case "id_marca":
                                        id_producto_marca = reader.Value;
                                        break;
                                    case "id_familias":
                                        id_familias = reader.Value;
                                        //listFamilia.Add(id_familia); -- cambiar por id_familias
                                        break;
                                    case "id_subfamilias":
                                        id_subfamilias = reader.Value;
                                        //listSubfamilia.Add(id_subfamilia); cambiar por id_subfamilias
                                        break;
                                    case "id_productos":
                                        id_productos = reader.Value;
                                        //listProductos.Add(id_productos); --cambiar por id_productos
                                        break;
                                    case "id_año":
                                        id_year = reader.Value;// cambiar por id_año
                                        break;
                                    case "id_mes":
                                        id_month = reader.Value;//cambiar por id_mes
                                        break;
                                    case "id_dias":
                                        id_dias = reader.Value;
                                        //listDias.Add(id_dia);--cambiar id_dia
                                        break;
                                    case "id_periodo":
                                        id_periodo = Convert.ToInt32(reader.Value);
                                        break;
                                    case "descripcion":
                                        descripcion = reader.Value;
                                        break;
                                }
                            }
                        }

                        if (id_servicio == oReportsPtros.Id_servicio && id_canal == oReportsPtros.Id_canal && id_compañia == oReportsPtros.Id_compania && id_reporte == oReportsPtros.Id_reporte && id_user == oReportsPtros.Id_user)
                        {
                            oReportes_parametros_SF.Id = id;
                            oReportes_parametros_SF.Id_servicio = id_servicio;
                            oReportes_parametros_SF.Id_canal = id_canal;
                            oReportes_parametros_SF.Id_compania = id_compañia;
                            oReportes_parametros_SF.Id_reporte = id_reporte;
                            oReportes_parametros_SF.Id_user = id_user;
                            oReportes_parametros_SF.Id_oficina = id_oficina;
                            oReportes_parametros_SF.Id_corporacion = id_corporacion;
                            oReportes_parametros_SF.Id_cadena = id_cadena;
                            oReportes_parametros_SF.Id_puntoDeVenta = id_puntosDeVenta;
                            //foreach (string id_ptoVenta in listPuntoDeVenta)
                            //    oReportes_parametros.ListPuntoDeVenta.Add(id_ptoVenta);
                            oReportes_parametros_SF.Id_fuerzaVenta = id_fuerzaVenta;
                            oReportes_parametros_SF.Id_supervisor = id_supervisor;
                            oReportes_parametros_SF.Id_categoria = id_producto_categoria;
                            oReportes_parametros_SF.Id_marca = id_producto_marca;
                            oReportes_parametros_SF.Id_familias = id_familias;
                            oReportes_parametros_SF.Id_subfamilias = id_subfamilias;
                            oReportes_parametros_SF.Id_productos = id_productos;
                            //foreach (string id_familias in listFamilia)
                            //    oReportes_parametros.ListFamilia.Add(id_familias);
                            //foreach (string id_subfamilias in listSubfamilia)
                            //    oReportes_parametros.ListSubfamilia.Add(id_subfamilias);
                            //oReportes_parametros.Id_producto_familia = id_producto_familia;
                            oReportes_parametros_SF.Id_year = id_year;
                            oReportes_parametros_SF.Id_month = id_month;
                            oReportes_parametros_SF.Id_periodo = id_periodo.ToString();
                            oReportes_parametros_SF.Id_dias = id_dias;
                            oReportes_parametros_SF.Descripcion = descripcion;
                            //foreach (string dias in listDias)
                            //    oReportes_parametros.ListDias.Add(dias);

                            oListReportes_parametros.Add(oReportes_parametros_SF);
                        }

                        //break; solo si desea buscar un elemento
                    }
                }
                reader.Close();
            }

            // Devolvemos el listado genérico
            return oListReportes_parametros;
        }

        public Boolean DeleteElement(Reportes_parametros oReportsPtros, string path)
        {
            try
            {
                string url = path;
                // Crea una instancia del documento XML, y lee la data del XML.
                XmlDocument doc = new XmlDocument();
                doc.Load(url);

                XmlNodeList nodeList = doc.SelectNodes("//parametros");
                //1. Remove the Genre nodes from Book elements.

                foreach (XmlNode node in nodeList)
                {
                    if (node.Attributes.Count != 0)
                    {
                        if (node.Attributes["id"].Value == oReportsPtros.Id.ToString())
                        {
                            node.RemoveAll();
                        }
                    }

                }

                // Guarda el XML modificado a un archivo  en formato Unicode.
                doc.PreserveWhitespace = true;
                XmlTextWriter wrtr = new XmlTextWriter(url, Encoding.UTF8);
                doc.WriteTo(wrtr);
                wrtr.Close();

                return true;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();

                return false;
            }
        }
        
        
        
        //  Obtener act
        public Reportes_parametros_SF[] Get_AllParametros(string path)
        {
            // Creamos la lista genérica de Personas
            List<Reportes_parametros_SF> oListReportes_parametros_SF = new List<Reportes_parametros_SF>();

            string url = path; //"Path o Url de nuestro XML";
            // Abrimos el elemto XmlTextReader usando la sentencia using, 
            // que se encargará de cerrar todos los recursos que use el objeto

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = false;

            using (XmlTextReader reader = new XmlTextReader(url))
            {

                // Con estas dos sentencias, no situamos en el primer elemento
                // de nuestro fichero XML (raíz)
                reader.MoveToContent();
                //reader.ReadStartElement();

                // Ahora viene el típico bucle del que sólo saldremos cuando se termine
                // el fichero XML
                while (reader.Read())
                {
                    // Si el reader está en un elemento y ese elemento se llama "parametros"
                    // (en nuestro ejemplo todos los elementos se llaman parametros)
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "parametros"))
                    {
                        // Creamos un objeto del tipo Reportes_parametros
                        //Reportes_parametros oReportes_parametros = new Reportes_parametros();
                        Reportes_parametros_SF oReportes_parametros_SF = new Reportes_parametros_SF();
                        // Aquí viene el alma de nuestro algoritmo
                        // Viajamos desde el primer al último atributo

                        int id = 0, 
                            id_reporte = 0, 
                            id_servicio = 0, 
                            id_compañia = 0, 
                            id_oficina = 0, 
                            id_periodo = 0;
                        string id_user = String.Empty,
                            id_canal = String.Empty,
                            id_punto_venta = String.Empty,
                            id_producto_categoria = String.Empty,
                            id_producto_marca = String.Empty,
                            id_producto_familia = String.Empty,
                            id_year = String.Empty,
                            id_month = String.Empty,
                            descripcion = String.Empty,
                            id_corporacion = String.Empty,
                            id_cadena = String.Empty,
                            id_fuerzaVenta = String.Empty,
                            id_supervisor = String.Empty,
                            id_familia = String.Empty,
                            id_subfamilia = String.Empty,
                            id_productos = String.Empty,
                            id_dia = String.Empty;

                        List<string> listPuntoDeVenta = new List<string>(),
                                        listFamilia = new List<string>(),
                                        listSubfamilia = new List<string>(),
                                        listProductos = new List<string>(),
                                        listDias = new List<string>();

                        for (int i = 0; i < reader.AttributeCount; i++)
                        {
                            // Nos movemos al atributo que nos corresponde.
                            // Es muy importante observar que siempre se mueve de los atributos previos a los
                            // posteriores, pues el XmlTextReader sólo sabe ir hacia delante.
                            reader.MoveToAttribute(i);
                            {
                                // Según sea el nombre del atributo, colocamos su valor en una u otra
                                // propiedad de nuestro objeto parametros
                                switch (reader.Name)
                                {
                                    case "id":
                                        id = Convert.ToInt32(reader.Value);
                                        break;

                                    case "id_servicio":
                                        id_servicio = Convert.ToInt32(reader.Value);
                                        break;
                                    case "id_canal":
                                        id_canal = reader.Value;
                                        break;
                                    case "id_compañia":
                                        id_compañia = Convert.ToInt32(reader.Value);
                                        break;
                                    case "id_reporte":
                                        id_reporte = Convert.ToInt32(reader.Value);
                                        break;
                                    case "id_user":
                                        id_user = reader.Value;
                                        break;
                                    case "id_oficina":
                                        id_oficina = Convert.ToInt32(reader.Value);
                                        break;
                                    case "id_corporacion":
                                        id_corporacion = reader.Value;            
                                        break;
                                    case "id_cadena":
                                        id_cadena = reader.Value;
                                        break;
                                    case "id_punto_venta":
                                        id_punto_venta = reader.Value;
                                        listPuntoDeVenta.Add(id_punto_venta.ToString());
                                        break;
                                    case "id_producto_categoria":
                                        id_producto_categoria = reader.Value;
                                        break;

                                    case "id_producto_marca":
                                        id_producto_marca = reader.Value;
                                        break;

                                    case "id_producto_familia":
                                        id_familia = reader.Value;
                                        listFamilia.Add(id_familia);
                                        break;

                                    case "id_producto_subfamilia":
                                        id_subfamilia = reader.Value;
                                        listSubfamilia.Add(id_subfamilia);
                                        break;

                                    case "id_producto":
                                        id_productos = reader.Value;
                                        listProductos.Add(id_productos);
                                        break;

                                    case "id_year":
                                        id_year = reader.Value;
                                        break;

                                    case "id_month":
                                        id_month = reader.Value;
                                        break;

                                    case "id_dias":
                                        id_dia = reader.Value;
                                        listDias.Add(id_dia);
                                        break;
                                    case "id_periodo":
                                        id_periodo = Convert.ToInt32(reader.Value);
                                        break;
                                    case "descripcion":
                                        descripcion = reader.Value;
                                        break;
                                }
                            }
                        }

                        oReportes_parametros_SF.Id = id;
                        oReportes_parametros_SF.Id_servicio = id_servicio;
                        oReportes_parametros_SF.Id_canal = id_canal;
                        oReportes_parametros_SF.Id_compania = id_compañia;
                        oReportes_parametros_SF.Id_reporte = id_reporte;
                        oReportes_parametros_SF.Id_user = id_user;
                        oReportes_parametros_SF.Id_oficina = id_oficina;
                        foreach (string id_ptoVenta in listPuntoDeVenta)
                            oReportes_parametros_SF.ListPuntoDeVenta.Add(id_ptoVenta);
                        oReportes_parametros_SF.Id_categoria = id_producto_categoria;
                        oReportes_parametros_SF.Id_marca = id_producto_marca;
                        foreach (string id_familias in listFamilia)
                            oReportes_parametros_SF.ListFamilia.Add(id_familias);
                        foreach (string id_subfamilias in listSubfamilia)
                            oReportes_parametros_SF.ListSubfamilia.Add(id_subfamilias);
                        //oReportes_parametros_SF.Id_producto_familia = id_producto_familia;
                        oReportes_parametros_SF.Id_year = id_year;
                        oReportes_parametros_SF.Id_month = id_month;
                        oReportes_parametros_SF.Id_periodo = id_periodo.ToString();
                        oReportes_parametros_SF.Descripcion = descripcion;
                        foreach (string dias in listDias)
                            oReportes_parametros_SF.ListDias.Add(dias);

                        oListReportes_parametros_SF.Add(oReportes_parametros_SF);

                        //break; solo si desea buscar un elemento
                    }
                }
                reader.Close();
            }
            // Devolvemos el listado genérico
            return oListReportes_parametros_SF.ToArray();
        }


    }
}
