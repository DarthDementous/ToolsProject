using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2017_08_21_ToolsProjectClassGenerator
{
    public partial class ParamPopup : Form
    {
        // Hold onto instance of main form to access its members
        public ParamPopup(Form1 a_mainForm = null)
        {
            m_mainForm = a_mainForm;

            InitializeComponent();
            InitialiseObjects();
        }

        private void InitialiseObjects()
        {
            // Give combo box default selection
            CB_Access.SelectedIndex = 0;
        }

        private Form1 m_mainForm;
        public FormUtility formUtil = new FormUtility();

        public string textBuffer;
        private char space = ' ';

        private bool isVirtual = false;
        private bool isInheriting = false;
    }
}
