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
    public partial class ClassPopup : PopupForm
    {
        // Hold onto instance of main form to access its members
        public ClassPopup()
        {
            InitialiseForms();
            InitializeComponent();
            InitialiseObjects();
        }

        public FormUtility formUtil = new FormUtility();

        public string   textBuffer;
        private char    space = ' ';

        private bool    isVirtual    = false;
        private bool    isInheriting = false;

        private void InitialiseObjects()
        {
            // Give combo box default selection
            CB_Access.SelectedIndex = 0;
        }

        /**
        *   @brief Using user specified info, add string of class representation to listview.
        *   NOTE: Overrides GenerateFunction in KeyForm sub-class.
        *   @return Bool of whether function was successfully generated or not (empty parameters).
        *   */
        protected override bool GenerateFunction()
        {
            // Quit out early with failure if no class or sub-class name (if inheriting)
            if (TXT_Class.Text == "" || (TXT_BaseClass.Text == "" && isInheriting))
            {
                return false;
            }

            // Determine optional identifiers for class
            string virtOpt = isVirtual ? "VIRTUAL" : "";
            string inheritOpt = isInheriting ? (":" + space + CB_Access.SelectedItem.ToString() + space + TXT_BaseClass.Text) : "";

            // Convert class options into string
            textBuffer = virtOpt + space + TXT_Class.Text + space + inheritOpt;

            // Add class representation
            m_mainForm.LV_Classes.Items.Add(textBuffer);

            // Add class to list
            m_mainForm.classes.Add(formUtil.StringToClass(textBuffer));

            return true;
        }

        private void BTN_ClassConfirm_Click(object sender, EventArgs e)
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

            /// TODO: Hitting enter when text field is not in focus targets button and triggers class confirm as well as the enter key press meaning two message boxes come up.
        }

        private void CB_InheritOpt_CheckedChanged(object sender, EventArgs e)
        {
            // Flip activation of inheritance options
            isInheriting = !isInheriting;

            GB_InheritOptions.Enabled = !GB_InheritOptions.Enabled;
            GB_InheritOptions.Visible = !GB_InheritOptions.Visible;
        }

        private void CB_VirtualOpt_CheckedChanged(object sender, EventArgs e)
        {
            isVirtual = !isVirtual;
        }
    }

}
