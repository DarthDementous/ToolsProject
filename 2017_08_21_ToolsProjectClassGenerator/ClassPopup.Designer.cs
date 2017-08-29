﻿namespace _2017_08_21_ToolsProjectClassGenerator
{
    partial class ClassPopup
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
            this.TXT_Class = new System.Windows.Forms.TextBox();
            this.BTN_ClassConfirm = new System.Windows.Forms.Button();
            this.CB_VirtualOpt = new System.Windows.Forms.CheckBox();
            this.CB_InheritOpt = new System.Windows.Forms.CheckBox();
            this.TXT_BaseClass = new System.Windows.Forms.TextBox();
            this.CB_Access = new System.Windows.Forms.ComboBox();
            this.LBL_ClassName = new System.Windows.Forms.Label();
            this.GB_InheritOptions = new System.Windows.Forms.GroupBox();
            this.GB_InheritOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXT_Class
            // 
            this.TXT_Class.BackColor = System.Drawing.Color.DarkGray;
            this.TXT_Class.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Class.ForeColor = System.Drawing.Color.Black;
            this.TXT_Class.Location = new System.Drawing.Point(28, 50);
            this.TXT_Class.Name = "TXT_Class";
            this.TXT_Class.Size = new System.Drawing.Size(222, 20);
            this.TXT_Class.TabIndex = 0;
            // 
            // BTN_ClassConfirm
            // 
            this.BTN_ClassConfirm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_ClassConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ClassConfirm.ForeColor = System.Drawing.Color.OrangeRed;
            this.BTN_ClassConfirm.Location = new System.Drawing.Point(83, 203);
            this.BTN_ClassConfirm.Name = "BTN_ClassConfirm";
            this.BTN_ClassConfirm.Size = new System.Drawing.Size(119, 44);
            this.BTN_ClassConfirm.TabIndex = 1;
            this.BTN_ClassConfirm.Text = "Generate Class";
            this.BTN_ClassConfirm.UseVisualStyleBackColor = false;
            this.BTN_ClassConfirm.Click += new System.EventHandler(this.BTN_ClassConfirm_Click);
            // 
            // CB_VirtualOpt
            // 
            this.CB_VirtualOpt.AutoSize = true;
            this.CB_VirtualOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_VirtualOpt.ForeColor = System.Drawing.Color.White;
            this.CB_VirtualOpt.Location = new System.Drawing.Point(28, 86);
            this.CB_VirtualOpt.Name = "CB_VirtualOpt";
            this.CB_VirtualOpt.Size = new System.Drawing.Size(107, 17);
            this.CB_VirtualOpt.TabIndex = 2;
            this.CB_VirtualOpt.Text = "Virtual Destructor";
            this.CB_VirtualOpt.UseVisualStyleBackColor = true;
            this.CB_VirtualOpt.CheckedChanged += new System.EventHandler(this.CB_VirtualOpt_CheckedChanged);
            // 
            // CB_InheritOpt
            // 
            this.CB_InheritOpt.AutoSize = true;
            this.CB_InheritOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_InheritOpt.ForeColor = System.Drawing.Color.White;
            this.CB_InheritOpt.Location = new System.Drawing.Point(28, 109);
            this.CB_InheritOpt.Name = "CB_InheritOpt";
            this.CB_InheritOpt.Size = new System.Drawing.Size(109, 17);
            this.CB_InheritOpt.TabIndex = 3;
            this.CB_InheritOpt.Text = "Inherit From Class";
            this.CB_InheritOpt.UseVisualStyleBackColor = true;
            this.CB_InheritOpt.CheckedChanged += new System.EventHandler(this.CB_InheritOpt_CheckedChanged);
            // 
            // TXT_BaseClass
            // 
            this.TXT_BaseClass.BackColor = System.Drawing.Color.DarkGray;
            this.TXT_BaseClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_BaseClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_BaseClass.ForeColor = System.Drawing.Color.Black;
            this.TXT_BaseClass.Location = new System.Drawing.Point(131, 18);
            this.TXT_BaseClass.Name = "TXT_BaseClass";
            this.TXT_BaseClass.Size = new System.Drawing.Size(107, 20);
            this.TXT_BaseClass.TabIndex = 4;
            // 
            // CB_Access
            // 
            this.CB_Access.BackColor = System.Drawing.Color.White;
            this.CB_Access.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Access.FormattingEnabled = true;
            this.CB_Access.Items.AddRange(new object[] {
            "PUBLIC",
            "PROTECTED",
            "PRIVATE"});
            this.CB_Access.Location = new System.Drawing.Point(16, 18);
            this.CB_Access.Name = "CB_Access";
            this.CB_Access.Size = new System.Drawing.Size(107, 21);
            this.CB_Access.TabIndex = 5;
            // 
            // LBL_ClassName
            // 
            this.LBL_ClassName.AutoSize = true;
            this.LBL_ClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ClassName.ForeColor = System.Drawing.Color.White;
            this.LBL_ClassName.Location = new System.Drawing.Point(25, 34);
            this.LBL_ClassName.Name = "LBL_ClassName";
            this.LBL_ClassName.Size = new System.Drawing.Size(73, 13);
            this.LBL_ClassName.TabIndex = 6;
            this.LBL_ClassName.Text = "Class Name";
            // 
            // GB_InheritOptions
            // 
            this.GB_InheritOptions.Controls.Add(this.CB_Access);
            this.GB_InheritOptions.Controls.Add(this.TXT_BaseClass);
            this.GB_InheritOptions.Enabled = false;
            this.GB_InheritOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_InheritOptions.ForeColor = System.Drawing.Color.White;
            this.GB_InheritOptions.Location = new System.Drawing.Point(14, 135);
            this.GB_InheritOptions.Name = "GB_InheritOptions";
            this.GB_InheritOptions.Size = new System.Drawing.Size(253, 50);
            this.GB_InheritOptions.TabIndex = 7;
            this.GB_InheritOptions.TabStop = false;
            this.GB_InheritOptions.Text = "Base Class Options";
            this.GB_InheritOptions.Visible = false;
            // 
            // ClassPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.LBL_ClassName);
            this.Controls.Add(this.CB_InheritOpt);
            this.Controls.Add(this.CB_VirtualOpt);
            this.Controls.Add(this.BTN_ClassConfirm);
            this.Controls.Add(this.TXT_Class);
            this.Controls.Add(this.GB_InheritOptions);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Name = "ClassPopup";
            this.Text = "class_popup";
            this.TopMost = true;
            this.GB_InheritOptions.ResumeLayout(false);
            this.GB_InheritOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_Class;
        private System.Windows.Forms.Button BTN_ClassConfirm;
        private System.Windows.Forms.CheckBox CB_VirtualOpt;
        private System.Windows.Forms.CheckBox CB_InheritOpt;
        private System.Windows.Forms.TextBox TXT_BaseClass;
        private System.Windows.Forms.ComboBox CB_Access;
        private System.Windows.Forms.Label LBL_ClassName;
        private System.Windows.Forms.GroupBox GB_InheritOptions;
    }
}