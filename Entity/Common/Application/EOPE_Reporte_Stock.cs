using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              EOPE_Reporte_Stock
    /// Creada Por:         Carlos Marín
    /// Fecha de Creación:  09/09/2011
    /// </summary>
    public class EOPE_Reporte_Stock
    {

        #region Atributos

        int lPerson_id;
        string lID_PERFIL;
        string lID_EQUIPO;
        string lID_CLIENTE;
        string lID_PTOVENTA;
        string lID_CATEGORIA;
        string lID_MARCA;
        string lID_FAMILIA;
        string lID_SUBFAMILIA;
        string lFEC_REG_CEL;
        string lLATITUD;
        string lLONGITUD;
        string lORIGEN;
        string lID_REG_STOCK;

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

        public string ID_FAMILIA
        {
            get { return lID_FAMILIA; }
            set { lID_FAMILIA = value; }
        }

        public string ID_SUBFAMILIA
        {
            get { return lID_SUBFAMILIA; }
            set { lID_SUBFAMILIA = value; }
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

        public string ID_REG_STOCK
        {
            get { return lID_REG_STOCK; }
            set { lID_REG_STOCK = value; }
        }

        #endregion

    }
}
