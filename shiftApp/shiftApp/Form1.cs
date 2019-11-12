using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shiftApp
{
    public partial class Form1 : Form
    {
        char[] hexNumCharArray = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

        public Form1()
        {
            InitializeComponent();
        }

        private void rotateBtn_Click(object sender, EventArgs e)
        {
            var num = TxtNumberToBeRotated.Text;
            var key = Convert.ToChar(TxtNumberForRotation.Text);

            /* 
             ushort.Parse(CS, System.Globalization.NumberStyles.HexNumber: convert the hexadecimal string to ushort (int)
             ToString("X4"): Convert the result back to hexadecimal number as string
             */

            TxtRightRotatedNumber.Text = rightRotateShift(ushort.Parse(num, System.Globalization.NumberStyles.HexNumber), key).ToString("X4");
            TxtLeftRotatedNumber.Text = leftRotateShift(ushort.Parse(num, System.Globalization.NumberStyles.HexNumber), key).ToString("X4");
        }

        private static ushort leftRotateShift(ushort usVal, char cCrypt)
        {
            ushort cry;
            ushort i;

            for (i = 0; i < cCrypt; i++)
            {
                if ((usVal & 0x8000) != 0)
                {
                    cry = 1;
                }
                else
                {
                    cry = 0;
                }
                usVal = (ushort)(usVal << 1);
                if (cry == 1)
                {
                    usVal = (ushort)(usVal | 0x0001);
                }
            }
            return (usVal);
        }

        public static ushort rightRotateShift(ushort usVal, char cCrypt)
        {
            ushort cry;
            ushort i;

            for (i = 0; i < cCrypt; i++)
            {
                if ((usVal & 0x0001) != 0)
                {
                    cry = 1;
                }
                else
                {
                    cry = 0;
                }
                usVal = (ushort)(usVal >> 1);
                if (cry == 1)
                {
                    usVal = (ushort)(usVal | 0x8000);
                }
            }
            return (usVal);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            TxtRightRotatedNumber.Text = "";
            TxtLeftRotatedNumber.Text = "";
            TxtNumberForRotation.Text = "";
            TxtNumberToBeRotated.Text = "";
        }

        private void TxtNumberToBeRotated_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (TxtNumberToBeRotated.Text.Length == 5 && !char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //}

            // handle if the character is not control or is not in the hexNumCharArray
            if (!char.IsControl(e.KeyChar) && !hexNumCharArray.Contains(Char.ToUpper(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxtNumberForRotation_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (TxtNumberForRotation.Text.Length == 5 && !char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //}

            // handle if the character is not control or is not in the hexNumCharArray
            if (!char.IsControl(e.KeyChar) && !hexNumCharArray.Contains(Char.ToUpper(e.KeyChar)))
            {
                e.Handled = true;
            }

        }
    }
}
