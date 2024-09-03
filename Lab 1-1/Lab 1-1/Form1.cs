// Programmer: Joshua Hariharan
// Project: Lab 1-1
// Date: 09/02/2022
// Description: Displays a greeting to the user.
using System.Windows.Forms;

namespace Lab_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Display a message when clicking on the button as well using the textbox text in the message
        private void greetingButton_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Hello, " + firstNameTextBox.Text + "! Welcome to my program!");
        }
        //Closes the form
        private void quitButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
