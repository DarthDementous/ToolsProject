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
    public partial class ClassPopup : Form
    {
        // Hold onto instance of main form to access its members
        public ClassPopup(Form1 a_mainForm = null)
        {
            m_mainForm = a_mainForm;

            InitializeComponent();
            InitialiseObjects();
        }

        private Form1 m_mainForm;
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

        private void BTN_ClassConfirm_Click(object sender, EventArgs e)
        {
            // Determine optional identifiers for class
            string virtOpt      = isVirtual ? "VIRTUAL" : "";
            string inheritOpt   = isInheriting ? (":" + space + CB_Access.SelectedItem.ToString() + space + TXT_BaseClass.Text) : ""; 

            // Convert class options into string
            textBuffer = virtOpt + space + TXT_Class.Text + space + inheritOpt;
            
            // Add class to list
            m_mainForm.LV_Classes.Items.Add(textBuffer);
        }

        private void CB_InheritOpt_CheckedChanged(object sender, EventArgs e)
        {
            // Flip activation of inheritance options
            isInheriting            = !isInheriting;

            CB_Access.Enabled       = !CB_Access.Enabled;
            TXT_BaseClass.Enabled   = !TXT_BaseClass.Enabled;
        }

        private void CB_VirtualOpt_CheckedChanged(object sender, EventArgs e)
        {
            isVirtual = !isVirtual;
        }
    }
}
