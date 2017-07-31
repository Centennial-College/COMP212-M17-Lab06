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
    }
}
