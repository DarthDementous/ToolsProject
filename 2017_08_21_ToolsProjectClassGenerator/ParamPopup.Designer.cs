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
            this.BTN_ClassConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXT_ParamName
            // 
            this.TXT_ParamName.BackColor = System.Drawing.Color.DarkGray;
            this.TXT_ParamName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_ParamName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TXT_ParamName.Location = new System.Drawing.Point(63, 145);
            this.TXT_ParamName.Margin = new System.Windows.Forms.Padding(6);
            this.TXT_ParamName.Name = "TXT_ParamName";
            this.TXT_ParamName.Size = new System.Drawing.Size(442, 31);
            this.TXT_ParamName.TabIndex = 1;
            this.TXT_ParamName.Text = "Parameter Name...";
            // 
            // TXT_ParamType
            // 
            this.TXT_ParamType.BackColor = System.Drawing.Color.DarkGray;
            this.TXT_ParamType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_ParamType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TXT_ParamType.Location = new System.Drawing.Point(63, 61);
            this.TXT_ParamType.Margin = new System.Windows.Forms.Padding(6);
            this.TXT_ParamType.Name = "TXT_ParamType";
            this.TXT_ParamType.Size = new System.Drawing.Size(442, 31);
            this.TXT_ParamType.TabIndex = 2;
            this.TXT_ParamType.Text = "Type...";
            // 
            // RB_ReferenceOpt
            // 
            this.RB_ReferenceOpt.AutoSize = true;
            this.RB_ReferenceOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_ReferenceOpt.ForeColor = System.Drawing.Color.White;
            this.RB_ReferenceOpt.Location = new System.Drawing.Point(363, 305);
            this.RB_ReferenceOpt.Name = "RB_ReferenceOpt";
            this.RB_ReferenceOpt.Size = new System.Drawing.Size(142, 29);
            this.RB_ReferenceOpt.TabIndex = 14;
            this.RB_ReferenceOpt.TabStop = true;
            this.RB_ReferenceOpt.Text = "Reference";
            this.RB_ReferenceOpt.UseVisualStyleBackColor = true;
            // 
            // RB_PointerOpt
            // 
            this.RB_PointerOpt.AutoSize = true;
            this.RB_PointerOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_PointerOpt.ForeColor = System.Drawing.Color.White;
            this.RB_PointerOpt.Location = new System.Drawing.Point(62, 305);
            this.RB_PointerOpt.Name = "RB_PointerOpt";
            this.RB_PointerOpt.Size = new System.Drawing.Size(111, 29);
            this.RB_PointerOpt.TabIndex = 13;
            this.RB_PointerOpt.TabStop = true;
            this.RB_PointerOpt.Text = "Pointer";
            this.RB_PointerOpt.UseVisualStyleBackColor = true;
            // 
            // CB_ConstOpt
            // 
            this.CB_ConstOpt.AutoSize = true;
            this.CB_ConstOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_ConstOpt.ForeColor = System.Drawing.Color.White;
            this.CB_ConstOpt.Location = new System.Drawing.Point(63, 232);
            this.CB_ConstOpt.Name = "CB_ConstOpt";
            this.CB_ConstOpt.Size = new System.Drawing.Size(122, 29);
            this.CB_ConstOpt.TabIndex = 15;
            this.CB_ConstOpt.Text = "Is Const";
            this.CB_ConstOpt.UseVisualStyleBackColor = true;
            // 
            // BTN_ClassConfirm
            // 
            this.BTN_ClassConfirm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_ClassConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ClassConfirm.ForeColor = System.Drawing.Color.OrangeRed;
            this.BTN_ClassConfirm.Location = new System.Drawing.Point(159, 374);
            this.BTN_ClassConfirm.Margin = new System.Windows.Forms.Padding(6);
            this.BTN_ClassConfirm.Name = "BTN_ClassConfirm";
            this.BTN_ClassConfirm.Size = new System.Drawing.Size(238, 85);
            this.BTN_ClassConfirm.TabIndex = 16;
            this.BTN_ClassConfirm.Text = "Generate Parameter";
            this.BTN_ClassConfirm.UseVisualStyleBackColor = false;
            // 
            // ParamPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(568, 504);
            this.Controls.Add(this.BTN_ClassConfirm);
            this.Controls.Add(this.CB_ConstOpt);
            this.Controls.Add(this.RB_ReferenceOpt);
            this.Controls.Add(this.RB_PointerOpt);
            this.Controls.Add(this.TXT_ParamType);
            this.Controls.Add(this.TXT_ParamName);
            this.Name = "ParamPopup";
            this.Text = "ParamPopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_ParamName;
        private System.Windows.Forms.TextBox TXT_ParamType;
        private System.Windows.Forms.RadioButton RB_ReferenceOpt;
        private System.Windows.Forms.RadioButton RB_PointerOpt;
        private System.Windows.Forms.CheckBox CB_ConstOpt;
        private System.Windows.Forms.Button BTN_ClassConfirm;
    }
}