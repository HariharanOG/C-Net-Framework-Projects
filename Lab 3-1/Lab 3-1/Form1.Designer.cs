namespace Lab_3_1
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
            this.petOwnerGroupBox = new System.Windows.Forms.GroupBox();
            this.ownerPhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ownerNameTextBox = new System.Windows.Forms.TextBox();
            this.ownerPhoneLabel = new System.Windows.Forms.Label();
            this.ownerNameLabel = new System.Windows.Forms.Label();
            this.petGroupBox = new System.Windows.Forms.GroupBox();
            this.typeIfOtherTextBox = new System.Windows.Forms.TextBox();
            this.typeIfOtherLabel = new System.Windows.Forms.Label();
            this.otherRadioButton = new System.Windows.Forms.RadioButton();
            this.dogRadioButton = new System.Windows.Forms.RadioButton();
            this.catRadioButton = new System.Windows.Forms.RadioButton();
            this.petDOBMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.petNameTextBox = new System.Windows.Forms.TextBox();
            this.petTypeLabel = new System.Windows.Forms.Label();
            this.petDateOfBirthLabel = new System.Windows.Forms.Label();
            this.petNameLabel = new System.Windows.Forms.Label();
            this.servicesGroupBox = new System.Windows.Forms.GroupBox();
            this.furTrimmingPLabel = new System.Windows.Forms.Label();
            this.shampooPLabel = new System.Windows.Forms.Label();
            this.nailClippingPLabel = new System.Windows.Forms.Label();
            this.fleaRemovalPLabel = new System.Windows.Forms.Label();
            this.totalFeeLabel = new System.Windows.Forms.Label();
            this.totalFeeLblLabel = new System.Windows.Forms.Label();
            this.furTrimmingPriceLabel = new System.Windows.Forms.Label();
            this.shampooPriceLabel = new System.Windows.Forms.Label();
            this.nailClippingPriceLabel = new System.Windows.Forms.Label();
            this.fleaRemovalPriceLabel = new System.Windows.Forms.Label();
            this.furTrimmingCheckBox = new System.Windows.Forms.CheckBox();
            this.shampooCheckBox = new System.Windows.Forms.CheckBox();
            this.nailClippingCheckBox = new System.Windows.Forms.CheckBox();
            this.fleaRemovalCheckBox = new System.Windows.Forms.CheckBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.petOwnerGroupBox.SuspendLayout();
            this.petGroupBox.SuspendLayout();
            this.servicesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // petOwnerGroupBox
            // 
            this.petOwnerGroupBox.Controls.Add(this.ownerPhoneMaskedTextBox);
            this.petOwnerGroupBox.Controls.Add(this.ownerNameTextBox);
            this.petOwnerGroupBox.Controls.Add(this.ownerPhoneLabel);
            this.petOwnerGroupBox.Controls.Add(this.ownerNameLabel);
            this.petOwnerGroupBox.Location = new System.Drawing.Point(12, 12);
            this.petOwnerGroupBox.Name = "petOwnerGroupBox";
            this.petOwnerGroupBox.Size = new System.Drawing.Size(494, 90);
            this.petOwnerGroupBox.TabIndex = 0;
            this.petOwnerGroupBox.TabStop = false;
            this.petOwnerGroupBox.Text = "Pet Owner";
            // 
            // ownerPhoneMaskedTextBox
            // 
            this.ownerPhoneMaskedTextBox.Location = new System.Drawing.Point(114, 54);
            this.ownerPhoneMaskedTextBox.Mask = "(999) 000-0000";
            this.ownerPhoneMaskedTextBox.Name = "ownerPhoneMaskedTextBox";
            this.ownerPhoneMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.ownerPhoneMaskedTextBox.TabIndex = 3;
            // 
            // ownerNameTextBox
            // 
            this.ownerNameTextBox.Location = new System.Drawing.Point(114, 22);
            this.ownerNameTextBox.Name = "ownerNameTextBox";
            this.ownerNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.ownerNameTextBox.TabIndex = 2;
            // 
            // ownerPhoneLabel
            // 
            this.ownerPhoneLabel.Location = new System.Drawing.Point(7, 54);
            this.ownerPhoneLabel.Name = "ownerPhoneLabel";
            this.ownerPhoneLabel.Size = new System.Drawing.Size(100, 23);
            this.ownerPhoneLabel.TabIndex = 1;
            this.ownerPhoneLabel.Text = "O&wner Phone: ";
            this.ownerPhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ownerNameLabel
            // 
            this.ownerNameLabel.Location = new System.Drawing.Point(7, 22);
            this.ownerNameLabel.Name = "ownerNameLabel";
            this.ownerNameLabel.Size = new System.Drawing.Size(100, 23);
            this.ownerNameLabel.TabIndex = 0;
            this.ownerNameLabel.Text = "&Owner Name: ";
            this.ownerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // petGroupBox
            // 
            this.petGroupBox.Controls.Add(this.typeIfOtherTextBox);
            this.petGroupBox.Controls.Add(this.typeIfOtherLabel);
            this.petGroupBox.Controls.Add(this.otherRadioButton);
            this.petGroupBox.Controls.Add(this.dogRadioButton);
            this.petGroupBox.Controls.Add(this.catRadioButton);
            this.petGroupBox.Controls.Add(this.petDOBMaskedTextBox);
            this.petGroupBox.Controls.Add(this.petNameTextBox);
            this.petGroupBox.Controls.Add(this.petTypeLabel);
            this.petGroupBox.Controls.Add(this.petDateOfBirthLabel);
            this.petGroupBox.Controls.Add(this.petNameLabel);
            this.petGroupBox.Location = new System.Drawing.Point(12, 120);
            this.petGroupBox.Name = "petGroupBox";
            this.petGroupBox.Size = new System.Drawing.Size(494, 162);
            this.petGroupBox.TabIndex = 1;
            this.petGroupBox.TabStop = false;
            this.petGroupBox.Text = "Pet";
            // 
            // typeIfOtherTextBox
            // 
            this.typeIfOtherTextBox.Enabled = false;
            this.typeIfOtherTextBox.Location = new System.Drawing.Point(318, 118);
            this.typeIfOtherTextBox.Name = "typeIfOtherTextBox";
            this.typeIfOtherTextBox.Size = new System.Drawing.Size(100, 22);
            this.typeIfOtherTextBox.TabIndex = 10;
            // 
            // typeIfOtherLabel
            // 
            this.typeIfOtherLabel.Enabled = false;
            this.typeIfOtherLabel.Location = new System.Drawing.Point(181, 117);
            this.typeIfOtherLabel.Name = "typeIfOtherLabel";
            this.typeIfOtherLabel.Size = new System.Drawing.Size(119, 23);
            this.typeIfOtherLabel.TabIndex = 9;
            this.typeIfOtherLabel.Text = "T&ype (if Other):";
            this.typeIfOtherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // otherRadioButton
            // 
            this.otherRadioButton.AutoSize = true;
            this.otherRadioButton.Location = new System.Drawing.Point(228, 96);
            this.otherRadioButton.Name = "otherRadioButton";
            this.otherRadioButton.Size = new System.Drawing.Size(60, 20);
            this.otherRadioButton.TabIndex = 8;
            this.otherRadioButton.TabStop = true;
            this.otherRadioButton.Text = "Other";
            this.otherRadioButton.UseVisualStyleBackColor = true;
            this.otherRadioButton.CheckedChanged += new System.EventHandler(this.otherRadioButton_CheckedChanged);
            // 
            // dogRadioButton
            // 
            this.dogRadioButton.AutoSize = true;
            this.dogRadioButton.Location = new System.Drawing.Point(168, 96);
            this.dogRadioButton.Name = "dogRadioButton";
            this.dogRadioButton.Size = new System.Drawing.Size(54, 20);
            this.dogRadioButton.TabIndex = 7;
            this.dogRadioButton.TabStop = true;
            this.dogRadioButton.Text = "Dog";
            this.dogRadioButton.UseVisualStyleBackColor = true;
            // 
            // catRadioButton
            // 
            this.catRadioButton.AutoSize = true;
            this.catRadioButton.Location = new System.Drawing.Point(114, 95);
            this.catRadioButton.Name = "catRadioButton";
            this.catRadioButton.Size = new System.Drawing.Size(48, 20);
            this.catRadioButton.TabIndex = 6;
            this.catRadioButton.TabStop = true;
            this.catRadioButton.Text = "Cat";
            this.catRadioButton.UseVisualStyleBackColor = true;
            // 
            // petDOBMaskedTextBox
            // 
            this.petDOBMaskedTextBox.Location = new System.Drawing.Point(151, 57);
            this.petDOBMaskedTextBox.Mask = "00/00/0000";
            this.petDOBMaskedTextBox.Name = "petDOBMaskedTextBox";
            this.petDOBMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.petDOBMaskedTextBox.TabIndex = 5;
            this.petDOBMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // petNameTextBox
            // 
            this.petNameTextBox.Location = new System.Drawing.Point(151, 21);
            this.petNameTextBox.Name = "petNameTextBox";
            this.petNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.petNameTextBox.TabIndex = 4;
            // 
            // petTypeLabel
            // 
            this.petTypeLabel.Location = new System.Drawing.Point(7, 93);
            this.petTypeLabel.Name = "petTypeLabel";
            this.petTypeLabel.Size = new System.Drawing.Size(100, 23);
            this.petTypeLabel.TabIndex = 3;
            this.petTypeLabel.Text = "Pe&t Type: ";
            this.petTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // petDateOfBirthLabel
            // 
            this.petDateOfBirthLabel.Location = new System.Drawing.Point(7, 56);
            this.petDateOfBirthLabel.Name = "petDateOfBirthLabel";
            this.petDateOfBirthLabel.Size = new System.Drawing.Size(137, 23);
            this.petDateOfBirthLabel.TabIndex = 2;
            this.petDateOfBirthLabel.Text = "P&et Date Of Birth: ";
            this.petDateOfBirthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // petNameLabel
            // 
            this.petNameLabel.Location = new System.Drawing.Point(7, 18);
            this.petNameLabel.Name = "petNameLabel";
            this.petNameLabel.Size = new System.Drawing.Size(100, 23);
            this.petNameLabel.TabIndex = 1;
            this.petNameLabel.Text = "&Pet Name: ";
            this.petNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // servicesGroupBox
            // 
            this.servicesGroupBox.Controls.Add(this.furTrimmingPLabel);
            this.servicesGroupBox.Controls.Add(this.shampooPLabel);
            this.servicesGroupBox.Controls.Add(this.nailClippingPLabel);
            this.servicesGroupBox.Controls.Add(this.fleaRemovalPLabel);
            this.servicesGroupBox.Controls.Add(this.totalFeeLabel);
            this.servicesGroupBox.Controls.Add(this.totalFeeLblLabel);
            this.servicesGroupBox.Controls.Add(this.furTrimmingPriceLabel);
            this.servicesGroupBox.Controls.Add(this.shampooPriceLabel);
            this.servicesGroupBox.Controls.Add(this.nailClippingPriceLabel);
            this.servicesGroupBox.Controls.Add(this.fleaRemovalPriceLabel);
            this.servicesGroupBox.Controls.Add(this.furTrimmingCheckBox);
            this.servicesGroupBox.Controls.Add(this.shampooCheckBox);
            this.servicesGroupBox.Controls.Add(this.nailClippingCheckBox);
            this.servicesGroupBox.Controls.Add(this.fleaRemovalCheckBox);
            this.servicesGroupBox.Location = new System.Drawing.Point(12, 301);
            this.servicesGroupBox.Name = "servicesGroupBox";
            this.servicesGroupBox.Size = new System.Drawing.Size(494, 131);
            this.servicesGroupBox.TabIndex = 2;
            this.servicesGroupBox.TabStop = false;
            this.servicesGroupBox.Text = "Services";
            // 
            // furTrimmingPLabel
            // 
            this.furTrimmingPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.furTrimmingPLabel.Location = new System.Drawing.Point(419, 58);
            this.furTrimmingPLabel.Name = "furTrimmingPLabel";
            this.furTrimmingPLabel.Size = new System.Drawing.Size(69, 21);
            this.furTrimmingPLabel.TabIndex = 13;
            this.furTrimmingPLabel.Text = "PRICE";
            // 
            // shampooPLabel
            // 
            this.shampooPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shampooPLabel.Location = new System.Drawing.Point(419, 18);
            this.shampooPLabel.Name = "shampooPLabel";
            this.shampooPLabel.Size = new System.Drawing.Size(69, 20);
            this.shampooPLabel.TabIndex = 12;
            this.shampooPLabel.Text = "PRICE";
            // 
            // nailClippingPLabel
            // 
            this.nailClippingPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nailClippingPLabel.Location = new System.Drawing.Point(148, 58);
            this.nailClippingPLabel.Name = "nailClippingPLabel";
            this.nailClippingPLabel.Size = new System.Drawing.Size(66, 21);
            this.nailClippingPLabel.TabIndex = 11;
            this.nailClippingPLabel.Text = "PRICE";
            // 
            // fleaRemovalPLabel
            // 
            this.fleaRemovalPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fleaRemovalPLabel.Location = new System.Drawing.Point(148, 21);
            this.fleaRemovalPLabel.Name = "fleaRemovalPLabel";
            this.fleaRemovalPLabel.Size = new System.Drawing.Size(66, 23);
            this.fleaRemovalPLabel.TabIndex = 10;
            this.fleaRemovalPLabel.Text = "PRICE";
            // 
            // totalFeeLabel
            // 
            this.totalFeeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalFeeLabel.Location = new System.Drawing.Point(200, 91);
            this.totalFeeLabel.Name = "totalFeeLabel";
            this.totalFeeLabel.Size = new System.Drawing.Size(83, 23);
            this.totalFeeLabel.TabIndex = 9;
            this.totalFeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalFeeLblLabel
            // 
            this.totalFeeLblLabel.Location = new System.Drawing.Point(111, 91);
            this.totalFeeLblLabel.Name = "totalFeeLblLabel";
            this.totalFeeLblLabel.Size = new System.Drawing.Size(83, 23);
            this.totalFeeLblLabel.TabIndex = 8;
            this.totalFeeLblLabel.Text = "Total Fee:";
            this.totalFeeLblLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // furTrimmingPriceLabel
            // 
            this.furTrimmingPriceLabel.AutoSize = true;
            this.furTrimmingPriceLabel.Location = new System.Drawing.Point(416, 58);
            this.furTrimmingPriceLabel.Name = "furTrimmingPriceLabel";
            this.furTrimmingPriceLabel.Size = new System.Drawing.Size(0, 16);
            this.furTrimmingPriceLabel.TabIndex = 7;
            // 
            // shampooPriceLabel
            // 
            this.shampooPriceLabel.AutoSize = true;
            this.shampooPriceLabel.Location = new System.Drawing.Point(416, 20);
            this.shampooPriceLabel.Name = "shampooPriceLabel";
            this.shampooPriceLabel.Size = new System.Drawing.Size(0, 16);
            this.shampooPriceLabel.TabIndex = 6;
            // 
            // nailClippingPriceLabel
            // 
            this.nailClippingPriceLabel.AutoSize = true;
            this.nailClippingPriceLabel.Location = new System.Drawing.Point(131, 63);
            this.nailClippingPriceLabel.Name = "nailClippingPriceLabel";
            this.nailClippingPriceLabel.Size = new System.Drawing.Size(0, 16);
            this.nailClippingPriceLabel.TabIndex = 5;
            // 
            // fleaRemovalPriceLabel
            // 
            this.fleaRemovalPriceLabel.AutoSize = true;
            this.fleaRemovalPriceLabel.Location = new System.Drawing.Point(131, 24);
            this.fleaRemovalPriceLabel.Name = "fleaRemovalPriceLabel";
            this.fleaRemovalPriceLabel.Size = new System.Drawing.Size(0, 16);
            this.fleaRemovalPriceLabel.TabIndex = 4;
            // 
            // furTrimmingCheckBox
            // 
            this.furTrimmingCheckBox.AutoSize = true;
            this.furTrimmingCheckBox.Location = new System.Drawing.Point(303, 58);
            this.furTrimmingCheckBox.Name = "furTrimmingCheckBox";
            this.furTrimmingCheckBox.Size = new System.Drawing.Size(107, 20);
            this.furTrimmingCheckBox.TabIndex = 3;
            this.furTrimmingCheckBox.Text = "F&ur Trimming";
            this.furTrimmingCheckBox.UseVisualStyleBackColor = true;
            // 
            // shampooCheckBox
            // 
            this.shampooCheckBox.AutoSize = true;
            this.shampooCheckBox.Location = new System.Drawing.Point(304, 21);
            this.shampooCheckBox.Name = "shampooCheckBox";
            this.shampooCheckBox.Size = new System.Drawing.Size(88, 20);
            this.shampooCheckBox.TabIndex = 2;
            this.shampooCheckBox.Text = "&Shampoo";
            this.shampooCheckBox.UseVisualStyleBackColor = true;
            // 
            // nailClippingCheckBox
            // 
            this.nailClippingCheckBox.AutoSize = true;
            this.nailClippingCheckBox.Location = new System.Drawing.Point(10, 59);
            this.nailClippingCheckBox.Name = "nailClippingCheckBox";
            this.nailClippingCheckBox.Size = new System.Drawing.Size(105, 20);
            this.nailClippingCheckBox.TabIndex = 1;
            this.nailClippingCheckBox.Text = "&Nail Clipping";
            this.nailClippingCheckBox.UseVisualStyleBackColor = true;
            // 
            // fleaRemovalCheckBox
            // 
            this.fleaRemovalCheckBox.AutoSize = true;
            this.fleaRemovalCheckBox.Location = new System.Drawing.Point(10, 21);
            this.fleaRemovalCheckBox.Name = "fleaRemovalCheckBox";
            this.fleaRemovalCheckBox.Size = new System.Drawing.Size(114, 20);
            this.fleaRemovalCheckBox.TabIndex = 0;
            this.fleaRemovalCheckBox.Text = "&Flea Removal";
            this.fleaRemovalCheckBox.UseVisualStyleBackColor = true;
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(81, 451);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(75, 23);
            this.totalButton.TabIndex = 3;
            this.totalButton.Text = "Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(212, 451);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(355, 451);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 5;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 502);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.servicesGroupBox);
            this.Controls.Add(this.petGroupBox);
            this.Controls.Add(this.petOwnerGroupBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pet Boutique - Service Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.petOwnerGroupBox.ResumeLayout(false);
            this.petOwnerGroupBox.PerformLayout();
            this.petGroupBox.ResumeLayout(false);
            this.petGroupBox.PerformLayout();
            this.servicesGroupBox.ResumeLayout(false);
            this.servicesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox petOwnerGroupBox;
        private System.Windows.Forms.Label ownerPhoneLabel;
        private System.Windows.Forms.Label ownerNameLabel;
        private System.Windows.Forms.MaskedTextBox ownerPhoneMaskedTextBox;
        private System.Windows.Forms.TextBox ownerNameTextBox;
        private System.Windows.Forms.GroupBox petGroupBox;
        private System.Windows.Forms.Label petDateOfBirthLabel;
        private System.Windows.Forms.Label petNameLabel;
        private System.Windows.Forms.MaskedTextBox petDOBMaskedTextBox;
        private System.Windows.Forms.TextBox petNameTextBox;
        private System.Windows.Forms.Label petTypeLabel;
        private System.Windows.Forms.RadioButton dogRadioButton;
        private System.Windows.Forms.RadioButton catRadioButton;
        private System.Windows.Forms.TextBox typeIfOtherTextBox;
        private System.Windows.Forms.Label typeIfOtherLabel;
        private System.Windows.Forms.RadioButton otherRadioButton;
        private System.Windows.Forms.GroupBox servicesGroupBox;
        private System.Windows.Forms.Label fleaRemovalPriceLabel;
        private System.Windows.Forms.CheckBox furTrimmingCheckBox;
        private System.Windows.Forms.CheckBox shampooCheckBox;
        private System.Windows.Forms.CheckBox nailClippingCheckBox;
        private System.Windows.Forms.CheckBox fleaRemovalCheckBox;
        private System.Windows.Forms.Label totalFeeLblLabel;
        private System.Windows.Forms.Label furTrimmingPriceLabel;
        private System.Windows.Forms.Label shampooPriceLabel;
        private System.Windows.Forms.Label nailClippingPriceLabel;
        private System.Windows.Forms.Label totalFeeLabel;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label furTrimmingPLabel;
        private System.Windows.Forms.Label shampooPLabel;
        private System.Windows.Forms.Label nailClippingPLabel;
        private System.Windows.Forms.Label fleaRemovalPLabel;
    }
}

