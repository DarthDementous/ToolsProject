using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }

    /** @brief Sub-form that allows for key presses in order to enhance user functionality.
     * */
    class KeyForm : Form
    {
        private void GenerateFunction() { }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Let them close the form by pressing enter
            switch (keyData)
            {
                case Keys.Enter:
                    GenerateFunction();
                    this.Close();
                    break;

                case Keys.Escape:
                    this.Close();
                    break;

                    //case Keys.Alt | Keys.F4:

                    //    break;
            }

            if (keyData == Keys.Enter)
            {
                GenerateFunction();
                this.Close();
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
