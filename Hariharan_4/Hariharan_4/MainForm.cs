// Programmer: Joshua Hariharan
// Project: Assignment 4
// Date: 12/1/2022
// Description: Individual Assignment 4 Registration Form
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Allow the use of StreamReader and StreamWiter Classes
using System.Security.AccessControl;

namespace Hariharan_4
{
    public partial class MainForm : Form
    {
        // Declare Class Constants
        private const decimal LIVE_ACTION_CLASS_PRICE = 79.95m;
        private const decimal ANIMATION_CLASS_PRICE = 99.95m;
        private const decimal MAXIMUM_CLASSES = 4;

        // Declare Class Variables
        private decimal numberClasses;
        private decimal pricePerClass;
        private decimal totalPrice;
        public MainForm()
        {
            InitializeComponent();
        }
        // Execute code upon the form loading
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Display current date in the registration date
            registrationDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");

            // Array used for storing the contents of the combo box
            string[] status = { "Actor", "Producer", "Director", "Animator", "Cinematographer", "Drama Teacher", "Ligh Technician", "Sound Technician" };

            // load array info into the combo box
            for (int i = 0; i < status.Length; i++)
                statusComboBox.Items.Add(status[i]);

            // Maximum number of classes form constant
            classLabel.Text = "Classes (maximum of " + MAXIMUM_CLASSES + "):";

            // sort classes list box
            classesListBox.Sorted = true;

            // selection mode of the list box
            classesListBox.SelectionMode = SelectionMode.MultiSimple;

            // method to populate the list box
            PopulateList();

            // method to update the totals
            UpdateTotals();

        }
        // events handled when the live action radio button is checked
        private void liveActionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // call on methods
            PopulateList();
            UpdateTotals();
        }
        // events handled when the selction of the classes list box occurs
        private void classesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // call on a method
            UpdateTotals();
        }
        // events handled when the save button in the menu strip is activated
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // declare variables
            string classList = "";
            string paymentType;
            string receiptChoice;

            // else if statment to handle the save events
            if (numberClasses == 0)
            {
                MessageBox.Show("1 class needs to be selected for registration.", "Class Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numberClasses > MAXIMUM_CLASSES)
            {
                MessageBox.Show("More than 4 classes are selected.", "Exceeded Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (firstNameTextBox.Text == "" || lastNameTextBox.Text == "")
            {
                MessageBox.Show("Both First Name and Last Name must be filled in.", "Missing Names", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (emailAddressTextBox.Text == "")
            {
                MessageBox.Show("Email Address must be filled in.", "Missing Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dateOfBirthMaskedTextBox.MaskCompleted == false)
            {
                MessageBox.Show("Date of birth needs to be completed.", "Missing Date of birth", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                // for loop for classes concatenate
                for (int counter = 0; counter < classesListBox.Items.Count; counter++)
                {
                    // get selected function for determining if items in the list box is selected
                    if (classesListBox.GetSelected(counter))
                    {
                        classList += classesListBox.Items[counter] + "\r\n";
                    }
                }
                // value for the payment type selection
                if (cashRadioButton.Checked)
                {
                    paymentType = "cash";
                }
                else
                {
                    paymentType = "Check";
                }

                if (emailCheckbox.Checked)
                {
                    receiptChoice = "True";
                }
                else
                {
                    receiptChoice = "False";
                }

                // Message box to display the summary
                MessageBox.Show(" Registration Summary: \n" + "Registration Date: " + registrationDateMaskedTextBox.Text + "\n" + 
                    "Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n" + "Email Address: " + emailAddressTextBox.Text + "\n" + 
                    "Status: " + statusComboBox.Text + "\n" + "Classes Bought: \n" + classList + "\n" + "Total Classes: " + totalClassesLabel.Text + 
                    "\n" + "Price Per Class: " + pricePerClassLabel.Text + "\n" + "Payment Type: " + paymentType + "\n" + 
                    "Email Reciept: " + receiptChoice, "Registration Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Summary to text document
                try
                {
                    // save details to the registration data txt file
                    StreamWriter outputFile;
                    outputFile = File.AppendText("RegistrationData.txt");
                    outputFile.WriteLine("Registration Summary:");
                    outputFile.WriteLine("Registration Date: " + registrationDateMaskedTextBox.Text);
                    outputFile.WriteLine("Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text);
                    outputFile.WriteLine("Email: " + emailAddressTextBox.Text);
                    outputFile.WriteLine("Date of Birth: " + dateOfBirthMaskedTextBox.Text);
                    outputFile.WriteLine("Status: "+ statusComboBox.Text);
                    outputFile.WriteLine("Classes Bought: " + classList);
                    outputFile.WriteLine("Total Classes: " + totalClassesLabel.Text);
                    outputFile.WriteLine("Price Per Class: " + pricePerClassLabel.Text);
                    outputFile.WriteLine("Total Price: " + totalPriceLabel.Text);
                    outputFile.WriteLine("Payment Type: " + paymentType);
                    outputFile.WriteLine("Email Reciept: " + receiptChoice);
                    outputFile.Close();
                }
                catch (Exception ex)
                {
                    // use of try catch so that the program will display an error is something goes wrong
                    MessageBox.Show(ex.Message);
                }
                // Reset the form after all is done
                ClearForm();
            }
        }
        // Handles the events of the clear form button being clicked
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        // Handles the events of the exit button being clicked
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // if statement to handle if teh person would like to close the form or not
            DialogResult dialog = MessageBox.Show("Would you like to exit the form?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }
        // Actions handled for the about button in the menu strip
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create new instance of the about form
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        // method to populate the form
        private void PopulateList()
        {
            // use of try catch in order to keep the program from crashing
            try
            {
                // opening a text document and reading the contents of it
                StreamReader inputFile;
                if (liveActionRadioButton.Checked)
                {
                    inputFile = File.OpenText("LiveActionClasses.txt");
                    while (!inputFile.EndOfStream)
                    {
                        classesListBox.Items.Add(inputFile.ReadLine());
                    }
                    inputFile.Close();
                }
            }
            catch (Exception ex)
            {
                // display an error if something goes wrong
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }
        // method to update the totals on the form
        private void UpdateTotals()
        {
            // Assigning amounts to variables
            numberClasses = 0.00m;
            totalPrice = 0.00m;

            // class prices assigned depending on the type
            if(liveActionRadioButton.Checked)
            {
                pricePerClass = LIVE_ACTION_CLASS_PRICE;
            }
            else
            {
                pricePerClass = ANIMATION_CLASS_PRICE;
            }

            // count all the items selected in the list box
            for (int counter = 0; counter < totalPrice; counter++)
            {
                if (classesListBox.GetSelected(counter))
                {
                    numberClasses++;
                }
            }
            // Calculate Prices
            totalPrice = numberClasses * pricePerClass;

            // Update the amounts
            totalClassesLabel.Text = numberClasses.ToString();
            pricePerClassLabel.Text = pricePerClass.ToString("c");
            totalPriceLabel.Text = totalPrice.ToString("c");
        }

        // method for clearing the form
        private void ClearForm()
        {
            // Setting the objects back to their original state
            registrationDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            dateOfBirthMaskedTextBox.Text = "";
            emailAddressTextBox.Text = "";
            statusComboBox.Text = "";
            liveActionRadioButton.Checked = true;
            cashRadioButton.Checked = true;
            emailCheckbox.Checked = false;
            classesListBox.ClearSelected();
            UpdateTotals();
            registrationDateMaskedTextBox.Focus();
        }
    }
}
