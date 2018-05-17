using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
   public class EOPE_REPORTE_PRECIO
    {
       private  long lID;
       private int lPerson_id;
       private string lID_PERFIL;
       private string lID_EQUIPO;
       private string lID_CLIENTE;
       private string lID_PTOVENTA;
       private string lID_CATEGORIA;
       private string lID_MARCA;
       private string lTIPO_CANAL;
       private DateTime lFEC_REG_CEL;
       private DateTime lFEC_REG_BD;
       private string lLATITUD;
       private string lLONGITUD;
       private char lORIGEN;
       private string lOBSERVACION;
       private string lID_FAMILIA;
       private string lID_SUBFAMILIA;


       private int lID_REG_PRECIO;
       private string lID_PRODUCTO;
       private string lPRECIO_LISTA;
       private string lPRECIO_REVENTA;
       private string lPRECIO_OFERTA;
       private string lPVP;
       private string lPRECIO_COSTO;
       private string lPRECIO_MIN;
       private string lPRECIO_MAX;
       private string lPRECIO_REGULAR;
       private char lMOTIVO_OBS;

       public char MOTIVO_OBS
       {
           get { return lMOTIVO_OBS; }
           set { lMOTIVO_OBS = value; }
       }

       public string PRECIO_REGULAR
       {
           get { return lPRECIO_REGULAR; }
           set { lPRECIO_REGULAR = value; }
       }

       public string PRECIO_MAX
       {
           get { return lPRECIO_MAX; }
           set { lPRECIO_MAX = value; }
       }

       public string PRECIO_MIN
       {
           get { return lPRECIO_MIN; }
           set { lPRECIO_MIN = value; }
       }

       public string PRECIO_COSTO
       {
           get { return lPRECIO_COSTO; }
           set { lPRECIO_COSTO = value; }
       }

       public string PVP
       {
           get { return lPVP; }
           set { lPVP = value; }
       }

       public string PRECIO_OFERTA
       {
           get { return lPRECIO_OFERTA; }
           set { lPRECIO_OFERTA = value; }
       }

       public string PRECIO_REVENTA
       {
           get { return lPRECIO_REVENTA; }
           set { lPRECIO_REVENTA = value; }
       }

       public string PRECIO_LISTA
       {
           get { return lPRECIO_LISTA; }
           set { lPRECIO_LISTA = value; }
       }

       public string ID_PRODUCTO
       {
           get { return lID_PRODUCTO; }
           set { lID_PRODUCTO = value; }
       }

       public int ID_REG_PRECIO
       {
           get { return lID_REG_PRECIO; }
           set { lID_REG_PRECIO = value; }
       }






       public string ID_SUBFAMILIA
       {
           get { return lID_SUBFAMILIA; }
           set { lID_SUBFAMILIA = value; }
       }

       public string ID_FAMILIA
       {
           get { return lID_FAMILIA; }
           set { lID_FAMILIA = value; }
       }

       public string OBSERVACION
       {
           get { return lOBSERVACION; }
           set { lOBSERVACION = value; }
       }

       public char ORIGEN
       {
           get { return lORIGEN; }
           set { lORIGEN = value; }
       }

       public string LONGITUD
       {
           get { return lLONGITUD; }
           set { lLONGITUD = value; }
       }

       public string LATITUD
       {
           get { return lLATITUD; }
           set { lLATITUD = value; }
       }

       public DateTime FEC_REG_BD
       {
           get { return lFEC_REG_BD; }
           set { lFEC_REG_BD = value; }
       }

       public DateTime FEC_REG_CEL
       {
           get { return lFEC_REG_CEL; }
           set { lFEC_REG_CEL = value; }
       }

       public string TIPO_CANAL
       {
           get { return lTIPO_CANAL; }
           set { lTIPO_CANAL = value; }
       }

       public string ID_MARCA
       {
           get { return lID_MARCA; }
           set { lID_MARCA = value; }
       }

       public string ID_CATEGORIA
       {
           get { return lID_CATEGORIA; }
           set { lID_CATEGORIA = value; }
       }

       public string ID_PTOVENTA
       {
           get { return lID_PTOVENTA; }
           set { lID_PTOVENTA = value; }
       }

       public string ID_CLIENTE
       {
           get { return lID_CLIENTE; }
           set { lID_CLIENTE = value; }
       }

       public string ID_EQUIPO
       {
           get { return lID_EQUIPO; }
           set { lID_EQUIPO = value; }
       }

       public string ID_PERFIL
       {
           get { return lID_PERFIL; }
           set { lID_PERFIL = value; }
       }

       public int Person_id
       {
           get { return lPerson_id; }
           set { lPerson_id = value; }
       }

        public long ID
        {
            get { return lID; }
            set { lID = value; }
        }

    }
}
