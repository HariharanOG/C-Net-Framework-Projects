namespace Lab_1_2
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
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.fallButton = new System.Windows.Forms.Button();
            this.winterButton = new System.Windows.Forms.Button();
            this.springButton = new System.Windows.Forms.Button();
            this.summerButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.seasonsPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.seasonsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.Location = new System.Drawing.Point(28, 50);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(116, 20);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Choose a Season";
            // 
            // fallButton
            // 
            this.fallButton.Location = new System.Drawing.Point(44, 88);
            this.fallButton.Name = "fallButton";
            this.fallButton.Size = new System.Drawing.Size(75, 23);
            this.fallButton.TabIndex = 1;
            this.fallButton.Text = "Fall";
            this.fallButton.UseVisualStyleBackColor = true;
            this.fallButton.Click += new System.EventHandler(this.fallButton_Click);
            // 
            // winterButton
            // 
            this.winterButton.Location = new System.Drawing.Point(44, 131);
            this.winterButton.Name = "winterButton";
            this.winterButton.Size = new System.Drawing.Size(75, 23);
            this.winterButton.TabIndex = 2;
            this.winterButton.Text = "Winter";
            this.winterButton.UseVisualStyleBackColor = true;
            this.winterButton.Click += new System.EventHandler(this.winterButton_Click);
            // 
            // springButton
            // 
            this.springButton.Location = new System.Drawing.Point(44, 174);
            this.springButton.Name = "springButton";
            this.springButton.Size = new System.Drawing.Size(75, 25);
            this.springButton.TabIndex = 3;
            this.springButton.Text = "Spring";
            this.springButton.UseVisualStyleBackColor = true;
            this.springButton.Click += new System.EventHandler(this.springButton_Click);
            // 
            // summerButton
            // 
            this.summerButton.Location = new System.Drawing.Point(44, 219);
            this.summerButton.Name = "summerButton";
            this.summerButton.Size = new System.Drawing.Size(75, 23);
            this.summerButton.TabIndex = 4;
            this.summerButton.Text = "Summer";
            this.summerButton.UseVisualStyleBackColor = true;
            this.summerButton.Click += new System.EventHandler(this.summerButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(213, 322);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // seasonsPictureBox
            // 
            this.seasonsPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seasonsPictureBox.Image = global::Lab_1_2.Properties.Resources.Winter;
            this.seasonsPictureBox.Location = new System.Drawing.Point(163, 50);
            this.seasonsPictureBox.Name = "seasonsPictureBox";
            this.seasonsPictureBox.Size = new System.Drawing.Size(181, 240);
            this.seasonsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.seasonsPictureBox.TabIndex = 6;
            this.seasonsPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 392);
            this.Controls.Add(this.seasonsPictureBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.summerButton);
            this.Controls.Add(this.springButton);
            this.Controls.Add(this.winterButton);
            this.Controls.Add(this.fallButton);
            this.Controls.Add(this.instructionsLabel);
            this.Name = "Form1";
            this.Text = "The Four Seasons";
            ((System.ComponentModel.ISupportInitialize)(this.seasonsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button fallButton;
        private System.Windows.Forms.Button winterButton;
        private System.Windows.Forms.Button springButton;
        private System.Windows.Forms.Button summerButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox seasonsPictureBox;
    }
}

