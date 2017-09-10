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
    public partial class MemberPopup : PopupForm
    {
        public int      selectedParamIndex;

        public MemberPopup()
        {
            InitialiseForms();
            InitializeComponent();
            InitialiseObjects();
        }

        /**
        * @brief Load data from member into the form details.
        * @param a_member is the member to extract data from.
        * @param a_editMode is whether member is being modified or added.
        * @return void.
        * */
        public void Populate(CppMember a_member, bool a_editMode)
        {
            editMode = a_editMode;

            CB_MemberAccess.SelectedItem    = a_member.access;
            CB_Identifiers.SelectedItem     = a_member.modifier;
             
            TXT_MemberName.Text             = a_member.name;
            TXT_Type.Text                   = a_member.type;

            // Memory type
            if (a_member.memType == "*")
            {
                RB_PointerOpt.Checked = true;
            }
            else if (a_member.memType == "&")
            {
                RB_ReferenceOpt.Checked = true;
            }
            else
            {
                RB_ValueOpt.Checked = true;
            }

            // Virtual
            if (a_member.isVirtual)
            {
                CheckBox_VirtualOpt.Checked = true;
            }

            // Function
            if (a_member.isFunction)
            {
                CheckBox_FunctionOpt.Checked = true;

                // Populate parameters (if any)
                foreach (var param in a_member.args) {
                    LV_Params.Items.Add(param.ToString());
                }
            }

            // Change button text to reflect the mode of the form
            if (editMode)
            {
                BTN_MemberConfirm.Text = "Confirm Changes";
            }

        }

        private void InitialiseObjects()
        {
            // Starting group box selections
            CB_MemberAccess.SelectedIndex = 0;
            CB_Identifiers.SelectedIndex = 0;
        }

        /**
        *   @brief Using user specified info, add string of member representation to listview.
        *   NOTE: Overrides GenerateFunction.
        *   @return Bool of whether item was successfully generated or not.
        * */
        protected override bool GenerateItem()
        {
            // Quit out early with failure if no class or sub-class name (if inheriting)
            if (TXT_Type.Text == "" || TXT_MemberName.Text == "")
            {
                return false;
            }

            // Determine optional paramter representation
            string virtOpt = (CheckBox_VirtualOpt.Checked) ? "VIRTUAL" : "";
            string funcBraces = (CheckBox_FunctionOpt.Checked) ? "(" : "";

            // Determine representation of return type/member type
            string memType = "";

            if (RB_PointerOpt.Checked)
            {
                memType = "*";
            }
            else if (RB_ReferenceOpt.Checked)
            {
                memType = "&";
            }

            // Determine parameter string
            for (int i = 0; i < LV_Params.Items.Count; ++i) {
                funcBraces += LV_Params.Items[i].Text;

                // Format if not final parameter
                if (i != LV_Params.Items.Count - 1) {
                    funcBraces += ", ";
                }
            }

            // If function, close off braces
            if (CheckBox_FunctionOpt.Checked) {
                funcBraces += ")";
            }

            // e.g. PRIVATE INLINE int& bagels(int thing, const float morg)
            textBuffer = CB_MemberAccess.SelectedItem.ToString() + space + virtOpt + space + CB_Identifiers.SelectedItem.ToString() + space
                + TXT_Type.Text + memType + space + TXT_MemberName.Text + funcBraces;

            // Modify current selected member or add new one depending on form mode
            if (editMode)
            {
                m_mainForm.LV_Members.Items[m_mainForm.selectedMemberIndex].Text = textBuffer;
            }
            else
            {
                m_mainForm.LV_Members.Items.Add(textBuffer);
            }

            // Apply properties to blueprints of current member
            CppMember currentMember = m_mainForm.selectedClass.members[m_mainForm.selectedMemberIndex];      // Added member is at the end of the list 

            currentMember.access        = CB_MemberAccess.SelectedItem.ToString();
            currentMember.isVirtual     = CheckBox_VirtualOpt.Checked;
            currentMember.modifier      = CB_Identifiers.SelectedItem.ToString();
            currentMember.type          = TXT_Type.Text;
            currentMember.memType       = memType;
            currentMember.name          = TXT_MemberName.Text;
            currentMember.isFunction    = CheckBox_FunctionOpt.Checked;

            return true;
        }

        #region Form Element Events
        private void CB_FunctionOpt_CheckedChanged(object sender, EventArgs e)
        {
            // Flip active status of function options
            GB_FuncOptions.Visible = !GB_FuncOptions.Visible;
        }

        private void CheckBox_FunctionOpt_CheckedChanged(object sender, EventArgs e)
        {
            GB_FuncOptions.Visible = !GB_FuncOptions.Visible;
        }

        private void BTN_MemberConfirm_Click(object sender, EventArgs e)
        {
            ConfirmItem();
        }
        #endregion

        #region C++ Parameter Element Events
        private void BTN_AddParam_Click(object sender, EventArgs e)
        {
            formUtil.LoadPopup<ParamPopup>("ParamPopup");
        }

        private void BTN_RemoveParam_Click(object sender, EventArgs e)
        {
            formUtil.RemoveItems<CppMember>(m_mainForm.selectedClass.members[m_mainForm.selectedMemberIndex].args, LV_Params);
        }

        private void LV_Params_DoubleClick(object sender, EventArgs e) {
            // Set new focused parameter index
            selectedParamIndex = LV_Params.SelectedIndices[0];

            // Attempt to load parameter pop-up form
            ParamPopup successfulPopup = formUtil.LoadPopup<ParamPopup>("ParamPopup");

            if (successfulPopup != null)
            {
                // Successfully loaded, populate form with parameter data and set to edit mode.
                successfulPopup.Populate(m_mainForm.selectedClass.members[m_mainForm.selectedMemberIndex].args[selectedParamIndex], true);
            }
        }
        #endregion
    }
}
