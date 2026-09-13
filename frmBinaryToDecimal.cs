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
    public partial class frmBinaryToDecimal : Form
    {
        public frmBinaryToDecimal()
        {
            InitializeComponent();
        }
        private bool Detecting_A_Non_Binary_Number(string S)
        {
            for(int i = 0; i < S.Length; i++)
            {
                if (S[i] != '0' && S[i] != '1')
                {
                    return true;
                }
            }

            return false;
        }
        private void ConvertBinaryToDecimal()
        {
            string BinaryStr;
            BinaryStr = txtBinaryInput.Text;

            if (!Detecting_A_Non_Binary_Number(BinaryStr))
            {
                long DecimalNum = 0;
                long Base = 1;

                for (int i = BinaryStr.Length - 1; i >= 0; i--)
                {
                    if (BinaryStr[i] == '1')
                    {
                        DecimalNum += Base;
                    }

                    Base *= 2;
                }

                lblResultValue.Text = Convert.ToString(DecimalNum);
            }

            else
            {
                MessageBox.Show("Wrong Binary Number !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Delete()
        {
            txtBinaryInput.Text = "";
            lblResultValue.Text = "";
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            ConvertBinaryToDecimal();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
