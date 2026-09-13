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
    public partial class frmDecimalToBinary : Form
    {
        public frmDecimalToBinary()
        {
            InitializeComponent();
        }

        private void Delete()
        {
            txtDecimalInput.Text = string.Empty;
            lblResultValue.Text = string.Empty;
        }
        private void ConvertDecimalToBinary()
        {
            string DecimalStr;
            DecimalStr = txtDecimalInput.Text;

            int Decimal = Convert.ToInt32(DecimalStr);
            string Binary = "";

            while(Decimal > 0)
            {
                Binary = (Decimal % 2).ToString() + Binary;
                Decimal /= 2;
            }

            lblResultValue.Text = Binary;
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            ConvertDecimalToBinary();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
