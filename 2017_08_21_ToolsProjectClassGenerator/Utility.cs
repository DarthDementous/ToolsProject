﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2017_08_21_ToolsProjectClassGenerator;

namespace Utilities
{
    /** @brief Inherited structure for storing data for C++ members (variables, functions, parameters)
    * */
    public class CppMember
    {
        // AccessLevel, Modifier, Type, Name, MemoryType 
        public CppMember(string a_access, string a_mod, string a_type, string a_name, string a_mem, bool a_isVirt = false, bool a_isFunc = false)
        {
            m_type = a_type;
            m_name = a_name;

            m_access     = a_access;
            m_modifier   = a_mod;
            m_memType    = a_mem;

            m_isVirtual  = a_isVirt;
            m_isFunction = a_isFunc;
        }

        public override string ToString()
        {
            // Determine whether to add braces to string
            string funcBraces = (m_isFunction) ? "()" : "";

            // Determine representation of return type/member type
            string memType = "";

            if (memType == "PTR")
            {
                memType = "*";
            }
            else if (memType == "REF")
            {
                memType = "&";
            }

            // Return string representation of member
            return m_access + ' ' + m_modifier + ' ' + m_type + ' ' + m_memType + ' ' + m_name + funcBraces;

        }

        string m_name;
        string m_type;

        bool m_isVirtual;    /*FUNCTIONS ONLY: Whether member is to be overridden.*/
        bool m_isFunction;   /*Whether to treat member like a function.*/

        string m_access;       /*Level of access (PUBLIC, PROTECTED, PRIVATE)*/
        string m_modifier;     /*Member modifiers e.g. const, static etc.*/
        string m_memType;      /*Type of memory (VAl, PTR, REF)*/

        public List<CppMember> args = new List<CppMember>(); /*List of parameters if member is a function.*/
    }

    /** @brief Structure for holding data for C++ classes 
    * */
    public class CppClass
    {
        // ClassName, [isVirtual], [BaseClassName, Access]
        public CppClass(string a_name, bool a_isVirtual = false, string a_baseName = "", string a_access = "PUBLIC")
        {
            m_name = a_name;
            m_isVirtual = a_isVirtual;

            m_baseAccess = a_access;
            m_baseName = a_baseName;
        }

        public override string ToString()
        {
            // Determine optional identifiers for class
            string virtOpt = m_isVirtual ? "VIRTUAL" : "";
            string inheritOpt = (m_baseName != "") ? (":" + ' ' + m_baseAccess + ' ' + m_baseName) : "";

            // Convert class data into a string
            return virtOpt + ' ' + m_name + ' ' + inheritOpt;
        }

        string m_name;
        bool m_isVirtual;  /*Determine whether class has a virtual destructor.*/

        string m_baseName;    /*Name of base class.*/
        string m_baseAccess;  /*Type of inheritance (PUBLIC = default, PROTECTED, PRIVATE)*/

        public List<CppMember> members = new List<CppMember>(); /*Currently held members of class.*/
    }

    /** @brief Class that allows the use of helpful custom winform utility functions.
     * */
    public class FormUtility
    {
        public enum eMemType { VAL, PTR, REF };
        public enum eAccess { PUBLIC, PROTECTED, PRIVATE};

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

        /**
         * @brief Convert string into C++ member data.
         * @param a_str is the string to convert. (e.g. "PUBLIC int meggle", "PRIVATE VIRTUAL STATIC int moggle()")
         * @return Constructed C++ member structure.
         * */
        public CppMember StringToMember(string a_str)
        {
            /// 1. Define variables needed to construct member
            string access = "", modifier = "", type = "", name = "", memType = "";
            bool isFunc = false, isVirt = false;

            /// 2. Extract member information from string
            var splitString = a_str.Split();

            // First three items can be determined whole-sale
            access      = splitString[0];
            isVirt      = (splitString[1] == "VIRTUAL") ? true : false;
            modifier    = splitString[2];

            // Determine memory type by testing with delimiters
            var ptrTest = splitString[3].Split('*');
            if (ptrTest.Count() > 1)                    // Type is a pointer
            {
                type    = ptrTest[0];
                memType = "PTR";
            }
            else                                        // Type is not a pointer
            {
                type    = ptrTest[0];
                memType = "VAL";
            }

            var refTest = splitString[3].Split('&');
            if (refTest.Count() > 1)                   // Type is a reference
            {
                type    = refTest[0];
                memType = "REF";
            }
            else                                        // Type is not a reference
            {
                type    = refTest[0];
                memType = "VAL";
            }

            // Determine if member is a function
            var funcTest = splitString[4].Split('(');
            if (funcTest.Count() > 1)                   // Is a function
            {
                name    = funcTest[0];
                isFunc  = true;
            }
            else                                        // Is not a function
            {
                name    = funcTest[0];
                isFunc  = false;
            }

            /// 3. Construct and return member structure
            return new CppMember(access, modifier, type, name, memType, isVirt, isFunc);
        }

        /**
         * @brief Convert string into C++ class data.
         * @param a_str is the string to convert. (e.g. "VIRTUAL className : PUBLIC baseName", "className")
         * @return Constructed C++ class structure.
         * */
        public CppClass StringToClass(string a_str)
        {
            // 1. Define variables necessary for creating the class
            string name = "", baseName = "", baseAccess = "";
            bool isVirtual = false;

            // 2. Extract class information from string
            var splitString = a_str.Split(':');             // Split string into class section and base class section

            /// Process first section (class info)
            if (splitString.Count() != 0)
            {
                foreach (var item in splitString[0].Split())
                {
                    // Virtual identifier
                    if (item == "VIRTUAL")
                    {
                        isVirtual = true;
                    }
                    // Class name
                    else if (item != "")
                    {
                        name = item;
                    }
                }
            }

            /// Process second section (inherited class info)
            if (splitString.Count() > 1)
            {
                foreach (var item in splitString[1].Split())
                {
                    // Access level
                    if (item == "PUBLIC" || item == "PROTECTED" || item == "PRIVATE")
                    {
                        baseAccess = item;
                    }
                    // Base class name
                    else if (item != "")
                    {
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
}
