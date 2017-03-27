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
        static void MainDuanYan() {
            string[] words = new string[] { "heal", "heel", "noah", "techno" };
            string regExp = "^h";
            Match aMatch;
            foreach (string word in words)
                if (Regex.IsMatch(word, regExp)) {
                    aMatch = Regex.Match(word, regExp);
                    Console.WriteLine("Matched: " + word + " at position: " + aMatch.Index);
                }
        }
        //        这段代码的输出就只有字符串“ heal”和“ heel”匹配。
        //这里还有一个断言会导致正则表达式只在行的末尾找到匹配。这个断言就是美元符号（ $）。如果把前一个正则
        //表达式修改成如下形式：
        //string regExp = "h$";
        //        那么“ noah”就是唯一能找到的匹配。
        //此外，另有一个断言可以在正则表达式中式指定所有匹配只能发生在单词的边缘。这就意味着匹配只能发生在
        //用空格分隔的单词的开始或结束处。此断言用\b 表示。下面是此断言的工作过程：
        //string words = "hark, what doth thou say, Harold? "; string regExp = "\\bh";
        //        这个正则表达式与字符串中的单词“ hark”和“ Harold”相匹配。
        //在正则表达式中还可以使用其他一些断言，但是上述三种是最普遍用到的断言。

        //        8.5 使用分组构造
        //RegEx 类有一套分组构造可以用来把成功匹配进行分组，从而使字符解析成相关匹配更容易。例如，给定了生
        //日和年龄的字符串，而用户只想确定日期的话。通过把日期分组到一起，就可以确定它们作为一组，而不再需要单
        //独进行匹配了。

        //        8.5.1 匿名组
        //这里可能用到几个不同的分组构造。通过括号内围绕的正则表达式就可以组成第一个构造。正如不久要介绍的
        //一样，既然也可以命名组，大家就可以考虑把这个构造作为匿名组。作为一个实例，请看看下列字符串：
        //“ 08/14/57 46 02/2/29 45 06/05/85 18 03/12/88 16 09/09/90 13”
        //这个字符串就是由生日和年龄组成的。如果只需要匹配年龄而不要生日，就可以把正则表达式作为一个匿名组
        //来书写：
        //（ \\s\\d{2}\\s）
        //通过编写这种方式的正则表达式，字符串中的每个匹配就从 1 开始的数字进行确认。为全部匹配保留数字零，
        //这通常将会包含更多的数据。下面这段小程序就用到了匿名组
        static void MainNiMingZu() {
            string words = "08/14/57 46 02/25/59 45 06/05/85 18" + "03/12/88 16 09/09/90 13";
            string regExp1 = "(\\s\\d{2}\\s)";
            MatchCollection matchSet = Regex.Matches(words, regExp1);
            foreach (Match aMatch in matchSet)
                Console.WriteLine(aMatch.Groups[0].Captures[0]);
        }

        //        组通常用名字构建。命名的组更容易使用，这是因为在重新找到匹配时可以通过名字引用到组。命名组是由作
        //为正则表达式前缀的问号和一对尖括号包裹的名字组成的。例如，为了在先前的程序代码“ ages”中命名组，可以
        //把正则表达式写成下列形式：        
        //(?<ages>\\s\\d{2}\\s)
        //还可以用一对小括号来代替尖括号包裹名字。
        //现在要来修改一下这个程序，使得此程序寻找日期而不是年龄，而且用分组构造来组织日期。下面是代码：
        static void MainMinMingZu() {
            string words = "08/14/57 46 02/25/59 45 06/05/85 18 " + "03/12/88 16 09/09/90 13";
            string regExp1 = "(?<dates>(\\d{2}/\\d{2}/\\d{2}))\\s";
            MatchCollection matchSet = Regex.Matches(words, regExp1);
            foreach (Match aMatch in matchSet)
                Console.WriteLine("Date: {0}", aMatch.Groups["dates"]);
        }
        //        下面集中在用正则表达式来产生输出：
        //(\\d{2}/\\d{2}/\\d{2})\\s
        //大家可以把这个表达式读作“ 2 个数字跟着一条斜线，再跟着两个数字和一条斜线，再跟着两个数字
        //，再跟着一个空格”。为了给正则表达式分组，可以做下列添加：
        //(?<dates>(\\d{2}/\\d{2}/\\d{2}))\\s
        //为了找到字符串中的每个匹配，需要用 Match 类的 Group 方法来把它们分离成一个组的集合Groups("dates")：
        //Console.WriteLine("Date: {0}", aMatch.Groups("dates"));

        //        8.5.3 零宽度正向预搜索断言和零宽度反向预搜索断言
        //断言还可以用来确定正则表达式向前或向后搜索到匹配的程度。这些断言可能是正的或负的，这就意味着正则
        //表达式在寻找特殊的匹配模式（正的）或特殊的非匹配模式（负的）。党刊到一些市里的时候这些内容就会更清楚
        //了。
        //这些断言中第一个要讨论的就是正的正向预搜索断言。此断言进行了如下这样的说明：
        //(?= reg-exp-char)
        //这里的 reg-exp-char 是正则表达式或元字符。此断言说明只要搜索到匹配的当前子表达式在指定位置的右侧，
        //那么匹配就继续。下面这段代码说明了此断言的工作原理：
        string words1 = "lions lion tigers tiger bears,bear";
        //word后缀 
        //正向预搜索断言 右侧内容是空格(?=\\s)
        string regExp11 = "\\w+(?=\\s)";
        //        正则表达式说明对跟随空格的每个单词都做了匹配。匹配的单词有“ lions”、“ lion”、“ tigers”和“ tiger”。正则
        //        表达式匹配单词，但是不匹配空格。记住这一点是非常重要的。
        //下一个断言是
        //负的正向预搜索断言。只要搜索到不匹配的当前子表达式在指定位置的右侧，那么此断言就继续
        //匹配。下面是代码段实例：
        string words2 = "subroutine routine subprocedure procedure";
        //前缀是not sub (?!sub)
        //\b只是匹配字符串开头结尾及空格回车等的位置, 不会匹配空格符
        string regExp12 = "\\b(?!sub)\\w+\\b";
        // 此正则表达式表明对每个单词所做的匹配不是以前缀“ sub”开始的。匹配的单词有“ routine”和“ procedure”。

        //接下来的断言被称为是反向预搜索断言。这些断言会正向左或反向左搜索匹配，而不是向右了。下面的代码段举例
        //说明了如何编写一个正的反向预搜索断言：
        string words3 = "subroutines routine subprocedures procedure";
        //\b只是匹配字符串开头结尾及空格回车等的位置, 不会匹配空格符
        //反向预搜索断言 ,左起内容固定为s
        string regExp13 = "\\b\\w+(?<=s)\\b";
        // 这个正则表达式搜索出现在“ s”后的单词的所有边缘。匹配的单词有“ subroutines”和“ subprocedures”。
        //只要子表达式不匹配在位置的左侧，那么负的反向预搜索断言就继续匹配。这里可以很容易的修改上述提到的正则
        //表达式，使得其就只能匹配不是以字母“ s”开始的单词，就像下面这样：
        string regExp14 = "\\b\\w+(?<!s)\\b";

        //Regex匹配了以后自动产生了一个被称为是 Capture 的对象，产生了一个被称为是 Capture 的对象，保存的是每次匹配捕捉的结果,并且加入
        //CaptureCollection这个可以拿到命名组的集合，然后可以对这个集合进行遍历，foreach的时候 使用 Match.Groups["dates"].Captures属性
        //        8.6 CaptureCollection 类
        //当正则表达式匹配 子表达式 的时候，
        //产生了一个被称为是 Capture 的对象，保存的是每次匹配捕捉的结果
        //而且会把此对象添加到名为 CaptureCollection 的捕获集合里面。
        //    当在正则表达式中使用 命名组 的时候，这个组就有自己的 捕获集合。
        //为了重新 得到 用了命名组的正则表达式所收集的捕获，就要调用来自 Match 对象 Group 属性的 Captures 属性。
        //这在实例中是很容易理解的。利用前面小节的其中一个正则表达式，下列代码返回了在字符串中找到的所有日期和
        //年龄，而且日期和年龄是完全分组的：
        //        程序的外循坏遍历了每个匹配，而两个内循环则遍历了不同的 Capture 集合，一个是日期集合而另一个则是年
//龄集合。按照这种方式使用 CaptureCollection 可确保捕获每组匹配而不仅仅是最后的匹配。
        static void MainCaptureCollection() {
            string dates = "08/14/57 46 02/25/59 45 06/05/85 18 " + "03/12/88 16 09/09/90 13";
            string regExp = "(?<dates>(\\d{2}/\\d{2}/\\d{2}))\\s(?<ages>(\\d{2}))\\s";
            MatchCollection matchSet;
            matchSet = Regex.Matches(dates, regExp);
            Console.WriteLine();
            foreach (Match aMatch in matchSet) {
                //遍历集合
                foreach (Capture aCapture in aMatch.Groups["dates"].Captures)
                    Console.WriteLine("date capture: " + aCapture.ToString());
                foreach (Capture aCapture in aMatch.Groups["ages"].Captures)
                    Console.WriteLine("age capture: " + aCapture.ToString());
            }
        }

//        8.7 正则表达式的选项
//在指定正则表达式的时候可以设置几个选项。这些选项的范围从指定多行模式以便正则表达式可以在多行上正
//确工作，到编译正则表达式以便能更快速执行。下面这张表列出了可以设置的不同选项。
//在查看此表之前，需要注意这些选项的设置方式。通常情况下，对 RegEx 类的方法之一指定选项常量作为第三
//个参数就可以设置选项了，比如 Match 方法、 Matches 方法。例如，如果想要为正则表达式设置 Multiline 选项，代
//码行应像下面这样：
//matchSet = Regex.Matches(dates, regexp, RegexOptions.Multiline);
//这个选项连同其他选项可以直接输入也可以用 Intellisense 来选择。
//下面就是可用的选项了：


    }//!_class FindThe
}//!_namespace RegExCh.Main
