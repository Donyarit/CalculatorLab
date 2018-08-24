using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    

    public partial class Form1 : Form
    {
        string firstOperand;
        double x1;
        double x2;
        double P;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            x1 = 0;
            x2 = 0;
        }
        
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0") 
            {
                lblDisplay.Text = lblDisplay.Text + ".";

            }
           else if(count ==0)
            {
                lblDisplay.Text = lblDisplay.Text + ".";
                count = 1;
            }
            
            
        }
   

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double x2 = double.Parse(lblDisplay.Text);
            if (firstOperand == "+")
            {
                x1 = x1 + x2;
               
            }
            else if (firstOperand == "-")
            {
                x1 = x1 - x2;
               
            }
            else if (firstOperand == "X")
            {
                x1 = x1 * x2;
                
            }
            else if (firstOperand == "÷")
            {
                x1 = x1 / x2;
                

            }
            lblDisplay.Text = x1.ToString();
            if (lblDisplay.Text.Length > 8)
            {
                lblDisplay.Text = "Error";
            }
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length != 8)
            {
                if (lblDisplay.Text == "0")
                {
                    lblDisplay.Text = ((Button)sender).Text;
                }
                else
                {
                    lblDisplay.Text = lblDisplay.Text + ((Button)sender).Text;
                }
            }
            

        }
        
        private void btnOperator_Click(object sender, EventArgs e)
        {
            firstOperand = ((Button)sender).Text;
            x1 = double.Parse(lblDisplay.Text);
            
            
             if (firstOperand == "±")
            {
                x1 = -(x1);
                lblDisplay.Text = x1.ToString();
            }
             else if (firstOperand == "<")
            {
                if (lblDisplay.Text.Length == 1)
                {
                    lblDisplay.Text = "0";

                }
                else
                {
                    lblDisplay.Text = lblDisplay.Text.Remove(lblDisplay.Text.Length - 1);
                    count = 0; 
                }
            }
            else
            {
                lblDisplay.Text = "0";

            }
        }

        private void btnPercentOperator_Click(object sender, EventArgs e)
        {
            P = double.Parse(lblDisplay.Text);
            if(x1 == 0)
            {
                P = P / 100;
            }
            else
            {
                P = (P / 100) * x1;

            }
            lblDisplay.Text = P.ToString();
        }
    }
}
