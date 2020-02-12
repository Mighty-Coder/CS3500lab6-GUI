using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UserInput_TextChanged(object sender, EventArgs e)
        {
            double input = double.Parse(UserInputTextbox.Text);
            input = input * 1.2;
            OutputTextbox.Text = input.ToString();
        }

        private void GetTotal_Click(object sender, EventArgs e)
        {
            double input; 
            if (double.TryParse(UserInputTextbox.Text, out input)) {
                input = input * 1.2;
                OutputTextbox.Text = input.ToString();
            } else 
            {
                MessageBox.Show("Bad input, please try again with numbers");
            } 
        }
    }
}
