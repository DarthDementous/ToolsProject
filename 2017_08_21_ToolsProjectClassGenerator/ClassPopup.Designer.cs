namespace _2017_08_21_ToolsProjectClassGenerator
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
            this.SuspendLayout();
            // 
            // TXT_Class
            // 
            this.TXT_Class.BackColor = System.Drawing.Color.DarkGray;
            this.TXT_Class.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Class.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TXT_Class.Location = new System.Drawing.Point(56, 96);
            this.TXT_Class.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TXT_Class.Name = "TXT_Class";
            this.TXT_Class.Size = new System.Drawing.Size(442, 31);
            this.TXT_Class.TabIndex = 0;
            this.TXT_Class.Text = "Class Name...";
            // 
            // BTN_ClassConfirm
            // 
            this.BTN_ClassConfirm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_ClassConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ClassConfirm.ForeColor = System.Drawing.Color.OrangeRed;
            this.BTN_ClassConfirm.Location = new System.Drawing.Point(166, 367);
            this.BTN_ClassConfirm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BTN_ClassConfirm.Name = "BTN_ClassConfirm";
            this.BTN_ClassConfirm.Size = new System.Drawing.Size(238, 85);
            this.BTN_ClassConfirm.TabIndex = 1;
            this.BTN_ClassConfirm.Text = "Generate Class";
            this.BTN_ClassConfirm.UseVisualStyleBackColor = false;
            this.BTN_ClassConfirm.Click += new System.EventHandler(this.BTN_ClassConfirm_Click);
            // 
            // CB_VirtualOpt
            // 
            this.CB_VirtualOpt.AutoSize = true;
            this.CB_VirtualOpt.ForeColor = System.Drawing.Color.White;
            this.CB_VirtualOpt.Location = new System.Drawing.Point(56, 165);
            this.CB_VirtualOpt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CB_VirtualOpt.Name = "CB_VirtualOpt";
            this.CB_VirtualOpt.Size = new System.Drawing.Size(210, 29);
            this.CB_VirtualOpt.TabIndex = 2;
            this.CB_VirtualOpt.Text = "Virtual Destructor";
            this.CB_VirtualOpt.UseVisualStyleBackColor = true;
            this.CB_VirtualOpt.CheckedChanged += new System.EventHandler(this.CB_VirtualOpt_CheckedChanged);
            // 
            // CB_InheritOpt
            // 
            this.CB_InheritOpt.AutoSize = true;
            this.CB_InheritOpt.ForeColor = System.Drawing.Color.White;
            this.CB_InheritOpt.Location = new System.Drawing.Point(56, 210);
            this.CB_InheritOpt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CB_InheritOpt.Name = "CB_InheritOpt";
            this.CB_InheritOpt.Size = new System.Drawing.Size(218, 29);
            this.CB_InheritOpt.TabIndex = 3;
            this.CB_InheritOpt.Text = "Inherit From Class";
            this.CB_InheritOpt.UseVisualStyleBackColor = true;
            this.CB_InheritOpt.CheckedChanged += new System.EventHandler(this.CB_InheritOpt_CheckedChanged);
            // 
            // TXT_BaseClass
            // 
            this.TXT_BaseClass.BackColor = System.Drawing.Color.DarkGray;
            this.TXT_BaseClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_BaseClass.Enabled = false;
            this.TXT_BaseClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TXT_BaseClass.Location = new System.Drawing.Point(284, 275);
            this.TXT_BaseClass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TXT_BaseClass.Name = "TXT_BaseClass";
            this.TXT_BaseClass.Size = new System.Drawing.Size(214, 31);
            this.TXT_BaseClass.TabIndex = 4;
            this.TXT_BaseClass.Text = "Base Class Name...";
            // 
            // CB_Access
            // 
            this.CB_Access.BackColor = System.Drawing.Color.White;
            this.CB_Access.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Access.Enabled = false;
            this.CB_Access.FormattingEnabled = true;
            this.CB_Access.Items.AddRange(new object[] {
            "PUBLIC",
            "PROTECTED",
            "PRIVATE"});
            this.CB_Access.Location = new System.Drawing.Point(56, 275);
            this.CB_Access.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CB_Access.Name = "CB_Access";
            this.CB_Access.Size = new System.Drawing.Size(210, 33);
            this.CB_Access.TabIndex = 5;
            // 
            // ClassPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(568, 504);
            this.Controls.Add(this.CB_Access);
            this.Controls.Add(this.TXT_BaseClass);
            this.Controls.Add(this.CB_InheritOpt);
            this.Controls.Add(this.CB_VirtualOpt);
            this.Controls.Add(this.BTN_ClassConfirm);
            this.Controls.Add(this.TXT_Class);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ClassPopup";
            this.Text = "class_popup";
            this.TopMost = true;
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
    }
}