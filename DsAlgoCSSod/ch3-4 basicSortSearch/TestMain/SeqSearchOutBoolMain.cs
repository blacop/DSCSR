using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSearchProject
{
    public class SeqSearchOutBoolMain
    {
        //SeqSearchOutBoolMain
        /*程序首先会通过从文本文件中读取一组数据开始运行。
        数据是由前 100 个整数组成的，
        而且是按照部分随机的顺序进行存储的。
        随后，程序会提示用户输入所要查找的数，
        并且调用 SeqSearch 函数来进行查找。
        当然，用户也可以编写顺序查找函数。
        这样当找到要查找的数值时，函数就会返回此数值在数组内的位置。而
        当没有找到要查找的数值时，函数就会返回-1。*/
        /*static void Main(string[] args)
        {
            int[] numbers = new int[100];
            StreamReader numFile = File.OpenText(@"c:\\numbers.txt");
            for (int i = 0; i < numbers.Length; i++) //小 bug
                numbers[i] = Convert.ToInt32(numFile.ReadLine(), 10);
            int searchNumber;
            Console.Write("Enter a number to search for: ");
            searchNumber = Convert.ToInt32(Console.ReadLine(), 10);
            bool found;
            found = SeqSearch(numbers, searchNumber);
            if (found)
                Console.WriteLine(searchNumber + " is in the array.");
            else
                Console.WriteLine(searchNumber + " is not in the array.");
        }//static void Main(string[] args)
        */

        public static bool SeqSearch(int[] arr, int sValue)
        {
            //SeqSearchOutBool
            for (int index = 0; index < arr.Length; index++)
            {
                if (arr[index] == sValue)
                {
                    return true;
                }
            }//for (int index = 0; index < arr.Length; index++)
            return false;
        }//public bool SeqSearch(int[] arr,int sValue)

    }//public class SeqSearchOutBoolMain
}//namespace BasicSearchProject
