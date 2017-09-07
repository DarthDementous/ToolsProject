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

        public bool     editMode = false;  /*TRUE = form has been opened to edit existing member, FALSE = form has been opened to add new member*/

        /**
        * @brief Load data from class into the popup details.
        * @param a_member is the member to extract data from.
        * @param a_editMode is whether class is being modified or added.
        * @return void.
        * */
        public void Populate(CppClass a_cls, bool a_editMode)
        {
            editMode = a_editMode;

            TXT_Class.Text = a_cls.name;

            if (a_cls.isVirtual)
            {
                CB_VirtualOpt.Checked = true;
            }

            // Inheritance options
            if (a_cls.baseName != "")
            {
                // Display inheritance options
                CB_InheritOpt.Checked = true;

                GB_InheritOptions.Visible = true;
                GB_InheritOptions.Enabled = true;

                CB_Access.SelectedItem  = a_cls.baseAccess;
                TXT_BaseClass.Text      = a_cls.baseName;
            } else
            {
                // Disable inheritance options
                CB_InheritOpt.Checked = false;

                GB_InheritOptions.Visible   = false;
                GB_InheritOptions.Enabled   = false;
            }

            // Modify button text if in edit mode
            if (editMode)
            {
                BTN_ClassConfirm.Text = "Confirm Changes";
            }
        }

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
            if (TXT_Class.Text == "" || (TXT_BaseClass.Text == "" && GB_InheritOptions.Enabled))
            {
                return false;
            }

            // Determine optional identifiers for class
            string virtOpt = isVirtual ? "VIRTUAL" : "";
            string inheritOpt = GB_InheritOptions.Enabled ? (":" + space + CB_Access.SelectedItem.ToString() + space + TXT_BaseClass.Text) : "";

            // Convert class options into string
            textBuffer = virtOpt + space + TXT_Class.Text + space + inheritOpt;

            // Modify or add class depending on mode of form
            if (editMode)
            {
                // Modify string representation
                m_mainForm.LV_Classes.Items[m_mainForm.selectedClassIndex].Text = textBuffer;

                // Update variables of selected class instead of overwriting completely and losing member data
                CppClass currentClass = m_mainForm.classes[m_mainForm.selectedClassIndex];

                currentClass.isVirtual  = isVirtual;
                currentClass.name       = TXT_Class.Text;
                currentClass.baseAccess = CB_Access.SelectedItem.ToString();
                currentClass.baseName   = TXT_BaseClass.Text;
            }
            else
            {
                // Add class representation
                m_mainForm.LV_Classes.Items.Add(textBuffer);

                // Add class to list
                m_mainForm.classes.Add(formUtil.StringToClass(textBuffer));
            }

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
            GB_InheritOptions.Enabled = !GB_InheritOptions.Enabled;
            GB_InheritOptions.Visible = !GB_InheritOptions.Visible;
        }

        private void CB_VirtualOpt_CheckedChanged(object sender, EventArgs e)
        {
            isVirtual = !isVirtual;
        }
    }

}
