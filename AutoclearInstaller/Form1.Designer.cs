namespace AutoclearInstaller
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
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.agreeButton = new System.Windows.Forms.Button();
            this.documentsCheck = new System.Windows.Forms.CheckBox();
            this.downloadsCheck = new System.Windows.Forms.CheckBox();
            this.picturesCheck = new System.Windows.Forms.CheckBox();
            this.recycleBin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // outputBox
            // 
            this.outputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputBox.Location = new System.Drawing.Point(0, 0);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(430, 600);
            this.outputBox.TabIndex = 0;
            this.outputBox.Text = "";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 606);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 35);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // agreeButton
            // 
            this.agreeButton.Location = new System.Drawing.Point(445, 606);
            this.agreeButton.Name = "agreeButton";
            this.agreeButton.Size = new System.Drawing.Size(75, 35);
            this.agreeButton.TabIndex = 2;
            this.agreeButton.Text = "Agree";
            this.agreeButton.UseVisualStyleBackColor = true;
            this.agreeButton.Click += new System.EventHandler(this.agreeButton_Click);
            // 
            // documentsCheck
            // 
            this.documentsCheck.AutoSize = true;
            this.documentsCheck.Location = new System.Drawing.Point(445, 13);
            this.documentsCheck.Name = "documentsCheck";
            this.documentsCheck.Size = new System.Drawing.Size(143, 21);
            this.documentsCheck.TabIndex = 3;
            this.documentsCheck.Text = "TEMP Documents";
            this.documentsCheck.UseVisualStyleBackColor = true;
            // 
            // downloadsCheck
            // 
            this.downloadsCheck.AutoSize = true;
            this.downloadsCheck.Location = new System.Drawing.Point(445, 41);
            this.downloadsCheck.Name = "downloadsCheck";
            this.downloadsCheck.Size = new System.Drawing.Size(141, 21);
            this.downloadsCheck.TabIndex = 4;
            this.downloadsCheck.Text = "TEMP Downloads";
            this.downloadsCheck.UseVisualStyleBackColor = true;
            // 
            // picturesCheck
            // 
            this.picturesCheck.AutoSize = true;
            this.picturesCheck.Location = new System.Drawing.Point(445, 69);
            this.picturesCheck.Name = "picturesCheck";
            this.picturesCheck.Size = new System.Drawing.Size(123, 21);
            this.picturesCheck.TabIndex = 5;
            this.picturesCheck.Text = "TEMP Pictures";
            this.picturesCheck.UseVisualStyleBackColor = true;
            // 
            // recycleBin
            // 
            this.recycleBin.AutoSize = true;
            this.recycleBin.Location = new System.Drawing.Point(445, 97);
            this.recycleBin.Name = "recycleBin";
            this.recycleBin.Size = new System.Drawing.Size(147, 21);
            this.recycleBin.TabIndex = 6;
            this.recycleBin.Text = "Empty Recycle Bin";
            this.recycleBin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 653);
            this.Controls.Add(this.recycleBin);
            this.Controls.Add(this.picturesCheck);
            this.Controls.Add(this.downloadsCheck);
            this.Controls.Add(this.documentsCheck);
            this.Controls.Add(this.agreeButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.outputBox);
            this.Name = "Form1";
            this.Text = "AutoClear v0.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button agreeButton;
        private System.Windows.Forms.CheckBox documentsCheck;
        private System.Windows.Forms.CheckBox downloadsCheck;
        private System.Windows.Forms.CheckBox picturesCheck;
        private System.Windows.Forms.CheckBox recycleBin;
    }
}

