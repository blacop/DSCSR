using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegExCh {
    class Program {
        //Regex匹配了以后自动产生了一个被称为是 Capture 的对象，
        //产生了一个被称为是 Capture 的对象，
        //保存的是每次匹配捕捉的结果,并且加入
        //CaptureCollection这个可以拿到命名组的集合，
        //然后可以对这个集合进行遍历，
        //foreach的时候 使用 Match.Groups["dates"].Captures属性

        static void Main(string[] args) {
            string dates = "08/14/57 46 02/25/59 45 06/05/85 18 " + "03/12/88 16 09/09/90 13";
            string regExp = "(?<dates>(\\d{2}/\\d{2}/\\d{2}))\\s(?<ages>(\\d{2}))\\s"; //正则命名组
            MatchCollection matchSet;                 //声明一个匹配结果集
            matchSet = Regex.Matches(dates, regExp);  //结果集 匹配赋值
            Console.WriteLine();
            foreach (Match aMatch in matchSet) {      //遍历  
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

//        RegexOption 成员 内置字符 描述
//None N/A 说明没有选项设置。
//IgnoreCase I 说明字母非大小写匹配。
//Multiline M 说明多行模式。
//ExplicitCapture N 说明只有对正确的捕获明确命名或计算组。
//Compiled N/A 说明将会对正则表达式编译成汇编。
//Singleline S 说明单行模式。
//IgnorePatternWhiteSpace X 说明由于模式而排斥非转义空格，而且使注释跟在符号（ #）之后。
//RightToLeft N/A 说明搜索是从右到左，而不是从左到右。
//ECMAScript N/A 说明 ECMAScript-compliant 行为对表达式有效。

    }//!_ class Program
}//!_namespace RegExCh
