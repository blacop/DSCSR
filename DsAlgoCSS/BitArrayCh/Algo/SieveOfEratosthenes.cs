using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitArrayCh.Algo {
    public partial class SieveOfEratosthenes : Form {
        public SieveOfEratosthenes() { //构造器
            InitializeComponent();
        } //构造器        
        private StringBuilder ConvertBits(int val) { //二进制转化器，进int,出string
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
        } //二进制转化器，进int,出string

        public static void IntArrayToBitArrayExp() { //IntArrayToBitArrayExp By Lambda表达式
            //参考文献
            //delegate and event totuial,委托 和 事件 教程
            //http://www.cnblogs.com/hyddd/archive/2009/07/26/1531538.html
            //lanmbda totuial,lanmbda 教程
            //http://www.cnblogs.com/kingmoon/archive/2011/05/03/2035696.html
            //c#中怎么用int转换成BitArray
            //https://zhidao.baidu.com/question/298885026.html

            // C#的Lambda 表达式都使用 Lambda 运算符 =>，该运算符读为“goes to”。语法如下：
            //形参列表=>函数体
            //函数体多于一条语句的可用大括号括起。

            //    lambda运算符：所有的lambda表达式都是用新的lambda运算符 " => ",可以叫他，“转到”或者 “成为”。
            //运算符将表达式分为两部分，左边指定输入参数，右边是lambda的主体。
            //lambda表达式：
            //       1.一个参数：param => expr
            //       2.多个参数：（param - list）=>expr
            //  上面这些东西，记着，下面我们开始应用并阐述lambda，让你乐在其中。

            //"Lambda表达式"是一个匿名函数，是一种高效的类似于函数式编程的表达式，
            //Lambda简化了开发中需要编写的代码量。
            //它可以包含表达式和语句，并且可用于创建委托或表达式目录树类型，
            //支持带有可绑定到委托或表达式树的输入参数的内联表达式。
            //所有Lambda表达式都使用Lambda运算符 =>，该运算符读作"goes to"。
            //Lambda运算符的左边是输入参数(如果有)，
            //右边是表达式或语句块。Lambda表达式x => x * x读作"x goes to x times x"。
            //可以将此表达式分配给委托类型，如下所示

            //这里Lambda的表达式 表示 Src表 到 Rst表 的 一一映射
            int[] values = { -1, 2, 3, 0, -4 };
            BitArray bitValues = new BitArray(values.Select(x => x >= 0).ToArray());
            foreach (bool bitValue in bitValues)
                Console.WriteLine(bitValue);
            Console.ReadKey();
        }//IntArrayToBitArrayExp By Lambda表达式

        private void btnPrime_Click(object sender, EventArgs e) { //取得用户输入的数据并且转化成二进制数() 分析已经生成的质数表
            #region 取得用户输入的数据并且转化成二进制数()
            //bits应该是用户输入的数据 转化成的 二进制数
            int value = Int32.Parse(txtValue.Text);
            int[] values = new int[] { value };
            BitArray bitValues = new BitArray(values.Select(x => x >= 0).ToArray());
            #endregion 取得用户输入的数据并且转化成二进制数()

            #region 分析已经生成的质数表
            BitArray bitSet = bitValues;
            BuildSieve(bitSet);
            if (bitSet.Get(value) != false)
                lblPrime.Text = (value + " is a prime number.");
            else
                lblPrime.Text = (value + " is not a prime number.");
            #endregion
        }//取得用户输入的数据并且转化成二进制数() 分析已经生成的质数表

        private void BuildSieve(BitArray bits) { //取得用户输入的数据并且转化成二进制数() 制定素数表格 输出素数表格
            #region 取得用户输入的数据并且转化成二进制数()
            //bits应该是用户输入的数据 转化成的 二进制数
            int userData = Int32.Parse(txtValue.Text);//从输入框取到数据 imp
            StringBuilder primesSB = ConvertBits(userData); //从输入框取到数据，转化成二进制数 SB
            String primes = primesSB.ToString();//从输入框取到数据 ，转化成二进制数 字符串
            #endregion

            #region 制定素数表格
            //埃拉托斯特尼筛法检定素数 制定素数表格
            for (int i = 0; i <= bits.Count - 1; i++) //初始化BitArray全1,set 1;
                bits.Set(i, true);
            //在这个循环内应用了筛网：
            // 此循环会检查所有数的倍数一直到 BitArray 内数据项数的平方根为止，并且清除掉 2、 3、 4、 5 等等的所有倍数。
            //一旦采用此筛网构建数组，那么就可以对 BitArray 执行一个简单调用：
            //bitSet.Get(value)
            //如果找到了数值，那么这个数就是素数。如果没有找到数值，那么筛网会删除掉这个数值，并且确定此数不是
            //素数。
            int lastBit = (int)(Math.Sqrt(userData)); //用户数据开平方，埃拉托斯特尼筛法检定素数 的循环次数
            for (int i = 2; i <= lastBit - 1; i++)  //埃拉托斯特尼筛法检定素数 开始筛网
                if (bits.Get(i))
                    for (int j = 2 * i; j <= bits.Count - 1; j++)
                        bits.Set(j, false); //去除 非质数，set 0;
            #endregion

            #region 输出素数表格
            int counter = 0;
            for (int i = 1; i <= bits.Count - 1; i++) { //userData二进制数 的长度
                if (bits.Get(i)) {
                    primes += i.ToString();
                    counter++;
                    if ((counter % 7) == 0)
                        primes += "\n";
                    else
                        primes += "\n";
                }
            }//userData二进制数 的长度
            #endregion

            txtPrimes.Text = primes;
        }//取得用户输入的数据并且转化成二进制数() 制定素数表格 输出素数表格

    }//public partial class SieveOfEratosthenes
}//namespace BitArrayCh.Algo
