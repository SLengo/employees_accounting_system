namespace ClientWinForms
{
    partial class AddActionFrom
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
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.sernametextBox = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.phonetextBox = new System.Windows.Forms.TextBox();
            this.agetextBox = new System.Windows.Forms.TextBox();
            this.SexComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.actionSignlabel = new System.Windows.Forms.Label();
            this.dateOfBirthdaydateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WorkingPanel = new System.Windows.Forms.Panel();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.DateBirthdayCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.WorkingPanel.SuspendLayout();
            this.AddPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 262);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(158, 36);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Accept";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(186, 262);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(155, 36);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(129, 11);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(203, 20);
            this.nametextBox.TabIndex = 2;
            // 
            // sernametextBox
            // 
            this.sernametextBox.Location = new System.Drawing.Point(129, 37);
            this.sernametextBox.Name = "sernametextBox";
            this.sernametextBox.Size = new System.Drawing.Size(203, 20);
            this.sernametextBox.TabIndex = 2;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(129, 63);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(203, 20);
            this.emailtextBox.TabIndex = 2;
            // 
            // phonetextBox
            // 
            this.phonetextBox.Location = new System.Drawing.Point(129, 89);
            this.phonetextBox.Name = "phonetextBox";
            this.phonetextBox.Size = new System.Drawing.Size(203, 20);
            this.phonetextBox.TabIndex = 2;
            // 
            // agetextBox
            // 
            this.agetextBox.Location = new System.Drawing.Point(129, 115);
            this.agetextBox.Name = "agetextBox";
            this.agetextBox.Size = new System.Drawing.Size(203, 20);
            this.agetextBox.TabIndex = 2;
            this.agetextBox.Leave += new System.EventHandler(this.agetextBox_Leave);
            // 
            // SexComboBox
            // 
            this.SexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexComboBox.FormattingEnabled = true;
            this.SexComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.SexComboBox.Location = new System.Drawing.Point(129, 141);
            this.SexComboBox.Name = "SexComboBox";
            this.SexComboBox.Size = new System.Drawing.Size(203, 21);
            this.SexComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sex";
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Location = new System.Drawing.Point(3, 175);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(82, 13);
            this.BirthdayLabel.TabIndex = 4;
            this.BirthdayLabel.Text = "Date of birthday";
            // 
            // actionSignlabel
            // 
            this.actionSignlabel.AutoSize = true;
            this.actionSignlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actionSignlabel.Location = new System.Drawing.Point(12, 9);
            this.actionSignlabel.Name = "actionSignlabel";
            this.actionSignlabel.Size = new System.Drawing.Size(51, 20);
            this.actionSignlabel.TabIndex = 5;
            this.actionSignlabel.Text = "label8";
            // 
            // dateOfBirthdaydateTimePicker
            // 
            this.dateOfBirthdaydateTimePicker.Location = new System.Drawing.Point(129, 168);
            this.dateOfBirthdaydateTimePicker.Name = "dateOfBirthdaydateTimePicker";
            this.dateOfBirthdaydateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.dateOfBirthdaydateTimePicker.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(10, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Working...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClientWinForms.Properties.Resources.ajax_loader;
            this.pictureBox1.InitialImage = global::ClientWinForms.Properties.Resources.ajax_loader;
            this.pictureBox1.Location = new System.Drawing.Point(95, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // WorkingPanel
            // 
            this.WorkingPanel.Controls.Add(this.label8);
            this.WorkingPanel.Controls.Add(this.pictureBox1);
            this.WorkingPanel.Location = new System.Drawing.Point(223, 225);
            this.WorkingPanel.Name = "WorkingPanel";
            this.WorkingPanel.Size = new System.Drawing.Size(118, 33);
            this.WorkingPanel.TabIndex = 9;
            this.WorkingPanel.Visible = false;
            // 
            // AddPanel
            // 
            this.AddPanel.Controls.Add(this.DateBirthdayCheckBox);
            this.AddPanel.Controls.Add(this.label1);
            this.AddPanel.Controls.Add(this.nametextBox);
            this.AddPanel.Controls.Add(this.dateOfBirthdaydateTimePicker);
            this.AddPanel.Controls.Add(this.sernametextBox);
            this.AddPanel.Controls.Add(this.emailtextBox);
            this.AddPanel.Controls.Add(this.BirthdayLabel);
            this.AddPanel.Controls.Add(this.phonetextBox);
            this.AddPanel.Controls.Add(this.label6);
            this.AddPanel.Controls.Add(this.agetextBox);
            this.AddPanel.Controls.Add(this.label5);
            this.AddPanel.Controls.Add(this.SexComboBox);
            this.AddPanel.Controls.Add(this.label4);
            this.AddPanel.Controls.Add(this.label2);
            this.AddPanel.Controls.Add(this.label3);
            this.AddPanel.Location = new System.Drawing.Point(12, 32);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(336, 191);
            this.AddPanel.TabIndex = 10;
            // 
            // DateBirthdayCheckBox
            // 
            this.DateBirthdayCheckBox.AutoSize = true;
            this.DateBirthdayCheckBox.Location = new System.Drawing.Point(108, 174);
            this.DateBirthdayCheckBox.Name = "DateBirthdayCheckBox";
            this.DateBirthdayCheckBox.Size = new System.Drawing.Size(15, 14);
            this.DateBirthdayCheckBox.TabIndex = 7;
            this.DateBirthdayCheckBox.UseVisualStyleBackColor = true;
            this.DateBirthdayCheckBox.Visible = false;
            // 
            // AddActionFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 324);
            this.Controls.Add(this.AddPanel);
            this.Controls.Add(this.WorkingPanel);
            this.Controls.Add(this.actionSignlabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(372, 363);
            this.MinimumSize = new System.Drawing.Size(372, 363);
            this.Name = "AddActionFrom";
            this.Text = "Employee action";
            this.VisibleChanged += new System.EventHandler(this.AddActionFrom_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.WorkingPanel.ResumeLayout(false);
            this.WorkingPanel.PerformLayout();
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox sernametextBox;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.TextBox phonetextBox;
        private System.Windows.Forms.TextBox agetextBox;
        private System.Windows.Forms.ComboBox SexComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.Label actionSignlabel;
        private System.Windows.Forms.DateTimePicker dateOfBirthdaydateTimePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel WorkingPanel;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.CheckBox DateBirthdayCheckBox;
    }
}