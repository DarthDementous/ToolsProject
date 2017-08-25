using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
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

        //private void BTN_LoadFile_Click(object sender, EventArgs e)
        //{
        //    // Suspends entire program until desired result is found (like a while loop)
        //    if (DLG_FindFile.ShowDialog() == DialogResult.OK)
        //    {
        //        //MessageBox.Show(DLG_FindFile.SelectedPath);

        //        // Save and list files with the specified extension in the chosen folder
        //        string[] fileNames = Directory.GetFiles(DLG_FindFile.SelectedPath, "*.xlsx");

        //        foreach (string name in fileNames)
        //        {
        //            LV_Classes.Items.Add(name);
        //        }
        //    }
        //}

        private void BTN_OpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                // Filter syntax = "What the user sees | extensions for the computer e.g. *.jpg"
                DLG_OpenFile.Filter = "XML FILES | *.xml; *.xls; *.xlsx; *.xlsm; *.xlsb;";
                //DLG_OpenFile.FilterIndex = 2; - Set which filter is selected by default

                DLG_OpenFile.Multiselect        = false;                // One file at a time
                DLG_OpenFile.Title              = "CHOOSE FILE";       
                DLG_OpenFile.InitialDirectory   = @"Desktop";

                if (DLG_OpenFile.ShowDialog() == DialogResult.OK)
                {
                    string      pathName = DLG_OpenFile.FileName;
                    string      fileName = Path.GetFileNameWithoutExtension(DLG_OpenFile.FileName);
                    DataTable   table    = new DataTable();

                    string connectionString = "";
                    string sheetName        = TXT_SheetName.Text;

                    FileInfo file           = new FileInfo(pathName);
                    
                    if (!file.Exists) { throw new Exception("File does not exist."); }

                    string ext = file.Extension;

                    switch (ext)
                    {
                        case ".xls":
                            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                            break;
                        case ".xlsx":
                            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathName + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";
                            break;
                        default:
                            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                            break;
                    }

                    OleDbConnection     connectionXLS       = new OleDbConnection(connectionString);
                    OleDbDataAdapter    connectionAdapter   = new OleDbDataAdapter(string.Format("select * from [" + sheetName + "$", fileName), connectionXLS);

                    connectionAdapter.Fill(table);

                    DGV_SpreadSheet.DataSource = table;
                }
            }
            catch
            {
                MessageBox.Show("!?!?!??!?!");
            }
        }

        private void CB_FunctionOpt_CheckedChanged(object sender, EventArgs e)
        {
            // Flip active status of function options
            GB_FuncOptions.Enabled = !GB_FuncOptions.Enabled;
            GB_FuncOptions.Visible = !GB_FuncOptions.Visible;
        }

        private void BTN_AddParam_Click(object sender, EventArgs e)
        {
            var popup = formUtil.GetFormByName("ParamPopup");

            // Only load pop up if it hasn't been loaded before
            if (popup == null)
            {
                // Create new instance of pop up form and display
                var popupForm = new ParamPopup(this);
                popupForm.Show();
            }
        }
    }
}
