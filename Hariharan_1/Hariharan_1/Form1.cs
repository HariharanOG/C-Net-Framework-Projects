// Programmer: Joshua Hariharan
// Project: Assignment 1 Joshua Hariharan
// Date: 9/21/2022
// Description: Individual Assignment #1
using System.Windows.Forms;

namespace Hariharan_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Calculations for when the total button is pressed
        private void totalButton_Click(object sender, System.EventArgs e)
        {
            // Try catch used in case if string is put in the place of a decimal
            try
            {
                // Declare Local Constant
                const decimal TAX_RATE = 0.07m;

                // Declare local variables
                decimal nights;         // Number of nights
                decimal rate;           // Price per night
                decimal minibar;        // Minibar charges
                decimal telephone;      // Telephone charges
                decimal miscellaneous;  // Miscellaneous charges
                decimal room;           // Room Charges
                decimal additional;     // Aditional Charges
                decimal tax;            // Tax Charges
                decimal subtotal;       // Subtotal
                decimal total;          // Total Charges

                // Get values from textboxes and assign them
                nights = decimal.Parse(numberOfNightsTextBox.Text);
                rate = decimal.Parse(nightlyRateTextBox.Text);
                minibar = decimal.Parse(miniBarTextBox.Text);
                telephone = decimal.Parse(telephoneTextBox.Text);
                miscellaneous = decimal.Parse(miscellaneousTextBox.Text);

                // Calculate Room Charges
                room = rate * nights;
                roomChargesLabel.Text = room.ToString("c");

                // Calculate Additional Charges
                additional = minibar + telephone + miscellaneous;
                additionalChargesLabel.Text = additional.ToString("c");

                // Calculate Tax Charges
                tax = (additional + room) * TAX_RATE;
                taxChargesLabel.Text = tax.ToString("c");

                // Calculate Subtotal
                subtotal = additional + room;
                subtotalLabel.Text = subtotal.ToString("c");

                // Total Charges
                total = subtotal + tax;
                totalChargesLabel.Text = total.ToString("c");
            }
            catch (System.Exception ex )
            {
                // Display the default error message
                MessageBox.Show(ex.Message);
            }
            }
        // Clear Inputs
        private void clearButton_Click(object sender, System.EventArgs e)
        {
            dateMaskedTextBox.Text = "";
            firstTextBox.Text = "";
            lastNameTextBox.Text = "";
            roomNumberMaskedTextBox.Text = "";
            numberOfNightsTextBox.Text = "";
            nightlyRateTextBox.Text = "";
            miniBarTextBox.Text = "";
            telephoneTextBox.Text = "";
            miscellaneousTextBox.Text = "";
            roomChargesLabel.Text = "";
            additionalChargesLabel.Text = "";
            taxChargesLabel.Text = "";
            subtotalLabel.Text = "";
            totalChargesLabel.Text = "";

            // Set Focus to first input control
            dateMaskedTextBox.Focus();
        }
        // Display message when help is clicked
        private void helpButton_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Enter all the information into each text box so that the program can calculate your fees.");
        }
        // Close the form
        private void exitButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
    }

