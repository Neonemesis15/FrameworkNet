using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Web;
using System.Xml.Linq;



namespace Lucky.CFG.Util
{
    public class Reportes_parametrosToXml// : System.Web.UI.Page
    {

        public bool createXml(Reportes_parametros oReportsPtros, string path)
        { 
            using (XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;

                writer.WriteStartDocument();
                writer.WriteStartElement("consulta");

                int id=1;//inicialisamos la clave de los elementos en uno
                writer.WriteStartElement("parametros");
                writer.WriteAttributeString("id",id.ToString());
                writer.WriteAttributeString("id_servicio", oReportsPtros.Id_servicio.ToString());
                writer.WriteAttributeString("id_canal", oReportsPtros.Id_canal.ToString());
                writer.WriteAttributeString("id_compañia", oReportsPtros.Id_compañia.ToString());
                writer.WriteAttributeString("id_reporte", oReportsPtros.Id_reporte.ToString());
                writer.WriteAttributeString("id_user", oReportsPtros.Id_user);

                writer.WriteAttributeString("id_oficina", oReportsPtros.Id_oficina.ToString());
                writer.WriteAttributeString("id_punto_venta", oReportsPtros.Id_punto_venta);
                writer.WriteAttributeString("id_producto_categoria", oReportsPtros.Id_producto_categoria);
                writer.WriteAttributeString("id_producto_marca", oReportsPtros.Id_producto_marca);
                writer.WriteAttributeString("id_producto_familia", oReportsPtros.Id_producto_familia);
                writer.WriteAttributeString("id_año", oReportsPtros.Id_año);
                writer.WriteAttributeString("id_mes", oReportsPtros.Id_mes);
                writer.WriteAttributeString("id_periodo", oReportsPtros.Id_periodo.ToString());
                writer.WriteAttributeString("descripcion", oReportsPtros.Descripcion);
                writer.WriteAttributeString("id_tipoactividad", oReportsPtros.Id_tipoactividad);
                writer.WriteAttributeString("fecha_inicio", oReportsPtros.Fecha_inicio);
                writer.WriteAttributeString("fecha_fin", oReportsPtros.Fecha_fin);
                writer.WriteAttributeString("id_tipoReporte", oReportsPtros.Id_tipoReporte);
                writer.WriteAttributeString("id_subCategoria", oReportsPtros.Id_subCategoria);
                writer.WriteAttributeString("id_subMarca", oReportsPtros.Id_subMarca);
                writer.WriteAttributeString("skuProducto", oReportsPtros.SkuProducto);
                writer.WriteAttributeString("icadena",   oReportsPtros.Icadena.ToString());
                writer.WriteAttributeString("inegocio", oReportsPtros.Inegocio.ToString());
                writer.WriteAttributeString("id_Semana", oReportsPtros.Id_Semana.ToString());


                ////primera forma de agregar elementos
                //writer.WriteElementString("id_oficina", oReportsPtros.Id_oficina.ToString());
                //writer.WriteElementString("id_punto_venta", oReportsPtros.Id_punto_venta);
                //writer.WriteElementString("id_producto_categoria", oReportsPtros.Id_producto_categoria);
                //writer.WriteElementString("id_producto_marca", oReportsPtros.Id_producto_marca);
                //writer.WriteElementString("Id_producto_familia", oReportsPtros.Id_producto_familia);
                //writer.WriteElementString("id_año", oReportsPtros.Id_año);
                //writer.WriteElementString("id_mes", oReportsPtros.Id_mes);

                ////segunda forma de agregar elementos
                //writer.WriteStartElement("id_periodo");
                //writer.WriteString(oReportsPtros.Id_periodo.ToString());
                //writer.WriteEndElement();

                //writer.WriteStartElement("descripcion");
                //writer.WriteString(oReportsPtros.Descripcion.ToString());
                //writer.WriteEndElement();

                writer.WriteEndElement();

                writer.WriteEndElement();

                writer.WriteEndDocument();

                writer.Close();
            }

            return false;
        }
        //  Adicionando
        public bool addToXml(Reportes_parametros oReportsPtros,string path)
        {
            string url = path;
            // Crea una instancia del documento XML, y lee la data del XML.
            XmlDocument doc = new XmlDocument();
            doc.Load(url);  
             
            //  Crear un nuevo elemento.
            XmlElement newElem = doc.CreateElement("parametros");

            //Obtenemos el maximo id 
            int id=0;
            Reportes_parametros[] vector = Get_AllParametros(path);

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
            newAttr.Value = oReportsPtros.Id_servicio.ToString();
            newElem.Attributes.Append(newAttr);

            XmlAttribute newAttr2 = doc.CreateAttribute("id_canal");
            newAttr2.Value = oReportsPtros.Id_canal.ToString();
            newElem.Attributes.Append(newAttr2);

            XmlAttribute newAttr3 = doc.CreateAttribute("id_compañia");
            newAttr3.Value = oReportsPtros.Id_compañia.ToString();
            newElem.Attributes.Append(newAttr3);

            XmlAttribute newAttr4 = doc.CreateAttribute("id_reporte");
            newAttr4.Value = oReportsPtros.Id_reporte.ToString();
            newElem.Attributes.Append(newAttr4);

            XmlAttribute newAttr5 = doc.CreateAttribute("id_user");
            newAttr5.Value = oReportsPtros.Id_user;
            newElem.Attributes.Append(newAttr5);

            XmlAttribute newAttr6 = doc.CreateAttribute("id_oficina");
            newAttr6.Value = oReportsPtros.Id_oficina.ToString();
            newElem.Attributes.Append(newAttr6);

            XmlAttribute newAttr7 = doc.CreateAttribute("id_punto_venta");
            newAttr7.Value = oReportsPtros.Id_punto_venta;
            newElem.Attributes.Append(newAttr7);

            XmlAttribute newAttr8 = doc.CreateAttribute("id_producto_categoria");
            newAttr8.Value = oReportsPtros.Id_producto_categoria;
            newElem.Attributes.Append(newAttr8);

            XmlAttribute newAttr9 = doc.CreateAttribute("id_producto_marca");
            newAttr9.Value = oReportsPtros.Id_producto_marca;
            newElem.Attributes.Append(newAttr9);

            XmlAttribute newAttr10 = doc.CreateAttribute("id_producto_familia");
            newAttr10.Value = oReportsPtros.Id_producto_familia;
            newElem.Attributes.Append(newAttr10);

            XmlAttribute newAttr11 = doc.CreateAttribute("id_año");
            newAttr11.Value = oReportsPtros.Id_año;
            newElem.Attributes.Append(newAttr11);

            XmlAttribute newAttr12 = doc.CreateAttribute("id_mes");
            newAttr12.Value = oReportsPtros.Id_mes;
            newElem.Attributes.Append(newAttr12);

            XmlAttribute newAttr13 = doc.CreateAttribute("id_periodo");
            newAttr13.Value = oReportsPtros.Id_periodo.ToString();
            newElem.Attributes.Append(newAttr13);

            XmlAttribute newAttr14 = doc.CreateAttribute("descripcion");
            newAttr14.Value = oReportsPtros.Descripcion;
            newElem.Attributes.Append(newAttr14);

            XmlAttribute newAttr15 = doc.CreateAttribute("id_tipoactividad");
            newAttr15.Value = oReportsPtros.Id_tipoactividad;
            newElem.Attributes.Append(newAttr15);

            XmlAttribute newAttr16 = doc.CreateAttribute("fecha_inicio");
            newAttr16.Value = oReportsPtros.Fecha_inicio;
            newElem.Attributes.Append(newAttr16);

            XmlAttribute newAttr17 = doc.CreateAttribute("fecha_fin");
            newAttr17.Value = oReportsPtros.Fecha_fin;
            newElem.Attributes.Append(newAttr17);

            XmlAttribute newAttr18 = doc.CreateAttribute("id_tipoReporte");
            newAttr18.Value = oReportsPtros.Id_tipoReporte;
            newElem.Attributes.Append(newAttr18);

            XmlAttribute newAttr19 = doc.CreateAttribute("id_subCategoria");
            newAttr19.Value = oReportsPtros.Id_subCategoria;
            newElem.Attributes.Append(newAttr19);

            XmlAttribute newAttr20 = doc.CreateAttribute("id_subMarca");
            newAttr20.Value = oReportsPtros.Id_subMarca;
            newElem.Attributes.Append(newAttr20);

            XmlAttribute newAttr21 = doc.CreateAttribute("skuProducto");
            newAttr21.Value = oReportsPtros.SkuProducto;
            newElem.Attributes.Append(newAttr21);

            //Se Agrega nuevos parametros Ing. Carlos Hernandez 30/04/2011
            XmlAttribute newAttr22 = doc.CreateAttribute("icadena");
            newAttr22.Value = oReportsPtros.Icadena.ToString();
            newElem.Attributes.Append(newAttr22);


            //Se Agrega nuevos parametros Ing. Carlos Hernandez 30/04/2011
            XmlAttribute newAttr23 = doc.CreateAttribute("inegocio");
            newAttr23.Value = oReportsPtros.Inegocio.ToString();
            newElem.Attributes.Append(newAttr23);

            //Se Agrega nuevos parametros Ing. Renato Castillo 06/09/2011
            XmlAttribute newAttr24 = doc.CreateAttribute("id_Semana");
            newAttr24.Value = oReportsPtros.Id_Semana.ToString();
            newElem.Attributes.Append(newAttr24);


            //Se Agrega nuevos parametros Ing. Ditmar Estrada 21/02/2012
            XmlAttribute newAttr25 = doc.CreateAttribute("Id_TipoCiudad");
            newAttr25.Value = oReportsPtros.Id_Semana.ToString();
            newElem.Attributes.Append(newAttr25);

            //Se Agrega nuevos parametros pSalas 28/02/2012
            XmlAttribute newAttr26 = doc.CreateAttribute("Id_malla");
            newAttr26.Value = oReportsPtros.Id_malla.ToString();
            newElem.Attributes.Append(newAttr26);


            //Este agrega mas elementos 
            //////// Crea los nodos hijos. Este codigo demustra las varias vias para agregar.
            //////newElem.InnerXml = "<id_oficina></id_oficina><id_punto_venta></id_punto_venta>" +
            //////                   "<id_producto_categoria></id_producto_categoria><id_producto_marca></id_producto_marca>" +
            //////                   "<Id_producto_familia></Id_producto_familia><id_año></id_año>" +
            //////                   "<id_mes></id_mes><id_periodo></id_periodo>"+
            //////                   "<descripcion></descripcion>";
            //////   //primera forma                             
            //////XmlText txtNode = doc.CreateTextNode(oReportsPtros.Id_oficina.ToString());
            //////newElem.FirstChild.AppendChild(txtNode);
            //////newElem.AppendChild(doc.CreateWhitespace("\r\n")); // Salto de linea

            ////////segunda forma
            //////newElem["id_punto_venta"].InnerText = oReportsPtros.Id_punto_venta;
            //////newElem["id_producto_categoria"].InnerText = oReportsPtros.Id_producto_categoria;
            //////newElem["id_producto_marca"].InnerText = oReportsPtros.Id_producto_marca;
            //////newElem["Id_producto_familia"].InnerText = oReportsPtros.Id_producto_familia;
            //////newElem["id_año"].InnerText = oReportsPtros.Id_año;
            //////newElem["id_mes"].InnerText = oReportsPtros.Id_mes;
            //////newElem["id_periodo"].InnerText = oReportsPtros.Id_periodo.ToString();
            //////newElem["descripcion"].InnerText = oReportsPtros.Descripcion.ToString();

            // Agrega el nuevo elemento al final de la lista del nodo parametros.
            doc.DocumentElement.AppendChild(newElem);

            // Guarda el XML modificado a un archivo  en formato Unicode.
            doc.PreserveWhitespace = true;
            XmlTextWriter wrtr = new XmlTextWriter(url, Encoding.UTF8);
            doc.WriteTo(wrtr);
            wrtr.Close();

            return true;

        }
        public List<Reportes_parametros> Get_Parametros(Reportes_parametros oReportsPtros, string path)
        {
            // Creamos la lista genérica de Personas
            List<Reportes_parametros> oListReportes_parametros = new List<Reportes_parametros>();

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
                        Reportes_parametros oReportes_parametros = new Reportes_parametros();

                        // Aquí viene el alma de nuestro algoritmo
                        // Viajamos desde el primer al último atributo

                        int id=0,id_reporte = 0, id_servicio = 0, id_compañia = 0, id_oficina = 0,id_periodo = 0, icadena=0, inegocio=0,
                        id_tipoCiudad = 0, id_malla=0;
                        string id_user = String.Empty, id_canal = String.Empty,
                            id_punto_venta = String.Empty, id_producto_categoria = String.Empty,
                            id_producto_marca = String.Empty, id_producto_familia = String.Empty, id_año = String.Empty,
                            id_mes = String.Empty, descripcion = String.Empty, id_tipoactividad = String.Empty, fecha_fin = String.Empty, fecha_inicio = String.Empty,
                            id_tipoReporte = String.Empty, id_subCategoria = String.Empty, id_subMarca = String.Empty, skuProducto = String.Empty;
                            
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

                                    case "id_punto_venta":
                                        id_punto_venta = reader.Value;
                                        break;

                                    case "id_producto_categoria":
                                        id_producto_categoria = reader.Value;
                                        break;

                                    case "id_producto_marca":
                                        id_producto_marca = reader.Value;
                                        break;

                                    case "id_producto_familia":
                                        id_producto_familia = reader.Value;
                                        break;

                                    case "id_año":
                                        id_año = reader.Value;
                                        break;

                                    case "id_mes":
                                        id_mes = reader.Value;
                                        break;

                                    case "id_periodo":
                                        id_periodo = Convert.ToInt32(reader.Value);
                                        break;

                                    case "descripcion":
                                        descripcion = reader.Value;
                                        break;

                                    case "id_tipoactividad":
                                        id_tipoactividad = reader.Value;
                                        break;
                                    case "fecha_inicio":
                                        fecha_inicio = reader.Value;
                                        break;
                                    case "fecha_fin":
                                        fecha_fin = reader.Value;
                                        break;
                                    case "id_tipoReporte":
                                        id_tipoReporte = reader.Value;
                                        break;

                                    case "id_subCategoria":
                                        id_subCategoria = reader.Value;
                                        break;

                                    case "id_subMarca":
                                        id_subMarca = reader.Value;
                                        break;

                                    case "skuProducto":
                                        skuProducto = reader.Value;
                                        break;

                                    case "icadena":
                                        icadena = Convert.ToInt32(reader.Value);
                                        break;

                                    case "inegocio":
                                        inegocio = Convert.ToInt32(reader.Value);
                                        break;

                                    case "Id_TipoCiudad":
                                        id_tipoCiudad = Convert.ToInt32(reader.Value);
                                        break;

                                    case "Id_malla":
                                        id_malla = Convert.ToInt32(reader.Value);
                                        break;
                                }
                            }
                        }
                        bool  verificar = false;
                        if (oReportsPtros.Id_tipoReporte == null)
                        {
                            if (id_servicio == oReportsPtros.Id_servicio && id_canal == oReportsPtros.Id_canal && id_compañia == oReportsPtros.Id_compañia && id_reporte == oReportsPtros.Id_reporte && id_user == oReportsPtros.Id_user)
                                verificar = true;
                        }
                        else
                        {
                            if (id_servicio == oReportsPtros.Id_servicio && id_canal == oReportsPtros.Id_canal && id_compañia == oReportsPtros.Id_compañia && id_reporte == oReportsPtros.Id_reporte && id_user == oReportsPtros.Id_user && id_tipoReporte == oReportsPtros.Id_tipoReporte)
                                verificar = true;
                        }
                        if (verificar==true)
                        {                            
                            oReportes_parametros.Id = id;
                            oReportes_parametros.Id_servicio = id_servicio;
                            oReportes_parametros.Id_canal = id_canal;
                            oReportes_parametros.Id_compañia = id_compañia;
                            oReportes_parametros.Id_reporte = id_reporte;
                            oReportes_parametros.Id_user = id_user;

                            oReportes_parametros.Id_oficina = id_oficina;
                            oReportes_parametros.Id_punto_venta = id_punto_venta;
                            oReportes_parametros.Id_producto_categoria = id_producto_categoria;
                            oReportes_parametros.Id_producto_marca = id_producto_marca;
                            oReportes_parametros.Id_producto_familia = id_producto_familia;
                            oReportes_parametros.Id_año = id_año;
                            oReportes_parametros.Id_mes = id_mes;
                            oReportes_parametros.Id_periodo = id_periodo;
                            oReportes_parametros.Descripcion = descripcion;
                            oReportes_parametros.Id_tipoactividad = id_tipoactividad;
                            oReportes_parametros.Fecha_inicio= fecha_inicio;
                            oReportes_parametros.Fecha_fin= fecha_fin;
                            oReportes_parametros.Id_tipoReporte = id_tipoReporte;
                            oReportes_parametros.Id_subCategoria = id_subCategoria;
                            oReportes_parametros.Id_subMarca = id_subMarca;
                            oReportes_parametros.SkuProducto = skuProducto;
                            oReportes_parametros.Icadena = icadena;
                            oReportes_parametros.Inegocio= inegocio;
                            oReportes_parametros.Id_TipoCiudad = id_tipoCiudad;
                            oReportes_parametros.Id_malla = id_malla;

                            oListReportes_parametros.Add(oReportes_parametros);
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
        public Reportes_parametros[] Get_AllParametros(string path)
        {
            // Creamos la lista genérica de Personas
            List<Reportes_parametros> oListReportes_parametros = new List<Reportes_parametros>();

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
                        Reportes_parametros oReportes_parametros = new Reportes_parametros();

                        // Aquí viene el alma de nuestro algoritmo
                        // Viajamos desde el primer al último atributo

                        int id = 0, id_reporte = 0, id_servicio = 0, id_compañia = 0, id_oficina = 0,icadena=0, id_periodo = 0,
                            id_tipoCiudad = 0, id_malla=0;
                        string id_user = String.Empty, id_canal = String.Empty,
                            id_punto_venta = String.Empty, id_producto_categoria = String.Empty,
                            id_producto_marca = String.Empty, id_producto_familia = String.Empty, id_año = String.Empty,
                            id_mes = String.Empty, descripcion = String.Empty ;
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
                                        id=Convert.ToInt32(reader.Value);
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

                                    case "id_punto_venta":
                                        id_punto_venta = reader.Value;
                                        break;

                                    case "id_producto_categoria":
                                        id_producto_categoria = reader.Value;
                                        break;

                                    case "id_producto_marca":
                                        id_producto_marca = reader.Value;
                                        break;

                                    case "id_producto_familia":
                                        id_producto_familia = reader.Value;
                                        break;

                                    case "id_año":
                                        id_año = reader.Value;
                                        break;

                                    case "id_mes":
                                        id_mes = reader.Value;
                                        break;

                                    case "id_periodo":
                                        id_periodo = Convert.ToInt32(reader.Value);
                                        break;

                                    case "descripcion":
                                        descripcion = reader.Value;
                                        break;

                                    case "icadena":
                                        icadena = Convert.ToInt32(reader.Value);
                                        break;

                                    case "Id_TipoCiudad":
                                        id_tipoCiudad = Convert.ToInt32(reader.Value);
                                        break;

                                    case "Id_malla":
                                        id_malla = Convert.ToInt32(reader.Value);
                                        break;

                                }
                            }
                        }

                        oReportes_parametros.Id = id;
                        oReportes_parametros.Id_servicio = id_servicio;
                        oReportes_parametros.Id_canal = id_canal;
                        oReportes_parametros.Id_compañia = id_compañia;
                        oReportes_parametros.Id_reporte = id_reporte;
                        oReportes_parametros.Id_user = id_user;

                        oReportes_parametros.Id_oficina = id_oficina;
                        oReportes_parametros.Id_punto_venta = id_punto_venta;
                        oReportes_parametros.Id_producto_categoria = id_producto_categoria;
                        oReportes_parametros.Id_producto_marca = id_producto_marca;
                        oReportes_parametros.Id_producto_familia = id_producto_familia;
                        oReportes_parametros.Id_año = id_año;
                        oReportes_parametros.Id_mes = id_mes;
                        oReportes_parametros.Id_periodo = id_periodo;
                        oReportes_parametros.Descripcion = descripcion;
                        oReportes_parametros.Icadena = icadena;
                        oReportes_parametros.Id_TipoCiudad = id_tipoCiudad;
                        oReportes_parametros.Id_malla = id_malla;

                        oListReportes_parametros.Add(oReportes_parametros);

                        //break; solo si desea buscar un elemento
                    }
                }
                reader.Close();
            }
            // Devolvemos el listado genérico
            return oListReportes_parametros.ToArray();
        }
    }
}
