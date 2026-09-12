using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateorProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Num1 = "";
        private string Num2 = "";
        private string Operation = "";

        private void EnterTheFirstAndSecondNumbers(string Num)
        {
            if (Operation == "")
            {
                Num1 += Num;
                lblScreen.Text = Num1;
            }

            else
            {
                if (Num2 == "")
                {
                    lblScreen.Text = "";
                }

                Num2 += Num;
                lblScreen.Text = Num2;
            }
        }

        private void CalculatingAndDisplayingTheResult()
        {
            int Result = 0;

            if(Operation == "+")
            {
                Result = Convert.ToInt32(Num1) + Convert.ToInt32(Num2);
            }

            else if(Operation == "-")
            {
                Result = Convert.ToInt32(Num1) - Convert.ToInt32(Num2);
            }

            else if(Operation == "×")
            {
                Result = Convert.ToInt32(Num1) * Convert.ToInt32(Num2);
            }

            else
            {
                Result = Convert.ToInt32(Num1) / Convert.ToInt32(Num2);
            }

            lblScreen.Text = Result.ToString();
        }

        private void ClearCalculator()
        {
            Num1 = "";
            Num2 = "";
            Operation = "";
            lblScreen.Text = "";
        }

        private void btnNum_7_Click(object sender, EventArgs e)
        {
            EnterTheFirstAndSecondNumbers("7");
        }

        private void btnNum_8_Click(object sender, EventArgs e)
        {
            EnterTheFirstAndSecondNumbers("8");
        }

        private void btnNum_9_Click(object sender, EventArgs e)
        {
            EnterTheFirstAndSecondNumbers("9");
        }

        private void btnNum_4_Click(object sender, EventArgs e)
        {
            EnterTheFirstAndSecondNumbers("4");
        }

        private void btnNum_5_Click(object sender, EventArgs e)
        {
            EnterTheFirstAndSecondNumbers("5");
        }

        private void btnNum_6_Click(object sender, EventArgs e)
        {
            EnterTheFirstAndSecondNumbers("6");
        }

        private void btnNum_1_Click(object sender, EventArgs e)
        {
            EnterTheFirstAndSecondNumbers("1");
        }

        private void btnNum_2_Click(object sender, EventArgs e)
        {
            EnterTheFirstAndSecondNumbers("2");
        }

        private void btnNum_3_Click(object sender, EventArgs e)
        {
            EnterTheFirstAndSecondNumbers("3");
        }

        private void btnNum_0_Click(object sender, EventArgs e)
        {
            EnterTheFirstAndSecondNumbers("0");
        }

        private void btnOp_Div_Click(object sender, EventArgs e)
        {
            Operation = "/";
        }

        private void btnOp_Addition_Click(object sender, EventArgs e)
        {
            Operation = "+";
        }

        private void btnOp_Sub_Click(object sender, EventArgs e)
        {
            Operation = "-";
        }

        private void btnOp_Multi_Click(object sender, EventArgs e)
        {
            Operation = "×";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            CalculatingAndDisplayingTheResult();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearCalculator();
        }
    }
}
