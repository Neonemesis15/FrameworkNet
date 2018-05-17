using System;
using System.Collections.Generic;
using System.Data;
using Lucky.Data.Common.Application;
using Lucky.Entity.Common.Application;

namespace Lucky.Business.Common.Application
{
    public class Planning
    {
        public List<EPlaning> lista_campanias_cliente(int company_id)
        {
            
            DPlanning dplanning = new DPlanning();
            List<EPlaning> leplanning = new List<EPlaning>();

            DataTable dt = new DataTable();
            dt = dplanning.lista_campanias_cliente(company_id);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                EPlaning eplanning = new EPlaning();
                eplanning.idplanning = dt.Rows[i]["id_planning"].ToString();
                eplanning.PlanningName = dt.Rows[i]["Planning_Name"].ToString();
                eplanning.codStrategy = Convert.ToInt32(dt.Rows[i]["cod_Strategy"]);
                eplanning.PlanningCodChannel = dt.Rows[i]["Planning_CodChannel"].ToString();
                eplanning.PlanningStartActivity = Convert.ToDateTime(dt.Rows[i]["Planning_StartActivity"]);
                eplanning.PlanningEndActivity = Convert.ToDateTime(dt.Rows[i]["Planning_EndActivity"]);
                leplanning.Add(eplanning);
            }
            return leplanning;
        }
    }
}
