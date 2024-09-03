// Programmer: Joshua Hariharan
// Project: Lab 3-1
// 10/07/2022
// Form for taking pet order
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_1
{
    public partial class Form1 : Form
    {
        // Execute when form loads at the program startup
        private const decimal FLEA_REMOVAL_PRICE = 5.00m;
        private const decimal NAIL_CLIPPING_PRICE = 4.50m;
        private const decimal SHAMPOO_PRICE = 4.00m;
        private const decimal FUR_TRIMMING_PRICE = 9.00m;
        public Form1()
        {
            InitializeComponent();
        }
        // Activates when form loads in
        private void Form1_Load(object sender, EventArgs e)
        {
            // Assign the prices to labels for the services
            fleaRemovalPLabel.Text = FLEA_REMOVAL_PRICE.ToString("c");
            nailClippingPLabel.Text = NAIL_CLIPPING_PRICE.ToString("c");
            shampooPLabel.Text = SHAMPOO_PRICE.ToString("c");
            furTrimmingPLabel.Text = FUR_TRIMMING_PRICE.ToString("c");
        }
        // Handles the radio button being triggered
        private void otherRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Manage the situation when the other radio button is clicked
            if (otherRadioButton.Checked)
            {
                typeIfOtherLabel.Enabled = true;
                typeIfOtherTextBox.Enabled = true;
                typeIfOtherTextBox.Text = "";
            }
            else
            {
                typeIfOtherLabel.Enabled = false;
                typeIfOtherTextBox.Enabled = false;
                typeIfOtherTextBox.Text = ""; //clear the contents of the textbox
            }

        }
        // Handle the total buton click action
        // Calculate and display the total fee when the button is clicked
        private void totalButton_Click(object sender, EventArgs e)
        {
            // Declare local variable
            decimal totalFee = 0.00m;

            // if blocks are going to be used to handle the calculations,each checkboxs adds its price on to total fee
            if (fleaRemovalCheckBox.Checked)
            {
                totalFee += FLEA_REMOVAL_PRICE;
            }
            if (nailClippingCheckBox.Checked)
            {
                totalFee += NAIL_CLIPPING_PRICE;
            }
            if (shampooCheckBox.Checked)
            {
                totalFee += SHAMPOO_PRICE;
            }
            if (furTrimmingCheckBox.Checked)
            {
                totalFee += FUR_TRIMMING_PRICE;
            }

            {   // Change the total fee text box to currenct
                totalFeeLabel.Text = totalFee.ToString("c");

                // Send Focus to the Clear Button
                clearButton.Focus();
            }

        }
        // Event triggered when clear button is clicked, clears all the text. 
        private void clearButton_Click(object sender, EventArgs e)
        {
            ownerNameTextBox.Text = "";
            ownerPhoneMaskedTextBox.Text = "";
            petNameTextBox.Text = "";
            petDOBMaskedTextBox.Text = "";
            catRadioButton.Checked = true;
            fleaRemovalCheckBox.Checked = false;
            nailClippingCheckBox.Checked = false;
            shampooCheckBox.Checked = false;
            furTrimmingCheckBox.Checked = false;
            totalFeeLabel.Text = "";
        }
        // Quit Button Event, Closes the form
        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
