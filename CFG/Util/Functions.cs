using System;
using System.Globalization;
using System.Data;
using System.Web.UI.WebControls;
using System.IO;


namespace Lucky.CFG.Util
{
    /// <summary>
    /// Clase de Funciones generales.
    /// En este ambito NO se deben manejar Controles Webs, Conexiones de BD
    /// ni variables de Session.
    /// </summary>
    public class Functions
    {
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Functions()
        { }

        /// <summary>
        /// Prepara la cadena del mensaje de error para que no
        /// contenga caracteres no permitidos
        /// </summary>
        /// <param name="sCadena">Mensaje de error</param>
        /// <returns>Mensaje de Error preparado</returns>
        public string preparaMsgError(string sCadena)
        {
            string sNuevaCad = sCadena;
            sNuevaCad = sCadena.Replace("\n", " ");
            sNuevaCad = sNuevaCad.Replace("\r", " ");

           
            return sNuevaCad;
        }

        /// <summary>
        /// Devuelve el nombre del mes.
        /// </summary>
        /// <param name="iMes">Número de mes (Del 1 al 12)</param>
        /// <returns></returns>
        public static string obtenerNombreMes(int iMes)
        {
            if (iMes < 1 || iMes > 12)
                return "Desconocido";
            return new CultureInfo("es-Pe").DateTimeFormat.MonthNames[iMes - 1];
        }

        /// <summary>
        /// Devuelve todos los nombres de los doce meses en un arreglo de string.
        /// </summary>
        /// <returns></returns>
        public static string[] obtenerNombresMeses()
        {
            string[] meses = new CultureInfo("es-Pe").DateTimeFormat.MonthNames;
            string[] mesesListos = new string[12];

            for (int i = 0; i < 12; i++)
                mesesListos[i] = meses[i];

            return mesesListos;
        }

        /// <summary>
        /// Devuelve el nombre del dia. Tomando como primer 
        /// dia de la semana el Lunes.
        /// </summary>
        /// <param name="iMes">Número de dia (Del 1 al 7)</param>
        /// <returns></returns>
        public static string obtenerNombreDia(int iDia)
        {
            if (iDia < 1 || iDia > 7)
                return "Desconocido";

            CultureInfo ci = new CultureInfo("es-Pe");

            if (iDia == 7)
                return ci.DateTimeFormat.DayNames[0];
            return ci.DateTimeFormat.DayNames[iDia];
        }

        /// <summary>
        /// Devuelve todos los nombres de los siete dias en un arreglo de string.
        /// </summary>
        /// <returns></returns>
        public static string[] obtenerNombresDias()
        {
            return new CultureInfo("es-Pe").DateTimeFormat.DayNames;
        }

        /// <summary>
        /// Calcula la cantidad de años transcurridos a la fecha actual.
        /// </summary>
        /// <param name="dFechaInicio">Fecha de Inicio</param>
        /// <returns></returns>
        public static int calcularAnos(DateTime dFechaInicio)
        {
            int anhos = DateTime.Now.Year - dFechaInicio.Year;

            if (DateTime.Now.DayOfYear < dFechaInicio.DayOfYear)
                anhos -= 1;

            return anhos;
        }

        /// <summary>
        /// Retorna el número de dias entre 2 fechas
        /// </summary>
        /// <param name="dFechaIni"> Fecha más antigua </param>
        /// <param name="dFechaFin"> Fecha más reciente</param>
        /// <returns> Cantidad de Dias entre las fechas ingresadas </returns>
        public static int diasEntreFechas(DateTime dFechaIni, DateTime dFechaFin)
        {
            TimeSpan oTimeSpan = dFechaFin - dFechaIni;
            return oTimeSpan.Days + 1;
        }

        /// <summary>
        ///	Procedminiento que lanza PopUp
        /// </summary>
        /// <param name="awbPrin"> Pagina </param>
        /// <param name="asUrl"> Url</param>
        /// <param name="asRutPag"> Direccion </param>
        /// <param name="asLeft"> Izquierda del Scream</param>
        /// <param name="asTop"> Tope del Scream</param>
        /// <param name="asWith"> Ancho </param>
        /// <param name="asHeight"> Alto </param>
        /// <param name="asResizable"> Resizable  (yes - no)</param>
        /// <param name="asScrollbars"> Scrollbars (yes - no) </param>
        /// <param name="asToolBar"> ToolBar  (yes - no)</param>
        /// <param name="asStatus"> Status  (yes - no)</param>
        /// <param name="asCreateNewEntry"> Crea una nueva entrada o refresca los resultado sobre la ventana PopUp Levantada  (true - false)</param>
        public static void ProPopUp(CFG.Web.SessionControl awbPrin, string asUrl, string asRutPag, string asLeft, string asTop, string asWith, string asHeight, string asResizable, string asScrollbars, string asToolBar, string asStatus, string asCreateNewEntry)
        {
            string lsScp;

            lsScp = "";
            lsScp += "<script language=JavaScript> ";
            lsScp += "window.open('" + asUrl + asRutPag + "','PopUp','left=" + asLeft + ",top=" + asTop + ",width=" + asWith + ",height=" + asHeight + ",resizable=" + asResizable + ",scrollbars=" + asScrollbars + ",toolbar=" + asToolBar + ",status=" + asStatus + "'," + asCreateNewEntry + ");";
            lsScp += "</script>";

            awbPrin.ClientScript.RegisterClientScriptBlock(System.Type.GetType("System.String"), "PopUp", lsScp);
        }

        /// <summary>
        ///	Procedminiento que lanza PopUp
        /// </summary>
        /// <param name="awbPrin"> Pagina </param>
        /// <param name="asUrl"> Url</param>
        /// <param name="asRutPag"> Direccion </param>
        /// <param name="asRutPag"> Direccion de Pagina Consolidada </param>
        /// <param name="asLeft"> Izquierda del Scream</param>
        /// <param name="asTop"> Tope del Scream</param>
        /// <param name="asWith"> Ancho </param>
        /// <param name="asHeight"> Alto </param>
        /// <param name="asResizable"> Resizable  (yes - no)</param>
        /// <param name="asScrollbars"> Scrollbars (yes - no) </param>
        /// <param name="asToolBar"> ToolBar  (yes - no)</param>
        /// <param name="asStatus"> Status  (yes - no)</param>
        /// <param name="asCreateNewEntry"> Crea una nueva entrada o refresca los resultado sobre la ventana PopUp Levantada  (true - false)</param>
        /// <param name="abRepCon"> Indicador de Reporte Consolidado</param>
        public static void ProPopUp(Lucky.CFG.Web.SessionControl awbPrin, string asUrl, string asRutPag, string asRutPagCon, string asLeft, string asTop, string asWith, string asHeight, string asResizable, string asScrollbars, string asToolBar, string asStatus, string asCreateNewEntry, bool abRepCon)
        {
            string lsScp;

            lsScp = "";
            lsScp += "<script language=JavaScript> ";
            lsScp += "window.open('" + asUrl + asRutPag + "','PopUp1','left=" + asLeft + ",top=" + asTop + ",width=" + asWith + ",height=" + asHeight + ",resizable=" + asResizable + ",scrollbars=" + asScrollbars + ",toolbar=" + asToolBar + ",status=" + asStatus + "'," + asCreateNewEntry + "); ";

            if (abRepCon)
                lsScp += "window.open('" + asUrl + asRutPagCon + "','PopUp2','left=" + asLeft + ",top=" + asTop + ",width=" + asWith + ",height=" + asHeight + ",resizable=" + asResizable + ",scrollbars=" + asScrollbars + ",toolbar=" + asToolBar + ",status=" + asStatus + "'," + asCreateNewEntry + "); ";

            lsScp += "</script>";

            awbPrin.ClientScript.RegisterClientScriptBlock(System.Type.GetType("System.String"), "PopUp", lsScp);

        }

        /// <summary>
        ///	Procedminiento que Cierra la pagina Web
        /// </summary>
        /// <param name="awbPrin"> Pagina </param>
        public static void ProCerrar(Lucky.CFG.Web.SessionControl awbPrin)
        {
            string lsScp;

            lsScp = "";
            lsScp += "<script language=JavaScript> ";
            lsScp += "window.close();";
            lsScp += "</script>";

            awbPrin.ClientScript.RegisterClientScriptBlock(System.Type.GetType("System.String"), "close", lsScp);
        }




        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private DataTable _dtDatos = null;
        private DataRow[] _drDatos = null;
        private string _text;
        private string _field;


        public Functions(DataRow[] drDatos, string text, string field)
        {
            _drDatos = drDatos;
            _text = text;
            _field = field;
        }


        public Functions(DataTable dtDatos, string text, string field)
        {
            _dtDatos = dtDatos;
            _text = text;
            _field = field;
        }

        public static bool IsDate(string sdate)
        {
            DateTime dt;
            bool isDate = true;
            try
            {
                dt = DateTime.Parse(sdate);
            }
            catch
            {
                isDate = false;
            }
            return isDate;
        }

        public static bool IsNumeric(string theValue)
        {
            try
            {
                Convert.ToDouble(theValue);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Boolean WriteFile(string strTexto, string FileName)
        {
            Boolean blnOk = false;

            try
            {
                StreamWriter sr;
                sr = File.CreateText(FileName);

                string aLine = null;
                StringReader sw = new StringReader(strTexto);

                while (true)
                {
                    aLine = sw.ReadLine();
                    if (aLine != null)
                        sr.WriteLine(aLine);
                    else
                        break;
                }
                sr.Close();
            }
            catch
            {
                blnOk = false;
            }
            return (blnOk);
        }

        public static Boolean WriteFileAppend(string strTexto, string FileName)
        {
            Boolean blnok = false;
            StreamWriter sr;

            try
            {
                if (!File.Exists(FileName))
                {
                    sr = File.CreateText(FileName);
                    sr.Close();
                }


                sr = File.AppendText(FileName);
                sr.WriteLine(strTexto);
                sr.Close();
                blnok = true;
            }
            catch
            {
                blnok = false;
            }
            finally
            {
                GC.Collect();
            }

            return (blnok);
        }

        public static bool WriteFileDoc(string strTexto, string FileName, string FilePlantilla)
        {
            Boolean blnok = false;

            Stream instream = null;
            BufferedStream bufin = null;

            try
            {
                if (File.Exists(FileName))
                    File.Delete(FileName);


                instream = File.OpenRead(FilePlantilla);
                bufin = new BufferedStream(instream);
                byte[] bytes = new byte[4096];
                bufin.Read(bytes, 0, 4096);
                string sTemplate = System.Text.Encoding.ASCII.GetString(bytes);
                instream.Close();
                bufin.Close();

                StreamWriter sr = File.AppendText(FileName);
                sr.WriteLine(sTemplate.Trim() + strTexto);
                sr.Close();

                blnok = true;
            }
            catch
            {
                blnok = false;
            }
            finally
            {
                instream = null;
                bufin = null;
                GC.Collect();
            }

            return (blnok);
        }

        public static Int32 GenerateFileName()
        {
            int ultimoTick = 0;
            while (ultimoTick == Environment.TickCount)
            {
                System.Threading.Thread.Sleep(1);
            }

            ultimoTick = Environment.TickCount;
            ultimoTick = ultimoTick - (28 * (ultimoTick / 28));

            if (ultimoTick > 28)
                ultimoTick -= 28;

            if (ultimoTick < 1)
                ultimoTick = 0;

            return ultimoTick;
        }

        public static string ToXmlString(DataTable dtTmp)
        {
            string sE = Convert.ToString((char)13) + Convert.ToString((char)10);
            string sQ = Convert.ToString((char)34);
            string sXml = "";
            try
            {
                if (dtTmp.Rows.Count > 0)
                {
                    sXml = @"<ROOT>" + sE;
                    foreach (DataRow dr in dtTmp.Rows)
                    {
                        sXml += @"<" + dtTmp.TableName + " ";
                        foreach (DataColumn dc in dtTmp.Columns)
                        {
                            sXml += @dc.ColumnName + "=" + sQ + dr[dc.ColumnName].ToString().Trim() + sQ + " ";
                        }
                        sXml += @">" + "</" + dtTmp.TableName + ">" + sE;
                    }
                    sXml += @"</ROOT>";
                }
            }
            catch
            {
                sXml = "";
            }
            return sXml;
        }

        public static string ToXmlString(DataTable dtTmp, string[,] strArray)
        {
            string sE = Convert.ToString((char)13) + Convert.ToString((char)10);
            string sQ = Convert.ToString((char)34);
            string sXml = "";
            try
            {
                if (dtTmp.Rows.Count > 0)
                {
                    sXml = @"<ROOT>" + sE;
                    foreach (DataRow dr in dtTmp.Rows)
                    {
                        sXml += @"<" + dtTmp.TableName + " ";

                        for (int i = 0; i < strArray.GetLength(0); i++)
                        {
                            sXml += @strArray[i, 0].ToString() + "=" + sQ + dr[strArray[i, 0].ToString()].ToString().Trim() + sQ + " ";
                        }
                        sXml += @">" + "</" + dtTmp.TableName + ">" + sE;
                    }
                    sXml += @"</ROOT>";
                }
            }
            catch
            {
                sXml = "";
            }
            return sXml;
        }

        public static string ToXmlString(DataRow[] drs, string TableName)
        {
            string sE = Convert.ToString((char)13) + Convert.ToString((char)10);
            string sQ = Convert.ToString((char)34);
            string sXml = "";
            try
            {
                if (drs.Length > 0)
                {
                    sXml = @"<ROOT>" + sE;
                    foreach (DataRow dr in drs)
                    {
                        sXml += @"<" + TableName + " ";
                        foreach (DataColumn dc in dr.Table.Columns)
                        {
                            // SI ES TIPO DE DATO NUMERICO  . EN VEZ DE COMA
                            if (dc.DataType == Type.GetType("System.Int32") ||
                                dc.DataType == Type.GetType("System.Double") ||
                                dc.DataType == Type.GetType("System.Decimal"))
                                sXml += @dc.ColumnName + "=" + sQ + dr[dc.ColumnName].ToString().Replace(",", ".").Trim() + sQ + " ";
                            else
                                sXml += @dc.ColumnName + "=" + sQ + dr[dc.ColumnName].ToString().Trim() + sQ + " ";
                        }
                        sXml += @">" + "</" + TableName + ">" + sE;
                    }
                    sXml += @"</ROOT>";
                }
            }
            catch
            {
                sXml = "";
            }
            return sXml;

        }

        public ListItem[] LoadDropDown()
        {
            ListItem[] _items = new ListItem[_dtDatos.Rows.Count];
            Int32 _cont = 0;
            if (_dtDatos.Rows.Count > 0)
            {
                foreach (DataRow dr in _dtDatos.Rows)
                {
                    _items[_cont] = new ListItem(dr[_text].ToString().Trim(), dr[_field].ToString().Trim());
                    _cont++;
                }
            }
            return _items;
        }

        public ListItem[] LoadDropDownNew()
        {
            ListItem[] _items = new ListItem[_dtDatos.Rows.Count + 1];
            Int32 _cont = 0;
            _items[_cont] = new ListItem("NUEVO", "NUEVO");
            _cont++;

            if (_dtDatos.Rows.Count > 0)
            {
                foreach (DataRow dr in _dtDatos.Rows)
                {
                    _items[_cont] = new ListItem(dr[_text].ToString().Trim(), dr[_field].ToString().Trim());
                    _cont++;
                }
            }
            return _items;
        }

        public ListItem[] LoadDropDownAll()
        {
            ListItem[] _items = new ListItem[_dtDatos.Rows.Count + 1];
            Int32 _cont = 0;
            _items[_cont] = new ListItem("[TODAS]", "");
            _cont++;

            if (_dtDatos.Rows.Count > 0)
            {
                foreach (DataRow dr in _dtDatos.Rows)
                {
                    _items[_cont] = new ListItem(dr[_text].ToString().Trim(), dr[_field].ToString().Trim());
                    _cont++;
                }
            }
            return _items;
        }

        public ListItem[] LoadDropDownNothing()
        {
            ListItem[] _items = null;
            Int32 intList = 1;

            try
            {
                if (_drDatos == null)
                {
                    _drDatos = new DataRow[_dtDatos.Rows.Count];
                    _dtDatos.Rows.CopyTo(_drDatos, 0);
                }


                if (_drDatos.GetLength(0) > 0)
                    intList = _drDatos.GetLength(0);

                _items = new ListItem[intList];
                Int32 _cont = 0;


                if (_drDatos.GetLength(0) > 0)
                {
                    foreach (DataRow dr in _drDatos)
                    {
                        _items[_cont] = new ListItem(dr[_text].ToString().Trim(), dr[_field].ToString().Trim());
                        _cont++;
                    }
                }
                else
                    _items[_cont] = new ListItem("NINGUNO", "NINGUNO");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return _items;
        }

        public ListItem[] LoadDropDownNull()
        {
            ListItem[] _items = new ListItem[_dtDatos.Rows.Count + 1];
            Int32 _cont = 0;


            if (_dtDatos.Rows.Count > 0)
            {
                _items[_cont] = new ListItem("[SELECCIONAR]", "");
                _cont++;

                foreach (DataRow dr in _dtDatos.Rows)
                {
                    _items[_cont] = new ListItem(dr[_text].ToString().Trim(), dr[_field].ToString().Trim());
                    _cont++;
                }
            }
            else
                _items[_cont] = new ListItem("NINGUNO", "NINGUNO");

            return _items;
        }

        public ListItem[] LoadDropDownNull2()
        {
            ListItem[] _items = new ListItem[_dtDatos.Rows.Count + 1];
            Int32 _cont = 0;

            if (_dtDatos.Rows.Count > 0)
            {
                _items[_cont] = new ListItem("NINGUNO", "NINGUNO");
                _cont++;

                foreach (DataRow dr in _dtDatos.Rows)
                {
                    _items[_cont] = new ListItem(dr[_text].ToString().Trim(), dr[_field].ToString().Trim());
                    _cont++;
                }
            }
            else
                _items[_cont] = new ListItem("NINGUNO", "NINGUNO");

            return _items;
        }
        public static DataTable ConvertToDataTable(string[] headers, string[][] content)
        {
            DataTable dt = new DataTable();
            foreach (string header in headers)
            {
                if (header == "validado")
                    dt.Columns.Add(header, Type.GetType("System.Boolean"));
                else
                    dt.Columns.Add(header, Type.GetType("System.String"));
            }
            
            DataRow dr;

            for (int i = 0; i < content.Length; i++)
            {
                dr = dt.NewRow();
                for (int j = 0; j < content[i].Length; j++)
                {
                    dr[j] = content[i][j];
                }
                dt.Rows.Add(dr);
            }

            return dt;
        }
    }
}