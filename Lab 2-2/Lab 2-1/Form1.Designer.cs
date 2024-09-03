using System;

namespace Lab_2_1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.areaLabel = new System.Windows.Forms.Label();
            this.carpetChargeLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.laborChargeLabel = new System.Windows.Forms.Label();
            this.orderTotalLabel = new System.Windows.Forms.Label();
            this.areaLblLabel = new System.Windows.Forms.Label();
            this.carpetChargeLblLabel = new System.Windows.Forms.Label();
            this.taxLblLabel = new System.Windows.Forms.Label();
            this.laborChargeLblLabel = new System.Windows.Forms.Label();
            this.orderTotalLblLabel = new System.Windows.Forms.Label();
            this.dividerGroupBox = new System.Windows.Forms.GroupBox();
            this.dividerGroupBox2 = new System.Windows.Forms.GroupBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.titleLabel.Location = new System.Drawing.Point(82, 29);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(240, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Carpet Calculator";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lengthLabel
            // 
            this.lengthLabel.Location = new System.Drawing.Point(21, 79);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(81, 33);
            this.lengthLabel.TabIndex = 1;
            this.lengthLabel.Text = "Carpet Length (feet):";
            this.lengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // widthLabel
            // 
            this.widthLabel.Location = new System.Drawing.Point(156, 79);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(95, 33);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Carpet Width (feet):";
            this.widthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceLabel
            // 
            this.priceLabel.Location = new System.Drawing.Point(308, 79);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(81, 33);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Carpet Price ($/sq.ft)";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(24, 125);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(78, 20);
            this.lengthTextBox.TabIndex = 2;
            this.lengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(159, 125);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(92, 20);
            this.widthTextBox.TabIndex = 4;
            this.widthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(311, 125);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(78, 20);
            this.priceTextBox.TabIndex = 6;
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // areaLabel
            // 
            this.areaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.areaLabel.Location = new System.Drawing.Point(311, 178);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(76, 23);
            this.areaLabel.TabIndex = 7;
            this.areaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // carpetChargeLabel
            // 
            this.carpetChargeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carpetChargeLabel.Location = new System.Drawing.Point(311, 220);
            this.carpetChargeLabel.Name = "carpetChargeLabel";
            this.carpetChargeLabel.Size = new System.Drawing.Size(76, 23);
            this.carpetChargeLabel.TabIndex = 8;
            // 
            // taxLabel
            // 
            this.taxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxLabel.Location = new System.Drawing.Point(311, 262);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(76, 23);
            this.taxLabel.TabIndex = 9;
            // 
            // laborChargeLabel
            // 
            this.laborChargeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborChargeLabel.Location = new System.Drawing.Point(311, 304);
            this.laborChargeLabel.Name = "laborChargeLabel";
            this.laborChargeLabel.Size = new System.Drawing.Size(76, 23);
            this.laborChargeLabel.TabIndex = 10;
            // 
            // orderTotalLabel
            // 
            this.orderTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderTotalLabel.Location = new System.Drawing.Point(311, 346);
            this.orderTotalLabel.Name = "orderTotalLabel";
            this.orderTotalLabel.Size = new System.Drawing.Size(76, 23);
            this.orderTotalLabel.TabIndex = 11;
            // 
            // areaLblLabel
            // 
            this.areaLblLabel.Location = new System.Drawing.Point(156, 178);
            this.areaLblLabel.Name = "areaLblLabel";
            this.areaLblLabel.Size = new System.Drawing.Size(110, 23);
            this.areaLblLabel.TabIndex = 12;
            this.areaLblLabel.Text = "Carpet Area (sq.ft):";
            this.areaLblLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carpetChargeLblLabel
            // 
            this.carpetChargeLblLabel.Location = new System.Drawing.Point(156, 220);
            this.carpetChargeLblLabel.Name = "carpetChargeLblLabel";
            this.carpetChargeLblLabel.Size = new System.Drawing.Size(110, 23);
            this.carpetChargeLblLabel.TabIndex = 13;
            this.carpetChargeLblLabel.Text = "Carpet Charge:";
            this.carpetChargeLblLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxLblLabel
            // 
            this.taxLblLabel.Location = new System.Drawing.Point(114, 262);
            this.taxLblLabel.Name = "taxLblLabel";
            this.taxLblLabel.Size = new System.Drawing.Size(152, 23);
            this.taxLblLabel.TabIndex = 14;
            this.taxLblLabel.Text = "Sales Tax (7.0%) on Carpet: ";
            this.taxLblLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laborChargeLblLabel
            // 
            this.laborChargeLblLabel.Location = new System.Drawing.Point(107, 304);
            this.laborChargeLblLabel.Name = "laborChargeLblLabel";
            this.laborChargeLblLabel.Size = new System.Drawing.Size(159, 23);
            this.laborChargeLblLabel.TabIndex = 15;
            this.laborChargeLblLabel.Text = "Labor Charge ($0.50 / sq.ft):";
            this.laborChargeLblLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderTotalLblLabel
            // 
            this.orderTotalLblLabel.Location = new System.Drawing.Point(156, 346);
            this.orderTotalLblLabel.Name = "orderTotalLblLabel";
            this.orderTotalLblLabel.Size = new System.Drawing.Size(110, 23);
            this.orderTotalLblLabel.TabIndex = 16;
            this.orderTotalLblLabel.Text = "ORDER TOTAL:";
            this.orderTotalLblLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividerGroupBox
            // 
            this.dividerGroupBox.Location = new System.Drawing.Point(0, 151);
            this.dividerGroupBox.Name = "dividerGroupBox";
            this.dividerGroupBox.Size = new System.Drawing.Size(410, 3);
            this.dividerGroupBox.TabIndex = 17;
            this.dividerGroupBox.TabStop = false;
            // 
            // dividerGroupBox2
            // 
            this.dividerGroupBox2.Location = new System.Drawing.Point(0, 373);
            this.dividerGroupBox2.Name = "dividerGroupBox2";
            this.dividerGroupBox2.Size = new System.Drawing.Size(410, 3);
            this.dividerGroupBox2.TabIndex = 18;
            this.dividerGroupBox2.TabStop = false;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(27, 392);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 19;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(159, 392);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(92, 23);
            this.clearButton.TabIndex = 20;
            this.clearButton.Text = "Clea&r";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(311, 392);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 21;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 459);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.dividerGroupBox2);
            this.Controls.Add(this.dividerGroupBox);
            this.Controls.Add(this.orderTotalLblLabel);
            this.Controls.Add(this.laborChargeLblLabel);
            this.Controls.Add(this.taxLblLabel);
            this.Controls.Add(this.carpetChargeLblLabel);
            this.Controls.Add(this.areaLblLabel);
            this.Controls.Add(this.orderTotalLabel);
            this.Controls.Add(this.laborChargeLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.carpetChargeLabel);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Carpet Kingdom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Label carpetChargeLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label laborChargeLabel;
        private System.Windows.Forms.Label orderTotalLabel;
        private System.Windows.Forms.Label areaLblLabel;
        private System.Windows.Forms.Label carpetChargeLblLabel;
        private System.Windows.Forms.Label taxLblLabel;
        private System.Windows.Forms.Label laborChargeLblLabel;
        private System.Windows.Forms.Label orderTotalLblLabel;
        private System.Windows.Forms.GroupBox dividerGroupBox;
        private System.Windows.Forms.GroupBox dividerGroupBox2;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

