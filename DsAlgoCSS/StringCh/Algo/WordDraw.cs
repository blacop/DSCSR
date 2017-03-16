using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCh.Algo {
    class WordDraw {

        //虽然这段程序很有趣，但是它不是很实用。实际需要的程序应该是可以从任意长度的符合格式短语中抽离出单
        //词。我们可以用几种不同的算法来实现。
        //这里将用到的算法包含下列这些步骤：
        //1. 找到字符串中第一个空格的位置。
        //2. 抽取单词。
        //3. 从空格后边开始到字符串的末尾构建一个新的字符串。
        //4. 寻找新字符串中的另外一个空格。
        //5. 如果没有其他空格，那么抽取的单词就从当前位置到字符串的末尾。
        //6. 否则循环返回第 2 步重复操作。
        //下面就是根据此算法编写的代码（从字符串中抽取的每个单词都存储到名为 word 的集合里面）：

        //static void Main1() {
        //    //单词提取
        //    string astring = "Now is the time";
        //    int pos;
        //    string word;
        //    ArrayList words = new ArrayList();
        //    pos = astring.IndexOf(" ");//1. 找到字符串中第一个空格的位置
        //    while (pos > 0) {
        //        word = astring.Substring(0, pos);//2. 抽取单词。
        //        words.Add(word); //存储到名为 word 的集合
        //        //3. 从空格后边开始到字符串的末尾构建一个新的字符串。
        //        astring = astring.Substring(pos + 1, astring.Length - (pos + 1));
        //        pos = astring.IndexOf(" "); // 找到新的字符串中空格的位置

        //        if (pos == -1) { //5. 如果没有其他空格，那么抽取的单词就从当前位置到字符串的末尾。
        //            word = astring.Substring(0, asstring.Length);
        //            words.Add(word); //存储到名为 word 的集合
        //        }
        //        Console.Read();
        //    }//单词提取//static void Main()
        //}//static void Main1()

        /// <summary>
        /// //单词提取,In 需要分割的字符串，返回 名为 word 的集合
        /// </summary>
        /// <param name="astring">需要分割的字符串</param>
        /// <returns>名为 word 的集合</returns>
        static ArrayList SplitWords(string astring) { //单词提取,In 需要分割的字符串
            string[] ws = new string[astring.Length - 1];
            ArrayList words = new ArrayList();
            int pos;
            string word;
            pos = astring.IndexOf(" ");//1. 找到字符串中第一个空格的位置
            while (pos > 0) {
                word = astring.Substring(0, pos);//2. 抽取单词。
                words.Add(word); //存储到名为 word 的集合
                //3. 从空格后边开始到字符串的末尾构建一个新的字符串。
                astring = astring.Substring(pos + 1, astring.Length - (pos + 1));
                if (pos == -1) {
                    //5. 如果没有其他空格，那么抽取的单词就从当前位置到字符串的末尾。
                    word = astring.Substring(0, astring.Length);
                    words.Add(word); //存储到名为 word 的集合
                }
                pos = astring.IndexOf(" ");
            }
            return words;//返回 名为 word 的集合
        }//单词提取 //static ArrayList SplitWords(string astring)
        //当然，如果打算在程序中实际使用这个算法，那么最好把它做成一个函数并且返回一个集合，如下所示：
        static void Main() {
            string astring = "now is the time for all good people ";
            ArrayList words = new ArrayList();
            words = SplitWords(astring);
            foreach (string word in words)
                Console.Write(word + " ");
            Console.Read();
        }//static void Main()

    }//class WordDraw
}//namespace StringCh.Algo
