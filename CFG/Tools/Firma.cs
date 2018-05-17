using System;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using System.Configuration;

namespace Lucky.CFG.Tools
{
    public class Firma : System.Web.UI.Page
    {
        public String _inputImagePath;

        public byte[] imagen;



        public DataTable Consultatodos()
        {

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConectaDBLucky"].ConnectionString);

            SqlDataAdapter DbDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            DbDataAdapter.SelectCommand = cn.CreateCommand();
            DbDataAdapter.SelectCommand.CommandText = "Select * from  firma";


            //Hago la consulta
            DataTable tabla = new DataTable();
            DbDataAdapter.Fill(tabla);
            return tabla;
        }
        public DataTable Consulta(string nombre, string apePaterno, string apeMaterno,string cargo)
        {

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConectaDBLucky"].ConnectionString);

            SqlDataAdapter DbDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            DbDataAdapter.SelectCommand = cn.CreateCommand();
            DbDataAdapter.SelectCommand.CommandText = "Select * from  firma where Nombre='" + nombre + "' and ApellidoPaterno='" + apePaterno + "' and ApellidoMaterno='" + apeMaterno + "' and Cargo='"+ cargo+"'";


            //Hago la consulta
            DataTable tabla = new DataTable();
            DbDataAdapter.Fill(tabla);
            return tabla;
        }
        public void Actualizar(string id,string nombre, string apePaterno, string apeMaterno, string cargo, string celular, string telefono, string anexo, byte[] firma,string RPM, string Nextel)
        {
          

                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConectaDBLucky"].ConnectionString);

                SqlCommand oSqlCommand = new SqlCommand(" UPDATE firma SET Nombre=@Nombre,ApellidoPaterno=@ApellidoPaterno,ApellidoMaterno=@ApellidoMaterno,Cargo=@Cargo,Celular=@Celular,telefono=@telefono,anexo=@anexo,imagen=@imagen, RPM=@RPM,Nextel=@Nextel  where  idFirma=@id", cn);

                oSqlCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                oSqlCommand.Parameters["@id"].Value = Convert.ToInt32(id);
                oSqlCommand.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
                oSqlCommand.Parameters["@Nombre"].Value = nombre;
                oSqlCommand.Parameters.Add(new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar));
                oSqlCommand.Parameters["@ApellidoPaterno"].Value = apePaterno;
                oSqlCommand.Parameters.Add(new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar));
                oSqlCommand.Parameters["@ApellidoMaterno"].Value = apeMaterno;
                oSqlCommand.Parameters.Add(new SqlParameter("@Cargo", SqlDbType.VarChar));
                oSqlCommand.Parameters["@Cargo"].Value = cargo;
                oSqlCommand.Parameters.Add(new SqlParameter("@Celular", SqlDbType.VarChar));
                oSqlCommand.Parameters["@Celular"].Value = celular;
                oSqlCommand.Parameters.Add(new SqlParameter("@telefono", SqlDbType.VarChar));
                oSqlCommand.Parameters["@telefono"].Value = telefono;
                oSqlCommand.Parameters.Add(new SqlParameter("@anexo", SqlDbType.VarChar));
                oSqlCommand.Parameters["@anexo"].Value = anexo;
                oSqlCommand.Parameters.Add(new SqlParameter("@imagen", SqlDbType.Image));
                oSqlCommand.Parameters["@imagen"].Value = firma;
                oSqlCommand.Parameters.Add(new SqlParameter("@RPM", SqlDbType.VarChar));
                oSqlCommand.Parameters["@RPM"].Value = RPM;
                oSqlCommand.Parameters.Add(new SqlParameter("@Nextel", SqlDbType.VarChar));
                oSqlCommand.Parameters["@Nextel"].Value = Nextel;


            


                oSqlCommand.Connection.Open();
                oSqlCommand.ExecuteNonQuery();
                oSqlCommand.Connection.Close();
                imagen = null;

        }

        public void Delete(string id)
        {
            

                 SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConectaDBLucky"].ConnectionString);

                 SqlCommand oSqlCommand = new SqlCommand("delete from [firma] where idFirma=@id", cn);

                 oSqlCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                 oSqlCommand.Parameters["@id"].Value = Convert.ToInt32(id);


                oSqlCommand.Connection.Open();
                oSqlCommand.ExecuteNonQuery();
                oSqlCommand.Connection.Close();

        }

        public void insertarimagen()
        {
            try
            {

                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConectaDBLucky"].ConnectionString);

                SqlCommand oSqlCommand = new SqlCommand(" UPDATE firma SET imagen=@imagen  where  idFirma=@id", cn);

                oSqlCommand.Parameters.Add(new SqlParameter("@imagen", SqlDbType.Image));
                oSqlCommand.Parameters["@imagen"].Value = imagen;
                oSqlCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                string ff = Session["id"].ToString();
                oSqlCommand.Parameters["@id"].Value = Convert.ToInt32(Session["id"].ToString());

                oSqlCommand.Connection.Open();
                oSqlCommand.ExecuteNonQuery();
                oSqlCommand.Connection.Close();
                imagen = null;

            }
            catch
            {

            }

        }

        public void registrar(string nombre, string apePaterno, string apeMaterno, string cargo, string celular, string telefono, string anexo, byte[] firma, string RPM, string Nextel)
        {
           
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConectaDBLucky"].ConnectionString);

                SqlCommand oSqlCommand = new SqlCommand(" insert into firma(Nombre,ApellidoPaterno,ApellidoMaterno,Cargo,Celular,telefono,anexo,imagen,RPM,Nextel) values(@Nombre,@ApellidoPaterno,@ApellidoMaterno,@Cargo,@Celular,@telefono,@anexo,@imagen,@RPM,@Nextel)", cn);

                oSqlCommand.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
                oSqlCommand.Parameters["@Nombre"].Value = nombre;
                oSqlCommand.Parameters.Add(new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar));
                oSqlCommand.Parameters["@ApellidoPaterno"].Value = apePaterno;
                oSqlCommand.Parameters.Add(new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar));
                oSqlCommand.Parameters["@ApellidoMaterno"].Value = apeMaterno;
                oSqlCommand.Parameters.Add(new SqlParameter("@Cargo", SqlDbType.VarChar));
                oSqlCommand.Parameters["@Cargo"].Value = cargo;
                oSqlCommand.Parameters.Add(new SqlParameter("@Celular", SqlDbType.VarChar));
                oSqlCommand.Parameters["@Celular"].Value = celular;
                oSqlCommand.Parameters.Add(new SqlParameter("@telefono", SqlDbType.VarChar));
                oSqlCommand.Parameters["@telefono"].Value = telefono;
                oSqlCommand.Parameters.Add(new SqlParameter("@anexo", SqlDbType.VarChar));
                oSqlCommand.Parameters["@anexo"].Value = anexo;
                oSqlCommand.Parameters.Add(new SqlParameter("@imagen", SqlDbType.Image));
                oSqlCommand.Parameters["@imagen"].Value = firma;
                oSqlCommand.Parameters.Add(new SqlParameter("@RPM", SqlDbType.VarChar));
                oSqlCommand.Parameters["@RPM"].Value = RPM;
                oSqlCommand.Parameters.Add(new SqlParameter("@Nextel", SqlDbType.VarChar));
                oSqlCommand.Parameters["@Nextel"].Value = Nextel;



                oSqlCommand.Connection.Open();
                oSqlCommand.ExecuteNonQuery();
                oSqlCommand.Connection.Close();
                imagen = null;



      
        }


        //metodo para recortar la imagen
        public byte[] CropImageFile(byte[] imageFile, int targetW, int targetH, int targetX, int targetY)
        {

            System.Drawing.Image imgPhoto = System.Drawing.Image.FromStream(new MemoryStream(imageFile));
            Bitmap bmPhoto = new Bitmap(targetW, targetH, PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);
            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.SmoothingMode = SmoothingMode.AntiAlias;
            grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;
            grPhoto.PixelOffsetMode = PixelOffsetMode.HighQuality;
            grPhoto.DrawImage(imgPhoto, new Rectangle(0, 0, targetW, targetH), targetX, targetY, targetW, targetH, GraphicsUnit.Pixel);
            // Save out to memory and then to a file.  We dispose of all objects to make sure the files don't stay locked.
            MemoryStream mm = new MemoryStream();
            bmPhoto.Save(mm, System.Drawing.Imaging.ImageFormat.Png);
            imgPhoto.Dispose();
            bmPhoto.Dispose();
            grPhoto.Dispose();
            return mm.GetBuffer();
        }

        //metodo para convertir a image desde una ruta donde se encuentra una imagen
        public System.Drawing.Image urlimagenToImagen(string url)
        {
            FileStream fs;
            System.Drawing.Image imag;
            fs = new FileStream(Server.MapPath(url), FileMode.Open, FileAccess.Read);

            imag = System.Drawing.Image.FromStream(fs);
            fs.Close();

            return imag;
        }


        public void MImage(string ImagePath, byte[] byteArrayIn)
        { 
             try
            {
            FileStream fc;


            imagen = byteArrayIn;

            System.Drawing.Image img = byteArrayToImage(byteArrayIn);
            img = img.GetThumbnailImage(312, 112, null, IntPtr.Zero);
            byteArrayIn = null;
            byteArrayIn = imageToByteArray(img);
            // insertarimagen();
            if (Session["Consulta"].ToString() != "consulta")
            {
                if (Session["Actualizar"] != null)
                {
                    Actualizar(Session["idfirma"].ToString(), Session["txtNombre"].ToString(), Session["txtApePaterno"].ToString(), Session["txtApeMaterno"].ToString(), Session["txtCargo"].ToString(), Session["txtCelular"].ToString(), Session["txtTelefono"].ToString(), Session["txtAnexo"].ToString(), imagen, Session["txtCelularRPM"].ToString(), Session["txtCelularNextel"].ToString());
                }
                else
                {
                    registrar(Session["txtNombre"].ToString(), Session["txtApePaterno"].ToString(), Session["txtApeMaterno"].ToString(), Session["txtCargo"].ToString(), Session["txtCelular"].ToString(), Session["txtTelefono"].ToString(), Session["txtAnexo"].ToString(), imagen, Session["txtCelularRPM"].ToString(), Session["txtCelularNextel"].ToString());
                }
            }
            // string t = Session["for"].ToString();
            string t = "firma";
            _inputImagePath = ImagePath;

                fc = File.Create(Server.MapPath(t + ".Png"));
                fc.Write(byteArrayIn, 0, byteArrayIn.Length);
                fc.Flush();
                fc.Close();


                if (Session["Actualizar"] != null)
                {
                    Session["mensaje"] = "Se Actualizo correctamente";
                }
                else
                {
                    Session["mensaje"] = "Se Registro correctamente";
                }
                Session["Actualizar"] = null;

            }
            catch
            {
                Session["mensaje"] = "EL registro ya existe en la base de datos";
                Session["Actualizar"] = "";
            }
        }
        // De image a byte []:
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            Session["array"] = ms.ToArray();
            return ms.ToArray();
        }
        // De byte [] a image:
        public System.Drawing.Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            return returnImage;
        }
    }
}
