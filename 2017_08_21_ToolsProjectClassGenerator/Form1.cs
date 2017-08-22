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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitialiseObjects();
        }

        private void InitialiseObjects()
        {

        }

        public FormUtility formUtil = new FormUtility();

        private void BTN_AddClass_Click(object sender, EventArgs e)
        {
            var popup = formUtil.GetFormByName("ClassPopup");

            // Only load pop up if it hasn't been loaded before
            if (popup == null)
            {
                // Create new instance of pop up form and display
                var popupForm = new ClassPopup(this);
                popupForm.Show();
            }

        }

        private void BTN_RemoveClass_Click(object sender, EventArgs e)
        {
            /// No items selected, remove end if there is one
            if (LV_Classes.SelectedItems.Count == 0 && LV_Classes.Items.Count != 0)
            {
                LV_Classes.Items.RemoveAt(LV_Classes.Items.Count - 1);
            }

            /// Item(s) selected, remove them
            else
            {
                foreach (var item in LV_Classes.SelectedItems)
                {
                    LV_Classes.Items.Remove((ListViewItem)(item));
                }
            }
        }
    }
}
