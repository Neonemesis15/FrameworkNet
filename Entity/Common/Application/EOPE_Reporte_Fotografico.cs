using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
   public class EOPE_Reporte_Fotografico
   {
       #region Atributos


       int lPerson_id;
        string lID_PERFIL;
        string lID_EQUIPO;
        string lID_CLIENTE;
        string lID_PTOVENTA;
        string lTIPO_REPORTE;
        string lID_CATEGORIA;
        string lID_MARCA;
        string lFEC_REG_CEL;
        string lLATITUD;
        string lLONGITUD;
        string lORIGEN;
        string lTIPO_REP_FOTOGRAF;


        int iTipo_Proceso;
        string sComentario;
        byte[] bimagen;
        string sNOMBREFOTO;

       #endregion


        #region Propiedades

        public int Person_id
        {
            get { return lPerson_id; }
            set { lPerson_id = value; }
        }


        public string ID_PERFIL
        {
            get { return lID_PERFIL; }
            set { lID_PERFIL = value; }
        }


        public string ID_EQUIPO
        {
            get { return lID_EQUIPO; }
            set { lID_EQUIPO = value; }
        }


        public string ID_CLIENTE
        {
            get { return lID_CLIENTE; }
            set { lID_CLIENTE = value; }
        }

        public string ID_PTOVENTA
        {
            get { return lID_PTOVENTA; }
            set { lID_PTOVENTA = value; }
        }


        public string TIPO_REPORTE
        {
            get { return lTIPO_REPORTE; }
            set { lTIPO_REPORTE = value; }
        }


        public string ID_CATEGORIA
        {
            get { return lID_CATEGORIA; }
            set { lID_CATEGORIA = value; }
        }



        public string ID_MARCA
        {
            get { return lID_MARCA; }
            set { lID_MARCA = value; }
        }


        public string FEC_REG_CEL
        {
            get { return lFEC_REG_CEL; }
            set { lFEC_REG_CEL = value; }
        }

        public string LATITUD
        {
            get { return lLATITUD; }
            set { lLATITUD = value; }
        }


        public string LONGITUD
        {
            get { return lLONGITUD; }
            set { lLONGITUD = value; }
        }



        public string ORIGEN
        {
            get { return lORIGEN; }
            set { lORIGEN = value; }
        }


        public string TIPO_REP_FOTOGRAF
        {
            get { return lTIPO_REP_FOTOGRAF; }
            set { lTIPO_REP_FOTOGRAF = value; }
        }

        public int Tipo_Proceso
        {
            get { return iTipo_Proceso; }
            set { iTipo_Proceso = value; }
        }


        public string Comentario
        {
            get { return sComentario; }
            set { sComentario = value; }
        }


        public byte[] imagen
        {
            get { return bimagen; }
            set { bimagen = value; }
        }


        public string NOMBREFOTO
        {
            get { return sNOMBREFOTO; }
            set { sNOMBREFOTO = value; }
        }

        #endregion

   }
}
