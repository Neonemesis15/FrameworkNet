using System;
using System.Data;
using System.Configuration;
using System.IO;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


namespace Lucky.CFG.Util
{
    public class GridViewExportUtil
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="gv"></param>
        public static void Export(string fileName, GridView gv)
        {
            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.AddHeader(
                "content-disposition", string.Format("attachment; filename={0}", fileName));
            HttpContext.Current.Response.ContentType = "application/ms-excel";

            using (StringWriter sw = new StringWriter())
            {
                using (HtmlTextWriter htw = new HtmlTextWriter(sw))
                {
                    //  Create a form to contain the grid
                    Table table = new Table();

                    //  add the header row to the table
                    if (gv.HeaderRow != null)
                    {
                        GridViewExportUtil.PrepareControlForExport(gv.HeaderRow);
                        table.Rows.Add(gv.HeaderRow);
                    }

                    //  add each of the data rows to the table
                    foreach (GridViewRow row in gv.Rows)
                    {
                        GridViewExportUtil.PrepareControlForExport(row);
                        table.Rows.Add(row);
                    }

                    //  add the footer row to the table
                    if (gv.FooterRow != null)
                    {
                        GridViewExportUtil.PrepareControlForExport(gv.FooterRow);
                        table.Rows.Add(gv.FooterRow);
                    }

                    //  render the table into the htmlwriter
                    table.RenderControl(htw);

                    //  render the htmlwriter into the response
                    HttpContext.Current.Response.Write(sw.ToString());
                    HttpContext.Current.Response.End();
                }
            }
        }

        /// <summary>
        /// Replace any of the contained controls with literals
        /// </summary>
        /// <param name="control"></param>
        private static void PrepareControlForExport(Control control)
        {
            for (int i = 0; i < control.Controls.Count; i++)
            {
                Control current = control.Controls[i];
                if (current is LinkButton)
                {
                    control.Controls.Remove(current);
                    control.Controls.AddAt(i, new LiteralControl((current as LinkButton).Text));
                }
                else if (current is ImageButton)
                {
                    control.Controls.Remove(current);
                    control.Controls.AddAt(i, new LiteralControl((current as ImageButton).AlternateText));
                }
                else if (current is HyperLink)
                {
                    control.Controls.Remove(current);
                    control.Controls.AddAt(i, new LiteralControl((current as HyperLink).Text));
                }
                else if (current is DropDownList)
                {
                    control.Controls.Remove(current);
                    control.Controls.AddAt(i, new LiteralControl((current as DropDownList).SelectedItem.Text));
                }
                else if (current is CheckBox)
                {
                    control.Controls.Remove(current);
                    control.Controls.AddAt(i, new LiteralControl((current as CheckBox).Checked ? "Si" : "No"));
                }

                if (current.HasControls())
                {
                    GridViewExportUtil.PrepareControlForExport(current);
                }
            }
        }
        public static void ExportToExcelMethodTwo(string strFileName,GridView gv)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            System.IO.StringWriter sw = new System.IO.StringWriter(sb);
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            Page page = new Page();
            HtmlForm form = new HtmlForm();

            //GridView1.EnableViewState = false;
            //GridView1.AllowPaging = false;
            //gv.DataBind();

            page.EnableEventValidation = false;
            page.DesignerInitialize();
            page.Controls.Add(form);

            
            if (gv.HeaderRow != null)
            {
                GridViewExportUtil.PrepareControlForExport(gv.HeaderRow);
            }


            //  add each of the data rows to the table
            foreach (GridViewRow row in gv.Rows)
            {
                GridViewExportUtil.PrepareControlForExport(row);          
            }

            //  add the footer row to the table
            if (gv.FooterRow != null)
            {
                GridViewExportUtil.PrepareControlForExport(gv.FooterRow);
            }

            form.Controls.Add(gv);
            page.RenderControl(htw);


            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.Buffer = true;
            HttpContext.Current.Response.ContentType = "application/ms-excel";// vnd.ms-excel";
            HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment;filename=" + strFileName + ".xls");
            HttpContext.Current.Response.Charset = "UTF-8";

            HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.Default;
            HttpContext.Current.Response.Write(sb.ToString());
            HttpContext.Current.Response.End();
        }

        public static void ExportToExcelMethodThree(string strFileName, GridView gv, GridView gv2)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            System.IO.StringWriter sw = new System.IO.StringWriter(sb);
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            Page page = new Page();
            HtmlForm form = new HtmlForm();


            //GridView1.EnableViewState = false;
            //GridView1.AllowPaging = false;
            //gv.DataBind();

            page.EnableEventValidation = true;
            page.DesignerInitialize();
            page.Controls.Add(form);
            


            if (gv.HeaderRow != null)
            {
                GridViewExportUtil.PrepareControlForExport(gv.HeaderRow);
            }


            //  add each of the data rows to the table
            foreach (GridViewRow row in gv.Rows)
            {
                GridViewExportUtil.PrepareControlForExport(row);
            }

            //  add the footer row to the table
            if (gv.FooterRow != null)
            {
                GridViewExportUtil.PrepareControlForExport(gv.FooterRow);
            }




            if (gv2.HeaderRow != null)
            {
                GridViewExportUtil.PrepareControlForExport(gv2.HeaderRow);
            }
            
            //  add each of the data rows to the table
            foreach (GridViewRow row in gv2.Rows)
            {
                GridViewExportUtil.PrepareControlForExport(row);
            }

            //  add the footer row to the table
            if (gv2.FooterRow != null)
            {
                GridViewExportUtil.PrepareControlForExport(gv2.FooterRow);
            }

            form.Controls.Add(gv);
            form.Controls.Add(gv2);
            page.RenderControl(htw);

            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.Buffer = true;
            HttpContext.Current.Response.ContentType = "application/ms-excel";// vnd.ms-excel";
            HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment;filename=" + strFileName + ".xls");
            HttpContext.Current.Response.Charset = "UTF-8";

            HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.Default;
            HttpContext.Current.Response.Write(sb.ToString());
            HttpContext.Current.Response.End();
        }

        public static void ExportToExcelMethodsix(string strFileName, GridView gv, GridView gv2, GridView gv3, GridView gv4, GridView gv5, GridView gv6)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            System.IO.StringWriter sw = new System.IO.StringWriter(sb);
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            Page page = new Page();
            HtmlForm form = new HtmlForm();


            //GridView1.EnableViewState = false;
            //GridView1.AllowPaging = false;
            //gv.DataBind();

            page.EnableEventValidation = true;
            page.DesignerInitialize();
            page.Controls.Add(form);



            if (gv.HeaderRow != null)
            {
                GridViewExportUtil.PrepareControlForExport(gv.HeaderRow);
            }


            //  add each of the data rows to the table
            foreach (GridViewRow row in gv.Rows)
            {
                GridViewExportUtil.PrepareControlForExport(row);
            }

            //  add the footer row to the table
            if (gv.FooterRow != null)
            {
                GridViewExportUtil.PrepareControlForExport(gv.FooterRow);
            }




            if (gv2.HeaderRow != null)
            {
                GridViewExportUtil.PrepareControlForExport(gv2.HeaderRow);
            }

            //  add each of the data rows to the table
            foreach (GridViewRow row in gv2.Rows)
            {
                GridViewExportUtil.PrepareControlForExport(row);
            }

            //  add the footer row to the table
            if (gv2.FooterRow != null)
            {
                GridViewExportUtil.PrepareControlForExport(gv2.FooterRow);
            }



            if (gv3.HeaderRow != null)
            {
                GridViewExportUtil.PrepareControlForExport(gv3.HeaderRow);
            }

            //  add each of the data rows to the table
            foreach (GridViewRow row in gv3.Rows)
            {
                GridViewExportUtil.PrepareControlForExport(row);
            }

            //  add the footer row to the table
            if (gv3.FooterRow != null)
            {
                GridViewExportUtil.PrepareControlForExport(gv3.FooterRow);
            }


            if (gv4.HeaderRow != null)
            {
                GridViewExportUtil.PrepareControlForExport(gv4.HeaderRow);
            }

            //  add each of the data rows to the table
            foreach (GridViewRow row in gv4.Rows)
            {
                GridViewExportUtil.PrepareControlForExport(row);
            }

            //  add the footer row to the table
            if (gv4.FooterRow != null)
            {
                GridViewExportUtil.PrepareControlForExport(gv4.FooterRow);
            }


            if (gv5.HeaderRow != null)
            {
                GridViewExportUtil.PrepareControlForExport(gv5.HeaderRow);
            }

            //  add each of the data rows to the table
            foreach (GridViewRow row in gv2.Rows)
            {
                GridViewExportUtil.PrepareControlForExport(row);
            }

            //  add the footer row to the table
            if (gv5.FooterRow != null)
            {
                GridViewExportUtil.PrepareControlForExport(gv5.FooterRow);
            }


            if (gv6.HeaderRow != null)
            {
                GridViewExportUtil.PrepareControlForExport(gv6.HeaderRow);
            }

            //  add each of the data rows to the table
            foreach (GridViewRow row in gv.Rows)
            {
                GridViewExportUtil.PrepareControlForExport(row);
            }

            //  add the footer row to the table
            if (gv6.FooterRow != null)
            {
                GridViewExportUtil.PrepareControlForExport(gv6.FooterRow);
            }

          

            form.Controls.Add(gv);
            form.Controls.Add(gv2);
            form.Controls.Add(gv3);
            form.Controls.Add(gv4);
            form.Controls.Add(gv5);
            form.Controls.Add(gv6);
            page.RenderControl(htw);

            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.Buffer = true;
            HttpContext.Current.Response.ContentType = "application/ms-excel";// vnd.ms-excel";
            HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment;filename=" + strFileName + ".xls");
            HttpContext.Current.Response.Charset = "UTF-8";

            HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.Default;
            HttpContext.Current.Response.Write(sb.ToString());
            HttpContext.Current.Response.End();
        }

        public static void ExportDataTableToExcel(DataTable dt,string file_name)
        {

            HttpContext context = HttpContext.Current;

            string attachment = "attachment; filename="+file_name+".xls";


            context.Response.ClearContent();

            context.Response.AddHeader("content-disposition", attachment);

            context.Response.ContentType = "application/vnd.ms-excel";

            string tab = "";

            foreach (DataColumn dc in dt.Columns)
            {

                context.Response.Write(tab + dc.ColumnName);

                tab = "\t";

            }

            context.Response.Write("\n");



            int i;

            foreach (DataRow dr in dt.Rows)
            {

                tab = "";

                for (i = 0; i < dt.Columns.Count; i++)
                {

                    context.Response.Write(tab + dr[i].ToString());

                    tab = "\t";

                }

                context.Response.Write("\n");

            }

            context.Response.End();
        }
        public static void ExportDataTableToCSV(DataTable dt, string filename)
        {
            DataTable toExcel = dt.Copy();
            HttpContext context = HttpContext.Current;

            /* Iteramos cada una de las columnas del datatable para
            * escribir el encabezado del CSV */
            foreach (DataColumn column in toExcel.Columns)
            {
                context.Response.Write(column.ColumnName + ",");

            }
            // Creamos una nueva linea en el archivo despues de escribir el
            // encabezado
            context.Response.Write(Environment.NewLine);

            /* Empezamos a escribir cada una de las columnas
            * de cada fila separadas por comas */
            foreach (DataRow row in toExcel.Rows)
            {
                for (int i = 0; i < toExcel.Columns.Count; i++)
                {
                    context.Response.Write(row[i].ToString().Replace(",", string.Empty) + ",");
                }
                // Se finalizo de escribir la fila, asi que creamos una nueva linea
                context.Response.Write(Environment.NewLine);
            }

            // Agregamos los headers HTTP para que el archivo sea descargado
            context.Response.ContentType = "text/csv";
            context.Response.AppendHeader("Content-Disposition", "attachment; filename=" + filename + ".csv");
            context.Response.End();
        }
    }
}
