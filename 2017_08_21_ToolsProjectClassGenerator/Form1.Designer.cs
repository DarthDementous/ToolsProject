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
            this.DGV_SpreadSheet.Location = new System.Drawing.Point(376, 42);
            this.DGV_SpreadSheet.Name = "DGV_SpreadSheet";
            this.DGV_SpreadSheet.Size = new System.Drawing.Size(411, 517);
            this.DGV_SpreadSheet.TabIndex = 4;
            // 
            // BTN_OpenFile
            // 
            this.BTN_OpenFile.Location = new System.Drawing.Point(376, 565);
            this.BTN_OpenFile.Name = "BTN_OpenFile";
            this.BTN_OpenFile.Size = new System.Drawing.Size(75, 23);
            this.BTN_OpenFile.TabIndex = 5;
            this.BTN_OpenFile.Text = "Open File";
            this.BTN_OpenFile.UseVisualStyleBackColor = true;
            this.BTN_OpenFile.Click += new System.EventHandler(this.BTN_OpenFile_Click);
            // 
            // TXT_SheetName
            // 
            this.TXT_SheetName.Location = new System.Drawing.Point(474, 567);
            this.TXT_SheetName.Name = "TXT_SheetName";
            this.TXT_SheetName.Size = new System.Drawing.Size(100, 20);
            this.TXT_SheetName.TabIndex = 6;
            this.TXT_SheetName.Text = "Sheet Name...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.TXT_SheetName);
            this.Controls.Add(this.BTN_OpenFile);
            this.Controls.Add(this.DGV_SpreadSheet);
            this.Controls.Add(this.BTN_RemoveClass);
            this.Controls.Add(this.BTN_AddClass);
            this.Controls.Add(this.LV_Classes);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

