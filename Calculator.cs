using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calulator
{
    public partial class Calculator : Form
    {
        double firstinput;
        double secondinput;
        double result;
        string function;
        public Calculator()
        {
            InitializeComponent();
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
            {
                displaybox.Text = "1";
            }
            else
            {
                displaybox.Text = displaybox.Text + "1";
            }
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
            {
                displaybox.Text = "2";
            }
            else
            {
                displaybox.Text = displaybox.Text + "2";
            }
        }

        private void btn03_Click(object sender, EventArgs e)
        {
            if ( displaybox.Text == "0" && displaybox.Text !=null )
            {
                displaybox.Text = "3";
            }
            else
            {
                displaybox.Text = displaybox.Text + "3";
            }
        }

        private void btn04_Click_1(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
            {
                displaybox.Text = "4";
            }
            else
            {
                displaybox.Text = displaybox.Text + "4";
            }
        }

        private void btn05_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
            {
                displaybox.Text = "5";
            }
            else
            {
                displaybox.Text = displaybox.Text + "5";
            }
        }

        private void btn06_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null )
            {
                displaybox.Text = "6";
            }
            else
            {
                displaybox.Text = displaybox.Text + "6";
            }
        }

        private void btn07_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
            {
                displaybox.Text = "7";
            }
            else
            {
                displaybox.Text = displaybox.Text + "7";
            }
        }

        private void btn08_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
            {
                displaybox.Text = "8";
            }
            else
            {
                displaybox.Text = displaybox.Text + "8";
            }
        }

        private void btn09_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
            {
                displaybox.Text = "9";
            }
            else
            {
                displaybox.Text = displaybox.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
            {
                displaybox.Text = "0";
            }
            else
            {
                displaybox.Text = displaybox.Text + "0";
            }
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
            {
                displaybox.Text = ".";
            }
            else
            {
                displaybox.Text = displaybox.Text + ".";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            function = "+";
            displaybox.Text = "0";
            firstinput = Convert.ToDouble(displaybox.Text);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            function = "-";
            displaybox.Text = "0";
            firstinput = Convert.ToDouble(displaybox.Text);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            function = "*";
            displaybox.Text = "0";
            firstinput = Convert.ToDouble(displaybox.Text);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            function = "/";
            displaybox.Text = "0";
            firstinput = Convert.ToDouble(displaybox.Text);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            firstinput = Convert.ToDouble(displaybox.Text);
            secondinput = Convert.ToDouble(displaybox.Text);
            if (function == "+")
            {
                result = firstinput + secondinput;
                displaybox.Text = Convert.ToString(result);
                firstinput = result;
            }
            else if(function == "-")
            {
                result = firstinput - secondinput;
                displaybox.Text = Convert.ToString(result);
                firstinput = result; 
            }
            else if (function == "*")
            {
                result = firstinput * secondinput;
                displaybox.Text = Convert.ToString(result);
                firstinput = result;
            }
            else if (function == "/")
            {
                if (secondinput == 0)
                {
                    displaybox.Text = "Can not divided by zero.";
                }
                else
                {
                    result = firstinput / secondinput;
                    displaybox.Text = Convert.ToString(result);
                    firstinput = result;
                }
            }

            else
            {
                displaybox.Text = "Function Error.";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            displaybox.Text = "0";
        }
    }
}
