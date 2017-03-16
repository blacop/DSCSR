using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitArrayCh.Algo {
    public partial class BitMove : Form {
        public BitMove() { //构造器
            InitializeComponent();
        }


        /// <summary>
        /// 二进制转化器,In Decimal,Out Binary
        /// </summary>
        /// <param name="val">In Decimal</param>
        /// <returns>Out Binary</returns>
        private StringBuilder ConvertBits(int val) { //二进制转化器
            int bitMask = 1 << 31;
            StringBuilder bitBuffer = new StringBuilder(35);
            for (int i = 1; i <= 32; i++) {
                if ((val & bitMask) == 0)
                    bitBuffer.Append("0");
                else
                    bitBuffer.Append("1");
                val <<= 1;
                if ((i % 8) == 0)
                    bitBuffer.Append(" ");
            }
            return bitBuffer;
        } //二进制转化器      
        private void btnLeft_Click(object sender, EventArgs e) {
            //控件位置提醒Integer to shift: txtInt1
            //控件位置提醒Bit to shift: txtBitShift
            //lblOrigBits 是line 1 的32位 二进制数
            //lblInt1Bits 是line 2 的32位 二进制数
            int value = Int32.Parse(txtInt1.Text);
            lblOrigBits.Text = ConvertBits(value).ToString(); //二进制 输出
            value <<= Int32.Parse(txtBitShift.Text); //shift移动 输入框 输入的 位数
            lblInt1Bits.Text = ConvertBits(value).ToString(); //二进制 输出
        }

        private void btnRight_Click(object sender, EventArgs e) {
            int value = Int32.Parse(txtInt1.Text);
            lblOrigBits.Text = ConvertBits(value).ToString(); //二进制 输出
            value >>= Int32.Parse(txtBitShift.Text); //shift移动 输入框 输入的 位数
            lblInt1Bits.Text = ConvertBits(value).ToString(); //二进制 输出
        }

        private void btnClear_Click(object sender, EventArgs e) {
            txtInt1.Text = "";
            txtInt1.Text = "";
            lblOrigBits.Text = "";
            lblOrigBits.Text = "";
            txtInt1.Focus();
        }
    }//public partial class BitMove : Form
}//namespace BitArrayCh.Algo 
