using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              EOPE_Reporte_SOD
    /// Creada Por:         Carlos Marín
    /// Fecha de Creación:  20/02/2012
    /// </summary>
   public class EOPE_Reporte_SOD
    {
        #region Atributos

        string lID_REG_SOD;
        string lPerson_id;
        string lID_PERFIL;
        string lID_EQUIPO;
        string lID_CLIENTE;
        string lID_PTOVENTA;
        string lID_CATEGORIA;
        string lFEC_REG_CEL;
        string lFEC_REG_BD;
        string lLATITUD;
        string lLONGITUD;
        string lORIGEN;
        string lOBSERVACION;

        #endregion


        #region Prodiedades
        public string ID_REG_SOD
        {
            get { return lID_REG_SOD; }
            set { lID_REG_SOD = value; }
        }

        public string Person_id
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
        public string ID_CATEGORIA
        {
            get { return lID_CATEGORIA; }
            set { lID_CATEGORIA = value; }
        }

        public string FEC_REG_CEL
        {
            get { return lFEC_REG_CEL; }
            set { lFEC_REG_CEL = value; }
        }
        public string FEC_REG_BD
        {
            get { return lFEC_REG_BD; }
            set { lFEC_REG_BD = value; }
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
        public string OBSERVACION
        {
            get { return lOBSERVACION; }
            set { lOBSERVACION = value; }
        }
        #endregion
    }
}
