namespace Hariharan_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.motorwayMotelPictureBox = new System.Windows.Forms.PictureBox();
            this.motorwayMotelLblLabel = new System.Windows.Forms.Label();
            this.dateGroupBox = new System.Windows.Forms.GroupBox();
            this.dateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.guestInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstTextBox = new System.Windows.Forms.TextBox();
            this.roomInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.nightlyRateTextBox = new System.Windows.Forms.TextBox();
            this.nightlyRateLabel = new System.Windows.Forms.Label();
            this.numberOfNightsLabel = new System.Windows.Forms.Label();
            this.numberOfNightsTextBox = new System.Windows.Forms.TextBox();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.roomNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.additionalChargesGroupBox = new System.Windows.Forms.GroupBox();
            this.miscellaneousTextBox = new System.Windows.Forms.TextBox();
            this.miscellaneousLabel = new System.Windows.Forms.Label();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.miniBarTextBox = new System.Windows.Forms.TextBox();
            this.miniBarLabel = new System.Windows.Forms.Label();
            this.totalButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.billingSummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.totalChargesLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxChargesLabel = new System.Windows.Forms.Label();
            this.additionalChargesLabel = new System.Windows.Forms.Label();
            this.roomChargesLabel = new System.Windows.Forms.Label();
            this.totalChargesLblLabel = new System.Windows.Forms.Label();
            this.subtotalLblLabel = new System.Windows.Forms.Label();
            this.taxChargesLblLabel = new System.Windows.Forms.Label();
            this.additionalChargesLblLabel = new System.Windows.Forms.Label();
            this.roomChargesLblLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.motorwayMotelPictureBox)).BeginInit();
            this.dateGroupBox.SuspendLayout();
            this.guestInfoGroupBox.SuspendLayout();
            this.roomInfoGroupBox.SuspendLayout();
            this.additionalChargesGroupBox.SuspendLayout();
            this.billingSummaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // motorwayMotelPictureBox
            // 
            this.motorwayMotelPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("motorwayMotelPictureBox.Image")));
            this.motorwayMotelPictureBox.Location = new System.Drawing.Point(461, 12);
            this.motorwayMotelPictureBox.Name = "motorwayMotelPictureBox";
            this.motorwayMotelPictureBox.Size = new System.Drawing.Size(334, 299);
            this.motorwayMotelPictureBox.TabIndex = 0;
            this.motorwayMotelPictureBox.TabStop = false;
            // 
            // motorwayMotelLblLabel
            // 
            this.motorwayMotelLblLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.motorwayMotelLblLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorwayMotelLblLabel.ForeColor = System.Drawing.Color.LightBlue;
            this.motorwayMotelLblLabel.Location = new System.Drawing.Point(12, 9);
            this.motorwayMotelLblLabel.Name = "motorwayMotelLblLabel";
            this.motorwayMotelLblLabel.Size = new System.Drawing.Size(175, 96);
            this.motorwayMotelLblLabel.TabIndex = 1;
            this.motorwayMotelLblLabel.Text = "Motorway Motel";
            this.motorwayMotelLblLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateGroupBox
            // 
            this.dateGroupBox.Controls.Add(this.dateMaskedTextBox);
            this.dateGroupBox.Location = new System.Drawing.Point(12, 108);
            this.dateGroupBox.Name = "dateGroupBox";
            this.dateGroupBox.Size = new System.Drawing.Size(222, 59);
            this.dateGroupBox.TabIndex = 2;
            this.dateGroupBox.TabStop = false;
            this.dateGroupBox.Text = "Today\'s Date";
            // 
            // dateMaskedTextBox
            // 
            this.dateMaskedTextBox.Location = new System.Drawing.Point(6, 19);
            this.dateMaskedTextBox.Mask = "00/00/0000";
            this.dateMaskedTextBox.Name = "dateMaskedTextBox";
            this.dateMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateMaskedTextBox.TabIndex = 0;
            this.dateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guestInfoGroupBox
            // 
            this.guestInfoGroupBox.Controls.Add(this.lastNameLabel);
            this.guestInfoGroupBox.Controls.Add(this.firstNameLabel);
            this.guestInfoGroupBox.Controls.Add(this.lastNameTextBox);
            this.guestInfoGroupBox.Controls.Add(this.firstTextBox);
            this.guestInfoGroupBox.Location = new System.Drawing.Point(12, 174);
            this.guestInfoGroupBox.Name = "guestInfoGroupBox";
            this.guestInfoGroupBox.Size = new System.Drawing.Size(222, 87);
            this.guestInfoGroupBox.TabIndex = 3;
            this.guestInfoGroupBox.TabStop = false;
            this.guestInfoGroupBox.Text = "Guest Information";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Location = new System.Drawing.Point(6, 46);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(100, 20);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name:";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Location = new System.Drawing.Point(6, 20);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(100, 20);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name: ";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(116, 46);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // firstTextBox
            // 
            this.firstTextBox.Location = new System.Drawing.Point(116, 20);
            this.firstTextBox.Name = "firstTextBox";
            this.firstTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstTextBox.TabIndex = 0;
            // 
            // roomInfoGroupBox
            // 
            this.roomInfoGroupBox.Controls.Add(this.nightlyRateTextBox);
            this.roomInfoGroupBox.Controls.Add(this.nightlyRateLabel);
            this.roomInfoGroupBox.Controls.Add(this.numberOfNightsLabel);
            this.roomInfoGroupBox.Controls.Add(this.numberOfNightsTextBox);
            this.roomInfoGroupBox.Controls.Add(this.roomNumberLabel);
            this.roomInfoGroupBox.Controls.Add(this.roomNumberMaskedTextBox);
            this.roomInfoGroupBox.Location = new System.Drawing.Point(12, 268);
            this.roomInfoGroupBox.Name = "roomInfoGroupBox";
            this.roomInfoGroupBox.Size = new System.Drawing.Size(222, 106);
            this.roomInfoGroupBox.TabIndex = 4;
            this.roomInfoGroupBox.TabStop = false;
            this.roomInfoGroupBox.Text = "Room Information";
            // 
            // nightlyRateTextBox
            // 
            this.nightlyRateTextBox.Location = new System.Drawing.Point(116, 73);
            this.nightlyRateTextBox.Name = "nightlyRateTextBox";
            this.nightlyRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.nightlyRateTextBox.TabIndex = 5;
            // 
            // nightlyRateLabel
            // 
            this.nightlyRateLabel.Location = new System.Drawing.Point(6, 73);
            this.nightlyRateLabel.Name = "nightlyRateLabel";
            this.nightlyRateLabel.Size = new System.Drawing.Size(100, 20);
            this.nightlyRateLabel.TabIndex = 4;
            this.nightlyRateLabel.Text = "Nightly Rate:";
            this.nightlyRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberOfNightsLabel
            // 
            this.numberOfNightsLabel.Location = new System.Drawing.Point(6, 44);
            this.numberOfNightsLabel.Name = "numberOfNightsLabel";
            this.numberOfNightsLabel.Size = new System.Drawing.Size(100, 20);
            this.numberOfNightsLabel.TabIndex = 3;
            this.numberOfNightsLabel.Text = "Number of Nights:";
            this.numberOfNightsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberOfNightsTextBox
            // 
            this.numberOfNightsTextBox.Location = new System.Drawing.Point(116, 45);
            this.numberOfNightsTextBox.Name = "numberOfNightsTextBox";
            this.numberOfNightsTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfNightsTextBox.TabIndex = 2;
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.Location = new System.Drawing.Point(6, 19);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(100, 20);
            this.roomNumberLabel.TabIndex = 1;
            this.roomNumberLabel.Text = "Room Number: ";
            this.roomNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomNumberMaskedTextBox
            // 
            this.roomNumberMaskedTextBox.Location = new System.Drawing.Point(116, 19);
            this.roomNumberMaskedTextBox.Mask = "000";
            this.roomNumberMaskedTextBox.Name = "roomNumberMaskedTextBox";
            this.roomNumberMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.roomNumberMaskedTextBox.TabIndex = 0;
            // 
            // additionalChargesGroupBox
            // 
            this.additionalChargesGroupBox.Controls.Add(this.miscellaneousTextBox);
            this.additionalChargesGroupBox.Controls.Add(this.miscellaneousLabel);
            this.additionalChargesGroupBox.Controls.Add(this.telephoneTextBox);
            this.additionalChargesGroupBox.Controls.Add(this.telephoneLabel);
            this.additionalChargesGroupBox.Controls.Add(this.miniBarTextBox);
            this.additionalChargesGroupBox.Controls.Add(this.miniBarLabel);
            this.additionalChargesGroupBox.Location = new System.Drawing.Point(12, 380);
            this.additionalChargesGroupBox.Name = "additionalChargesGroupBox";
            this.additionalChargesGroupBox.Size = new System.Drawing.Size(222, 110);
            this.additionalChargesGroupBox.TabIndex = 5;
            this.additionalChargesGroupBox.TabStop = false;
            this.additionalChargesGroupBox.Text = "Additional Charges";
            // 
            // miscellaneousTextBox
            // 
            this.miscellaneousTextBox.Location = new System.Drawing.Point(116, 74);
            this.miscellaneousTextBox.Name = "miscellaneousTextBox";
            this.miscellaneousTextBox.Size = new System.Drawing.Size(100, 20);
            this.miscellaneousTextBox.TabIndex = 7;
            // 
            // miscellaneousLabel
            // 
            this.miscellaneousLabel.Location = new System.Drawing.Point(6, 74);
            this.miscellaneousLabel.Name = "miscellaneousLabel";
            this.miscellaneousLabel.Size = new System.Drawing.Size(100, 20);
            this.miscellaneousLabel.TabIndex = 6;
            this.miscellaneousLabel.Text = "Miscellaneous:";
            this.miscellaneousLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.Location = new System.Drawing.Point(116, 45);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.telephoneTextBox.TabIndex = 5;
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.Location = new System.Drawing.Point(6, 45);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(100, 20);
            this.telephoneLabel.TabIndex = 4;
            this.telephoneLabel.Text = "Telephone:";
            this.telephoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // miniBarTextBox
            // 
            this.miniBarTextBox.Location = new System.Drawing.Point(116, 16);
            this.miniBarTextBox.Name = "miniBarTextBox";
            this.miniBarTextBox.Size = new System.Drawing.Size(100, 20);
            this.miniBarTextBox.TabIndex = 3;
            // 
            // miniBarLabel
            // 
            this.miniBarLabel.Location = new System.Drawing.Point(6, 16);
            this.miniBarLabel.Name = "miniBarLabel";
            this.miniBarLabel.Size = new System.Drawing.Size(100, 20);
            this.miniBarLabel.TabIndex = 2;
            this.miniBarLabel.Text = "Mini Bar:";
            this.miniBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(13, 497);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(75, 23);
            this.totalButton.TabIndex = 6;
            this.totalButton.Text = "Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(94, 497);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(175, 497);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 23);
            this.helpButton.TabIndex = 8;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(256, 497);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // billingSummaryGroupBox
            // 
            this.billingSummaryGroupBox.Controls.Add(this.totalChargesLabel);
            this.billingSummaryGroupBox.Controls.Add(this.subtotalLabel);
            this.billingSummaryGroupBox.Controls.Add(this.taxChargesLabel);
            this.billingSummaryGroupBox.Controls.Add(this.additionalChargesLabel);
            this.billingSummaryGroupBox.Controls.Add(this.roomChargesLabel);
            this.billingSummaryGroupBox.Controls.Add(this.totalChargesLblLabel);
            this.billingSummaryGroupBox.Controls.Add(this.subtotalLblLabel);
            this.billingSummaryGroupBox.Controls.Add(this.taxChargesLblLabel);
            this.billingSummaryGroupBox.Controls.Add(this.additionalChargesLblLabel);
            this.billingSummaryGroupBox.Controls.Add(this.roomChargesLblLabel);
            this.billingSummaryGroupBox.Location = new System.Drawing.Point(461, 318);
            this.billingSummaryGroupBox.Name = "billingSummaryGroupBox";
            this.billingSummaryGroupBox.Size = new System.Drawing.Size(334, 172);
            this.billingSummaryGroupBox.TabIndex = 10;
            this.billingSummaryGroupBox.TabStop = false;
            this.billingSummaryGroupBox.Text = "Billing Summary";
            // 
            // totalChargesLabel
            // 
            this.totalChargesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalChargesLabel.Location = new System.Drawing.Point(156, 136);
            this.totalChargesLabel.Name = "totalChargesLabel";
            this.totalChargesLabel.Size = new System.Drawing.Size(100, 20);
            this.totalChargesLabel.TabIndex = 12;
            this.totalChargesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subtotalLabel.Location = new System.Drawing.Point(156, 106);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(100, 20);
            this.subtotalLabel.TabIndex = 11;
            this.subtotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxChargesLabel
            // 
            this.taxChargesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxChargesLabel.Location = new System.Drawing.Point(156, 77);
            this.taxChargesLabel.Name = "taxChargesLabel";
            this.taxChargesLabel.Size = new System.Drawing.Size(100, 20);
            this.taxChargesLabel.TabIndex = 10;
            this.taxChargesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // additionalChargesLabel
            // 
            this.additionalChargesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.additionalChargesLabel.Location = new System.Drawing.Point(156, 46);
            this.additionalChargesLabel.Name = "additionalChargesLabel";
            this.additionalChargesLabel.Size = new System.Drawing.Size(100, 20);
            this.additionalChargesLabel.TabIndex = 9;
            this.additionalChargesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomChargesLabel
            // 
            this.roomChargesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomChargesLabel.Location = new System.Drawing.Point(156, 16);
            this.roomChargesLabel.Name = "roomChargesLabel";
            this.roomChargesLabel.Size = new System.Drawing.Size(100, 20);
            this.roomChargesLabel.TabIndex = 8;
            this.roomChargesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalChargesLblLabel
            // 
            this.totalChargesLblLabel.Location = new System.Drawing.Point(6, 136);
            this.totalChargesLblLabel.Name = "totalChargesLblLabel";
            this.totalChargesLblLabel.Size = new System.Drawing.Size(100, 20);
            this.totalChargesLblLabel.TabIndex = 7;
            this.totalChargesLblLabel.Text = "Total Charges:";
            this.totalChargesLblLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subtotalLblLabel
            // 
            this.subtotalLblLabel.Location = new System.Drawing.Point(6, 107);
            this.subtotalLblLabel.Name = "subtotalLblLabel";
            this.subtotalLblLabel.Size = new System.Drawing.Size(100, 20);
            this.subtotalLblLabel.TabIndex = 6;
            this.subtotalLblLabel.Text = "Subtotal:";
            this.subtotalLblLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxChargesLblLabel
            // 
            this.taxChargesLblLabel.Location = new System.Drawing.Point(6, 77);
            this.taxChargesLblLabel.Name = "taxChargesLblLabel";
            this.taxChargesLblLabel.Size = new System.Drawing.Size(100, 20);
            this.taxChargesLblLabel.TabIndex = 5;
            this.taxChargesLblLabel.Text = "Tax Charges:";
            this.taxChargesLblLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // additionalChargesLblLabel
            // 
            this.additionalChargesLblLabel.Location = new System.Drawing.Point(6, 46);
            this.additionalChargesLblLabel.Name = "additionalChargesLblLabel";
            this.additionalChargesLblLabel.Size = new System.Drawing.Size(100, 20);
            this.additionalChargesLblLabel.TabIndex = 4;
            this.additionalChargesLblLabel.Text = "Additional Charges:";
            this.additionalChargesLblLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomChargesLblLabel
            // 
            this.roomChargesLblLabel.Location = new System.Drawing.Point(6, 16);
            this.roomChargesLblLabel.Name = "roomChargesLblLabel";
            this.roomChargesLblLabel.Size = new System.Drawing.Size(100, 20);
            this.roomChargesLblLabel.TabIndex = 3;
            this.roomChargesLblLabel.Text = "Room Charges:";
            this.roomChargesLblLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 551);
            this.Controls.Add(this.billingSummaryGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.additionalChargesGroupBox);
            this.Controls.Add(this.roomInfoGroupBox);
            this.Controls.Add(this.guestInfoGroupBox);
            this.Controls.Add(this.dateGroupBox);
            this.Controls.Add(this.motorwayMotelLblLabel);
            this.Controls.Add(this.motorwayMotelPictureBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motorway Motel";
            ((System.ComponentModel.ISupportInitialize)(this.motorwayMotelPictureBox)).EndInit();
            this.dateGroupBox.ResumeLayout(false);
            this.dateGroupBox.PerformLayout();
            this.guestInfoGroupBox.ResumeLayout(false);
            this.guestInfoGroupBox.PerformLayout();
            this.roomInfoGroupBox.ResumeLayout(false);
            this.roomInfoGroupBox.PerformLayout();
            this.additionalChargesGroupBox.ResumeLayout(false);
            this.additionalChargesGroupBox.PerformLayout();
            this.billingSummaryGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox motorwayMotelPictureBox;
        private System.Windows.Forms.Label motorwayMotelLblLabel;
        private System.Windows.Forms.GroupBox dateGroupBox;
        private System.Windows.Forms.MaskedTextBox dateMaskedTextBox;
        private System.Windows.Forms.GroupBox guestInfoGroupBox;
        private System.Windows.Forms.TextBox firstTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.GroupBox roomInfoGroupBox;
        private System.Windows.Forms.Label numberOfNightsLabel;
        private System.Windows.Forms.TextBox numberOfNightsTextBox;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.MaskedTextBox roomNumberMaskedTextBox;
        private System.Windows.Forms.TextBox nightlyRateTextBox;
        private System.Windows.Forms.Label nightlyRateLabel;
        private System.Windows.Forms.GroupBox additionalChargesGroupBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.TextBox miniBarTextBox;
        private System.Windows.Forms.Label miniBarLabel;
        private System.Windows.Forms.TextBox miscellaneousTextBox;
        private System.Windows.Forms.Label miscellaneousLabel;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox billingSummaryGroupBox;
        private System.Windows.Forms.Label totalChargesLblLabel;
        private System.Windows.Forms.Label subtotalLblLabel;
        private System.Windows.Forms.Label taxChargesLblLabel;
        private System.Windows.Forms.Label additionalChargesLblLabel;
        private System.Windows.Forms.Label roomChargesLblLabel;
        private System.Windows.Forms.Label totalChargesLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxChargesLabel;
        private System.Windows.Forms.Label additionalChargesLabel;
        private System.Windows.Forms.Label roomChargesLabel;
    }
}

