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
}
