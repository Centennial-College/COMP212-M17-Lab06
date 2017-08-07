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

        /**
         * need to have this because the radioBtn checked may not neccessarily be the list currently on focus
         * in the list box
         * 
         * e.g. Consider checking char radio button but not pressing generate values, then the previously generated
         * list would still be the focus for the search and display functionalities. 
         * 
         * This is why we need this variable in order to help us determine which list to query/display from.
         */
        char currentListType;

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

            //disable searching and displaying values from list by default because the list is empty initially
            this.searchTB.Enabled = false;
            this.lowIndexTB.Enabled = false;
            this.highIndexTB.Enabled = false;
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
                currentListType = 'i';
            }
            else if (doublesRadioBtn.Checked)
            {
                dblList = new List<double>(10);
                for (int i = 0; i < 10; i++)
                {
                    dblList.Add(Math.Round(rng.NextDouble() * (100 - 10) + 10, 2)); //generates random int values between 10 and 99
                }
                this.listDisplayListBox.DataSource = dblList;
                currentListType = 'd';
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
                currentListType = 'c';
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            bool searchValueFound;
            //restrict input depending on the radio button checked
            try
            {
                if (currentListType == 'i')
                {
                    int searchInputValue = int.Parse(this.searchTB.Text);
                    searchValueFound = SearchData(intList, searchInputValue);
                }
                else if (currentListType == 'd')
                {
                    double searchInputValue = double.Parse(this.searchTB.Text);
                    searchValueFound = SearchData(dblList, searchInputValue);
                }
                else //currentListType=='c'
                {
                    char searchInputValue = char.Parse(this.searchTB.Text);
                    searchValueFound = SearchData(charList, searchInputValue);
                }

                MessageBox.Show($"The search value {this.searchTB.Text} was " + (searchValueFound ? "" : "not ") + "found in the list.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a(n) " +
                   (currentListType == 'i' ? "integer" : currentListType == 'd' ? "double" : "character") +
                    " value into the Search Input TextBox.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SearchData<T>(List<T> list, T searchValue)
        {
            return list.Contains(searchValue);
        }

        /// <summary>
        /// only enable searching and displaying values from the list after a list has been generated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listDisplayListBox_DataSourceChanged(object sender, EventArgs e)
        {
            if (listDisplayListBox.DataSource != null)
            {
                this.searchTB.Enabled = true;
                this.lowIndexTB.Enabled = true;
                this.highIndexTB.Enabled = true;
            }
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int lowIndex = int.Parse(this.lowIndexTB.Text);
                int highIndex = int.Parse(this.highIndexTB.Text);

                //there are only 10 elements in the generated lists
                if (lowIndex < 0 || lowIndex > 9 || highIndex < 0 || highIndex > 9)
                    throw new FormatException();

                if (highIndex < lowIndex)
                {
                    throw new IndexOutOfRangeException("High Index must be greater than or equal to low index!");
                }

                switch (currentListType)
                {
                    case 'i':
                        this.displayListBox.DataSource = PrintData(intList, lowIndex, highIndex); break;
                    case 'd':
                        this.displayListBox.DataSource = PrintData(dblList, lowIndex, highIndex); break;
                    default:
                        this.displayListBox.DataSource = PrintData(charList, lowIndex, highIndex); break;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter positive integers between 0 and 9 into the Index Input TextBoxes.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private List<T> PrintData<T>(List<T> list, int lowIndex, int highIndex)
        {
            return list.GetRange(lowIndex, highIndex - lowIndex + 1);
        }
    }
}
