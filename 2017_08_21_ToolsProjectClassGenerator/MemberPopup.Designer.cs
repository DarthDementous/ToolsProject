﻿namespace _2017_08_21_ToolsProjectClassGenerator
{
    partial class MemberPopup
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
            this.RB_ValueOpt = new System.Windows.Forms.RadioButton();
            this.RB_ReferenceOpt = new System.Windows.Forms.RadioButton();
            this.RB_PointerOpt = new System.Windows.Forms.RadioButton();
            this.CB_MemberAccess = new System.Windows.Forms.ComboBox();
            this.CB_Identifiers = new System.Windows.Forms.ComboBox();
            this.TXT_MemberName = new System.Windows.Forms.TextBox();
            this.CheckBox_FunctionOpt = new System.Windows.Forms.CheckBox();
            this.TXT_Type = new System.Windows.Forms.TextBox();
            this.LBL_Type = new System.Windows.Forms.Label();
            this.LBL_Name = new System.Windows.Forms.Label();
            this.LBL_Access = new System.Windows.Forms.Label();
            this.LBL_Identifier = new System.Windows.Forms.Label();
            this.GB_FuncOptions = new System.Windows.Forms.GroupBox();
            this.BTN_RemoveParam = new System.Windows.Forms.Button();
            this.LV_Params = new System.Windows.Forms.ListView();
            this.col_params = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTN_AddParam = new System.Windows.Forms.Button();
            this.GB_FuncOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // RB_ValueOpt
            // 
            this.RB_ValueOpt.AutoSize = true;
            this.RB_ValueOpt.Checked = true;
            this.RB_ValueOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_ValueOpt.ForeColor = System.Drawing.SystemColors.Control;
            this.RB_ValueOpt.Location = new System.Drawing.Point(28, 176);
            this.RB_ValueOpt.Margin = new System.Windows.Forms.Padding(2);
            this.RB_ValueOpt.Name = "RB_ValueOpt";
            this.RB_ValueOpt.Size = new System.Drawing.Size(52, 17);
            this.RB_ValueOpt.TabIndex = 21;
            this.RB_ValueOpt.TabStop = true;
            this.RB_ValueOpt.Text = "Value";
            this.RB_ValueOpt.UseVisualStyleBackColor = true;
            // 
            // RB_ReferenceOpt
            // 
            this.RB_ReferenceOpt.AutoSize = true;
            this.RB_ReferenceOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_ReferenceOpt.ForeColor = System.Drawing.SystemColors.Control;
            this.RB_ReferenceOpt.Location = new System.Drawing.Point(184, 176);
            this.RB_ReferenceOpt.Margin = new System.Windows.Forms.Padding(2);
            this.RB_ReferenceOpt.Name = "RB_ReferenceOpt";
            this.RB_ReferenceOpt.Size = new System.Drawing.Size(75, 17);
            this.RB_ReferenceOpt.TabIndex = 20;
            this.RB_ReferenceOpt.Text = "Reference";
            this.RB_ReferenceOpt.UseVisualStyleBackColor = true;
            // 
            // RB_PointerOpt
            // 
            this.RB_PointerOpt.AutoSize = true;
            this.RB_PointerOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_PointerOpt.ForeColor = System.Drawing.SystemColors.Control;
            this.RB_PointerOpt.Location = new System.Drawing.Point(107, 176);
            this.RB_PointerOpt.Margin = new System.Windows.Forms.Padding(2);
            this.RB_PointerOpt.Name = "RB_PointerOpt";
            this.RB_PointerOpt.Size = new System.Drawing.Size(58, 17);
            this.RB_PointerOpt.TabIndex = 19;
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
            this.CB_MemberAccess.Location = new System.Drawing.Point(28, 43);
            this.CB_MemberAccess.Margin = new System.Windows.Forms.Padding(2);
            this.CB_MemberAccess.Name = "CB_MemberAccess";
            this.CB_MemberAccess.Size = new System.Drawing.Size(107, 21);
            this.CB_MemberAccess.TabIndex = 18;
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
            this.CB_Identifiers.Location = new System.Drawing.Point(166, 43);
            this.CB_Identifiers.Margin = new System.Windows.Forms.Padding(2);
            this.CB_Identifiers.Name = "CB_Identifiers";
            this.CB_Identifiers.Size = new System.Drawing.Size(107, 21);
            this.CB_Identifiers.TabIndex = 17;
            // 
            // TXT_MemberName
            // 
            this.TXT_MemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_MemberName.Location = new System.Drawing.Point(166, 102);
            this.TXT_MemberName.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_MemberName.Name = "TXT_MemberName";
            this.TXT_MemberName.Size = new System.Drawing.Size(107, 19);
            this.TXT_MemberName.TabIndex = 16;
            // 
            // CheckBox_FunctionOpt
            // 
            this.CheckBox_FunctionOpt.AutoSize = true;
            this.CheckBox_FunctionOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_FunctionOpt.ForeColor = System.Drawing.SystemColors.Control;
            this.CheckBox_FunctionOpt.Location = new System.Drawing.Point(28, 143);
            this.CheckBox_FunctionOpt.Margin = new System.Windows.Forms.Padding(2);
            this.CheckBox_FunctionOpt.Name = "CheckBox_FunctionOpt";
            this.CheckBox_FunctionOpt.Size = new System.Drawing.Size(87, 17);
            this.CheckBox_FunctionOpt.TabIndex = 15;
            this.CheckBox_FunctionOpt.Text = "Is a Function";
            this.CheckBox_FunctionOpt.UseVisualStyleBackColor = true;
            // 
            // TXT_Type
            // 
            this.TXT_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Type.Location = new System.Drawing.Point(28, 102);
            this.TXT_Type.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_Type.Name = "TXT_Type";
            this.TXT_Type.Size = new System.Drawing.Size(107, 19);
            this.TXT_Type.TabIndex = 14;
            // 
            // LBL_Type
            // 
            this.LBL_Type.AutoSize = true;
            this.LBL_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Type.ForeColor = System.Drawing.Color.White;
            this.LBL_Type.Location = new System.Drawing.Point(25, 87);
            this.LBL_Type.Name = "LBL_Type";
            this.LBL_Type.Size = new System.Drawing.Size(35, 13);
            this.LBL_Type.TabIndex = 22;
            this.LBL_Type.Text = "Type";
            // 
            // LBL_Name
            // 
            this.LBL_Name.AutoSize = true;
            this.LBL_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Name.ForeColor = System.Drawing.Color.White;
            this.LBL_Name.Location = new System.Drawing.Point(163, 87);
            this.LBL_Name.Name = "LBL_Name";
            this.LBL_Name.Size = new System.Drawing.Size(39, 13);
            this.LBL_Name.TabIndex = 23;
            this.LBL_Name.Text = "Name";
            // 
            // LBL_Access
            // 
            this.LBL_Access.AutoSize = true;
            this.LBL_Access.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Access.ForeColor = System.Drawing.Color.White;
            this.LBL_Access.Location = new System.Drawing.Point(25, 28);
            this.LBL_Access.Name = "LBL_Access";
            this.LBL_Access.Size = new System.Drawing.Size(48, 13);
            this.LBL_Access.TabIndex = 24;
            this.LBL_Access.Text = "Access";
            // 
            // LBL_Identifier
            // 
            this.LBL_Identifier.AutoSize = true;
            this.LBL_Identifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Identifier.ForeColor = System.Drawing.Color.White;
            this.LBL_Identifier.Location = new System.Drawing.Point(163, 28);
            this.LBL_Identifier.Name = "LBL_Identifier";
            this.LBL_Identifier.Size = new System.Drawing.Size(52, 13);
            this.LBL_Identifier.TabIndex = 25;
            this.LBL_Identifier.Text = "Modifier";
            // 
            // GB_FuncOptions
            // 
            this.GB_FuncOptions.Controls.Add(this.BTN_RemoveParam);
            this.GB_FuncOptions.Controls.Add(this.LV_Params);
            this.GB_FuncOptions.Controls.Add(this.BTN_AddParam);
            this.GB_FuncOptions.Enabled = false;
            this.GB_FuncOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_FuncOptions.ForeColor = System.Drawing.Color.White;
            this.GB_FuncOptions.Location = new System.Drawing.Point(28, 224);
            this.GB_FuncOptions.Margin = new System.Windows.Forms.Padding(2);
            this.GB_FuncOptions.Name = "GB_FuncOptions";
            this.GB_FuncOptions.Padding = new System.Windows.Forms.Padding(2);
            this.GB_FuncOptions.Size = new System.Drawing.Size(245, 213);
            this.GB_FuncOptions.TabIndex = 26;
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
            // 
            // LV_Params
            // 
            this.LV_Params.BackColor = System.Drawing.Color.DarkGray;
            this.LV_Params.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_params});
            this.LV_Params.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LV_Params.ForeColor = System.Drawing.Color.MediumBlue;
            this.LV_Params.Location = new System.Drawing.Point(17, 21);
            this.LV_Params.Margin = new System.Windows.Forms.Padding(2);
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
            // 
            // MemberPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(304, 462);
            this.Controls.Add(this.GB_FuncOptions);
            this.Controls.Add(this.LBL_Identifier);
            this.Controls.Add(this.LBL_Access);
            this.Controls.Add(this.LBL_Name);
            this.Controls.Add(this.LBL_Type);
            this.Controls.Add(this.RB_ValueOpt);
            this.Controls.Add(this.RB_ReferenceOpt);
            this.Controls.Add(this.RB_PointerOpt);
            this.Controls.Add(this.CB_MemberAccess);
            this.Controls.Add(this.CB_Identifiers);
            this.Controls.Add(this.TXT_MemberName);
            this.Controls.Add(this.CheckBox_FunctionOpt);
            this.Controls.Add(this.TXT_Type);
            this.Name = "MemberPopup";
            this.Text = "MemberPopup";
            this.GB_FuncOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RB_ValueOpt;
        private System.Windows.Forms.RadioButton RB_ReferenceOpt;
        private System.Windows.Forms.RadioButton RB_PointerOpt;
        private System.Windows.Forms.ComboBox CB_MemberAccess;
        private System.Windows.Forms.ComboBox CB_Identifiers;
        private System.Windows.Forms.TextBox TXT_MemberName;
        private System.Windows.Forms.CheckBox CheckBox_FunctionOpt;
        private System.Windows.Forms.TextBox TXT_Type;
        private System.Windows.Forms.Label LBL_Type;
        private System.Windows.Forms.Label LBL_Name;
        private System.Windows.Forms.Label LBL_Access;
        private System.Windows.Forms.Label LBL_Identifier;
        private System.Windows.Forms.GroupBox GB_FuncOptions;
        private System.Windows.Forms.Button BTN_RemoveParam;
        public System.Windows.Forms.ListView LV_Params;
        private System.Windows.Forms.ColumnHeader col_params;
        private System.Windows.Forms.Button BTN_AddParam;
    }
}