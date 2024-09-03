// Programmer: Joshua Hariharan
// Project: Lab 2-1
//Date: 09/14/2022
// Description: Form for taking a carpet order.
using System;
using System.Windows.Forms;

namespace Lab_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        // Perform calculations and display results
        private void calculateButton_Click(object sender, System.EventArgs e)
        {
            // Use try-catch to handle any data entry exceptions
            try
            {
                // Declare local constants
                const decimal TAX_RATE = 0.07m;
                const decimal LABOR_RATE = 0.50m;

                // Declare local variables
                decimal length;          // Lengteh of carpet
                decimal width;           // Width of carpet
                decimal area;            // Area of carpet
                decimal price;          // Price of carpet
                decimal carpetCharge;   // Total price of carpet
                decimal tax;            // Tax on total price of carpet
                decimal laborCharge;    // Labor charge for installing carpet
                decimal orderTotal;     // Total charge for order

                // Get values from text boxes and assign to variables
                length = decimal.Parse(lengthTextBox.Text);
                width = decimal.Parse(widthTextBox.Text);
                price = decimal.Parse(priceTextBox.Text);

                // Calculate and display area of carpet
                area = length * width;
                areaLabel.Text = area.ToString("n3");

                // Calculate and display carpet charge
                carpetCharge = (decimal)area * price;
                carpetChargeLabel.Text = carpetCharge.ToString("c");

                // Calculate and display tax on carpet charge
                tax = carpetCharge * TAX_RATE;
                taxLabel.Text = tax.ToString("c");

                // Calculate and display labor charge
                laborCharge = (decimal)area * LABOR_RATE;
                laborChargeLabel.Text = laborCharge.ToString("c");

                // Calculate and display order total
                orderTotal = carpetCharge + tax + laborCharge;
                orderTotalLabel.Text = orderTotal.ToString("c");
            }
            catch (Exception ex)
            {
                // Display the default error message
                MessageBox.Show(ex.Message);
            }


            }
        }
    }

