using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              EPLA_Supe_Objetivos_Sod_May
    /// Creada Por:         Carlos Marín
    /// Fecha de Creación:  04/11/2011
    /// </summary>
  public  class EPLA_Supe_Objetivos_Sod_May
  {

      #region Atributos

      int lid_iobjsodmay;
        int lcompany_id;
        string lcod_channel;
        int lid_malla;
        string lid_ProductCategory;
        int lid_Brand;
        int lid_ReportsPlanning;
        double lValue_Marca;
        double lValue_Categoria;
        bool lStatus;

      #endregion

        #region Propiedades

        public int id_iobjsodmay
        {
            get { return lid_iobjsodmay; }
            set { lid_iobjsodmay = value; }
        }
        public int company_id
        {
            get { return lcompany_id; }
            set { lcompany_id = value; }
        }
        public string cod_channel
        {
            get { return lcod_channel; }
            set { lcod_channel = value; }
        }
        public int id_malla
        {
            get { return lid_malla; }
            set { lid_malla = value; }
        }
        public string id_ProductCategory
        {
            get { return lid_ProductCategory; }
            set { lid_ProductCategory = value; }
        }
        public int id_Brand
        {
            get { return lid_Brand; }
            set { lid_Brand = value; }
        }
        public int id_ReportsPlanning
        {
            get { return lid_ReportsPlanning; }
            set { lid_ReportsPlanning = value; }
        }
        public double Value_Marca
        {
            get { return lValue_Marca; }
            set { lValue_Marca = value; }
        }
        public double Value_Categoria
        {
            get { return lValue_Categoria; }
            set { lValue_Categoria = value; }
        }
        public bool Status
        {
            get { return lStatus; }
            set { lStatus = value; }
        }

        #endregion
  }
}
