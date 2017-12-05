namespace ClientWinForms
{
    partial class Settings
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
            this.URLtextBox = new System.Windows.Forms.TextBox();
            this.SaveURLbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // URLtextBox
            // 
            this.URLtextBox.Location = new System.Drawing.Point(12, 26);
            this.URLtextBox.Name = "URLtextBox";
            this.URLtextBox.Size = new System.Drawing.Size(343, 20);
            this.URLtextBox.TabIndex = 0;
            // 
            // SaveURLbutton
            // 
            this.SaveURLbutton.Location = new System.Drawing.Point(12, 51);
            this.SaveURLbutton.Name = "SaveURLbutton";
            this.SaveURLbutton.Size = new System.Drawing.Size(227, 23);
            this.SaveURLbutton.TabIndex = 1;
            this.SaveURLbutton.Text = "Validate and save";
            this.SaveURLbutton.UseVisualStyleBackColor = true;
            this.SaveURLbutton.Click += new System.EventHandler(this.SaveURLbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL to server";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 82);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveURLbutton);
            this.Controls.Add(this.URLtextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 121);
            this.MinimumSize = new System.Drawing.Size(380, 121);
            this.Name = "Settings";
            this.Text = "Settings";
            this.VisibleChanged += new System.EventHandler(this.Settings_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URLtextBox;
        private System.Windows.Forms.Button SaveURLbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}