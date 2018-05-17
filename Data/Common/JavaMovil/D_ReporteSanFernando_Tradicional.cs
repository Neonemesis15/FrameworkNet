using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;

namespace Lucky.Data.Common.JavaMovil
{
    public class D_ReporteSanFernando_Tradicional
    {
        private Conexion oCoon;

        public D_ReporteSanFernando_Tradicional()
        {
            UserInterface oUserInterface = new UserInterface();
            oCoon = new Conexion(3);
            oUserInterface = null;
        }

        #region AppMovil Movistar


        public string Registrar_ReporteSanFernando_Tradicional_Mov(
              List<E_Reporte_Precio_Mov> oListaRepPrecio_Mov
            , List<E_Reporte_Exhibicion_Mov> oListaRepExhibicion_Mov
            , List<E_Reporte_Marcaje_Precio_Mov> oListaRepMarcaje_Mov
            , List<E_Reporte_Mat_Apoyo_Mov> oListaRepMatApoyo_Mov
            //, List<E_Reporte_Mandil_Mov> oListaRepMandil_Mov
            //, List<E_Reporte_MatAdicional_Mov> oListaRepMatAdicional_Mov
            //, List<E_Reporte_Observacion_Mov> oListaRepObservacion_Mov
            , List<E_Reporte_Capacitacion_Mov> oListRepCapacitacion_Mov
            , List<E_Reporte_Incidencia_Mov> oListRepIncidencia_Mov
            , List<E_Reporte_Credito_Competencia_Mov> oListaRepCredito_Competencia_Mov
            , List<E_Reporte_Presencia_Mov> oListaRepPresencia_Mov
            , E_Visita_Mov oE_Visita_Mov
            , int AppEnvia)
        {
            D_Reporte_Precio oD_Reporte_Precio = new D_Reporte_Precio();
            D_Reporte_Exhibicion oD_Reporte_Exhibicion = new D_Reporte_Exhibicion();
            D_Reporte_Marcaje_Precio oD_Reporte_Marcaje = new D_Reporte_Marcaje_Precio();
            //D_Reporte_Mandil oD_Reporte_Mandil = new D_Reporte_Mandil();
            //D_Reporte_MatAdicional oD_Reporte_MatAdicional = new D_Reporte_MatAdicional();
            D_Reporte_Mat_Apoyo oD_Reporte_Mat_Apoyo = new D_Reporte_Mat_Apoyo();//Add 26/07/2012 PSA
            //D_Reporte_Observacion oD_Reporte_Observacion = new D_Reporte_Observacion();
            D_Reporte_Capacitacion oD_Reporte_Capacitacion = new D_Reporte_Capacitacion();//Agregado por DUEB, el 13/07/2012
            D_Reporte_Incidencia oD_Reporte_Incidencia = new D_Reporte_Incidencia();//Add 26/07/2012 PSA
            D_Reporte_Credito_Competencia oD_Reporte_Credito_Competencia = new D_Reporte_Credito_Competencia();//Agregado por DUEB, el 16/07/2012
            D_Reporte_Presencia oD_Reporte_Presencia = new D_Reporte_Presencia();//Add 26/07/2012 PSA
            D_Visita oD_Visita = new D_Visita();

            string mensaje_Precio = string.Empty;
            string mensaje_Exhibicion = string.Empty;
            string mensaje_Marcaje = string.Empty;
            string mensaje_MatApoyo = string.Empty;
            string mensaje_Capacitacion = string.Empty;
            string mensaje_Incidencia = string.Empty;
            string mensaje_Credito_Compt = string.Empty;
            string mensaje_Presencia = string.Empty;
            //string mensaje_Mandil = string.Empty;
            //string mensaje_MatAdicional = string.Empty;
            //string mensaje_Observacion = string.Empty;
            string mensaje_Visita = string.Empty;
            string mensaje_Final = string.Empty;
            try
            {
                mensaje_Precio = oD_Reporte_Precio.Registrar_Precio_Mov(oListaRepPrecio_Mov, AppEnvia.ToString());
                mensaje_Exhibicion = oD_Reporte_Exhibicion.Registrar_Reporte_Exhibicion_Mov(oListaRepExhibicion_Mov, AppEnvia.ToString());
                mensaje_Marcaje = oD_Reporte_Marcaje.Registrar_Marcaje_Precio_Mov(oListaRepMarcaje_Mov, AppEnvia);
                mensaje_MatApoyo = oD_Reporte_Mat_Apoyo.Registrar_Material_Apoyo_Mov(oListaRepMatApoyo_Mov, AppEnvia);
                //mensaje_Mandil = oD_Reporte_Mandil.Registrar_Mandil_Mov(oListaRepMandil_Mov, AppEnvia);
                //mensaje_MatAdicional = oD_Reporte_MatAdicional.Registrar_MatAdicional_Mov(oListaRepMatAdicional_Mov, AppEnvia);
                //mensaje_Observacion = oD_Reporte_Observacion.Registrar_Observacion_Mov(oListaRepObservacion_Mov, AppEnvia);
                mensaje_Capacitacion = oD_Reporte_Capacitacion.Registrar_Reporte_Capacitacion_Mov(oListRepCapacitacion_Mov, AppEnvia);
                mensaje_Incidencia = oD_Reporte_Incidencia.Registrar_Incidencia_Mov(oListRepIncidencia_Mov, AppEnvia.ToString());
                mensaje_Credito_Compt = oD_Reporte_Credito_Competencia.Registrar_Reporte_Credito_Competencia_Mov(oListaRepCredito_Competencia_Mov, AppEnvia);
                mensaje_Presencia = oD_Reporte_Presencia.Registrar_Presencia_Mov(oListaRepPresencia_Mov, AppEnvia);
                mensaje_Visita = oD_Visita.RegistrarVisita_Mov(oE_Visita_Mov);

                if (!mensaje_Precio.Equals(""))
                    mensaje_Precio = "Hubo Errores en Reporte Precios. ";
                if (!mensaje_Exhibicion.Equals(""))
                    mensaje_Exhibicion = "Hubo Errores en Reporte Exhibición. ";
                if (!mensaje_Marcaje.Equals(""))
                    mensaje_Marcaje = "Hubo Errores en Reporte Marcaje Precios. ";
                #region
                //if (!mensaje_Mandil.Equals(""))
                //    mensaje_Mandil = "Hubo Errores en Reporte Mandil. ";
                //if (!mensaje_MatAdicional.Equals(""))
                //    mensaje_MatAdicional = "Hubo Errores en Reporte Materiales Adicionales. ";
                //if (!mensaje_Observacion.Equals(""))
                //    mensaje_Observacion = "Hubo Errores en Reporte Observacion. ";
                #endregion
                if (!mensaje_MatApoyo.Equals(""))
                    mensaje_MatApoyo = "Hubo Errores en Registro de Entrega de Materiales. ";
                if (!mensaje_Capacitacion.Equals(""))//Agregado por DUEB, el 13/07/2012
                    mensaje_Capacitacion = "Hubo Errores en el de Reporte Capacitacion. ";
                if (!mensaje_Incidencia.Equals(""))
                    mensaje_Incidencia = "Hubo Errores en Registro de Incidencias. ";
                if (!mensaje_Credito_Compt.Equals(""))//Agregado por DUEB, el 16/07/2012
                    mensaje_Credito_Compt = "Hubo Errores en el de Reporte de Credito. ";
                if (!mensaje_Presencia.Equals(""))//Agregado por PSA , 26/07/2012
                    mensaje_Presencia = "Hubo Errores en el de Reporte de Presencia. ";
                if (!mensaje_Visita.Equals(""))
                    mensaje_Visita = "Hubo Errores en Registro de Visita. ";

            }
            catch (Exception ex) {
                throw ex;
            }
            return mensaje_Final = mensaje_Precio + 
                mensaje_Exhibicion + 
                mensaje_Marcaje +
                mensaje_MatApoyo +
                mensaje_Incidencia +
                mensaje_Presencia + 
                mensaje_Capacitacion +
                mensaje_Credito_Compt + 
                mensaje_Visita;
        }
        #endregion
    }
}
