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
        bool set1 = false, isSec = false, check = false, isAns = false, isDot = false, isRes = false;
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
            check = false; isAns = false;
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

        private void btnEqual_Click(object sender, EventArgs e)
        {
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
            if (!isRes) isRes = true;

            firstOperand = result; isSec = true; isDot = false; check = false; isAns = true;

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            firstOperand = lblDisplay.Text;
            if (op == null || check) { isSec = true; isDot = false; }
            else if (!check && !isRes) btnEqual_Click(sender, e);
            isRes = false; set1 = false; isSec = true; check = true; isAns = false;
            op = "1";
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            firstOperand = lblDisplay.Text;
            if (op == null || check) { isSec = true; isDot = false; }
            else if (!check && !isRes) btnEqual_Click(sender, e);
            set1 = false; isSec = true; check = true; isAns = false; isRes = false;
            op = "2";
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            firstOperand = lblDisplay.Text;
            if (op == null || check) { isSec = true; isDot = false; }
            else if (!check && !isRes) btnEqual_Click(sender, e);
            isRes = false; set1 = false; isSec = true; check = true; isAns = false;
            op = "3";
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            firstOperand = lblDisplay.Text;
            if (op == null || check) { isSec = true; isDot = false; }
            else if (!check && !isRes) btnEqual_Click(sender, e);
            isRes = false; set1 = false; isSec = true; check = true; isAns = false;
            op = "4";
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (!isAns)
            {
                secondOperand = (float.Parse(firstOperand) * float.Parse(lblDisplay.Text) / 100).ToString();
                lblDisplay.Text = secondOperand;
                isAns = true; isSec = true;
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            op = null;  firstOperand = null; secondOperand = null; set1 = false; isSec = false; isAns = false; check = false; isDot = false;
        }



    }
}
