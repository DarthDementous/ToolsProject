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
        public int              selectedClassIndex;
        public int              selectedMemberIndex;                    /*Hold onto index of selected member in case selection indices reset.*/

        public string           currentFileName;                        /*Save name of current file to display and save over.*/
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
            selectedClassIndex  = LV_Classes.SelectedIndices[0];
            selectedClass       = classes[LV_Classes.SelectedIndices[0]];

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
            var popup = formUtil.GetFormByName("MemberPopup");

            if (popup == null)
            {
                // Create new instance of pop up form and display
                var popupForm = new MemberPopup();
                popupForm.Show();

                // Load data from selected member
                popupForm.Populate(selectedClass.members[selectedMemberIndex], true);
            }
        }

        /// Selecting class
        private void LV_Classes_DoubleClick(object sender, EventArgs e)
        {
            // Display popup for editing class details
            var popup = formUtil.GetFormByName("ClassPopup");

            if (popup == null)
            {
                // Create new instance of pop up form and display
                var popupForm = new ClassPopup();
                popupForm.Show();

                // Load data from selected class
                popupForm.Populate(selectedClass, true);
            }
        }

        private void loadXMLFile(string a_filePath)
        {
            using (XmlReader reader = XmlReader.Create(a_filePath))
            {
                // Refresh all data before loading new data
                RefreshClassData();

                // Read file line by line
                while (reader.Read())
                {
                    /// CLASS-SPECIFIC DATA
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Class")
                    {
                        // Prepare new class structure
                        CppClass newClass = new CppClass(reader.GetAttribute("name"),
                            (reader.GetAttribute("isVirtual") == "True" ? true : false),        // Use ternary to convert string to bool
                            reader.GetAttribute("base_name"),
                            reader.GetAttribute("base_access"));

                        // Add to list of classes
                        classes.Add(newClass);

                        // Add string representation
                        LV_Classes.Items.Add(newClass.ToString());
                    }

                    /// MEMBER-SPECIFIC DATA
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Member")
                    {
                        // Prepare new member structure
                        CppMember newMember = new CppMember(reader.GetAttribute("access"),
                            reader.GetAttribute("modifier"),
                            reader.GetAttribute("type"),
                            reader.GetAttribute("name"),
                            reader.GetAttribute("memory_type"),
                            (reader.GetAttribute("isVirtual") == "True" ? true : false),
                            (reader.GetAttribute("isFunction") == "True" ? true : false));

                        // Add to current class
                        classes.Last().members.Add(newMember);
                    }

                    /// PARAMETER-SPECIFIC DATA
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Parameter")
                    {
                        // Prepare new parameter structure
                        CppMember newParam = new CppMember("",
                            reader.GetAttribute("const_status"),
                            reader.GetAttribute("type"),
                            reader.GetAttribute("name"),
                            reader.GetAttribute("memory_type"),
                            false,
                            false);

                        // Add to current member
                        classes.Last().members.Last().args.Add(newParam);
                    }
                }
            }

            // Display name of file in form title
            UpdateFormTitle();
        }

        private void saveXMLFile (string a_filePath)
        {
            using (XmlWriter writer = XmlWriter.Create(a_filePath))
            {
                // Open file stream
                writer.WriteStartDocument();

                // Write classes
                writer.WriteStartElement("CLASSES");                // New elements are added lower into the hierarchy

                foreach (CppClass cls in classes)
                {
                    writer.WriteStartElement("Class");

                    // NOTE: Attributes are not displayed in the order they are added
                    writer.WriteAttributeString("isVirtual", cls.isVirtual.ToString());
                    writer.WriteAttributeString("base_name", cls.baseName);
                    writer.WriteAttributeString("base_access", cls.baseAccess);
                    writer.WriteAttributeString("name", cls.name);

                    // Write members
                    writer.WriteStartElement("MEMBERS");

                    foreach (CppMember member in cls.members)
                    {
                        writer.WriteStartElement("Member");

                        writer.WriteAttributeString("name", member.name);
                        writer.WriteAttributeString("type", member.type);
                        writer.WriteAttributeString("modifier", member.modifier);
                        writer.WriteAttributeString("isVirtual", member.isVirtual.ToString());
                        writer.WriteAttributeString("access", member.access);
                        writer.WriteAttributeString("isFunction", member.isFunction.ToString());

                        // Write parameters
                        writer.WriteStartElement("PARAMETERS");

                        foreach (CppMember param in member.args)
                        {
                            writer.WriteStartElement("Parameter");

                            writer.WriteAttributeString("name", param.name);
                            writer.WriteAttributeString("memory_type", param.memType);
                            writer.WriteAttributeString("type", param.type);
                            writer.WriteAttributeString("const_status", param.modifier);

                            writer.WriteEndElement();
                        }

                        // End PARAMETERS
                        writer.WriteEndElement();                   // For proper XML formatting, always close out elements

                        // End current member
                        writer.WriteEndElement();
                    }

                    // End MEMBERS
                    writer.WriteEndElement();

                    // End current class
                    writer.WriteEndElement();
                }

                // End CLASSES
                writer.WriteEndElement();

                writer.WriteEndDocument();
            }

            // Display name of file in form title
            UpdateFormTitle();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            /// Prevent invalid objects from being dropped
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;               // If not a file, return

            string[] dragFiles = (string[])e.Data.GetData(DataFormats.FileDrop);    // Convert files into list of strings

            // Only one .fwg file is considered in the drag and drop process
            var testExtension = System.IO.Path.GetExtension(dragFiles[0]);

            // Compare extension regardless of capitalization
            if (testExtension.Equals(".fwg", StringComparison.CurrentCultureIgnoreCase))
            {
                // First file is .xml, allow for file to be copied into application
                e.Effect = DragDropEffects.Copy;
            } else
            {
                e.Effect = DragDropEffects.None;        // NOTE: It is undetermined whether this cancels the drag drop event or is purely for visual feedback
            }
        }

        // Event triggered AFTER file drop
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            // First file is assumed to be valid from DragEnter event, so load data from it
            string[] dragFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

            loadXMLFile(dragFiles[0]);
        }

        private void UpdateFormTitle()
        {
            if (currentFileName != null)
            {
                // Add open file name to the end of the form title
                this.Text = "C++ Framework Generator - " + System.IO.Path.GetFileName(currentFileName);
            }
            else
            {
                this.Text = "C++ Framework Generator";
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Refresh all items
            RefreshClassData();

            UpdateFormTitle();
        }

        private void RefreshClassData()
        {
            classes.Clear();
            LV_Classes.Items.Clear();
            LV_Members.Items.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Filter syntax = "What the user sees | extensions for the computer e.g. *.jpg"
                DLG_OpenFile.Filter = "FRAMEWORK GENERATOR FILES | *.fwg";
                //DLG_OpenFile.FilterIndex = 2; - Set which filter is selected by default

                DLG_OpenFile.Multiselect = false;                // Only one file at a time
                DLG_OpenFile.Title = "CHOOSE FILE";
                DLG_OpenFile.InitialDirectory = @"Desktop";

                if (DLG_OpenFile.ShowDialog() == DialogResult.OK)
                {
                    // Ensure further saves will overwrite currently opened file
                    currentFileName = DLG_OpenFile.FileName;

                    loadXMLFile(currentFileName);
                }
            }
            catch
            {
                MessageBox.Show("Unable to open file.");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Filter syntax = "What the user sees | extensions for the computer e.g. *.jpg"
                DLG_SaveFile.Filter = "FRAMEWORK GENERATOR FILES | *.fwg";
                DLG_SaveFile.RestoreDirectory = true;       // NOTE: ALWAYS true in Windows Vista/Seven, restores original working directory irregardless of what was selected

                // Suspend program until user has successfully initiated a save
                if (DLG_SaveFile.ShowDialog() == DialogResult.OK)
                {
                    // Set current file to allow it to be saved over
                    currentFileName = DLG_SaveFile.FileName;

                    saveXMLFile(currentFileName);
                }
            }
            catch
            {
                MessageBox.Show("Unable to save file.");
            }

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Enable or disable save option depending if file has been saved first
            if (currentFileName == null)
            {
                saveToolStripMenuItem.Enabled = false;
            } else
            {
                saveToolStripMenuItem.Enabled = true;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Overwrite current opened file
            saveXMLFile(currentFileName);
        }
    }
}
