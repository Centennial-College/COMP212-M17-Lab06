using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kevin_Ma_Lab06_Ex01
{
    public partial class AsynchronousProgrammingForm : Form
    {
        public AsynchronousProgrammingForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Recursive implementation of Factorial method.
        /// </summary>
        /// <param name="num">The nth factorial to be found</param>
        /// <returns>The factorial of the param 'num'</returns>
        private long Factorial(long num)
        {
            // 0! = 1
            if (num == 0)
                return 1;

            /**
             * 1! = 1*1 or 1*0!
             * 2! = 2*1 or 2*1!
             * ...
             * etc.
             */
            return num * Factorial(num - 1);
        }

        //EVENT HANDLERS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void AsynchronousProgrammingForm_Load(object sender, EventArgs e)
        {
            //disable the buttons on form load because should not be able to click them with no input
            calculateBtn.Enabled = false;
            checkForEvenOddBtn.Enabled = false;
            generateValuesBtn.Enabled = false;
            searchBtn.Enabled = false;
            displayBtn.Enabled = false;
        }

        private void getFactorialTB_TextChanged(object sender, EventArgs e)
        {
            //toggles the Enabled for the calculateBtn
            calculateBtn.Enabled = !getFactorialTB.Text.Equals(String.Empty);
        }

        private void inputNumberTB_TextChanged(object sender, EventArgs e)
        {
            //toggles the Enabled for the checkForEvenOddBtn
            checkForEvenOddBtn.Enabled = !inputNumberTB.Text.Equals(String.Empty);
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            //toggles the Enabled for the searchBtn
            searchBtn.Enabled = !searchTB.Text.Equals(String.Empty);
        }

        private void lowIndexTB_TextChanged(object sender, EventArgs e)
        {
            //toggles the Enabled for the displayBtn
            displayBtn.Enabled = !(lowIndexTB.Text.Equals(String.Empty) || highIndexTB.Text.Equals(String.Empty));
        }

        private void highIndexTB_TextChanged(object sender, EventArgs e)
        {
            //toggles the Enabled for the displayBtn
            displayBtn.Enabled = !(lowIndexTB.Text.Equals(String.Empty) || highIndexTB.Text.Equals(String.Empty));
        }

        private void radioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //toggles the Enabled for the generateValuesBtn
            generateValuesBtn.Enabled = intRadioBtn.Checked || doublesRadioBtn.Checked || charRadioBtn.Checked;
        }

        private async void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int input;
                if ((input = int.Parse(this.getFactorialTB.Text)) < 0)
                {
                    throw new FormatException();
                }

                /**
                 * shouldn't calculate factorial whose result larger than long
                 * max value as this would cause overflow and inccorect results
                 * 
                 * in C#, long.MaxValue = 9.223372036854775807e+18
                 * 
                 * 20! = 2.432902008 E+18
                 * 
                 * 21! = 5.109094217 E+19
                 * 
                 * Since we only accept positive integers, we simply need to 
                 * restrict user input to 0-20 since 21! would be larger than
                 * long.MaxValue
                 */
                if (input > 20)
                {
                    throw new InputValueTooLargeException("This program only calculates factorials up to 20.\n\nPlease enter an positive integer less than or equal to 20.");
                }

                long factorialResult = await Task.Run(() => Factorial(input));
                MessageBox.Show($"The factorial of {this.getFactorialTB.Text} is {factorialResult:n0}", "Factorial was Successfully Calculated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //NOTE: n0 gives no digits after dp and adds commas in thousands place for a number
            }
            catch (FormatException)
            {
                MessageBox.Show($"Please enter a positive integer into the Factorial Input TextBox.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InputValueTooLargeException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.getFactorialTB.Text = string.Empty;
            }
        }
    }
}
