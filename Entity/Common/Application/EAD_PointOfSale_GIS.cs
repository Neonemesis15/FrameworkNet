using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    public class EAD_PointOfSale_GIS
    {
        private int posgis_id;

        public int Posgis_id
        {
            get { return posgis_id; }
            set { posgis_id = value; }
        }
        private string posgis_nombre;

        public string Posgis_nombre
        {
            get { return posgis_nombre; }
            set { posgis_nombre = value; }
        }
        private string posgis_latitud;

        public string Posgis_latitud
        {
            get { return posgis_latitud; }
            set { posgis_latitud = value; }
        }
        private string posgis_longitud;

        public string Posgis_longitud
        {
            get { return posgis_longitud; }
            set { posgis_longitud = value; }
        }
        private string posgis_iconmarker;

        public string Posgis_iconmarker
        {
            get { return posgis_iconmarker; }
            set { posgis_iconmarker = value; }
        }
        private string posgis_informacion;

        public string Posgis_informacion
        {
            get { return posgis_informacion; }
            set { posgis_informacion = value; }
        }
        private bool posgis_status;

        public bool Posgis_status
        {
            get { return posgis_status; }
            set { posgis_status = value; }
        }
        private string posgis_createby;

        public string Posgis_createby
        {
            get { return posgis_createby; }
            set { posgis_createby = value; }
        }
        private DateTime posgis_dateby;

        public DateTime Posgis_dateby
        {
            get { return posgis_dateby; }
            set { posgis_dateby = value; }
        }
        private string posgis_modiby;

        public string Posgis_modiby
        {
            get { return posgis_modiby; }
            set { posgis_modiby = value; }
        }
        private DateTime posgis_datemodiby;

        public DateTime Posgis_datemodiby
        {
            get { return posgis_datemodiby; }
            set { posgis_datemodiby = value; }
        }
    }
}
