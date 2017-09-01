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

            formUtil.StringToMember(textBuffer);

            m_mainForm.LV_Members.Items.Add(textBuffer);

            return true;
        }

        private void BTN_RemoveMember_Click(object sender, EventArgs e)
        {
            formUtil.RemoveItems(m_mainForm.LV_Members);
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
