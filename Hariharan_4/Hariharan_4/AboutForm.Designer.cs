namespace Hariharan_4
{
    partial class AboutForm
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
            this.schoolPictureBox = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.schoolPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // schoolLabel
            // 
            this.schoolLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.schoolLabel.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolLabel.Location = new System.Drawing.Point(179, 13);
            this.schoolLabel.Name = "schoolLabel";
            this.schoolLabel.Size = new System.Drawing.Size(239, 108);
            this.schoolLabel.TabIndex = 3;
            this.schoolLabel.Text = "Hopkins Film School";
            this.schoolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // schoolPictureBox
            // 
            this.schoolPictureBox.Image = global::Hariharan_4.Properties.Resources.article_full_1x;
            this.schoolPictureBox.Location = new System.Drawing.Point(12, 12);
            this.schoolPictureBox.Name = "schoolPictureBox";
            this.schoolPictureBox.Size = new System.Drawing.Size(161, 109);
            this.schoolPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.schoolPictureBox.TabIndex = 2;
            this.schoolPictureBox.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(179, 143);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 202);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.schoolLabel);
            this.Controls.Add(this.schoolPictureBox);
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            ((System.ComponentModel.ISupportInitialize)(this.schoolPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label schoolLabel;
        private System.Windows.Forms.PictureBox schoolPictureBox;
        private System.Windows.Forms.Button closeButton;
    }
}