﻿using System;
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
            // Parameter is by value by default
            RB_ValOpt.Checked = true;
        }

        private Form1 m_mainForm;
        public FormUtility formUtil = new FormUtility();

        public string   textBuffer;
        private char    SPACE = ' ';

        private bool isConst = false;
        private FormUtility.eMemType memoryStatus = FormUtility.eMemType.VAL;      // Whether variable is a ptr, reference or value

        private void CB_ConstOpt_CheckedChanged(object sender, EventArgs e)
        {
            isConst = !isConst;
        }

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

        private void BTN_ClassConfirm_Click(object sender, EventArgs e)
        {
            // Determine representation for non-textbox choices
            string constant = (isConst) ? "CONST" : "";
            string type = TXT_ParamType.Text;

            switch (memoryStatus) {
                case FormUtility.eMemType.PTR:
                    type += "*";
                    break;
                case FormUtility.eMemType.REF:
                    type += "&";
                    break;
            }

            // Generate string to represent parameter and add to list
            textBuffer = constant + SPACE + type + SPACE + TXT_ParamName.Text;
            
            m_mainForm.LV_Params.Items.Add(textBuffer);
        }
    }
}