using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArrayCh.Algo {
    //BitArray 内置是逆序存储, 因此要自行实现正序输出

    //    此程序用到两个数组。第一个数组 BitSet 就是保存有 Byte（字节）值（按照位的格式）的 BitArray。而第二个
    //数组 binNumber 只是一个用来保存二进制字符串的字符串数组。这个二进制字符串是由每个 Byte（字节）值的二进
    //制位组成的，从最后一个位置（ 7）开始，一直向前移动到第一个位置（ 0）上。
    //每次遇到一个位值，程序会首先把它转化成为 1（如果为真值）或 0（如果为假值），然后把它放置在适当的位
    //置上。这里有两个变量分别用来说明在 BitSet 数组（位）内的位置以及在 binNumber 数组（二进制）内的位置。当
    //然，这里还需要知道什么时候已经转换了八个位，以及什么时候已经完成了对数的操作。把当前位值（在变量位内）
    //对 8 进行取模操作可以获得这些信息。如果没有余数，那么就说明正好在第八位上，而且可以把这个数写出来了。
    //否则，就需要继续循环操作。
    //尽管已经把程序完整地写到了 Main()内，但是在本章末尾的练习部分大家还有机会通过创建类，甚至是扩展含
    //有此转换方法的 BitArray 类来整理此程序。

    public class BitArrayCWL {
        /// <summary>
        /// BitArray升序输出(PrintASC),In byte[] ByteSet，Out CMD.
        /// </summary>
        /// <param name="ByteSet">In byte[] ByteSet</param>
        public static void BitArrayPrint(byte[] ByteSet) { //外部得到数据
            int bits;
            string[] binNumber = new string[8];//To Dsc String 输出到目标字符串
            int binary;
            
            BitArray BitSet = new BitArray(ByteSet); //外部得到数据 byte[] ByteSet，构造BitArray
            bits = 0;  //count
            binary = 7;  //index
            for (int i = 0; i <= BitSet.Count - 1; i++) {
                if (BitSet.Get(i) == true)
                    binNumber[binary] = "1"; //To Dsc String 输出到目标字符串
                else
                    binNumber[binary] = "0"; //To Dsc String 输出到目标字符串
                bits++;
                binary--;
                if ((bits % 8) == 0) { //BYTE_MAX == 255, So byte 只有 8位
                    binary = 7; //BYTE_MAX == 255, So byte 只有 8位
                    bits = 0;
                    for (int ji = 0; ji <= 7; ji++) // Console.Write
                        Console.Write(binNumber[ji]);
                    Console.WriteLine();
                }//if ((bits % 8) == 0)
            }//for (int i = 0; i <= BitSet.Count - 1; i++)
        }//static void Main()

        ////在可以调用 OLE 之前，必须将当前线程设置为单线程单元(STA)模式，请确保您的Main函数带有STAThreadAttribute标记。
        //[STAThread]
        //static void Main() {
        //    int bits;
        //    string[] binNumber = new string[8];//To Dsc String 输出到目标字符串
        //    int binary;
        //    byte[] ByteSet = new byte[] { 1, 2, 3, 4, 5 };//get data 得到数据
        //    BitArray BitSet = new BitArray(ByteSet); //构造BitArray
        //    bits = 0;  //count
        //    binary = 7;  //index
        //    for (int i = 0; i <= BitSet.Count - 1; i++) {
        //        if (BitSet.Get(i) == true)
        //            binNumber[binary] = "1"; //To Dsc String 输出到目标字符串
        //        else
        //            binNumber[binary] = "0"; //To Dsc String 输出到目标字符串
        //        bits++;
        //        binary--;
        //        if ((bits % 8) == 0) { //BYTE_MAX == 255, So byte 只有 8位
        //            binary = 7; //BYTE_MAX == 255, So byte 只有 8位
        //            bits = 0;
        //            for (int ji = 0; ji <= 7; ji++) // Console.Write
        //                Console.Write(binNumber[ji]);
        //            Console.WriteLine();
        //        }//if ((bits % 8) == 0)
        //    }//for (int i = 0; i <= BitSet.Count - 1; i++)
        //}//static void Main()

    }// class BitArrayCWL
}//namespace BitArrayCh.Algo
