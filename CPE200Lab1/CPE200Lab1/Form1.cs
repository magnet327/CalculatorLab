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
        string firstOperand = null, secondOperand = null;
        bool set1 = false, start2 = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(lblDisplay.Text == "0" || set1 == true)
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "1";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            if (set1 == true && start2 == false)
            {
                lblDisplay.Text = "";
                start2 = true;
            }
            if (lblDisplay.Text.Length < 8)
            {
                lblDisplay.Text = lblDisplay.Text + btn.Text;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            firstOperand = lblDisplay.Text;
            set1 = true;
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            string result;
            secondOperand = lblDisplay.Text;
            result = (float.Parse(firstOperand) + float.Parse(secondOperand)).ToString();
            lblDisplay.Text = result;
        }
    }
}
