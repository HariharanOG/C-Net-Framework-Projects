// Programmer: Joshua Hariharan
// Project: Lab 1-2
// Date: 09/02/2022
// Description: Four Seasons Application
using System.Windows.Forms;

namespace Lab_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Displays Fall Image
        private void fallButton_Click(object sender, System.EventArgs e)
        {
            seasonsPictureBox.Image = Lab_1_2.Properties.Resources.Fall;
        }
        // Displays Winter Image
        private void winterButton_Click(object sender, System.EventArgs e)
        {
            seasonsPictureBox.Image = Lab_1_2.Properties.Resources.Winter; 
        }
        // Diplays Spring Image
        private void springButton_Click(object sender, System.EventArgs e)
        {
            seasonsPictureBox.Image = Lab_1_2.Properties.Resources.Spring;
        }
        // Displays Summer Image
        private void summerButton_Click(object sender, System.EventArgs e)
        {
            seasonsPictureBox.Image = Lab_1_2.Properties.Resources.Summer;
        }
        // Closes the form/application
        private void exitButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
