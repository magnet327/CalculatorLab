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
        string firstOperand = null, secondOperand = null, result = null;
        bool set1 = false, isSec = false, isTrigger = false, isAns = false, isDot = false, isRes = false;

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (!isAns)
            {
                secondOperand = (float.Parse(firstOperand) * float.Parse(lblDisplay.Text) / 100).ToString();
                lblDisplay.Text = secondOperand;
                isAns = true; isSec = true;
            }
        }

        string op = null;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnX_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (lblDisplay.Text == "0" || isSec)
            {
                lblDisplay.Text = "";
                isSec = false;
            }
            if(set1 == true && isSec == false)
            {
                lblDisplay.Text = "";
                isSec = true;
            }
            if (lblDisplay.Text.Length < 8)
            {
                lblDisplay.Text += btn.Text;
            }
            isTrigger = false; isAns = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length > 1)
            {
                lblDisplay.Text = lblDisplay.Text.Remove(lblDisplay.Text.Length - 1);
            }
            else if (lblDisplay.Text.Length == 1)
            {
                lblDisplay.Text = "0";
            }
                
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!isDot) lblDisplay.Text += ".";
            isDot = true; set1 = false; isAns = false;
        }

        /*private void btnOpt_Click(object sender, EventArgs e)
        {
            Button opr = (Button)sender;

            if (op == null || isTrigger) { firstOperand = lblDisplay.Text; isSec = true; isDot = false; }
            else if (!isTrigger && !isRes) btnEqual_Click(sender, e);
            else if (isRes) isRes = false;
            isSec = true; isTrigger = true; isAns = false;

            if (opr.Text == "-") op = "1";
            else if (opr.Text == "+") op = "2";
            else if (opr.Text == "X") op = "3";
            else if (opr.Text == "÷") op = "4";
        }*/

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Button equal = (Button)sender;
            if (!isAns) secondOperand = lblDisplay.Text;
            if (firstOperand != null && secondOperand != null)
            {
                if (op == "1")
                    result = (float.Parse(firstOperand) - float.Parse(secondOperand)).ToString();

                else if (op == "2")
                    result = (float.Parse(firstOperand) + float.Parse(secondOperand)).ToString();

                else if (op == "3")
                    result = (float.Parse(firstOperand) * float.Parse(secondOperand)).ToString();

                else
                    result = (float.Parse(firstOperand) / float.Parse(secondOperand)).ToString();
                lblDisplay.Text = result;
            }
            if (equal.Text == "=" && !isRes) isRes = true;

            firstOperand = result; isSec = true; isDot = false; isTrigger = false; isAns = true;

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            firstOperand = lblDisplay.Text;
            if (op == null || isTrigger) { firstOperand = lblDisplay.Text; isSec = true; isDot = false; }
            else if (!isTrigger && !isRes) btnEqual_Click(sender, e);
            else if (isRes) isRes = false;
            set1 = false; isSec = true; isTrigger = true; isAns = false;
            op = "1";
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            firstOperand = lblDisplay.Text;
            if (op == null || isTrigger) { firstOperand = lblDisplay.Text; isSec = true; isDot = false; }
            else if (!isTrigger && !isRes) btnEqual_Click(sender, e);
            else if (isRes) isRes = false;
            set1 = false; isSec = true; isTrigger = true; isAns = false;
            op = "2";
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            firstOperand = lblDisplay.Text;
            if (op == null || isTrigger) { firstOperand = lblDisplay.Text; isSec = true; isDot = false; }
            else if (!isTrigger && !isRes) btnEqual_Click(sender, e);
            else if (isRes) isRes = false;
            set1 = false; isSec = true; isTrigger = true; isAns = false;
            op = "3";
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            firstOperand = lblDisplay.Text;
            if (op == null || isTrigger) { firstOperand = lblDisplay.Text; isSec = true; isDot = false; }
            else if (!isTrigger && !isRes) btnEqual_Click(sender, e);
            else if (isRes) isRes = false;
            set1 = false; isSec = true; isTrigger = true; isAns = false;
            op = "4";
        }
       

        
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            op = null;  firstOperand = null; secondOperand = null; set1 = false; isSec = false; isAns = false; isTrigger = false; isDot = false;
        }



    }
}
