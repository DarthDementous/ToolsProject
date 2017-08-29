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

        private void BTN_AddMember_Click(object sender, EventArgs e)
        {
            // Determine whether to add braces to string
            string funcBraces = (CheckBox_FunctionOpt.Checked) ? "()" : "";

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
            textBuffer = CB_MemberAccess.SelectedItem.ToString() + SPACE + CB_Identifiers.SelectedItem.ToString() + SPACE + TXT_Type.Text + SPACE + memType + SPACE + TXT_MemberName.Text + funcBraces;

            m_mainForm.LV_Members.Items.Add(textBuffer);
        }

        private void BTN_RemoveMember_Click(object sender, EventArgs e)
        {
            formUtil.RemoveItems(((Form1)m_mainForm).LV_Members);
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
    }
}
