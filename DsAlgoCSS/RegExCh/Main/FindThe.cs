using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegExCh.Main {
    //    程序做的第一件事就是创建一个新的 RegEx 对象并且把要匹配的正则表达式传递给构造器。当再次初始化了字
    //符串之后，程序声明了一个 Match 对象 matchSet。 Match 类为存储用来与正则表达式进行匹配的数据提供了方法。
    //If 语句使用了一种 Match 类的属性 Success 来确定是否是成功匹配。如果值返回为 True，那么正则表达式在字
    //符串中至少匹配了一条子串。否则的话，存储在 Success 中的值就是 False。
    class FindThe {
        static void MainMatch() {
            Regex reg = new Regex("the");
            string str1 = "the quick brown fox jumped over the lazy dog";
            Match matchSet;
            int matchPos;
            matchSet = reg.Match(str1);
            if (matchSet.Success) {
                matchPos = matchSet.Index;
                Console.WriteLine("found match at position:" + matchPos);
            }
            //        程序还可以有另外一种方法来查看是否匹配成功。通过把正则表达式和目标字符串传递给 IsMatch 方法的方式
            //可以对正则表达式进行预测试。如果与正则表达式产生了匹配，那么这种方法就返回 True，否则返回 False。这种方
            //法的操作如下所示：
            if (Regex.IsMatch(str1, "the")) {
                Match aMatch;
                aMatch = reg.Match(str1);
            }
        }//!_static void MainMainMatch()

        //        用 Match 类的一个问题就是它只能存储一个匹配。在前面的实例中，针对子串“ the”存在两个匹配。这里可
        //以使用另外一种类 MatchCollection 类来存储与正则表达式的多个匹配。为了处理所有找到的匹配可以把匹配存储到
        //MatchCollection 对象中。这里有一个实例（在 Main 函数内只包含了代码）
        static void MainMatchCollection() {
            Regex reg = new Regex("the");
            string str1 = "the quick brown fox jumped over the lazy dog";
            MatchCollection matchSet;
            matchSet = reg.Matches(str1);
            if (matchSet.Count > 0)
                foreach (Match aMatch in matchSet)
                    Console.WriteLine("found a match at: " + aMatch.Index);
            Console.Read();
        }//!_MainMatchCollection()

//        在编写正则表达式的时候，经常会要想正则表达式添加数量型数据，诸如“精确匹配两次”或者“匹配一次或
//多次”。利用数量词就可以把这些数据填加到正则表达式里面了。这里要看到的第一个数量词就是加号（ +）。这个数量词说明正则表达式应该匹配一个或多个紧接的字符。下面的程
//序就举例说明了这个数量词的用法：
        static void MainPlus() {
            string[] words = new string[] { "bad", "boy", "baaad", "bear", "bend" };
            foreach (string word in words)
                if (Regex.IsMatch(word, "ba+"))
                    Console.WriteLine(word);//匹配全部输出
        }//!_static void MainPlus

        //        通过在一对大括号内部放置一个数可以说明一个有限数量的匹配，就像在{n
        //    }
        //    中，这里的 n 是要找到的匹配数量。
        //下面的程序说明了这个数量词的用法：
        static void MainKuoHao() {
            string[] words = new string[] { "bad", "boy", "baad", "baaad", "bear", "bend" };
            foreach (string word in words)
                if (Regex.IsMatch(word, "ba{2}d"))
                    Console.WriteLine(word);
        }//!_static void MainKuoHao()

        //        通过在大括号内提供两个数字可以说明匹配的最大值和最小值： {n,m
        //    }，这里的 n 表示匹配的最小值而 m 则表
        //示最大值。在上述字符串中，正则表达式“ ba{1,3}
        //d”将可以匹配“ bad”、“ baad”以及“ baaad”。
        //到目前为止已经讨论过的数量词展示的就是所谓的贪心行为。他们试图有尽可能多的匹配，而且这种行为经常
        //会导致不预期的匹配。下面是一个例子：
        static void MainLazyFuHao() {
            string[] words = new string[] { "Part", "of", "this", "<b>string</b>", "is", "bold" };
            //.=>any,*=>0~all,
            string regExp = "<.*>";
            MatchCollection aMatch;
            foreach (string word in words) {
                //Regex.IsMatch([target],[rule])
                if (Regex.IsMatch(word, regExp)) {
                    aMatch = Regex.Matches(word, regExp);
                    for (int i = 0; i < aMatch.Count; i++)
                        Console.WriteLine(aMatch[i].Value);
                }
            }
        }
        //        原本期望这个程序就返回两个标签： <b>和</b>。但是由于贪心，正则表达式匹配了<b> 字符串</b>。利用懒惰
        //数量词：问号（？）就可以解决这个问题。当问号直接放在原有数量词后边时，数量词就变懒惰了。这里的懒惰是
        //指在正则表达式中用到的懒惰数量词将试图做尽可能少的匹配，而不是尽可能多的匹配了。
        //把正则表达式变成读取“ <.+>”也是于事无补的。这里需要用到懒惰数量词，而且一旦用了“ <.+？ >”，就会得
        //到正确的匹配： <b>和</b>。懒惰数量词还可以和所有数量词一起使用，包括包裹在一对大括号内的数量词。

        //        这里第一个要讨论的字符类就是句号（ .）。这是一种非常非常容易使用的字符类，但是它也确实是有问题的。
        //句点与字符串中任意字符匹配。下面是一个实例
        static void MainJuhao() {
            string str1 = "the quick brown fox jumped over the lazy dog";
            MatchCollection matchSet;
            matchSet = Regex.Matches(str1, ".");
            foreach (Match aMatch in matchSet)
                Console.WriteLine("matches at: " + aMatch.Index);
        }

        //        句点可以匹配字符串中每一个单独字符。
        //较好利用句点的方法就是用它在字符串内部定义字符范围，也就是用来限制字符串的开始或/和结束字符。下
        //面是使用相同字符串的一个实例：
        static void MainJuhao2() {
            string str1 = "the quick brown fox jumped over the lazy dog one time";
            MatchCollection matchSet;
            matchSet = Regex.Matches(str1, "t.e");
            foreach (Match aMatch in matchSet)
                Console.WriteLine("Matches at: " + aMatch.Index);
        }
        //        程序的输出是：
        //matches: the at: 0
        //matches: the at: 32
        //        在使用正则表达式的时候经常希望检查包含字符组的模式。大家可以编写用一组闭合的方括号（ [ ]）包裹着的
        //正则表达式。在方括号内的字符被称为是字符类。如果想要编写的正则表达式匹配任何小写的字母字符，可以写成
        //如下这样的表达式： [abcdefghijklmnopqrstuvwxyz]。但是这样是很难书写的，所以通过连字号： [a-z]
        //        来表示字母范围
        //的方式可以编写简写版本。
        //下面说明了如何利用这个正则表达式来匹配模式(parttern)(substring)：
        static void MainWord() {
            string str1 = "THE quick BROWN fox JUMPED over THE lazy DOG";
            MatchCollection matchSet;
            matchSet = Regex.Matches(str1, "[a-z]");
            foreach (Match aMatch in matchSet)
                Console.WriteLine("Matches at: " + aMatch.Index);
        }
        //        程序中匹配的字母就是那些组成单词“ quick”、“ fox”、“ over”和“ lazy”的字母。
        //字符类可以用多组字符构成。如果想要既匹配小写字母也匹配大写字母，那么可以把正则表达式写成这样：
        //“ [A-Za-z]”。当然，如果需要包括全部十个数字，也可以编写像[0 - 9] 这样由数字组成的字符类。
        //此外，通过在字符类前面放置一个脱字符号（ ^）的方法人们还可以创建字符类的反或者字符类的否定。例如，
        //如果有字符类[aeiou] 来表示元音类，那么就可以编写[^ aeiou] 来表示辅音或非元音。
        //如果把这三个字符类合并，就可以形成正则表达式用法中所谓的单词。正则表达式就像这个样子： [A-Za-z0-9]。
        //这里还有一个可以用来表示同样类的较短小的字符类： \w。 \W 用来表示\w 的反，也或者用来表示非单词字符（比
        //如标点符号）。
        //此外，还可以把数字字符类（ [0-9]）写成\d（注意由于在 C#语言中反斜杆后跟着其他字符很可能是转义序列，
        //所以诸如\d 这样的代码在 C#语言中都以\\d 形式来说明正则表达式而非转义代码）。而非数字字符类（ [^0-9]）则可
        //以写成\D 这样。最后，因为空格符在文本处理中扮演着非常重要的角色，所以把\s 用来表示空格字符，而把\S 用
        //来表示非空格字符。稍后在讨论分组构造时将会研究使用空白字符类。

        //        C#语言包含一系列可以添加给正则表达式的运算符。这些运算符可以在不导致正则表达式引擎遍历字符串的情
        //况下改变表达式的行为。这些运算符被称为断言。
        //第一个要研究的断言会导致正则表达式只能在字符串或行的开始处找到匹配。这个断言由脱字符号（ ^）产生。
        //在下面这段程序中，正则表达式只与第一个字符为字母“ h”的字符串相匹配，而忽略掉字符串中其他位置上的“ h”。
        //代码如下所示
        static void Main() {
            string[] words = new string[] { "heal", "heel", "noah", "techno" };
            string regExp = "^h";
            Match aMatch;
            foreach (string word in words)
                if (Regex.IsMatch(word, regExp)) {
                    aMatch = Regex.Match(word, regExp);
                    Console.WriteLine("Matched: " + word + " at position: " + aMatch.Index);
                }
        }


    }//!_class FindThe
}//!_namespace RegExCh.Main
