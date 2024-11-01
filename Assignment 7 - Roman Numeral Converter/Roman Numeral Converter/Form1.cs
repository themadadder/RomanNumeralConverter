using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roman_Numeral_Converter
{
    public partial class romanNumeralConverter : Form
    {
        public romanNumeralConverter()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(inputNumber.Text);
            
            if (input == 1)
            {
                numberOutputLabel.Text = "I";
            }
            else if (input == 2)
            {
                numberOutputLabel.Text = "II";
            }
            else if (input == 3)
            {
                numberOutputLabel.Text = "III";
            }
            else if (input == 4)
            {
                numberOutputLabel.Text = "IV";
            }
            else if (input == 5)
            {
                numberOutputLabel.Text = "V";
            }
            else if (input == 6)
            {
                numberOutputLabel.Text = "VI";
            }
            else if (input == 7)
            {
                numberOutputLabel.Text = "VII";
            }
            else if (input == 8)
            {
                numberOutputLabel.Text = "VIII";
            }
            else if (input == 9)
            {
                numberOutputLabel.Text = "IX";
            }
            else if (input == 10)
            {
                numberOutputLabel.Text = "X";
            }
            else
            {
                MessageBox.Show("Input error, please enter a number 1 - 10");
            }
               
        }
    }
}
