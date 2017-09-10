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

        #region C++ Class Element Events
        private void BTN_AddClass_Click(object sender, EventArgs e)
        {
            formUtil.LoadPopup<ClassPopup>("ClassPopup");
        }

        private void BTN_RemoveClass_Click(object sender, EventArgs e)
        {
            formUtil.RemoveItems(classes, LV_Classes);
        }

        /// Selecting class
        private void LV_Classes_Click(object sender, EventArgs e)
        {
            // Refresh items
            LV_Members.Items.Clear();

            // Set new focused class based on first item of selection
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

        /// Selecting class
        private void LV_Classes_DoubleClick(object sender, EventArgs e)
        {
            // Attempt to load class pop-up form
            ClassPopup successfulPopup = formUtil.LoadPopup<ClassPopup>("ClassPopup");

            if (successfulPopup != null)
            {
                // Successfully loaded, populate form with class data and set to edit mode.
                successfulPopup.Populate(selectedClass, true);
            }
        }
        #endregion

        #region C++ Member Element Events
        private void BTN_AddMember_Click(object sender, EventArgs e)
        {
            selectedClass.members.Add(new CppMember());             // Add temporary member to allow parameters to be stored before member is added
            selectedMemberIndex = selectedClass.members.Count - 1;  // Set selected member index to that temporary member

            formUtil.LoadPopup<MemberPopup>("MemberPopup");
        }

        private void BTN_RemoveMember_Click(object sender, EventArgs e)
        {
            formUtil.RemoveItems<CppMember>(selectedClass.members, LV_Members);
        }

        /// Selecting member
        private void LV_Members_DoubleClick(object sender, EventArgs e)
        {
            // Set new focused member index
            selectedMemberIndex = LV_Members.SelectedIndices[0];

            // Attempt to load member pop-up form
            MemberPopup successfulPopup = formUtil.LoadPopup<MemberPopup>("MemberPopup");

            if (successfulPopup != null)
            {
                // Successfully loaded, populate form with member data and set to edit mode.
                successfulPopup.Populate(selectedClass.members[selectedMemberIndex], true);
            }
        }
        #endregion

        #region Menu-strip Events
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Dealing with new unsaved file, ergo no filename
            currentFileName = null;

            // Refresh all items and make title blank
            RefreshClassData();
            UpdateFormTitle();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Filter syntax = "What the user sees | extensions for the computer e.g. *.jpg"
                DLG_OpenFile.Filter = "FRAMEWORK GENERATOR FILES | *.fwg";

                DLG_OpenFile.Multiselect = false;                // Only one file at a time
                DLG_OpenFile.Title = "CHOOSE FILE";
                DLG_OpenFile.InitialDirectory = @"Desktop";

                if (DLG_OpenFile.ShowDialog() == DialogResult.OK)
                {
                    // Interpret .fwg file
                    loadXMLFile(currentFileName);
                }
            }
            catch
            {
                MessageBox.Show("Unable to open file.");
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Enable or disable save option depending if file has been saved first
            if (currentFileName == null)
            {
                saveToolStripMenuItem.Enabled = false;
            }
            else
            {
                saveToolStripMenuItem.Enabled = true;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Overwrite current opened file
            saveXMLFile(currentFileName);
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
                    // Set the current file to allow it to be saved over
                    currentFileName = DLG_SaveFile.FileName;

                    // Write project data to .fwg file
                    saveXMLFile(currentFileName);
                }
            }
            catch
            {
                MessageBox.Show("Unable to save file.");
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Get temporary file name, and change extension so its prepared to store .chm data
            var userGuideFileName = Path.ChangeExtension(Path.GetTempFileName(), ".chm");

            // Create temporary file at temporary file path with the intention of writing to it
            using (FileStream fileStream = new FileStream(userGuideFileName, FileMode.Create, FileAccess.Write))
            {
                // Prepare file for writing binary
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                {
                    // Use byte string returned by resources to copy data of the .chm into the temporary file
                    binaryWriter.Write(Properties.Resources.C___Framework_Generator_User_Guide);
                }
            }

            // Open and run the temporary .chm file
            System.Diagnostics.Process.Start(userGuideFileName);
        }
        #endregion

        #region Main Form Events
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
            }
            else
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
        #endregion

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

            // Ensure further saves will overwrite currently opened file
            currentFileName = a_filePath;

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

        private void RefreshClassData()
        {
            classes.Clear();
            LV_Classes.Items.Clear();
            LV_Members.Items.Clear();
        }

    }
}
