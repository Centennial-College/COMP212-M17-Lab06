using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kevin_Ma_Lab06_Ex01
{
    public partial class AsynchronousProgrammingForm : Form
    {
        //Declare a delegate type
        delegate bool isEvenOrOdd(int num);

        //Declared for future use
        List<int> intList;
        List<double> dblList;
        List<char> charList;
        Random rng;

        public AsynchronousProgrammingForm()
        {
            InitializeComponent();

            //SECOND GROUP BOX
            //Create delegates that refer to lambda expressions
            isEvenOrOdd isEven = num => num % 2 == 0;
            isEvenOrOdd isOdd = num => num % 2 != 0;

            //Event Handler
            this.checkForEvenOddBtn.Click += (sender, e) =>
            {
                try
                {
                    int input = int.Parse(inputNumberTB.Text);

                    if (isEven(input))
                    {
                        MessageBox.Show($"The number {input} is Even.", "Even Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (isOdd(input))
                    {
                        MessageBox.Show($"The number {input} is Odd.", "Odd Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show($"Please enter an integer into the Input Number TextBox.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.inputNumberTB.Text = string.Empty;
                }
            };
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

        /// <summary>
        /// Asynchronously calculates the factorial of the input value in the getFactorialTB textbox. Only calculates factorial up to 20 since
        /// the Factorial(int num) method was implemented with long data type. The result will be displayed in a MessageBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int input;
                if ((input = int.Parse(this.getFactorialTB.Text)) < 0)  //can raise FormatException if inpt is anything other than integers
                {
                    throw new FormatException();    //raise FormatException for negative integers
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

        /// <summary>
        ///  Generate Values button should generate 10 values(between 10 and 99 and by making use of RNG) depending
        ///  on the selected radio button choice (int, double, char).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generateValuesBtn_Click(object sender, EventArgs e)
        {
            //resets variables
            rng = new Random();
            intList = null;
            dblList = null;
            charList = null;

            if (intRadioBtn.Checked)
            {
                intList = new List<int>(10);
                for (int i = 0; i < 10; i++)
                {
                    intList.Add(rng.Next(10, 100)); //generates random int values between 10 and 99
                }
                this.listDisplayListBox.DataSource = intList;
            }
            else if (doublesRadioBtn.Checked)
            {
                dblList = new List<double>(10);
                for (int i = 0; i < 10; i++)
                {
                    dblList.Add(Math.Round(rng.NextDouble() * (100 - 10) + 10, 2)); //generates random int values between 10 and 99
                }
                this.listDisplayListBox.DataSource = dblList;
            }
            //generateValuesBtn only enabled if one of the three radio buttons are checked
            //so if reaches here, only option is that charRadioBtn is checked
            else
            {
                charList = new List<char>(10);
                for (int i = 0; i < 10; i++)
                {
                    charList.Add((char)rng.Next(65, 123)); //generates random char values from ascii 65 (A) to ascii 122 (z)
                }
                this.listDisplayListBox.DataSource = charList;
            }
        }
    }
}
