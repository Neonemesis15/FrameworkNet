using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application
{
    public class EMenuDetalle
    {
        private int id_MenuD;

     
        private int id_Menu;
        private string descripcion;
        private string url;
        private string url_foto;
        private int id_Padre;
        private string id_objeto;
        private bool menuD_Status;
        private string createBy;
        private DateTime dateBy;
        private string modiBy;
        private DateTime dateModiBy;
 



        public EMenuDetalle() { }

         [JsonProperty("a")]
        public int Id_MenuD
        {
            get { return id_MenuD; }
            set { id_MenuD = value; }
        }

         [JsonProperty("b")]
        public int Id_Menu
        {
            get { return id_Menu; }
            set { id_Menu = value; }
        }

         [JsonProperty("c")]
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

         [JsonProperty("d")]
        public string Url
        {
            get { return url; }
            set { url = value; }
        }

         [JsonProperty("e")]
        public string Url_foto
        {
            get { return url_foto; }
            set { url_foto = value; }
        }

         [JsonProperty("f")]
        public int Id_Padre
        {
            get { return id_Padre; }
            set { id_Padre = value; }
        }

         [JsonProperty("g")]
        public string Id_objeto
        {
            get { return id_objeto; }
            set { id_objeto = value; }
        }

         [JsonProperty("h")]
        public bool MenuD_Status
        {
            get { return menuD_Status; }
            set { menuD_Status = value; }
        }

         [JsonProperty("i")]
        public string CreateBy
        {
            get { return createBy; }
            set { createBy = value; }
        }

         [JsonProperty("j")]
        public DateTime DateBy
        {
            get { return dateBy; }
            set { dateBy = value; }
        }

         [JsonProperty("k")]
        public string ModiBy
        {
            get { return modiBy; }
            set { modiBy = value; }
        }

         [JsonProperty("l")]
        public DateTime DateModiBy
        {
            get { return dateModiBy; }
            set { dateModiBy = value; }
        }

    }
}
