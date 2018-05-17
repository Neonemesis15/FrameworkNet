using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;


namespace Lucky.Business.Common.Application
{
    public class Person_Asign_Ejec_Direct
    {
        public Person_Asign_Ejec_Direct()
        {
            //Se define el Constructor por defecto
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
            DPerson_Asign_Ejec_Direct odrPerson_Asign_Ejec_Direct = new DPerson_Asign_Ejec_Direct();
            EPerson_Asign_Ejec_Direct oerPerson_Asign_Ejec_Direct = odrPerson_Asign_Ejec_Direct.RegisterAsign_Ejec_Direct(iPerson_id_Director, iPerson_id_Ejecutive,
            bAsign_Ejec_Direct_status, sAsign_Ejec_Direct_CreateBy, tAsign_Ejec_Direct_DateBy,
            sAsign_Ejec_Direct_ModiBy, tAsign_Ejec_Direct_DateModiBy);

            odrPerson_Asign_Ejec_Direct = null;
            return oerPerson_Asign_Ejec_Direct;
        }

        /// <summary>
        /// Description :   Método para consultar asignación de ejecutivos de cuenta a Director de Cuenta (cabeza)
        /// Create by   :   Ing. Mauricio Ortiz  
        /// Date        :   02/02/2010
        /// </summary>
        /// <param name="iPerson_id_Director"></param>
        /// <returns></returns>
        public DataSet SearchAsign_Ejec_Direct(int iPerson_id_Director)
        {
            DPerson_Asign_Ejec_Direct odSAsign_Ejec_Direct = new DPerson_Asign_Ejec_Direct();          
            DataSet ds = odSAsign_Ejec_Direct.SearchAsign_Ejec_Direct(iPerson_id_Director);
            return ds;
        }
    }
}
        