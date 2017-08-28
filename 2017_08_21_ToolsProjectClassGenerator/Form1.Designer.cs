namespace _2017_08_21_ToolsProjectClassGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LV_Classes = new System.Windows.Forms.ListView();
            this.col_classes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTN_AddClass = new System.Windows.Forms.Button();
            this.BTN_RemoveClass = new System.Windows.Forms.Button();
            this.DLG_FindFile = new System.Windows.Forms.FolderBrowserDialog();
            this.DGV_SpreadSheet = new System.Windows.Forms.DataGridView();
            this.BTN_OpenFile = new System.Windows.Forms.Button();
            this.DLG_OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.TXT_SheetName = new System.Windows.Forms.TextBox();
            this.LV_Members = new System.Windows.Forms.ListView();
            this.col_members = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GB_AddMember = new System.Windows.Forms.GroupBox();
            this.RB_ReferenceOpt = new System.Windows.Forms.RadioButton();
            this.RB_PointerOpt = new System.Windows.Forms.RadioButton();
            this.CB_MemberAccess = new System.Windows.Forms.ComboBox();
            this.CB_Identifiers = new System.Windows.Forms.ComboBox();
            this.TXT_MemberName = new System.Windows.Forms.TextBox();
            this.CheckBox_FunctionOpt = new System.Windows.Forms.CheckBox();
            this.TXT_Type = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GB_FuncOptions = new System.Windows.Forms.GroupBox();
            this.BTN_RemoveParam = new System.Windows.Forms.Button();
            this.LV_Params = new System.Windows.Forms.ListView();
            this.col_params = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTN_AddParam = new System.Windows.Forms.Button();
            this.BTN_RemoveMember = new System.Windows.Forms.Button();
            this.BTN_AddMember = new System.Windows.Forms.Button();
            this.RB_ValueOpt = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SpreadSheet)).BeginInit();
            this.GB_AddMember.SuspendLayout();
            this.GB_FuncOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // LV_Classes
            // 
            this.LV_Classes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LV_Classes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_classes});
            this.LV_Classes.ForeColor = System.Drawing.Color.OrangeRed;
            this.LV_Classes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LV_Classes.Location = new System.Drawing.Point(49, 42);
            this.LV_Classes.Name = "LV_Classes";
            this.LV_Classes.Size = new System.Drawing.Size(280, 546);
            this.LV_Classes.TabIndex = 0;
            this.LV_Classes.UseCompatibleStateImageBehavior = false;
            this.LV_Classes.View = System.Windows.Forms.View.Details;
            // 
            // col_classes
            // 
            this.col_classes.Text = "Classes";
            this.col_classes.Width = 546;
            // 
            // BTN_AddClass
            // 
            this.BTN_AddClass.BackColor = System.Drawing.Color.Black;
            this.BTN_AddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AddClass.ForeColor = System.Drawing.Color.OrangeRed;
            this.BTN_AddClass.Location = new System.Drawing.Point(49, 599);
            this.BTN_AddClass.Name = "BTN_AddClass";
            this.BTN_AddClass.Size = new System.Drawing.Size(44, 46);
            this.BTN_AddClass.TabIndex = 1;
            this.BTN_AddClass.Text = "+";
            this.BTN_AddClass.UseVisualStyleBackColor = false;
            this.BTN_AddClass.Click += new System.EventHandler(this.BTN_AddClass_Click);
            // 
            // BTN_RemoveClass
            // 
            this.BTN_RemoveClass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_RemoveClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_RemoveClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RemoveClass.ForeColor = System.Drawing.Color.OrangeRed;
            this.BTN_RemoveClass.Location = new System.Drawing.Point(104, 599);
            this.BTN_RemoveClass.Name = "BTN_RemoveClass";
            this.BTN_RemoveClass.Size = new System.Drawing.Size(45, 46);
            this.BTN_RemoveClass.TabIndex = 2;
            this.BTN_RemoveClass.Text = "-";
            this.BTN_RemoveClass.UseVisualStyleBackColor = false;
            this.BTN_RemoveClass.Click += new System.EventHandler(this.BTN_RemoveClass_Click);
            // 
            // DGV_SpreadSheet
            // 
            this.DGV_SpreadSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SpreadSheet.Location = new System.Drawing.Point(1029, 76);
            this.DGV_SpreadSheet.Name = "DGV_SpreadSheet";
            this.DGV_SpreadSheet.Size = new System.Drawing.Size(411, 517);
            this.DGV_SpreadSheet.TabIndex = 4;
            // 
            // BTN_OpenFile
            // 
            this.BTN_OpenFile.Location = new System.Drawing.Point(1029, 600);
            this.BTN_OpenFile.Name = "BTN_OpenFile";
            this.BTN_OpenFile.Size = new System.Drawing.Size(75, 23);
            this.BTN_OpenFile.TabIndex = 5;
            this.BTN_OpenFile.Text = "Open File";
            this.BTN_OpenFile.UseVisualStyleBackColor = true;
            this.BTN_OpenFile.Click += new System.EventHandler(this.BTN_OpenFile_Click);
            // 
            // TXT_SheetName
            // 
            this.TXT_SheetName.Location = new System.Drawing.Point(1127, 601);
            this.TXT_SheetName.Name = "TXT_SheetName";
            this.TXT_SheetName.Size = new System.Drawing.Size(100, 20);
            this.TXT_SheetName.TabIndex = 6;
            this.TXT_SheetName.Text = "Sheet Name...";
            // 
            // LV_Members
            // 
            this.LV_Members.BackColor = System.Drawing.Color.DarkGray;
            this.LV_Members.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_members});
            this.LV_Members.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LV_Members.Location = new System.Drawing.Point(376, 61);
            this.LV_Members.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LV_Members.Name = "LV_Members";
            this.LV_Members.Size = new System.Drawing.Size(186, 405);
            this.LV_Members.TabIndex = 7;
            this.LV_Members.UseCompatibleStateImageBehavior = false;
            this.LV_Members.View = System.Windows.Forms.View.Details;
            // 
            // col_members
            // 
            this.col_members.Text = "Members";
            this.col_members.Width = 369;
            // 
            // GB_AddMember
            // 
            this.GB_AddMember.BackColor = System.Drawing.Color.DimGray;
            this.GB_AddMember.Controls.Add(this.RB_ValueOpt);
            this.GB_AddMember.Controls.Add(this.RB_ReferenceOpt);
            this.GB_AddMember.Controls.Add(this.RB_PointerOpt);
            this.GB_AddMember.Controls.Add(this.CB_MemberAccess);
            this.GB_AddMember.Controls.Add(this.CB_Identifiers);
            this.GB_AddMember.Controls.Add(this.TXT_MemberName);
            this.GB_AddMember.Controls.Add(this.CheckBox_FunctionOpt);
            this.GB_AddMember.Controls.Add(this.TXT_Type);
            this.GB_AddMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_AddMember.ForeColor = System.Drawing.Color.White;
            this.GB_AddMember.Location = new System.Drawing.Point(614, 61);
            this.GB_AddMember.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_AddMember.Name = "GB_AddMember";
            this.GB_AddMember.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_AddMember.Size = new System.Drawing.Size(246, 248);
            this.GB_AddMember.TabIndex = 8;
            this.GB_AddMember.TabStop = false;
            this.GB_AddMember.Text = "Add Member";
            // 
            // RB_ReferenceOpt
            // 
            this.RB_ReferenceOpt.AutoSize = true;
            this.RB_ReferenceOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_ReferenceOpt.Location = new System.Drawing.Point(155, 214);
            this.RB_ReferenceOpt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RB_ReferenceOpt.Name = "RB_ReferenceOpt";
            this.RB_ReferenceOpt.Size = new System.Drawing.Size(75, 17);
            this.RB_ReferenceOpt.TabIndex = 12;
            this.RB_ReferenceOpt.Text = "Reference";
            this.RB_ReferenceOpt.UseVisualStyleBackColor = true;
            // 
            // RB_PointerOpt
            // 
            this.RB_PointerOpt.AutoSize = true;
            this.RB_PointerOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_PointerOpt.Location = new System.Drawing.Point(83, 214);
            this.RB_PointerOpt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RB_PointerOpt.Name = "RB_PointerOpt";
            this.RB_PointerOpt.Size = new System.Drawing.Size(58, 17);
            this.RB_PointerOpt.TabIndex = 11;
            this.RB_PointerOpt.Text = "Pointer";
            this.RB_PointerOpt.UseVisualStyleBackColor = true;
            // 
            // CB_MemberAccess
            // 
            this.CB_MemberAccess.FormattingEnabled = true;
            this.CB_MemberAccess.Items.AddRange(new object[] {
            "PUBLIC",
            "PROTECTED",
            "PRIVATE"});
            this.CB_MemberAccess.Location = new System.Drawing.Point(17, 25);
            this.CB_MemberAccess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CB_MemberAccess.Name = "CB_MemberAccess";
            this.CB_MemberAccess.Size = new System.Drawing.Size(107, 21);
            this.CB_MemberAccess.TabIndex = 10;
            // 
            // CB_Identifiers
            // 
            this.CB_Identifiers.FormattingEnabled = true;
            this.CB_Identifiers.Items.AddRange(new object[] {
            "",
            "CONST",
            "EXPLICIT",
            "EXTERN",
            "INLINE",
            "MUTABLE",
            "STATIC",
            "VOLATILE"});
            this.CB_Identifiers.Location = new System.Drawing.Point(17, 140);
            this.CB_Identifiers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CB_Identifiers.Name = "CB_Identifiers";
            this.CB_Identifiers.Size = new System.Drawing.Size(107, 21);
            this.CB_Identifiers.TabIndex = 9;
            // 
            // TXT_MemberName
            // 
            this.TXT_MemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_MemberName.Location = new System.Drawing.Point(17, 103);
            this.TXT_MemberName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXT_MemberName.Name = "TXT_MemberName";
            this.TXT_MemberName.Size = new System.Drawing.Size(107, 19);
            this.TXT_MemberName.TabIndex = 2;
            this.TXT_MemberName.Text = "Name...";
            // 
            // CheckBox_FunctionOpt
            // 
            this.CheckBox_FunctionOpt.AutoSize = true;
            this.CheckBox_FunctionOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_FunctionOpt.Location = new System.Drawing.Point(17, 181);
            this.CheckBox_FunctionOpt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckBox_FunctionOpt.Name = "CheckBox_FunctionOpt";
            this.CheckBox_FunctionOpt.Size = new System.Drawing.Size(87, 17);
            this.CheckBox_FunctionOpt.TabIndex = 1;
            this.CheckBox_FunctionOpt.Text = "Is a Function";
            this.CheckBox_FunctionOpt.UseVisualStyleBackColor = true;
            this.CheckBox_FunctionOpt.CheckedChanged += new System.EventHandler(this.CB_FunctionOpt_CheckedChanged);
            // 
            // TXT_Type
            // 
            this.TXT_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Type.Location = new System.Drawing.Point(17, 66);
            this.TXT_Type.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXT_Type.Name = "TXT_Type";
            this.TXT_Type.Size = new System.Drawing.Size(107, 19);
            this.TXT_Type.TabIndex = 0;
            this.TXT_Type.Text = "Type...";
            // 
            // GB_FuncOptions
            // 
            this.GB_FuncOptions.Controls.Add(this.BTN_RemoveParam);
            this.GB_FuncOptions.Controls.Add(this.LV_Params);
            this.GB_FuncOptions.Controls.Add(this.BTN_AddParam);
            this.GB_FuncOptions.Enabled = false;
            this.GB_FuncOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_FuncOptions.ForeColor = System.Drawing.Color.White;
            this.GB_FuncOptions.Location = new System.Drawing.Point(614, 349);
            this.GB_FuncOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_FuncOptions.Name = "GB_FuncOptions";
            this.GB_FuncOptions.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_FuncOptions.Size = new System.Drawing.Size(245, 213);
            this.GB_FuncOptions.TabIndex = 3;
            this.GB_FuncOptions.TabStop = false;
            this.GB_FuncOptions.Text = "Function Options";
            this.GB_FuncOptions.Visible = false;
            // 
            // BTN_RemoveParam
            // 
            this.BTN_RemoveParam.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_RemoveParam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_RemoveParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RemoveParam.ForeColor = System.Drawing.Color.OrangeRed;
            this.BTN_RemoveParam.Location = new System.Drawing.Point(72, 152);
            this.BTN_RemoveParam.Name = "BTN_RemoveParam";
            this.BTN_RemoveParam.Size = new System.Drawing.Size(45, 46);
            this.BTN_RemoveParam.TabIndex = 10;
            this.BTN_RemoveParam.Text = "-";
            this.BTN_RemoveParam.UseVisualStyleBackColor = false;
            this.BTN_RemoveParam.Click += new System.EventHandler(this.BTN_RemoveParam_Click);
            // 
            // LV_Params
            // 
            this.LV_Params.BackColor = System.Drawing.Color.DarkGray;
            this.LV_Params.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_params});
            this.LV_Params.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LV_Params.ForeColor = System.Drawing.Color.MediumBlue;
            this.LV_Params.Location = new System.Drawing.Point(17, 21);
            this.LV_Params.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LV_Params.Name = "LV_Params";
            this.LV_Params.Size = new System.Drawing.Size(213, 120);
            this.LV_Params.TabIndex = 9;
            this.LV_Params.UseCompatibleStateImageBehavior = false;
            this.LV_Params.View = System.Windows.Forms.View.Details;
            // 
            // col_params
            // 
            this.col_params.Text = "Parameters";
            this.col_params.Width = 419;
            // 
            // BTN_AddParam
            // 
            this.BTN_AddParam.BackColor = System.Drawing.Color.Black;
            this.BTN_AddParam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AddParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AddParam.ForeColor = System.Drawing.Color.OrangeRed;
            this.BTN_AddParam.Location = new System.Drawing.Point(17, 152);
            this.BTN_AddParam.Name = "BTN_AddParam";
            this.BTN_AddParam.Size = new System.Drawing.Size(44, 46);
            this.BTN_AddParam.TabIndex = 9;
            this.BTN_AddParam.Text = "+";
            this.BTN_AddParam.UseVisualStyleBackColor = false;
            this.BTN_AddParam.Click += new System.EventHandler(this.BTN_AddParam_Click);
            // 
            // BTN_RemoveMember
            // 
            this.BTN_RemoveMember.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_RemoveMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_RemoveMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RemoveMember.ForeColor = System.Drawing.Color.OrangeRed;
            this.BTN_RemoveMember.Location = new System.Drawing.Point(431, 478);
            this.BTN_RemoveMember.Name = "BTN_RemoveMember";
            this.BTN_RemoveMember.Size = new System.Drawing.Size(45, 46);
            this.BTN_RemoveMember.TabIndex = 12;
            this.BTN_RemoveMember.Text = "-";
            this.BTN_RemoveMember.UseVisualStyleBackColor = false;
            this.BTN_RemoveMember.Click += new System.EventHandler(this.BTN_RemoveMember_Click);
            // 
            // BTN_AddMember
            // 
            this.BTN_AddMember.BackColor = System.Drawing.Color.Black;
            this.BTN_AddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AddMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AddMember.ForeColor = System.Drawing.Color.OrangeRed;
            this.BTN_AddMember.Location = new System.Drawing.Point(376, 478);
            this.BTN_AddMember.Name = "BTN_AddMember";
            this.BTN_AddMember.Size = new System.Drawing.Size(44, 46);
            this.BTN_AddMember.TabIndex = 11;
            this.BTN_AddMember.Text = "+";
            this.BTN_AddMember.UseVisualStyleBackColor = false;
            this.BTN_AddMember.Click += new System.EventHandler(this.BTN_AddMember_Click);
            // 
            // RB_ValueOpt
            // 
            this.RB_ValueOpt.AutoSize = true;
            this.RB_ValueOpt.Checked = true;
            this.RB_ValueOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_ValueOpt.Location = new System.Drawing.Point(17, 214);
            this.RB_ValueOpt.Margin = new System.Windows.Forms.Padding(2);
            this.RB_ValueOpt.Name = "RB_ValueOpt";
            this.RB_ValueOpt.Size = new System.Drawing.Size(52, 17);
            this.RB_ValueOpt.TabIndex = 13;
            this.RB_ValueOpt.TabStop = true;
            this.RB_ValueOpt.Text = "Value";
            this.RB_ValueOpt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1479, 699);
            this.Controls.Add(this.BTN_RemoveMember);
            this.Controls.Add(this.GB_FuncOptions);
            this.Controls.Add(this.BTN_AddMember);
            this.Controls.Add(this.GB_AddMember);
            this.Controls.Add(this.LV_Members);
            this.Controls.Add(this.TXT_SheetName);
            this.Controls.Add(this.BTN_OpenFile);
            this.Controls.Add(this.DGV_SpreadSheet);
            this.Controls.Add(this.BTN_RemoveClass);
            this.Controls.Add(this.BTN_AddClass);
            this.Controls.Add(this.LV_Classes);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SpreadSheet)).EndInit();
            this.GB_AddMember.ResumeLayout(false);
            this.GB_AddMember.PerformLayout();
            this.GB_FuncOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView LV_Classes;
        private System.Windows.Forms.ColumnHeader col_classes;
        private System.Windows.Forms.Button BTN_AddClass;
        private System.Windows.Forms.Button BTN_RemoveClass;
        private System.Windows.Forms.FolderBrowserDialog DLG_FindFile;
        private System.Windows.Forms.DataGridView DGV_SpreadSheet;
        private System.Windows.Forms.Button BTN_OpenFile;
        private System.Windows.Forms.OpenFileDialog DLG_OpenFile;
        private System.Windows.Forms.TextBox TXT_SheetName;
        private System.Windows.Forms.ListView LV_Members;
        private System.Windows.Forms.ColumnHeader col_members;
        private System.Windows.Forms.GroupBox GB_AddMember;
        private System.Windows.Forms.ComboBox CB_Identifiers;
        private System.Windows.Forms.TextBox TXT_MemberName;
        private System.Windows.Forms.CheckBox CheckBox_FunctionOpt;
        private System.Windows.Forms.TextBox TXT_Type;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox GB_FuncOptions;
        private System.Windows.Forms.ComboBox CB_MemberAccess;
        private System.Windows.Forms.RadioButton RB_ReferenceOpt;
        private System.Windows.Forms.RadioButton RB_PointerOpt;
        public  System.Windows.Forms.ListView LV_Params;
        private System.Windows.Forms.ColumnHeader col_params;
        private System.Windows.Forms.Button BTN_RemoveParam;
        private System.Windows.Forms.Button BTN_AddParam;
        private System.Windows.Forms.Button BTN_RemoveMember;
        private System.Windows.Forms.Button BTN_AddMember;
        private System.Windows.Forms.RadioButton RB_ValueOpt;
    }
}

