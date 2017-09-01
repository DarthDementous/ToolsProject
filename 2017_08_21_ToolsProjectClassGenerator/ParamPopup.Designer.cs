namespace _2017_08_21_ToolsProjectClassGenerator
{
    partial class ParamPopup
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
            this.TXT_ParamName = new System.Windows.Forms.TextBox();
            this.TXT_ParamType = new System.Windows.Forms.TextBox();
            this.RB_ReferenceOpt = new System.Windows.Forms.RadioButton();
            this.RB_PointerOpt = new System.Windows.Forms.RadioButton();
            this.CB_ConstOpt = new System.Windows.Forms.CheckBox();
            this.BTN_ParamConfirm = new System.Windows.Forms.Button();
            this.RB_ValOpt = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // TXT_ParamName
            // 
            this.TXT_ParamName.BackColor = System.Drawing.Color.DarkGray;
            this.TXT_ParamName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_ParamName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TXT_ParamName.Location = new System.Drawing.Point(42, 93);
            this.TXT_ParamName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_ParamName.Name = "TXT_ParamName";
            this.TXT_ParamName.Size = new System.Drawing.Size(295, 22);
            this.TXT_ParamName.TabIndex = 1;
            this.TXT_ParamName.Text = "Parameter Name...";
            // 
            // TXT_ParamType
            // 
            this.TXT_ParamType.BackColor = System.Drawing.Color.DarkGray;
            this.TXT_ParamType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_ParamType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TXT_ParamType.Location = new System.Drawing.Point(42, 39);
            this.TXT_ParamType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_ParamType.Name = "TXT_ParamType";
            this.TXT_ParamType.Size = new System.Drawing.Size(295, 22);
            this.TXT_ParamType.TabIndex = 2;
            this.TXT_ParamType.Text = "Type...";
            // 
            // RB_ReferenceOpt
            // 
            this.RB_ReferenceOpt.AutoSize = true;
            this.RB_ReferenceOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_ReferenceOpt.ForeColor = System.Drawing.Color.White;
            this.RB_ReferenceOpt.Location = new System.Drawing.Point(242, 195);
            this.RB_ReferenceOpt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RB_ReferenceOpt.Name = "RB_ReferenceOpt";
            this.RB_ReferenceOpt.Size = new System.Drawing.Size(95, 21);
            this.RB_ReferenceOpt.TabIndex = 14;
            this.RB_ReferenceOpt.TabStop = true;
            this.RB_ReferenceOpt.Text = "Reference";
            this.RB_ReferenceOpt.UseVisualStyleBackColor = true;
            this.RB_ReferenceOpt.CheckedChanged += new System.EventHandler(this.RB_ReferenceOpt_CheckedChanged);
            // 
            // RB_PointerOpt
            // 
            this.RB_PointerOpt.AutoSize = true;
            this.RB_PointerOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_PointerOpt.ForeColor = System.Drawing.Color.White;
            this.RB_PointerOpt.Location = new System.Drawing.Point(141, 195);
            this.RB_PointerOpt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RB_PointerOpt.Name = "RB_PointerOpt";
            this.RB_PointerOpt.Size = new System.Drawing.Size(74, 21);
            this.RB_PointerOpt.TabIndex = 13;
            this.RB_PointerOpt.TabStop = true;
            this.RB_PointerOpt.Text = "Pointer";
            this.RB_PointerOpt.UseVisualStyleBackColor = true;
            this.RB_PointerOpt.CheckedChanged += new System.EventHandler(this.RB_PointerOpt_CheckedChanged);
            // 
            // CB_ConstOpt
            // 
            this.CB_ConstOpt.AutoSize = true;
            this.CB_ConstOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_ConstOpt.ForeColor = System.Drawing.Color.White;
            this.CB_ConstOpt.Location = new System.Drawing.Point(42, 148);
            this.CB_ConstOpt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CB_ConstOpt.Name = "CB_ConstOpt";
            this.CB_ConstOpt.Size = new System.Drawing.Size(80, 21);
            this.CB_ConstOpt.TabIndex = 15;
            this.CB_ConstOpt.Text = "Is Const";
            this.CB_ConstOpt.UseVisualStyleBackColor = true;
            this.CB_ConstOpt.CheckedChanged += new System.EventHandler(this.CB_ConstOpt_CheckedChanged);
            // 
            // BTN_ParamConfirm
            // 
            this.BTN_ParamConfirm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_ParamConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ParamConfirm.ForeColor = System.Drawing.Color.OrangeRed;
            this.BTN_ParamConfirm.Location = new System.Drawing.Point(106, 239);
            this.BTN_ParamConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_ParamConfirm.Name = "BTN_ParamConfirm";
            this.BTN_ParamConfirm.Size = new System.Drawing.Size(159, 54);
            this.BTN_ParamConfirm.TabIndex = 16;
            this.BTN_ParamConfirm.Text = "Generate Parameter";
            this.BTN_ParamConfirm.UseVisualStyleBackColor = false;
            this.BTN_ParamConfirm.Click += new System.EventHandler(this.BTN_ClassConfirm_Click);
            // 
            // RB_ValOpt
            // 
            this.RB_ValOpt.AutoSize = true;
            this.RB_ValOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_ValOpt.ForeColor = System.Drawing.Color.White;
            this.RB_ValOpt.Location = new System.Drawing.Point(42, 195);
            this.RB_ValOpt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RB_ValOpt.Name = "RB_ValOpt";
            this.RB_ValOpt.Size = new System.Drawing.Size(65, 21);
            this.RB_ValOpt.TabIndex = 17;
            this.RB_ValOpt.TabStop = true;
            this.RB_ValOpt.Text = "Value";
            this.RB_ValOpt.UseVisualStyleBackColor = true;
            this.RB_ValOpt.CheckedChanged += new System.EventHandler(this.RB_ValOpt_CheckedChanged);
            // 
            // ParamPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(379, 323);
            this.Controls.Add(this.RB_ValOpt);
            this.Controls.Add(this.BTN_ParamConfirm);
            this.Controls.Add(this.CB_ConstOpt);
            this.Controls.Add(this.RB_ReferenceOpt);
            this.Controls.Add(this.RB_PointerOpt);
            this.Controls.Add(this.TXT_ParamType);
            this.Controls.Add(this.TXT_ParamName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ParamPopup";
            this.Text = "ParamPopup";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_ParamName;
        private System.Windows.Forms.TextBox TXT_ParamType;
        private System.Windows.Forms.RadioButton RB_ReferenceOpt;
        private System.Windows.Forms.RadioButton RB_PointerOpt;
        private System.Windows.Forms.CheckBox CB_ConstOpt;
        private System.Windows.Forms.Button BTN_ParamConfirm;
        private System.Windows.Forms.RadioButton RB_ValOpt;
    }
}