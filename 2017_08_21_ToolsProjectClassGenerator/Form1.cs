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
using System.Xml;

namespace _2017_08_21_ToolsProjectClassGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<CppClass>   classes     = new List<CppClass>();     /*Keep track of all generated classes.*/
        public FormUtility      formUtil    = new FormUtility();

        public CppClass         selectedClass;                          /*Selection indices reset, keep track of focused class.*/
        public int              selectedMemberIndex;                    /*Hold onto index of selected member in case selection indices reset.*/

        ///**
        // * @brief Based on class strings in list view, update class data list accordingly.
        // * NOTE: Call everytime the listview is modified. 
        // * @return void.
        // * */
        //public void UpdateClasses()
        //{
        //    // Refresh data
        //    classes.Clear();                        /// TODO: Find a better way to refresh classes without deleting class member data

        //    // Convert strings to classes and add to list
        //    foreach (ListViewItem classRep in LV_Classes.Items)
        //    {
        //        classes.Add(formUtil.StringToClass(classRep.Text));
        //    }
        //}

        /**
         * @brief Update current selected classes' list of members based on listview.
         * NOTE: Call everytime the listview is modified.
         * @param a_selectClass is the class to update.
         * @return void.
         * */
        // public void UpdateClassMembers(CppClass a_selectClass)
        //{
        //    // Refresh data
        //    a_selectClass.members.Clear();

        //    // Convert strings to members and add to list
        //    foreach (ListViewItem memberRep in LV_Members.Items)
        //    {
        //        a_selectClass.members.Add(formUtil.StringToMember(memberRep.Text));
        //    }
            
        //}

        private void BTN_AddClass_Click(object sender, EventArgs e)
        {
            var popup = formUtil.GetFormByName("ClassPopup");

            // Only load pop up if it hasn't been loaded before
            if (popup == null)
            {
                // Create new instance of pop up form and display
                var popupForm = new ClassPopup();
                popupForm.Show();
            }
        }

        private void BTN_RemoveClass_Click(object sender, EventArgs e)
        {
            /// Actual class removal
            // No items selected, remove end if there is one
            if (LV_Classes.SelectedItems.Count == 0 && LV_Classes.Items.Count != 0)
            {
                classes.RemoveAt(LV_Classes.Items.Count - 1);
            }

            // Item(s) selected, remove them
            else
            {
                foreach (int index in LV_Classes.SelectedIndices)
                {
                    classes.RemoveAt(index);
                }
            }

            /// Class string removal
            formUtil.RemoveItems(LV_Classes);
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

        private void BTN_SaveFile_Click(object sender, EventArgs e) {

            using (XmlWriter writer = XmlWriter.Create("Classes.xml")) {
                // Open file stream
                writer.WriteStartDocument();

                writer.WriteStartElement("CLASSES");            // Create initial hierarchy category

                foreach (CppClass cls in classes) {
                    writer.WriteStartElement("Class");

                    writer.WriteElementString("VirtualDestructor", cls.isVirtual.ToString());
                    writer.WriteElementString("Name", cls.name);
                    writer.WriteElementString("BaseAccess", cls.baseAccess);
                    writer.WriteElementString("BaseName", cls.baseName);

                    foreach (CppMember member in cls.members) {
                        writer.WriteStartElement("Member");

                        //writer.WriteElementString("")
                    }

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();

                writer.WriteEndDocument();
            }
        }

        //private void BTN_LoadFile_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Filter syntax = "What the user sees | extensions for the computer e.g. *.jpg"
        //        DLG_OpenFile.Filter = "XML FILES | *.xml; *.xls; *.xlsx; *.xlsm; *.xlsb;";
        //        //DLG_OpenFile.FilterIndex = 2; - Set which filter is selected by default

        //        DLG_OpenFile.Multiselect        = false;                // One file at a time
        //        DLG_OpenFile.Title              = "CHOOSE FILE";       
        //        DLG_OpenFile.InitialDirectory   = @"Desktop";

        //        if (DLG_OpenFile.ShowDialog() == DialogResult.OK)
        //        {
        //            string      pathName = DLG_OpenFile.FileName;
        //            string      fileName = Path.GetFileNameWithoutExtension(DLG_OpenFile.FileName);
        //            DataTable   table    = new DataTable();

        //            string connectionString = "";
        //            string sheetName        = TXT_SheetName.Text;

        //            FileInfo file           = new FileInfo(pathName);
                    
        //            if (!file.Exists) { throw new Exception("File does not exist."); }

        //            string ext = file.Extension;

        //            switch (ext)
        //            {
        //                case ".xls":
        //                    connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
        //                    break;
        //                case ".xlsx":
        //                    connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathName + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";
        //                    break;
        //                default:
        //                    connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
        //                    break;
        //            }

        //            OleDbConnection     connectionXLS       = new OleDbConnection(connectionString);
        //            OleDbDataAdapter    connectionAdapter   = new OleDbDataAdapter(string.Format("select * from [" + sheetName + "$", fileName), connectionXLS);

        //            connectionAdapter.Fill(table);

        //            DGV_SpreadSheet.DataSource = table;
        //        }
        //    }
        //    catch
        //    {
        //        MessageBox.Show("!?!?!??!?!");
        //    }
        //}

        private void BTN_AddMember_Click(object sender, EventArgs e)
        {
            // Add temporary member to allow parameters to be stored before member is added
            selectedClass.members.Add(new CppMember());
            selectedMemberIndex = selectedClass.members.Count - 1;

            var popup = formUtil.GetFormByName("MemberPopup");

            // Only load pop up if it hasn't been loaded before
            if (popup == null)
            {
                // Create new instance of pop up form and display
                var popupForm = new MemberPopup();
                popupForm.Show();
            }
        }

        private void BTN_RemoveMember_Click(object sender, EventArgs e)
        {
            /// Actual member removal
            // No items selected, remove end if there is one
            if (LV_Members.SelectedItems.Count == 0 && LV_Members.Items.Count != 0)
            {
                selectedClass.members.RemoveAt(LV_Members.Items.Count - 1);
            }

            // Item(s) selected, remove them
            else
            {
                foreach (int index in LV_Members.SelectedIndices)
                {
                    selectedClass.members.RemoveAt(index);
                }
            }

            /// Member item string removal
            formUtil.RemoveItems(LV_Members);
        }

        /// Selecting class
        private void LV_Classes_Click(object sender, EventArgs e)
        {
            // Refresh items
            LV_Members.Items.Clear();

            // Set new focused class
            selectedClass = classes[LV_Classes.SelectedIndices[0]];

            // Populate member's list with focused class's members
            foreach (var member in selectedClass.members)
            {
                LV_Members.Items.Add(member.ToString());
            }

            // Display member panel (if not displaying already)
            PNL_Members.Visible = true;
        }

        /// Selecting member
        private void LV_Members_DoubleClick(object sender, EventArgs e)
        {
            // Set new focused member index
            selectedMemberIndex = LV_Members.SelectedIndices[0];

            // Display popup for editing member details
            var popup = formUtil.GetFormByName("ClassPopup");

            if (popup == null)
            {
                // Create new instance of pop up form and display
                var popupForm = new MemberPopup();
                popupForm.Show();

                // Load data from selected member
                popupForm.Populate(selectedClass.members[selectedMemberIndex], true);
            }
        }
    }
}
