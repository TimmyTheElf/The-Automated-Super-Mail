
namespace The_Automated_Super_Mail
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbTemplates = new System.Windows.Forms.ComboBox();
            this.lblTemplates = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnRecipients = new System.Windows.Forms.Button();
            this.rtbRecipients = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cmbTemplates
            // 
            this.cmbTemplates.FormattingEnabled = true;
            this.cmbTemplates.Location = new System.Drawing.Point(12, 39);
            this.cmbTemplates.Name = "cmbTemplates";
            this.cmbTemplates.Size = new System.Drawing.Size(358, 28);
            this.cmbTemplates.TabIndex = 0;
            // 
            // lblTemplates
            // 
            this.lblTemplates.AutoSize = true;
            this.lblTemplates.Location = new System.Drawing.Point(13, 16);
            this.lblTemplates.Name = "lblTemplates";
            this.lblTemplates.Size = new System.Drawing.Size(115, 20);
            this.lblTemplates.TabIndex = 1;
            this.lblTemplates.Text = "Select Template";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(13, 100);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(357, 27);
            this.txtSubject.TabIndex = 2;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(13, 77);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(58, 20);
            this.lblSubject.TabIndex = 3;
            this.lblSubject.Text = "Subject";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 151);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(486, 401);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // btnRecipients
            // 
            this.btnRecipients.Location = new System.Drawing.Point(496, 120);
            this.btnRecipients.Name = "btnRecipients";
            this.btnRecipients.Size = new System.Drawing.Size(239, 29);
            this.btnRecipients.TabIndex = 5;
            this.btnRecipients.Text = "Open recipients window";
            this.btnRecipients.UseVisualStyleBackColor = true;
            this.btnRecipients.Click += new System.EventHandler(this.btnRecipients_Click);
            // 
            // rtbRecipients
            // 
            this.rtbRecipients.Location = new System.Drawing.Point(496, 16);
            this.rtbRecipients.Name = "rtbRecipients";
            this.rtbRecipients.Size = new System.Drawing.Size(505, 98);
            this.rtbRecipients.TabIndex = 6;
            this.rtbRecipients.Text = "";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1013, 585);
            this.Controls.Add(this.rtbRecipients);
            this.Controls.Add(this.btnRecipients);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblTemplates);
            this.Controls.Add(this.cmbTemplates);
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTemplates;
        private System.Windows.Forms.Label lblTemplates;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnRecipients;
        private System.Windows.Forms.RichTextBox rtbRecipients;
    }
}

