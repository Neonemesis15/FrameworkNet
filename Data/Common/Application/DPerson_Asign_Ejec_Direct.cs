using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Clase:              DPerson_Asign_Ejec_Direct
    /// Creada Por:         Ing. Mauricio Ortiz
    /// Fecha de Creación:  02/02/2010
    /// Requerimientos No:  
    /// Descripcion:        Define los metodos transaccionales para Person_Asign_Ejec_Direct    
    /// </summary>

    public class DPerson_Asign_Ejec_Direct
    {
        private Conexion oConn;
        public DPerson_Asign_Ejec_Direct()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        /// <summary>
        /// Description :   Método para registrar asignación de ejecutivos de cuenta a Director de Cuenta
        /// Create by   :   Ing. Mauricio Ortiz  
        /// Date        :   02/02/2010
        /// </summary>
        /// <param name="iPerson_id_Director"></param>
        /// <param name="iPerson_id_Ejecutive"></param>
        /// <param name="bAsign_Ejec_Direct_status"></param>
        /// <param name="sAsign_Ejec_Direct_CreateBy"></param>
        /// <param name="tAsign_Ejec_Direct_DateBy"></param>
        /// <param name="sAsign_Ejec_Direct_ModiBy"></param>
        /// <param name="tAsign_Ejec_Direct_DateModiBy"></param>
        /// <returns>oerPerson_Asign_Ejec_Direct</returns>


        public EPerson_Asign_Ejec_Direct RegisterAsign_Ejec_Direct(int iPerson_id_Director, int iPerson_id_Ejecutive,
            bool bAsign_Ejec_Direct_status, string sAsign_Ejec_Direct_CreateBy, DateTime tAsign_Ejec_Direct_DateBy,
            string sAsign_Ejec_Direct_ModiBy, DateTime tAsign_Ejec_Direct_DateModiBy)
        {

            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_ADMIN_REGISTERPERSON_ASIGN_EJEC_DIRECT", iPerson_id_Director, iPerson_id_Ejecutive,
            bAsign_Ejec_Direct_status, sAsign_Ejec_Direct_CreateBy, tAsign_Ejec_Direct_DateBy,
            sAsign_Ejec_Direct_ModiBy, tAsign_Ejec_Direct_DateModiBy);

            EPerson_Asign_Ejec_Direct oerPerson_Asign_Ejec_Direct = new EPerson_Asign_Ejec_Direct();

            oerPerson_Asign_Ejec_Direct.Person_id_Director = iPerson_id_Director;
            oerPerson_Asign_Ejec_Direct.Person_id_Ejecutive = iPerson_id_Ejecutive;
            oerPerson_Asign_Ejec_Direct.Asign_Ejec_Direct_status = bAsign_Ejec_Direct_status;
            oerPerson_Asign_Ejec_Direct.Asign_Ejec_Direct_CreateBy = sAsign_Ejec_Direct_CreateBy;
            oerPerson_Asign_Ejec_Direct.Asign_Ejec_Direct_DateBy = tAsign_Ejec_Direct_DateBy;
            oerPerson_Asign_Ejec_Direct.Asign_Ejec_Direct_ModiBy = sAsign_Ejec_Direct_ModiBy;
            oerPerson_Asign_Ejec_Direct.Asign_Ejec_Direct_DateModiBy = tAsign_Ejec_Direct_DateModiBy;
            return oerPerson_Asign_Ejec_Direct;
        }


        /// <summary>
        /// Description :   Método para consultar asignación de ejecutivos de cuenta a Director de Cuenta (cabeza)
        /// Create by   :   Ing. Mauricio Ortiz  
        /// Date        :   02/02/2010
        /// </summary>
        /// <param name="iPerson_id_Director"></param>
        /// <returns>ds</returns>
        public DataSet SearchAsign_Ejec_Direct(int iPerson_id_Director)
        {
            DataSet ds = oConn.ejecutarDataSet("UP_WEBSIGE_ADMIN_SEARCHASIGNEJECADIRECTORES", iPerson_id_Director);
            EPerson_Asign_Ejec_Direct oeSAsign_Ejec_Direct = new EPerson_Asign_Ejec_Direct();
            
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                    {
                        oeSAsign_Ejec_Direct.cod_Country = ds.Tables[0].Rows[i]["cod_Country"].ToString().Trim();
                        oeSAsign_Ejec_Direct.Name_country = ds.Tables[0].Rows[i]["Name_Country"].ToString().Trim();
                        oeSAsign_Ejec_Direct.Person_id_Director = Convert.ToInt32(ds.Tables[0].Rows[i]["Person_id_Director"].ToString().Trim());
                        oeSAsign_Ejec_Direct.Person_NameDirector = ds.Tables[0].Rows[i]["Person_Name"].ToString().Trim();
                    }
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    for (int i = 0; i <= ds.Tables[1].Rows.Count - 1; i++)
                    {
                        oeSAsign_Ejec_Direct.Person_id_Ejecutive = Convert.ToInt32(ds.Tables[1].Rows[i]["Person_id_Ejecutive"].ToString().Trim());
                        oeSAsign_Ejec_Direct.Person_NameEjecutivo = ds.Tables[1].Rows[i]["Person_Name"].ToString().Trim();
                    }
                }
                
                return ds;
            }
            else
            {
                return null;
            }
        }
    }
}
            