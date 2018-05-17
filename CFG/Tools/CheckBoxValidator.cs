using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.UI;


namespace Lucky.CFG.Tools
{


    /// <summary>
    /// Validates a range of selected checkboxes
    /// </summary>
    public class CheckBoxValidator : BaseValidator
    {
        #region Private fields

        private Control _controlToValidate;
        private List<object> _checkBoxes;
        private int _minimumChecked = 1;
        private int _maximumChecked = int.MaxValue;

        #endregion

        #region Public properties

        /// <summary>
        /// Gets or sets the minimum amount of selected CheckBoxes allowed
        /// </summary>
        public int MinimumChecked
        {
            get { return _minimumChecked; }
            set { _minimumChecked = value; }
        }

        /// <summary>
        /// Gets or sets the maximum amount of selected CheckBoxes allowed (0 means no limit)
        /// </summary>
        public int MaximumChecked
        {
            get { return _maximumChecked != int.MaxValue ? _maximumChecked : 0; }
            set { _maximumChecked = value != 0 ? value : int.MaxValue; }
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Verifies if the ControlToValidate property points to a valid control on the page
        /// </summary>
        /// <returns></returns>
        protected override bool ControlPropertiesValid()
        {
            _controlToValidate = Page.FindControl(ControlToValidate);
            bool isValid = _controlToValidate is CheckBox || _controlToValidate is CheckBoxList || _controlToValidate.Controls.Count > 0;
            if (isValid)
                _checkBoxes = getCheckBoxes();

            return isValid;
        }

        /// <summary>
        /// Returns valid state if count of selected checkboxes is within the allowed range
        /// </summary>
        /// <returns></returns>
        protected override bool EvaluateIsValid()
        {
            int count = getCheckedCount();
            return count >= _minimumChecked && count <= _maximumChecked;
        }

        /// <summary>
        /// Adds client-side script on the page, if needed
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            if (EnableClientScript)
            {
                string onclick = string.Format("if(this.checked) document.getElementById('{0}').CheckedCount++; else document.getElementById('{0}').CheckedCount--;", ClientID);
                foreach (object checkBox in getCheckBoxes())
                {

                    if (checkBox is CheckBox)
                        ((CheckBox)checkBox).Attributes.Add("onclick", onclick);
                    if (checkBox is ListItem)
                        ((ListItem)checkBox).Attributes.Add("onclick", onclick);
                }

                Page.ClientScript.RegisterClientScriptBlock(GetType(), "ValidationFunction", string.Format(@"
function CodeGolem_CheckBoxValidator(sender)
{{
    return sender.CheckedCount >= {0} && sender.CheckedCount <= {1};
}}
", _minimumChecked, _maximumChecked), true);
            }
        }

        protected override void AddAttributesToRender(HtmlTextWriter writer)
        {
            base.AddAttributesToRender(writer);

            if (EnableClientScript)
            {
                Page.ClientScript.RegisterExpandoAttribute(this.ClientID, "evaluationfunction", "CodeGolem_CheckBoxValidator", false);
                Page.ClientScript.RegisterExpandoAttribute(this.ClientID, "CheckedCount", getCheckedCount().ToString(), false);
            }
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Gets the list of checkboxes to validate
        /// </summary>
        /// <returns></returns>
        private List<object> getCheckBoxes()
        {
            List<object> checkBoxes = new List<object>();

            if (_controlToValidate is CheckBox)
            {
                checkBoxes.Add((CheckBox)_controlToValidate);
            }
            else
            {
                checkBoxes = getCheckBoxes(_controlToValidate);
            }

            return checkBoxes;
        }

        /// <summary>
        /// Gets the list of checkboxes to validate, from the specified parent control
        /// </summary>
        /// <returns></returns>
        private List<object> getCheckBoxes(Control parent)
        {
            List<object> checkBoxes = new List<object>();

            if (parent is CheckBoxList)
            {
                CheckBoxList checkBoxList = (CheckBoxList)parent;
                foreach (ListItem item in checkBoxList.Items)
                {
                    checkBoxes.Add(item);
                }
            }
            else
            {
                foreach (Control control in parent.Controls)
                    if (control is CheckBox)
                        checkBoxes.Add((CheckBox)control);
                    else
                        checkBoxes.AddRange(getCheckBoxes(control));
            }

            return checkBoxes;
        }

        /// <summary>
        /// Gets a count of selected checkboxes
        /// </summary>
        /// <returns></returns>
        private int getCheckedCount()
        {
            int count = 0;
            foreach (object checkBox in _checkBoxes)
            {
                bool selected = false;
                if (checkBox is ListItem)
                    selected = ((ListItem)checkBox).Selected;
                if (checkBox is CheckBox)
                    selected = ((CheckBox)checkBox).Checked;
                if (selected)
                    count++;
            }

            return count;
        }

        #endregion
    }
}
