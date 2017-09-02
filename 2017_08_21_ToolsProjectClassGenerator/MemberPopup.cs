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
        public bool     editMode = false;  /*TRUE = form has been opened to edit existing member, FALSE = form has been opened to add new member*/

        private string  textBuffer;
        private char    SPACE = ' ';

        private bool isVirtual  = false;
        private bool isFunc     = false;

        FormUtility formUtil = new FormUtility();

        public MemberPopup()
        {
            InitialiseMainForm();
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
                isVirtual = true;
            }

            // Function
            if (a_member.isFunction)
            {
                CheckBox_FunctionOpt.Checked = true;
                isFunc = true;
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

        private void CB_FunctionOpt_CheckedChanged(object sender, EventArgs e)
        {
            // Flip active status of function options
            GB_FuncOptions.Enabled = !GB_FuncOptions.Enabled;
            GB_FuncOptions.Visible = !GB_FuncOptions.Visible;
        }

        protected override bool GenerateFunction()
        {
            // Quit out early with failure if no class or sub-class name (if inheriting)
            if (TXT_Type.Text == "" || TXT_MemberName.Text == "")
            {
                return false;
            }

            // Determine optional paramter representation
            string virtOpt = (isVirtual) ? "VIRTUAL" : "";
            string funcBraces = (isFunc) ? "()" : "";

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

            // e.g. PRIVATE INLINE int& bagels
            textBuffer = CB_MemberAccess.SelectedItem.ToString() + SPACE + virtOpt + SPACE + CB_Identifiers.SelectedItem.ToString() + SPACE
                + TXT_Type.Text + memType + SPACE + TXT_MemberName.Text + funcBraces;

            // Modify current selected member or add new one depending on form mode
            if (editMode)
            {
                m_mainForm.LV_Members.Items[m_mainForm.selectedMemberIndex].Text = textBuffer;
            }
            else
            {
                m_mainForm.LV_Members.Items.Add(textBuffer);
            }

            // Re-add members based on modifications to list
            m_mainForm.UpdateClassMembers(m_mainForm.selectedClass);

            return true;
        }

        private void BTN_AddParam_Click(object sender, EventArgs e)
        {
            var popup = formUtil.GetFormByName("ParamPopup");

            // Only load pop up if it hasn't been loaded before
            if (popup == null)
            {
                // Create new instance of pop up form and display
                var popupForm = new ParamPopup();
                popupForm.Show();
            }
        }

        private void BTN_RemoveParam_Click(object sender, EventArgs e)
        {
            formUtil.RemoveItems(LV_Params);
        }

        private void CB_VirtualOpt_CheckedChanged(object sender, EventArgs e)
        {
            isVirtual = !isVirtual;
        }

        private void CheckBox_FunctionOpt_CheckedChanged(object sender, EventArgs e)
        {
            GB_FuncOptions.Enabled = !GB_FuncOptions.Enabled;
            GB_FuncOptions.Visible = !GB_FuncOptions.Visible;

            isFunc = !isFunc;
        }

        private void BTN_MemberConfirm_Click(object sender, EventArgs e)
        {
            // Assess success of class creation and provide feedback.
            if (GenerateFunction())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Not all text fields were filled out.");
            }
        }
    }
}
