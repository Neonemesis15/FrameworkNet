using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// EParametros.cs
    /// Se utiliza para setear los parametros de Entrada
    /// que se van a aplicar sobre el resultado de los 
    /// diferentes reportes que maneja el WebSite, como
    /// por ejemplo el Reporte de Precios.
    /// Developed by: 
    /// - Pablo Salas Alvarez (PSA) 
    /// Changes:
    /// - 2018-12-20 Pablo Salas Alvarez (PSA) - Creación de la Clase
    /// </summary>
    public class EParametros{

        private String idPlanning;
        private String idChannel;
        private int idOficina;
        private int idNodeCommercial;
        private String idPuntoDeVenta;
        private String idCategoria;
        private String idSubCategoria;
        private String idMarca;
        private String idProducto;
        private int idPerson;
        private DateTime fechaInicio;
        private DateTime fechaFin;

        public String getIdPlanning() {
            return idPlanning;
        }
        public void setIdPlanning(String idPlanning) {
            this.idPlanning = idPlanning;
        }

        public String getIdChannel() {
            return idChannel;
        }
        public void setIdChannel(String idChannel){
            this.idChannel = idChannel;
        }

        public int getIdOficina() {
            return idOficina;
        }
        public void setIdOficina(int idOficina) {
            this.idOficina = idOficina;
        }

        public int getIdNodeCommercial() {
            return idNodeCommercial;
        }
        public void setIdNodeCommercial(int idNodeCommercial) {
            this.idNodeCommercial = idNodeCommercial;
        }

        public String getIdPuntoDeVenta() {
            return idPuntoDeVenta;
        }
        public void setIdPuntoDeVenta(String idPuntoDeVenta) {
            this.idPuntoDeVenta = idPuntoDeVenta;
        }

        public String getIdCategoria() {
            return idCategoria;
        }
        public void setIdCategoria(String idCategoria) {
            this.idCategoria = idCategoria;
        }

        public String getIdSubCategoria() {
            return idSubCategoria;
        }
        public void setIdSubCategoria(String idSubCategoria) {
            this.idSubCategoria = idSubCategoria;
        }

        public String getIdMarca() { 
            return idMarca;
        }
        public void setIdMarca(String idMarca){
            this.idMarca = idMarca;
        }

        public String getIdProducto() {
            return idProducto;
        }
        public void setIdProducto(String idProducto) {
            this.idProducto = idProducto;
        }

        public int getIdPerson() {
            return idPerson;
        }
        public void setIdPerson(int idPerson) {
            this.idPerson = idPerson;
        }

        public DateTime getFechaInicio() {
            return fechaInicio;
        }
        public void setFechaInicio(DateTime fechaInicio) {
            this.fechaInicio = fechaInicio;
        }

        public DateTime getFechaFin() {
            return fechaFin;
        }
        public void setFechaFin(DateTime fechaFin) {
            this.fechaFin = fechaFin;
        }
        
    }
}
