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
        private void ConvertBinaryToDecimal()
        {
            string BinaryStr;
            BinaryStr = txtBinaryInput.Text;

            long DecimalNum = 0;
            long Base = 1;

            for(int i = BinaryStr.Length - 1; i >= 0; i--)
            {
                if(BinaryStr[i] == '1')
                {
                    DecimalNum += Base;
                }

                Base *= 2;
            }

            lblResultValue.Text = Convert.ToString(DecimalNum);
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
