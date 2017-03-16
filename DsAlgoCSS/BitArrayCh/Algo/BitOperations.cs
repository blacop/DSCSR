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
    //按位运算，窗体程序，And,Or,Xor
    public partial class BitOperations : Form {
        public BitOperations() { //构造器
            InitializeComponent();
        } //构造器

        //程序的主体部分，for语句从 1 递增 到32，一共16次对二进制数的每一位的判断作操作。
        //循环体内部的条件判断用到了位运算中的&运算（与运算）和<<运算（左移运算）。
        // <<运算表示把1的二进制形式整体向左移j位，左移后低位补0，移出的高位部分被舍弃。
        //例如，当j为15时，表达式（1<<j）的值为1000000000000000；当j为10时，值为0000010000000000。
        //所以 i & （1<<j）的值相当于把i的二进制的第j位取出来（i的第j位与（1<<j）的第j位（由上述可以，为1）作与运算，
        //只有当i的第j位为1时值为真）。循环后既得i的二进制形式。
        private StringBuilder ConvertBits(int val) { //转换器
            int bitmask = 1 << 31; //位掩码,左移31位
            StringBuilder bitBuffer = new StringBuilder(35);
            for (int i = 1; i <= 32; i++) { //从左到右遍历
                if ((val & bitmask) == 0) //Bit And Compute ，作与运算，只有为1才能输出，这样就是按照二进制原样输出了，头一位是符号位，0为正数，1为负数，负数是补码（反码+1）
                    bitBuffer.Append("0");
                else
                    bitBuffer.Append("1");//从最高位开始按位取 二进制数
                val <<= 1;//左移1位 后 重新赋值 //从最高位从左往右开始按位取 二进制数

                if ((i % 8) == 0) //mod 8 ,append space
                    bitBuffer.Append(" ");
            }
            return bitBuffer;
        } //转换器//StringBuilder

        private void btnClear_Click(object sender, EventArgs e) { //Clear
            txtInt1.Text = "";
            txtInt2.Text = "";
            lblInt1Bits.Text = "";
            lblInt2Bits.Text = "";
            lblBitResult.Text = "";
            txtInt1.Focus();
        } //Clear

        private void btnAnd_Click(object sender, EventArgs e) { //And
            int val1, val2;
            val1 = Int32.Parse(txtInt1.Text);
            val2 = Int32.Parse(txtInt2.Text);
            lblInt1Bits.Text = ConvertBits(val1).ToString();
            lblInt2Bits.Text = ConvertBits(val2).ToString();
            lblBitResult.Text = ConvertBits(val1 & val2).ToString();
        } //And
        private void btnOr_Click(object sender, EventArgs e) { //Or
            int val1, val2;
            val1 = Int32.Parse(txtInt1.Text);
            val2 = Int32.Parse(txtInt2.Text);
            lblInt1Bits.Text = ConvertBits(val1).ToString();
            lblInt2Bits.Text = ConvertBits(val2).ToString();
            lblBitResult.Text = ConvertBits(val1 | val2).ToString();
        } //Or
        private void btnXor_Click(object sender, EventArgs e) { //Xor
            int val1, val2;
            val1 = Int32.Parse(txtInt1.Text);
            val2 = Int32.Parse(txtInt2.Text);
            lblInt1Bits.Text = ConvertBits(val1).ToString();
            lblInt2Bits.Text = ConvertBits(val2).ToString();
            lblBitResult.Text = ConvertBits(val1 ^ val2).ToString(); //Xor异或
        } //Xor
    }
}
