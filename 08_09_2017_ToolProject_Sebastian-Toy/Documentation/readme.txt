~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
C# Winform Tools Project
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
=======================================================================================================================================================
1. HOW TO START THE APPLICATION
------------------------
- Run the .exe in the ProjectRelease folder.

- To compile, open up '2017_08_21_ToolsProjectClassGenerator.sln' in the ProjectSource folder and Build in the desired mode.
	- There is a limitation of Visual Studio which is that it may not compile if the total directory length is too long. To avoid this, drag the source folder
	 to something more direct like the C drive.

=======================================================================================================================================================
2. PROJECT OVERVIEW/MODIFICATION GUIDE
------------------------
- C# Winform operates entirely on code written within events, most of them triggered by user input such as clicking a button. It is important to note
that when modifying this code there is no way to consistently run code each frame, certain things such as updating a list-view must happen in response
to events.

- The real estate of the application consists of one main Form and three sub-classes of form called PopupForm.
	- Main form - Form1.cs
		- The 'hub' of the project that handles events and functions concering adding/removing classes and members, saving and loading files,
		and displaying the .chm for the user guide.
		- Directly interfaces with ClassPopup, MemberPopup and ParamPopup.

	- Class Pop-up - ClassPopup.cs
		- Handles everything to do with generating a C++ class in terms of string representation and storing the data in the custom type CppClass.
		- Interfaces with Form1 to add and modify class data
	
	- Member Pop-up - MemberPopup.cs
		- Handles everything to do with generating a C++ class in terms of string representation and storing the data in the custom type CppMember.
		- Holds onto events and functions for adding/removing parameters
		- Interfaces with Form1 to add and modify member data

	- Parameter Pop-up - ParamPopup.cs
		- Handles everything to do with generating a C++ class in terms of string representation and storing the data in the custom type CppMember.
		- Interfaces with ClassPopup to represent the string data for the parameter, as well as Form1 to add the parameter data itself to the
		selected member.

- The Utility.cs is where a bunch of useful and re-usable functions are kept, as well as the definition for the custom PopupForm, CppMember, CppClass and
CppObject classes.
	- Utility functions are stored in the class FormUtil and require an instance in order to use the functions (see ClassPopup.cs for an example of this)

- When creating a new PopupForm, the constructor must call the following:
	- InitialiseForms() -> Defines instance of main form (can be overridden to hold onto more than one form, see ParamPopup for example)
	- InitializeComponent() -> Draws the elements in the form, must be manually called due to the constructor overriding the base Form one.

- Storing additional data for something like an extra variable in CppClass will require you to modify the saveXMLFile and loadXMLFile functions due to
the specific way the .fwg files are structured in the XML format.

- For an understanding of the .fwg file format, open 'demonstration.fwg' in the Save Files folder with an XML editor like Notepad++.
	- NOTE: For proper intending an XML formatting plugin may be required or else it'll appear all on one line.
=======================================================================================================================================================
3. HOW TO USE
------------------------
- Navigate to File->Help->User Guide in the top menu-strip of the application for an in-depth guide of all of the application's features.
	- The compiled help manual can also be accessed through Documentation/User Guide/ as well as the HelpNDoc file used to generate the .chm.

- A test file has been included in the Save Files folder which demonstrates the loading capabilities of the application. There are two ways to
load the .fwg file:
	- Drag and drop the file onto the application screen.
	- Navigate to File->Open and follow the dialogue to find and select the file. 
=======================================================================================================================================================
4. REPOSITORY LINKS
------------------------
Tools Project: 	       https://github.com/DarthDementous/ToolsProject.git
=======================================================================================================================================================