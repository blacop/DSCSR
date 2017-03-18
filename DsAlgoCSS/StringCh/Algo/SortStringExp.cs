using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCh.Algo {
    class SortStringExp {
        static void showNames(string[] arr) {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
                Console.Write(arr[i]);
        }
        static void trimVals(string[] arr) {
            char[] charArr = new char[] { ' ' };
            for (int i = 0; i <= arr.GetUpperBound(0); i++) {
                arr[i] = arr[i].Trim(charArr[0]);
                arr[i] = arr[i].TrimEnd(charArr[0]);
            }
        }

        //还有一个实例说明了如何排列来自数组的数据使其更容易阅读：
        static void ExpPadRightMain() {
            string[,] names = new string[,]{ //初始化字符串数组 2维的
                {"1504", "Mary", "Ella", "Steve", "Bob"},
                {"1133", "Elizabeth", "Alex", "David", "Joe"},
                {"2624", "Joel", "Chris", "Craig", "Bill"}
            };
            Console.WriteLine();
            Console.WriteLine();
            for (int outer = 0; outer <= names.GetUpperBound(0); outer++) { // GetUpperBound 1维的
                for (int inner = 0; inner <= names.GetUpperBound(1); inner++) // GetUpperBound 2维的
                    Console.Write(names[outer, inner] + " "); //遍历输出 string[,] names
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int outer = 0; outer <= names.GetUpperBound(0); outer++) {
                for (int inner = 0; inner <= names.GetUpperBound(1); inner++)
                    Console.Write(names[outer, inner].PadRight(10) + " ");
                Console.WriteLine();
            }
        }
        static void ExpConcatMain() {
            string s1 = "hello";
            string s2 = "world";
            string s3 = "";
            s3 = String.Concat(s1, " ", s2);
            Console.WriteLine(s3);
        }
        static void ExpLengthMain() {
            string[] names = new string[] { " David", " Raymond", "Mike ", "Bernica " };
            Console.WriteLine();
            showNames(names);
            Console.WriteLine();
            trimVals(names);
            Console.WriteLine();
            showNames(names);

            StringBuilder stBuff = new StringBuilder("Ken Thompson");
            Console.WriteLine("Length of stBuff3: " + stBuff.Length.ToString());
            Console.WriteLine("Capacity of stBuff3: " + stBuff.Capacity.ToString());
            Console.WriteLine("Maximum capacity of stBuff3: " + stBuff.MaxCapacity.ToString());
        }
        static void ExpAppendMain() {
            StringBuilder stBuff = new StringBuilder();
            String[] words = new string[] {"now ", "is ", "the ", "time ", "for ", "all ",
        "good ", "men ", "to ", "come ", "to ", "the ","aid ", "of ", "their ", "party"};
            for (int i = 0; i <= words.GetUpperBound(0); i++)
                stBuff.Append(words[i]);
            Console.WriteLine(stBuff);
            Console.ReadKey();
        }
        static void ExpInsertMain() {
            StringBuilder stBuff = new StringBuilder();
            stBuff.Insert(0, "Hello");
            stBuff.Insert(5, ", ");//Insert(index,char[]) //pos6
            stBuff.Append("world");
            Console.WriteLine(stBuff);
            char[] chars = new char[] { 't', 'h', 'e', 'r', 'e' };//pos6
            stBuff.Insert(5, " " + new string(chars));
            Console.WriteLine(stBuff);
            Console.ReadKey();
        }
        static void ExpRemoveMain() {
            StringBuilder stBuff = new StringBuilder("noise in+++++string");
            stBuff.Remove(8, 5);
            Console.WriteLine(stBuff);
            Console.ReadKey();
        }
        static void ExpToStringMain() {
            StringBuilder stBuff = new StringBuilder("HELLO WORLD");
            string st = stBuff.ToString();
            st = st.ToLower();
            st = st.Replace(
                st.Substring(0, 1), 
                st.Substring(0, 1).ToUpper());
            stBuff.Replace(stBuff.ToString(), st);
            Console.WriteLine(stBuff);
        }

        static void BuildSB(int size) {
            StringBuilder sbObject = new StringBuilder();
            for (int i = 0; i <= size; i++)
                sbObject.Append("a");
        }
        static void BuildString(int size) {
            string stringObject = "";
            for (int i = 0; i <= size; i++)
                stringObject += "a";
        }
        static void ExpSBSpeedMain() {
            int size = 100;
            Timing timeSB = new Timing();
            Timing timeST = new Timing();
            Console.WriteLine();
            for (int i = 0; i <= 3; i++) {
                timeSB.startTime();
                BuildSB(size);
                timeSB.stopTime();
                timeST.startTime();
                BuildString(size);
                timeST.stopTime();
                Console.WriteLine("Time (in milliseconds) to build StringBuilder " + "object for " + size + " elements: " +
                timeSB.Result().TotalMilliseconds);
                Console.WriteLine("Time (in milliseconds) to build String object " + "for " + size + " elements: " +
                timeST.Result().TotalMilliseconds);
                Console.WriteLine();
                size *= 10;
            }
            Console.ReadKey();
        }
        

    }//class SortStringExp
}//namespace StringCh.Algo
