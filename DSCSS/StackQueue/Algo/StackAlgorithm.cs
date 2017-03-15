using StackQueue.Body;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StackQueue.Algo {
    public class StackAlgorithm {
        public void ConversionOct(int n) { //【例3-1】数制转换问题
            LinkStack<int> s = new LinkStack<int>();
            while (n > 0) {
                s.Push(n % 8);
                n = n / 8;
            }
            while (!s.IsEmpty()) {
                n = s.Pop();
                Console.WriteLine("{0}", n);
            }
        } //【例3-1】数制转换问题 //8进制转换//public void Conversion(int n)   
          /* 【例3-2】括号匹配。
          括号匹配问题也是计算机程序设计中常见的问题。
          为简化问题，假设表达式中只允许有两种括号：圆括号和方括号。
          嵌套的顺序是任意的，([]())或[()[()][]]等都为正确的格式，
          而[(])或(([)])等都是不正确的格式。检验括号匹配的方法要用到栈。

          算法思想：如果括号序列不为空，重复步骤1。
          步骤1：从括号序列中取出1个括号，分为三种情况：
          a) 如果栈为空，则将括号入栈；
          b) 如果括号与栈顶的括号匹配，则将栈顶括号出栈。
          c) 如果括号与栈顶的括号不匹配，则将括号入栈。
          步骤2：如果括号序列为空并且栈为空则括号匹配，否则不匹配。
          算法如下，用顺序栈实现算法：
          */
        public bool MatchBracket(char[] charlist) { //匹配括号
            SeqStack<char> s = new SeqStack<char>(50);
            int len = charlist.Length;
            #region//开始循环,循环完毕
            for (int i = 0; i < len; ++i)//开始循环
            {
                if (s.IsEmpty())//空栈
                {
                    s.Push(charlist[i]);//入栈
                }//if (s.IsEmpty())
                else if ((((s.GetTop() == '(') && (charlist[i] == ')'))) || (((s.GetTop() == '[') && (charlist[i] == ']')))) {
                    //成功匹配
                    s.Pop();//出栈
                }//else if
                else {
                    //不匹配
                    s.Push(charlist[i]);//入栈
                }//else
            }//for (int i = 0; i < len; ++i)
            #endregion
            if (s.IsEmpty()) {
                //空栈
                return true;
            }//(s.IsEmpty())
            else {
                //非空栈
                return false;
            }//else
        }//匹配括号//public bool MatchBracket(char[] charlist)
         /*【例3-3】表达式求值
          为实现算法，使用两个栈，一个存放算符，叫OPTR，
          一个存放操作数和运算的结果数，叫OPND。算法思想如下：
         （1） 首先置OPND为空，将‘#’入OPTR；
         （2） 依次读入表达式中的每个字符，若是操作数则将该字符入OPND，
         若是算符，则和OPTR栈顶字符比较优先级，若OPTR栈顶字符优先级高，
         则将OPND栈中的两个操作数和OPTR栈顶算符出栈，
         然后将操作结果入OPND；若OPTR栈顶字符优先级低，
         则将该字符入OPTR；
         若二者优先级相等，则将OPTR栈顶字符出栈并读入下一个字符。
         */
        public int EvaluateExpression() {//表达式求值 //算符和操作数都从外部传入,读入之前的分离前置后置操作都没写
            SeqStack<char> optr = new SeqStack<char>(20);//存放算符，叫OPTR
            SeqStack<int> opnd = new SeqStack<int>(20);//存放操作数和运算的结果数，叫OPND
            optr.Push('#');//首发入栈#
            char c = (char)Console.Read();//读入算符,简化写法,手动输入算符1次
            char theta = (char)0;//表达式的算符
            int a = 0;//操作数
            int b = 0;//操作数
            while (c != '#')//循环终止条件:不是结束符#
            {
                #region//是算符
                if ((c != '+') && (c != '-') && (c != '*') && (c != '/') && (c != '(') && (c != ')')) {
                    //是算符
                    optr.Push(c);//入栈
                }
                #endregion
                #region//不是算符
                else//不是算符
                {
                    switch (Precede(optr.GetTop(), c))//
                    {
                        case '<':
                            optr.Push(c);//入栈1个算符
                            c = (char)Console.Read();//手动输入算符1次
                            break;
                        case '=':
                            optr.Pop();//出栈1个算符
                            c = (char)Console.Read();//手动输入算符1次
                            break;
                        case '>':
                            theta = optr.Pop();//出栈1个算符
                            a = opnd.Pop();//出栈2个操作数
                            b = opnd.Pop();
                            opnd.Push(Operate(a, theta, b));//入栈1个结果数(调用Operate()))
                            break;
                    }//switch (Precede(optr.GetTop(), c))
                }//else
                #endregion
            }//while (c != '#')
            return opnd.GetTop();//拿到栈顶结果数
        }//表达式求值//public int EvaluateExpression()
        private int Operate(int token1, char optr, int token2) {/*Operate为进行二元运算的方法*/
            int result;
            switch (optr) {//optr 操作符号
                case '+':
                    result = (token1 + token2);
                    break;
                case '-':
                    result = (token1 - token2);
                    break;
                case '*':
                    result = (token1 * token2);
                    break;
                case '/':
                    result = (token1 / token2);
                    break;
                default:
                    result = 0;
                    break;
            }//switch (optr) 操作符号
            return result;//返回结果数
        }/*Operate为进行二元运算的方法*///private int Operate(int a, char theta, int b)
        private char Precede(char optr1, char optr2) {//优先级关系的方法
                                                      /*Precede是判定optr栈顶算符与读入的算符之间的优先级关系的方法*/
            throw new NotImplementedException();
            //char result;
            //if (optr1 == '-' && optr2 == '=') { }//这个优先级关系很麻烦,跳过
            //else { }//这个优先级关系很麻烦,跳过
            //return result;//返回结果数
        }//优先级关系的方法//private char Precede(char v, char c)       
        static void EvaluateExpression_Main(string[] args) { /*EvaluateExpression_Another----------------*/
            //系统自带Stack
            Stack nums = new Stack();//算数
            Stack ops = new Stack();//算符
            string expression = "5 + 10 + 15 + 20";//手写表达式
            Calculate(nums, ops, expression);
            Console.WriteLine(nums.Pop());
            Console.Read();
        }  /*EvaluateExpression_Another----------------*/
        static bool IsNumeric(string input) { //判断数字 // IsNumeric isn't built into C# so we must define it
            bool flag = true;
            string pattern = (@"^\d+$");//是数字
            Regex validate = new Regex(pattern);//正则
            if (!validate.IsMatch(input))//不匹配 正则
            {
                flag = false;
            }
            return flag;
        } //判断数字 // IsNumeric isn't built into C# so we must define it
        static void Calculate(Stack N, Stack O, string exp) {//计算器
            string ch, token = ""; //拆分表达式为 ch算符 token运算数 
            for (int p = 0; p < exp.Length; p++) { //循环读取 表达式
                ch = exp.Substring(p, 1);//取子串
                if (IsNumeric(ch)) //是数字
                    token += ch; //+=
                if (ch == " " || p == (exp.Length - 1)) {//空格 或 p ==(exp.Length - 1),字符串0位置存length-1字符串长度
                    if (IsNumeric(token)) {
                        N.Push(token);//入栈token运算数
                        token = "";//清空token运算数
                    }
                } else if (ch == "+" || ch == "-" || ch == "*" || ch == "/")
                    O.Push(ch);//入栈算符
                if (N.Count == 2)//运算数 栈N.Count == 2
                    Compute(N, O);//运算
            }//循环读取 表达式//for (int p = 0; p < exp.Length; p++) 
        }//计算器//static void Calculate(Stack N, Stack O, string exp)
        static void Compute(Stack N, Stack O) { //Compute方法
            int oper1, oper2;
            string oper;
            oper1 = Convert.ToInt32(N.Pop());
            oper2 = Convert.ToInt32(N.Pop());
            oper = Convert.ToString(O.Pop());
            switch (oper) {
                case "+":
                    N.Push(oper1 + oper2);
                    break;
                case "-":
                    N.Push(oper1 - oper2);
                    break;
                case "*":
                    N.Push(oper1 * oper2);
                    break;
                case "/":
                    N.Push(oper1 / oper2);
                    break;
            }//switch (oper)
        }//运算方法//static void Compute(Stack N, Stack O)   
        static void MulBase_Main(string[] args) { /*MulBase_Another 十进制向多种进制的转换*/
            int num, baseNum;
            Console.Write("Enter a decimal number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a base: ");
            baseNum = Convert.ToInt32(Console.ReadLine());
            Console.Write(num + " converts to ");
            MulBase(num, baseNum);
            Console.WriteLine(" Base " + baseNum);
            Console.Read();
        } /*MulBase_Another 十进制向多种进制的转换*/
        static void MulBase(int n, int b) { //n:num,b:base进制
            Stack Digits = new Stack();
            do {
                Digits.Push(n % b);
                n /= b;
            } while (n != 0);
            while (Digits.Count > 0)
                Console.Write(Digits.Pop());
        }//n:num,b:base进制//static void MulBase(int n, int b)       
    }//public class Algorithm
}//namespace StackQueue.Algo
