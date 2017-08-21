namespace _2017_08_21_ToolsProjectClassGenerator
{
    partial class class_popup
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BTN_ClassConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(28, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Class Name...";
            // 
            // BTN_ClassConfirm
            // 
            this.BTN_ClassConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_ClassConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ClassConfirm.ForeColor = System.Drawing.Color.OrangeRed;
            this.BTN_ClassConfirm.Location = new System.Drawing.Point(83, 206);
            this.BTN_ClassConfirm.Name = "BTN_ClassConfirm";
            this.BTN_ClassConfirm.Size = new System.Drawing.Size(119, 44);
            this.BTN_ClassConfirm.TabIndex = 1;
            this.BTN_ClassConfirm.Text = "button1";
            this.BTN_ClassConfirm.UseVisualStyleBackColor = false;
            // 
            // class_popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.BTN_ClassConfirm);
            this.Controls.Add(this.textBox1);
            this.Name = "class_popup";
            this.Text = "class_popup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BTN_ClassConfirm;
    }
}