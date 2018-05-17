using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.CFG.Tools
{
   public  class TreeNodeEditEventArgs
    {
        #region Variables

        private string _nodoText;
        private string _nodoValue;
        private string _oldValue;
        private string _newValue;
        private bool _checked;

        #endregion Variables

        #region Propiedades

        public string NodoText { get { return _nodoText; } }
        public string NodoValue { get { return _nodoValue; } }
        public string OldValue { get { return _oldValue; } }
        public string NewValue { get { return _newValue; } }
        public bool Checked { get { return _checked; } }

        #endregion Propiedades

        #region Constructor

        public TreeNodeEditEventArgs(string nodotext, string nodoValue,
            string oldValue, string newValue, bool check)
        {
            this._nodoText = nodotext;
            this._nodoValue = nodoValue;
            this._oldValue = oldValue;
            this._newValue = newValue;
            this._checked = check;
        }

        #endregion Constructor
        


    }


}
