using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    public class E_PersonLevel
    {
        public E_PersonLevel() { }

        private string id_Level;
        private string level_Description;
        private bool level_Status;
        private string level_CreateBy;
        private string level_DateBy;
        private string level_ModiBy;
        private string level_DateModiBy;

        public string getId_Level() {
            return id_Level;
        }
        public void setId_Level(string id_Level) {
            this.id_Level = id_Level;
        }

        public string getLevel_Description() {
            return level_Description;
        }
        public void setLevel_Description(string level_Description) {
            this.level_Description = level_Description;
        }

        public bool getLevel_Status() {
            return level_Status;
        }

        public void setLevel_Status(bool level_Status) {
            this.level_Status = level_Status;
        }

        public string getLevel_CreateBy() {
            return level_CreateBy;
        }
        public void setLevel_CreateBy(string level_CreateBy) {
            this.level_CreateBy = level_CreateBy;
        }
        public string getLevel_DateBy() {
            return level_DateBy;
        }
        public void setLevel_DateBy(string level_DateBy) {
            this.level_DateBy = level_DateBy;
        }

        public string getLevel_ModiBy() {
            return level_ModiBy;
        }
        public void setLevel_ModiBy(string level_ModiBy) {
            this.level_ModiBy = level_ModiBy;
        }

        public string getLevel_DateModiBy() {
            return level_DateModiBy;
        }
        public void setLevel_DateModiBy(string level_DateModiBy) {
            this.level_DateModiBy = level_DateModiBy;
        }

    }
}
