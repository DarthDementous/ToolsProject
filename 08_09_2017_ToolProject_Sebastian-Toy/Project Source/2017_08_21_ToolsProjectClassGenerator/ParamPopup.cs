using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace _2017_08_21_ToolsProjectClassGenerator
{
    public partial class ParamPopup : PopupForm
    {
        public ParamPopup()
        {
            InitializeComponent();
            InitialiseObjects();
            InitialiseForms();
        }
        private FormUtility.eMemType memoryStatus = FormUtility.eMemType.VAL;      // Whether variable is a ptr, reference or value (default)

        private MemberPopup m_memberPopup;

        /**
        * @brief Load data from parameter into the form details.
        * @param a_param is the member to extract data from.
        * @param a_editMode is whether member is being modified or added.
        * @return void.
        * */
        public void Populate(CppMember a_param, bool a_editMode)
        {
            editMode = a_editMode;

            TXT_ParamName.Text = a_param.name;
            TXT_ParamType.Text = a_param.type;

            // Const status
            if (a_param.modifier == "CONST")
            {
                CB_ConstOpt.Checked = true;
            }

            // Memory type
            if (a_param.memType == "*")
            {
                RB_PointerOpt.Checked = true;
            }
            else if (a_param.memType == "&")
            {
                RB_ReferenceOpt.Checked = true;
            }
            else
            {
                RB_ValOpt.Checked = true;
            }

            // Change button text to reflect the mode of the form
            if (editMode)
            {
                BTN_ParamConfirm.Text = "Confirm Changes";
            }

        }

        private void InitialiseObjects()
        {
            // Parameter is by value by default
            RB_ValOpt.Checked = true;
        }

        // Override to allow access to main form and member pop-up form
        protected override void InitialiseForms()
        {
            // Assign pointer to main form
            m_mainForm = (Form1)Application.OpenForms["Form1"];

            // Assign pointer to member popup
            m_memberPopup = (MemberPopup)Application.OpenForms["MemberPopup"];
        }

        /**
        *   @brief Using user specified info, add string of parameter representation to listview.
        *   NOTE: Overrides GenerateItem
        *   @return Bool of whether item was successfully generated or not.
        * */
        protected override bool GenerateItem()
        {
            // Quit out early if no parameter name or type
            if (TXT_ParamName.Text == "" || TXT_ParamType.Text == "")
            {
                return false;
            }

            // Determine representation for non-textbox choices
            string constant = (CB_ConstOpt.Checked) ? "CONST" : "";
            string type = TXT_ParamType.Text;

            switch (memoryStatus)
            {
                case FormUtility.eMemType.PTR:
                    type += "*";
                    break;
                case FormUtility.eMemType.REF:
                    type += "&";
                    break;
            }

            // Generate string to represent parameter and add to list
            textBuffer = constant + space + type + space + TXT_ParamName.Text;

            // Modify current selected parameter or add new one depending on form mode
            if (editMode)
            {
                m_memberPopup.LV_Params.Items[m_mainForm.selectedMemberIndex].Text = textBuffer;

                // Modify actual parameter of current member
                m_mainForm.selectedClass.members[m_mainForm.selectedMemberIndex].args[m_memberPopup.selectedParamIndex] = formUtil.StringToParam(textBuffer);
            }
            else
            {
                m_memberPopup.LV_Params.Items.Add(textBuffer);

                // Add actual parameter to current member
                m_mainForm.selectedClass.members[m_mainForm.selectedMemberIndex].args.Add(formUtil.StringToParam(textBuffer));
            }

            return true;
        }

        #region Form Element Events
        private void RB_PointerOpt_CheckedChanged(object sender, EventArgs e)
        {
            memoryStatus = FormUtility.eMemType.PTR;
        }

        private void RB_ValOpt_CheckedChanged(object sender, EventArgs e)
        {
            memoryStatus = FormUtility.eMemType.VAL;
        }

        private void RB_ReferenceOpt_CheckedChanged(object sender, EventArgs e)
        {
            memoryStatus = FormUtility.eMemType.REF;
        }

        private void BTN_ParamConfirm_Click(object sender, EventArgs e)
        {
            ConfirmItem();
        }
        #endregion
    }
}
