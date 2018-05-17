
namespace Lucky.Entity.Common.Application
{
    public class PointOfSaleMarker
    {
        private int id_pointofsale;

        public int Id_pointofsale
        {
            get { return id_pointofsale; }
            set { id_pointofsale = value; }
        }
        private string pdv_name;

        public string Pdv_name
        {
            get { return pdv_name; }
            set { pdv_name = value; }
        }
        private string commercialnodename;

        public string Commercialnodename
        {
            get { return commercialnodename; }
            set { commercialnodename = value; }
        }
        private string pdv_address;

        public string Pdv_address
        {
            get { return pdv_address; }
            set { pdv_address = value; }
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
    }
}
