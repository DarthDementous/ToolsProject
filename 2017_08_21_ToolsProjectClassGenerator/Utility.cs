using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2017_08_21_ToolsProjectClassGenerator;

namespace Utilities
{
   public class FormUtility
    {
        public enum eMemType { VAL, PTR, REF };

        public Form GetFormByName(string a_name)
        {
            foreach (var form in Application.OpenForms.Cast<Form>())
            {
                // Form name matches parameters, return it
                if (form.Name == a_name)
                {
                    return form;
                }
            }

            // Form not found, return null
            return null;
        }

        /**
         * @brief Based on context of selection, remove desired items and set selection to bottom one.
         * @param a_lv is the ListView containing the items.
         * @return void
         * */
        public void RemoveItems(ListView a_lv)
        {
            // No items selected, remove end if there is one
            if (a_lv.SelectedItems.Count == 0 && a_lv.Items.Count != 0)
            {
                a_lv.Items.RemoveAt(a_lv.Items.Count - 1);
            }

            // Item(s) selected, remove them
            else
            {
                foreach (var item in a_lv.SelectedItems)
                {
                    a_lv.Items.Remove((ListViewItem)(item));
                }
            }
        }
    }

    /** @brief Sub-form that allows for key presses in order to enhance user functionality.
     * */
    public class PopupForm : Form
    {
        protected Form1 m_mainForm;

        protected void InitialiseMainForm()
        {
            // Assign pointer to main form
            m_mainForm = (Form1)Application.OpenForms["Form1"];
        }

        protected virtual bool GenerateFunction() { return false; }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Let them close the form by pressing enter
            switch (keyData)
            {
                case Keys.Enter:
                    if (GenerateFunction())
                    {
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Not all text fields were filled out.");
                    }
                    break;

                case Keys.Escape:
                    this.Close();
                    break;

                    //case Keys.Alt | Keys.F4:

                    //    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }

    /** @brief Base structure for holding data for code items in C++ 
     * */
    public class CppItem
    {
        public string type;
        public string name; 
    }

    /** @brief Inherited structure for storing data for C++ members
     * */
    public class CppMember : CppItem
    {
        
    } 
}
