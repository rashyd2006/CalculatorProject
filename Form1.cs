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
                lblScreen.Text += Num1;
            }

            else
            {
                if (Num2 == "")
                {
                    lblScreen.Text = "";
                }

                Num2 += Num;
                lblScreen.Text += Num2;
            }
        }
    }
}
