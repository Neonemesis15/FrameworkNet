using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    public class E_PersonModulos
    {
        private long idPersonModulo;
        private string idLevel;
        private string moduloId;
        private string moduloName;
        private bool personModuloStatus;
        private string personModuloDateBy;
        private string personModuloCreateBy;
        private string personModuloModiBy;
        private string personModuloDateModiBy;

        public long getIdPersonModulo() {
            return idPersonModulo;
        }
        public void setIdPersonModulo(long idPersonModulo) {
            this.idPersonModulo = idPersonModulo;
        }
        public string getIdLevel() {
            return idLevel;
        }
        public void setIdLevel(string idLevel) {
            this.idLevel = idLevel;
        }
        public string getModuloId() {
            return moduloId;
        }
        public void setModuloId(string moduloId) {
            this.moduloId = moduloId;
        }
        public string getModuloName() {
            return moduloName;
        }
        public void setModuloName(string moduloName) {
            this.moduloName = moduloName;
                }
        public bool getPersonModuloStatus() {
            return personModuloStatus;
        }
        public void setPersonModuloStatus(bool personModuloStatus) {
            this.personModuloStatus = personModuloStatus;
        }
        public string getPersonModuloDateBy() {
            return personModuloDateBy;
        }
        public void setPersonModuloDateBy(string personModuloDateBy) {
            this.personModuloDateBy = personModuloDateBy;
        }

        public string getPersonModuloCreateBy() {
            return personModuloCreateBy;
        }

        public void setPersonModuloCreateBy(string personModuloCreateBy) {
            this.personModuloCreateBy = personModuloCreateBy;
        }

        public string getPersonModuloModiBy() {
            return personModuloModiBy;
        }

        public void setPersonModuloModiBy(string personModuloModiBy) {
            this.personModuloModiBy = personModuloModiBy;
        }

        public string getPersonModuloDateModiBy() {
            return personModuloDateModiBy;
        }

        public void setPersonModuloDateModiBy(string personModuloDateModiBy) {
            this.personModuloDateModiBy = personModuloDateModiBy;
        }
    }
}
