namespace Hariharan_4
{
    partial class MainForm
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
            this.schoolLabel = new System.Windows.Forms.Label();
            this.registrationDateLabel = new System.Windows.Forms.Label();
            this.registrationDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.registrationInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.dateOfBirthMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.classInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.pricePerClassLabel = new System.Windows.Forms.Label();
            this.totalClassesLabel = new System.Windows.Forms.Label();
            this.totalPriceLblLabel = new System.Windows.Forms.Label();
            this.pricePerClassLblLabel = new System.Windows.Forms.Label();
            this.totalClassesLblLabel = new System.Windows.Forms.Label();
            this.classesListBox = new System.Windows.Forms.ListBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.animationRadioButton = new System.Windows.Forms.RadioButton();
            this.liveActionRadioButton = new System.Windows.Forms.RadioButton();
            this.classTypeLabel = new System.Windows.Forms.Label();
            this.paymentTypeLabel = new System.Windows.Forms.Label();
            this.infoMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashRadioButton = new System.Windows.Forms.RadioButton();
            this.checkRadioButton = new System.Windows.Forms.RadioButton();
            this.emailCheckbox = new System.Windows.Forms.CheckBox();
            this.schoolPictureBox = new System.Windows.Forms.PictureBox();
            this.registrationInfoGroupBox.SuspendLayout();
            this.classInfoGroupBox.SuspendLayout();
            this.infoMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // schoolLabel
            // 
            this.schoolLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.schoolLabel.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolLabel.Location = new System.Drawing.Point(179, 40);
            this.schoolLabel.Name = "schoolLabel";
            this.schoolLabel.Size = new System.Drawing.Size(239, 108);
            this.schoolLabel.TabIndex = 1;
            this.schoolLabel.Text = "Hopkins Film School";
            this.schoolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registrationDateLabel
            // 
            this.registrationDateLabel.AutoSize = true;
            this.registrationDateLabel.Location = new System.Drawing.Point(81, 171);
            this.registrationDateLabel.Name = "registrationDateLabel";
            this.registrationDateLabel.Size = new System.Drawing.Size(92, 13);
            this.registrationDateLabel.TabIndex = 2;
            this.registrationDateLabel.Text = "Registration Date:";
            // 
            // registrationDateMaskedTextBox
            // 
            this.registrationDateMaskedTextBox.Location = new System.Drawing.Point(179, 168);
            this.registrationDateMaskedTextBox.Mask = "00/00/0000";
            this.registrationDateMaskedTextBox.Name = "registrationDateMaskedTextBox";
            this.registrationDateMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.registrationDateMaskedTextBox.TabIndex = 3;
            this.registrationDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // registrationInfoGroupBox
            // 
            this.registrationInfoGroupBox.Controls.Add(this.statusComboBox);
            this.registrationInfoGroupBox.Controls.Add(this.dateOfBirthMaskedTextBox);
            this.registrationInfoGroupBox.Controls.Add(this.emailAddressTextBox);
            this.registrationInfoGroupBox.Controls.Add(this.lastNameTextBox);
            this.registrationInfoGroupBox.Controls.Add(this.firstNameTextBox);
            this.registrationInfoGroupBox.Controls.Add(this.statusLabel);
            this.registrationInfoGroupBox.Controls.Add(this.dateOfBirthLabel);
            this.registrationInfoGroupBox.Controls.Add(this.emailAddressLabel);
            this.registrationInfoGroupBox.Controls.Add(this.lastNameLabel);
            this.registrationInfoGroupBox.Controls.Add(this.firstNameLabel);
            this.registrationInfoGroupBox.Location = new System.Drawing.Point(12, 201);
            this.registrationInfoGroupBox.Name = "registrationInfoGroupBox";
            this.registrationInfoGroupBox.Size = new System.Drawing.Size(406, 111);
            this.registrationInfoGroupBox.TabIndex = 4;
            this.registrationInfoGroupBox.TabStop = false;
            this.registrationInfoGroupBox.Text = "Registration Information";
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(279, 75);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComboBox.TabIndex = 8;
            // 
            // dateOfBirthMaskedTextBox
            // 
            this.dateOfBirthMaskedTextBox.Location = new System.Drawing.Point(82, 75);
            this.dateOfBirthMaskedTextBox.Mask = "00/00/0000";
            this.dateOfBirthMaskedTextBox.Name = "dateOfBirthMaskedTextBox";
            this.dateOfBirthMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateOfBirthMaskedTextBox.TabIndex = 5;
            this.dateOfBirthMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Location = new System.Drawing.Point(89, 46);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(192, 20);
            this.emailAddressTextBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(287, 17);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(74, 20);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(241, 78);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Status:";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(7, 78);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(69, 13);
            this.dateOfBirthLabel.TabIndex = 3;
            this.dateOfBirthLabel.Text = "Date of Birth:";
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Location = new System.Drawing.Point(7, 48);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(76, 13);
            this.emailAddressLabel.TabIndex = 2;
            this.emailAddressLabel.Text = "Email Address:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(220, 20);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(7, 20);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // classInfoGroupBox
            // 
            this.classInfoGroupBox.Controls.Add(this.totalPriceLabel);
            this.classInfoGroupBox.Controls.Add(this.pricePerClassLabel);
            this.classInfoGroupBox.Controls.Add(this.totalClassesLabel);
            this.classInfoGroupBox.Controls.Add(this.totalPriceLblLabel);
            this.classInfoGroupBox.Controls.Add(this.pricePerClassLblLabel);
            this.classInfoGroupBox.Controls.Add(this.totalClassesLblLabel);
            this.classInfoGroupBox.Controls.Add(this.classesListBox);
            this.classInfoGroupBox.Controls.Add(this.classLabel);
            this.classInfoGroupBox.Controls.Add(this.animationRadioButton);
            this.classInfoGroupBox.Controls.Add(this.liveActionRadioButton);
            this.classInfoGroupBox.Controls.Add(this.classTypeLabel);
            this.classInfoGroupBox.Location = new System.Drawing.Point(12, 319);
            this.classInfoGroupBox.Name = "classInfoGroupBox";
            this.classInfoGroupBox.Size = new System.Drawing.Size(406, 174);
            this.classInfoGroupBox.TabIndex = 5;
            this.classInfoGroupBox.TabStop = false;
            this.classInfoGroupBox.Text = "Class Information";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceLabel.Location = new System.Drawing.Point(287, 129);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(73, 23);
            this.totalPriceLabel.TabIndex = 10;
            this.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pricePerClassLabel
            // 
            this.pricePerClassLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pricePerClassLabel.Location = new System.Drawing.Point(287, 99);
            this.pricePerClassLabel.Name = "pricePerClassLabel";
            this.pricePerClassLabel.Size = new System.Drawing.Size(73, 23);
            this.pricePerClassLabel.TabIndex = 9;
            this.pricePerClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalClassesLabel
            // 
            this.totalClassesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalClassesLabel.Location = new System.Drawing.Point(287, 69);
            this.totalClassesLabel.Name = "totalClassesLabel";
            this.totalClassesLabel.Size = new System.Drawing.Size(73, 23);
            this.totalClassesLabel.TabIndex = 8;
            this.totalClassesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalPriceLblLabel
            // 
            this.totalPriceLblLabel.AutoSize = true;
            this.totalPriceLblLabel.Location = new System.Drawing.Point(168, 134);
            this.totalPriceLblLabel.Name = "totalPriceLblLabel";
            this.totalPriceLblLabel.Size = new System.Drawing.Size(61, 13);
            this.totalPriceLblLabel.TabIndex = 7;
            this.totalPriceLblLabel.Text = "Total Price:";
            // 
            // pricePerClassLblLabel
            // 
            this.pricePerClassLblLabel.AutoSize = true;
            this.pricePerClassLblLabel.Location = new System.Drawing.Point(168, 104);
            this.pricePerClassLblLabel.Name = "pricePerClassLblLabel";
            this.pricePerClassLblLabel.Size = new System.Drawing.Size(81, 13);
            this.pricePerClassLblLabel.TabIndex = 6;
            this.pricePerClassLblLabel.Text = "Price Per Class:";
            // 
            // totalClassesLblLabel
            // 
            this.totalClassesLblLabel.AutoSize = true;
            this.totalClassesLblLabel.Location = new System.Drawing.Point(167, 74);
            this.totalClassesLblLabel.Name = "totalClassesLblLabel";
            this.totalClassesLblLabel.Size = new System.Drawing.Size(73, 13);
            this.totalClassesLblLabel.TabIndex = 5;
            this.totalClassesLblLabel.Text = "Total Classes:";
            // 
            // classesListBox
            // 
            this.classesListBox.FormattingEnabled = true;
            this.classesListBox.Location = new System.Drawing.Point(10, 74);
            this.classesListBox.Name = "classesListBox";
            this.classesListBox.Size = new System.Drawing.Size(120, 95);
            this.classesListBox.TabIndex = 4;
            this.classesListBox.SelectedIndexChanged += new System.EventHandler(this.classesListBox_SelectedIndexChanged);
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(7, 57);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(116, 13);
            this.classLabel.TabIndex = 3;
            this.classLabel.Text = "Classes (maximum of 4)";
            // 
            // animationRadioButton
            // 
            this.animationRadioButton.AutoSize = true;
            this.animationRadioButton.Location = new System.Drawing.Point(223, 28);
            this.animationRadioButton.Name = "animationRadioButton";
            this.animationRadioButton.Size = new System.Drawing.Size(71, 17);
            this.animationRadioButton.TabIndex = 2;
            this.animationRadioButton.TabStop = true;
            this.animationRadioButton.Text = "Animation";
            this.animationRadioButton.UseVisualStyleBackColor = true;
            // 
            // liveActionRadioButton
            // 
            this.liveActionRadioButton.AutoSize = true;
            this.liveActionRadioButton.Location = new System.Drawing.Point(125, 28);
            this.liveActionRadioButton.Name = "liveActionRadioButton";
            this.liveActionRadioButton.Size = new System.Drawing.Size(78, 17);
            this.liveActionRadioButton.TabIndex = 1;
            this.liveActionRadioButton.TabStop = true;
            this.liveActionRadioButton.Text = "Live Action";
            this.liveActionRadioButton.UseVisualStyleBackColor = true;
            this.liveActionRadioButton.CheckedChanged += new System.EventHandler(this.liveActionRadioButton_CheckedChanged);
            // 
            // classTypeLabel
            // 
            this.classTypeLabel.AutoSize = true;
            this.classTypeLabel.Location = new System.Drawing.Point(41, 28);
            this.classTypeLabel.Name = "classTypeLabel";
            this.classTypeLabel.Size = new System.Drawing.Size(62, 13);
            this.classTypeLabel.TabIndex = 0;
            this.classTypeLabel.Text = "Class Type:";
            // 
            // paymentTypeLabel
            // 
            this.paymentTypeLabel.AutoSize = true;
            this.paymentTypeLabel.Location = new System.Drawing.Point(52, 509);
            this.paymentTypeLabel.Name = "paymentTypeLabel";
            this.paymentTypeLabel.Size = new System.Drawing.Size(78, 13);
            this.paymentTypeLabel.TabIndex = 7;
            this.paymentTypeLabel.Text = "Payment Type:";
            // 
            // infoMenuStrip
            // 
            this.infoMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.infoMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.infoMenuStrip.Name = "infoMenuStrip";
            this.infoMenuStrip.Size = new System.Drawing.Size(441, 24);
            this.infoMenuStrip.TabIndex = 8;
            this.infoMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Location = new System.Drawing.Point(156, 507);
            this.cashRadioButton.Name = "cashRadioButton";
            this.cashRadioButton.Size = new System.Drawing.Size(49, 17);
            this.cashRadioButton.TabIndex = 9;
            this.cashRadioButton.TabStop = true;
            this.cashRadioButton.Text = "Cash";
            this.cashRadioButton.UseVisualStyleBackColor = true;
            // 
            // checkRadioButton
            // 
            this.checkRadioButton.AutoSize = true;
            this.checkRadioButton.Location = new System.Drawing.Point(244, 507);
            this.checkRadioButton.Name = "checkRadioButton";
            this.checkRadioButton.Size = new System.Drawing.Size(56, 17);
            this.checkRadioButton.TabIndex = 10;
            this.checkRadioButton.TabStop = true;
            this.checkRadioButton.Text = "Check";
            this.checkRadioButton.UseVisualStyleBackColor = true;
            // 
            // emailCheckbox
            // 
            this.emailCheckbox.AutoSize = true;
            this.emailCheckbox.Location = new System.Drawing.Point(156, 555);
            this.emailCheckbox.Name = "emailCheckbox";
            this.emailCheckbox.Size = new System.Drawing.Size(91, 17);
            this.emailCheckbox.TabIndex = 11;
            this.emailCheckbox.Text = "Email Receipt";
            this.emailCheckbox.UseVisualStyleBackColor = true;
            // 
            // schoolPictureBox
            // 
            this.schoolPictureBox.Image = global::Hariharan_4.Properties.Resources.article_full_1x;
            this.schoolPictureBox.Location = new System.Drawing.Point(12, 39);
            this.schoolPictureBox.Name = "schoolPictureBox";
            this.schoolPictureBox.Size = new System.Drawing.Size(161, 109);
            this.schoolPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.schoolPictureBox.TabIndex = 0;
            this.schoolPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 600);
            this.Controls.Add(this.emailCheckbox);
            this.Controls.Add(this.checkRadioButton);
            this.Controls.Add(this.cashRadioButton);
            this.Controls.Add(this.paymentTypeLabel);
            this.Controls.Add(this.classInfoGroupBox);
            this.Controls.Add(this.registrationInfoGroupBox);
            this.Controls.Add(this.registrationDateMaskedTextBox);
            this.Controls.Add(this.registrationDateLabel);
            this.Controls.Add(this.schoolLabel);
            this.Controls.Add(this.schoolPictureBox);
            this.Controls.Add(this.infoMenuStrip);
            this.MainMenuStrip = this.infoMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.registrationInfoGroupBox.ResumeLayout(false);
            this.registrationInfoGroupBox.PerformLayout();
            this.classInfoGroupBox.ResumeLayout(false);
            this.classInfoGroupBox.PerformLayout();
            this.infoMenuStrip.ResumeLayout(false);
            this.infoMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox schoolPictureBox;
        private System.Windows.Forms.Label schoolLabel;
        private System.Windows.Forms.Label registrationDateLabel;
        private System.Windows.Forms.MaskedTextBox registrationDateMaskedTextBox;
        private System.Windows.Forms.GroupBox registrationInfoGroupBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.MaskedTextBox dateOfBirthMaskedTextBox;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.GroupBox classInfoGroupBox;
        private System.Windows.Forms.Label classTypeLabel;
        private System.Windows.Forms.RadioButton animationRadioButton;
        private System.Windows.Forms.RadioButton liveActionRadioButton;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.ListBox classesListBox;
        private System.Windows.Forms.Label totalPriceLblLabel;
        private System.Windows.Forms.Label pricePerClassLblLabel;
        private System.Windows.Forms.Label totalClassesLblLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label pricePerClassLabel;
        private System.Windows.Forms.Label totalClassesLabel;
        private System.Windows.Forms.Label paymentTypeLabel;
        private System.Windows.Forms.MenuStrip infoMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.RadioButton cashRadioButton;
        private System.Windows.Forms.RadioButton checkRadioButton;
        private System.Windows.Forms.CheckBox emailCheckbox;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

