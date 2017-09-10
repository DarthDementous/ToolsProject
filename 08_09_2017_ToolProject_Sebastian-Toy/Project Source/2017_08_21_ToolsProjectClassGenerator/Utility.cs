using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2017_08_21_ToolsProjectClassGenerator;

namespace Utilities {
    public class CppObject
    {
        public CppObject() { }

        public string name;
        public bool isVirtual;          /*Determine whether class has a virtual destructor or function is virtual.*/

        public bool toRemove = false;   /*true = object is marked to be removed, false = do not remove object*/

    }

    /** @brief Inherited structure for storing data for C++ members (variables, functions, parameters)
    * */
    public class CppMember : CppObject {
        // AccessLevel, Modifier, Type, Name, MemoryType 

        public CppMember() {}

        public CppMember(string a_access, string a_mod, string a_type, string a_name, string a_mem, bool a_isVirt = false, bool a_isFunc = false) {
            type = a_type;
            name = a_name;

            access = a_access;
            modifier = a_mod;
            memType = a_mem;

            isVirtual = a_isVirt;
            isFunction = a_isFunc;
        }

        public override string ToString() {
            // Determine whether to add braces to string
            string funcBraces = (isFunction) ? "(" : "";
            string virtOpt = (isVirtual) ? "VIRTUAL" : "";

            // Determine parameter representation
            for (int i = 0; i < args.Count; ++i) {
                funcBraces += args[i].ToString();

                // Format if not final parameter
                if (i != args.Count - 1) {
                    funcBraces += ", ";
                }
            }
            
            // Close braces if member is function
            if (isFunction) {
                funcBraces += ")";
            }

            // Return string representation of member
            return access + ' ' + virtOpt + ' ' + modifier + ' ' + type + memType + ' ' + name + funcBraces;

        }

        public string type;

        public bool isFunction;   /*Whether to treat member like a function.*/

        public string access;       /*Level of access (PUBLIC, PROTECTED, PRIVATE)*/
        public string modifier;     /*Member modifiers e.g. const, static etc.*/
        public string memType;      /*Type of memory (&, *, "")*/

        public List<CppMember> args = new List<CppMember>(); /*List of parameters if member is a function.*/
    }

    /** @brief Inherited structure for holding data for C++ classes 
    * */
    public class CppClass : CppObject {
        // ClassName, [isVirtual], [BaseClassName, Access]
        public CppClass(string a_name, bool a_isVirtual = false, string a_baseName = "", string a_access = "PUBLIC") {
            name = a_name;
            isVirtual = a_isVirtual;

            baseAccess = a_access;
            baseName = a_baseName;
        }

        public override string ToString() {
            // Determine optional identifiers for class
            string virtOpt = isVirtual ? "VIRTUAL" : "";
            string inheritOpt = (baseName != "") ? (":" + ' ' + baseAccess + ' ' + baseName) : "";

            // Convert class data into a string
            return virtOpt + ' ' + name + ' ' + inheritOpt;
        }

        public string baseName;    /*Name of base class.*/
        public string baseAccess;  /*Type of inheritance (PUBLIC = default, PROTECTED, PRIVATE)*/

        public List<CppMember> members = new List<CppMember>(); /*Currently held members of class.*/
    }

    /** @brief Class that allows the use of helpful custom winform utility functions.
     * */
    public class FormUtility {
        public enum eMemType { VAL, PTR, REF };
        public enum eAccess { PUBLIC, PROTECTED, PRIVATE };

        public Form GetFormByName(string a_name) {
            foreach (var form in Application.OpenForms.Cast<Form>()) {
                // Form name matches parameters, return it
                if (form.Name == a_name) {
                    return form;
                }
            }

            // Form not found, return null
            return null;
        }

        /**
         * @brief Based on context of selection, remove desired items and set selection to bottom one.
         * @param a_itemList is the templated list containing the data for the items.
         * @param a_lv is the ListView containing the items.
         * @return void
         * */
        public void RemoveItems<T>(List<T> a_itemList, ListView a_lv) where T : CppObject {     // Constrain type so it must inherit from CppObject
            /// Actual item removal
            // No items selected, remove end if there is one
            if (a_lv.SelectedItems.Count == 0 && a_lv.Items.Count != 0)
            {
                a_itemList.RemoveAt(a_lv.Items.Count - 1);
            }

            // Item(s) selected, mark for deletion and remove
            else
            {
                foreach (int index in a_lv.SelectedIndices)
                {
                    // Mark for removal to avoid de-syncing the indices between the list of items and the listview
                    a_itemList[index].toRemove = true;
                }

                // Remove marked items
                for (int i = 0; i < a_itemList.Count; ++i)
                {
                    if (a_itemList[i].toRemove)
                    {
                        a_itemList.Remove(a_itemList[i]);

                        // Decrease index to avoid skipping over elements after modifying list
                        --i;
                    }
                }
            }

            /// Listview string removal

            // No items selected, remove end if there is one
            if (a_lv.SelectedItems.Count == 0 && a_lv.Items.Count != 0) {
                a_lv.Items.RemoveAt(a_lv.Items.Count - 1);
            }

            // Item(s) selected, remove them
            else {
                foreach (var item in a_lv.SelectedItems) {
                    a_lv.Items.Remove((ListViewItem)(item));
                }
            }
        }

        /**
         * @brief Display new pop-up form if there isn't one already.
         * @NOTE: Generic type must inherit from PopupForm.
         * @param a_formName is the name of the pop-up form to check if its already open.
         * */
        public T LoadPopup<T>(string a_formName) where T : PopupForm, new()  // New constraint allows new instances of generic type to be made
        {
            var popup = GetFormByName(a_formName);

            // Only load pop up if it hasn't been loaded before
            if (popup == null)
            {
                // Create new instance of pop up form and display
                var popupForm = new T();
                popupForm.Show();

                // Return successful instance of pop-up form
                return popupForm;
            }

            // Pop up already open, return null
            return null;
        }
        /**
         * @brief Convert string into C++ parameter data.
         * @param a_str is the string to convert. (e.g. "CONST float borg", " string moere)
         * @return Constructed C++ parameter structure.
         * */
        public CppMember StringToParam(string a_str) {
            /// 1. Define variables needed to construct parameter
            string cnst = "", type = "", memType = "", name = "";

            /// 2. Extract parameter information from string
            var splitString = a_str.Split();

            cnst = splitString[0];
            type = splitString[1];

            // Determine memory type by testing with delimiters
            var ptrTest = splitString[1].Split('*');
            if (ptrTest.Count() > 1)                    // Type is a pointer
            {
                type = ptrTest[0];
                memType = "*";
            } else                                      // Type is not a pointer
              {
                type = ptrTest[0];
                memType = "";
            }

            var refTest = splitString[1].Split('&');
            if (refTest.Count() > 1)                   // Type is a reference
            {
                type = refTest[0];
                memType = "&";
            } else                                     // Type is not a reference
              {
                type = refTest[0];
                memType = "";
            }

            name = splitString[2];

            return new CppMember("", cnst, type, name, memType);
        }

        /**
         * @brief Convert string into C++ member data.
         * @param a_str is the string to convert. (e.g. "PUBLIC int meggle", "PRIVATE VIRTUAL STATIC int moggle()")
         * @return Constructed C++ member structure.
         * */
        public CppMember StringToMember(string a_str) {
            /// 1. Define variables needed to construct member
            string access = "", modifier = "", type = "", name = "", memType = "";
            bool isFunc = false, isVirt = false;

            /// 2. Extract member information from string
            var splitString = a_str.Split();

            // First three items can be determined whole-sale
            access = splitString[0];
            isVirt = (splitString[1] == "VIRTUAL") ? true : false;
            modifier = splitString[2];

            // Determine memory type by testing with delimiters
            var ptrTest = splitString[3].Split('*');
            if (ptrTest.Count() > 1)                    // Type is a pointer
            {
                type = ptrTest[0];
                memType = "PTR";
            } else                                      // Type is not a pointer
              {
                type = ptrTest[0];
                memType = "VAL";
            }

            var refTest = splitString[3].Split('&');
            if (refTest.Count() > 1)                    // Type is a reference
            {
                type = refTest[0];
                memType = "REF";
            } else                                      // Type is not a reference
              {
                type = refTest[0];
                memType = "VAL";
            }

            // Determine if member is a function
            var funcTest = splitString[4].Split('(');
            if (funcTest.Count() > 1)                   // Is a function
            {
                name = funcTest[0];
                isFunc = true;
            } else                                        // Is not a function
              {
                name = funcTest[0];
                isFunc = false;
            }

            /// 3. Construct and return member structure
            return new CppMember(access, modifier, type, name, memType, isVirt, isFunc);
        }

        /**
         * @brief Convert string into C++ class data.
         * @param a_str is the string to convert. (e.g. "VIRTUAL className : PUBLIC baseName", "className")
         * @return Constructed C++ class structure.
         * */
        public CppClass StringToClass(string a_str) {
            // 1. Define variables necessary for creating the class
            string name = "", baseName = "", baseAccess = "";
            bool isVirtual = false;

            // 2. Extract class information from string
            var splitString = a_str.Split(':');             // Split string into class section and base class section

            /// Process first section (class info)
            if (splitString.Count() != 0) {
                foreach (var item in splitString[0].Split()) {
                    // Virtual identifier
                    if (item == "VIRTUAL") {
                        isVirtual = true;
                    }
                    // Class name
                    else if (item != "") {
                        name = item;
                    }
                }
            }

            /// Process second section (inherited class info)
            if (splitString.Count() > 1) {
                foreach (var item in splitString[1].Split()) {
                    // Access level
                    if (item == "PUBLIC" || item == "PROTECTED" || item == "PRIVATE") {
                        baseAccess = item;
                    }
                    // Base class name
                    else if (item != "") {
                        baseName = item;
                    }
                }
            }

            // 3. Construct class with information and return
            return new CppClass(name, isVirtual, baseName, baseAccess);
        }
    }

    /** @brief Sub-form that allows for key presses in order to enhance user functionality.
     * */
    public class PopupForm : Form {
        protected Form1 m_mainForm;             /* Hold onto pointer to main form to easily interface with it*/
        public bool editMode = false;           /*TRUE = form has been opened to edit existing item, FALSE = form has been opened to add new item*/

        protected   string   textBuffer;             /*Buffer for holding string representation of generated item data*/
        protected   char    space = ' ';            /*Identify space character with keyword for readability*/

        protected   FormUtility formUtil = new FormUtility();     /*Allow use of helpful custom utility functions*/

        protected virtual void InitialiseForms() {
            // Assign pointer to main form
            m_mainForm = (Form1)Application.OpenForms["Form1"];
        }

        /**
         * @brief Convert user input into item data and add string representation to relevant list-view.
         * NOTE: Designed to be overwritten by the derived classes.
         * */
        protected virtual bool GenerateItem() { return false; }

        /**
         * @brief Attempt to create item from user input.
         * @NOTE: Displays a message box with an error if unable to create item.
         * */
        protected void ConfirmItem() {
            // Assess success of item creation and provide feedback.
            if (GenerateItem())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Not all text fields were filled out.");
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            // Allow user to interact with the pop-up via key input
            switch (keyData) {
                // Generate item and close pop-up
                case Keys.Enter:
                    if (GenerateItem()) {
                        this.Close();

                    } else {
                        MessageBox.Show("Not all text fields were filled out.");
                    }
                    break;
                
                // Close pop-up
                case Keys.Escape:
                    this.Close();
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
