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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BTN_RemoveMember = new System.Windows.Forms.Button();
            this.BTN_AddMember = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SpreadSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // LV_Classes
            // 
            this.LV_Classes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LV_Classes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_classes});
            this.LV_Classes.ForeColor = System.Drawing.Color.OrangeRed;
            this.LV_Classes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LV_Classes.Location = new System.Drawing.Point(65, 52);
            this.LV_Classes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LV_Classes.Name = "LV_Classes";
            this.LV_Classes.Size = new System.Drawing.Size(372, 671);
            this.LV_Classes.TabIndex = 0;
            this.LV_Classes.UseCompatibleStateImageBehavior = false;
            this.LV_Classes.View = System.Windows.Forms.View.Details;
            this.LV_Classes.DoubleClick += new System.EventHandler(this.LV_Classes_DoubleClick);
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
            this.BTN_AddClass.Location = new System.Drawing.Point(65, 737);
            this.BTN_AddClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_AddClass.Name = "BTN_AddClass";
            this.BTN_AddClass.Size = new System.Drawing.Size(59, 57);
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
            this.BTN_RemoveClass.Location = new System.Drawing.Point(139, 737);
            this.BTN_RemoveClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_RemoveClass.Name = "BTN_RemoveClass";
            this.BTN_RemoveClass.Size = new System.Drawing.Size(60, 57);
            this.BTN_RemoveClass.TabIndex = 2;
            this.BTN_RemoveClass.Text = "-";
            this.BTN_RemoveClass.UseVisualStyleBackColor = false;
            this.BTN_RemoveClass.Click += new System.EventHandler(this.BTN_RemoveClass_Click);
            // 
            // DGV_SpreadSheet
            // 
            this.DGV_SpreadSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SpreadSheet.Location = new System.Drawing.Point(1372, 94);
            this.DGV_SpreadSheet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_SpreadSheet.Name = "DGV_SpreadSheet";
            this.DGV_SpreadSheet.Size = new System.Drawing.Size(548, 636);
            this.DGV_SpreadSheet.TabIndex = 4;
            // 
            // BTN_OpenFile
            // 
            this.BTN_OpenFile.Location = new System.Drawing.Point(1372, 738);
            this.BTN_OpenFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_OpenFile.Name = "BTN_OpenFile";
            this.BTN_OpenFile.Size = new System.Drawing.Size(100, 28);
            this.BTN_OpenFile.TabIndex = 5;
            this.BTN_OpenFile.Text = "Open File";
            this.BTN_OpenFile.UseVisualStyleBackColor = true;
            this.BTN_OpenFile.Click += new System.EventHandler(this.BTN_OpenFile_Click);
            // 
            // TXT_SheetName
            // 
            this.TXT_SheetName.Location = new System.Drawing.Point(1503, 740);
            this.TXT_SheetName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_SheetName.Name = "TXT_SheetName";
            this.TXT_SheetName.Size = new System.Drawing.Size(132, 22);
            this.TXT_SheetName.TabIndex = 6;
            this.TXT_SheetName.Text = "Sheet Name...";
            // 
            // LV_Members
            // 
            this.LV_Members.BackColor = System.Drawing.Color.DarkGray;
            this.LV_Members.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_members});
            this.LV_Members.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LV_Members.Location = new System.Drawing.Point(501, 75);
            this.LV_Members.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LV_Members.Name = "LV_Members";
            this.LV_Members.Size = new System.Drawing.Size(247, 498);
            this.LV_Members.TabIndex = 7;
            this.LV_Members.UseCompatibleStateImageBehavior = false;
            this.LV_Members.View = System.Windows.Forms.View.Details;
            // 
            // col_members
            // 
            this.col_members.Text = "Members";
            this.col_members.Width = 369;
            // 
            // BTN_RemoveMember
            // 
            this.BTN_RemoveMember.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_RemoveMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_RemoveMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RemoveMember.ForeColor = System.Drawing.Color.OrangeRed;
            this.BTN_RemoveMember.Location = new System.Drawing.Point(575, 588);
            this.BTN_RemoveMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_RemoveMember.Name = "BTN_RemoveMember";
            this.BTN_RemoveMember.Size = new System.Drawing.Size(60, 57);
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
            this.BTN_AddMember.Location = new System.Drawing.Point(501, 588);
            this.BTN_AddMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_AddMember.Name = "BTN_AddMember";
            this.BTN_AddMember.Size = new System.Drawing.Size(59, 57);
            this.BTN_AddMember.TabIndex = 11;
            this.BTN_AddMember.Text = "+";
            this.BTN_AddMember.UseVisualStyleBackColor = false;
            this.BTN_AddMember.Click += new System.EventHandler(this.BTN_AddMember_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1924, 860);
            this.Controls.Add(this.BTN_RemoveMember);
            this.Controls.Add(this.BTN_AddMember);
            this.Controls.Add(this.LV_Members);
            this.Controls.Add(this.TXT_SheetName);
            this.Controls.Add(this.BTN_OpenFile);
            this.Controls.Add(this.DGV_SpreadSheet);
            this.Controls.Add(this.BTN_RemoveClass);
            this.Controls.Add(this.BTN_AddClass);
            this.Controls.Add(this.LV_Classes);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SpreadSheet)).EndInit();
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
        public  System.Windows.Forms.ListView LV_Members;
        private System.Windows.Forms.ColumnHeader col_members;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BTN_RemoveMember;
        private System.Windows.Forms.Button BTN_AddMember;
    }
}

