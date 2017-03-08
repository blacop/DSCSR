using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringChapter.Body
{
    //串类StringDS的C#实现如下所示：
    public class StringDS
    {
        private char[] data; //字符数组
        public char this[int index]//索引器
        {
            get
            {
                return data[index];
            }
        }
        public StringDS(char[] arr)//构造器
        {
            data = new char[arr.Length];
            for (int i = 0; i < arr.Length; ++i)
            {
                data[i] = arr[i];
            }
        }
        public StringDS(StringDS s)//构造器
        {
            for (int i = 0; i < this.GetLength(); ++i)
            {
                data[i] = s[i];
            }
        }
        public StringDS(int len)//构造器
        {
            char[] arr = new char[len];
            data = arr;
        }
        public int GetLength()//求串长
        {
            return data.Length;
        }
        public int Compare(StringDS s)//串比较
        {
            /*、串比较
如果两个串的长度相等并且对应位置的字符相同，则串相等，返回0；
如果串s对应位置的字符大于该串的字符或者如果串s的长度大于该串，
而在该串的长度返回内二者对应位置的字符相同，则返回-1，该串小于串s；
其余情况返回1，该串大于串s。
             */
            int len = ((this.GetLength() <= s.GetLength()) ? this.GetLength() : s.GetLength());//求最小长度
            int i = 0;//循环次数
            for (i = 0; i < len; ++i)//循环比较
            {
                if (this[i] != s[i])//不相等时
                {
                    break;//跳出
                }
            }
            #region//循环完毕,比较不相等位数的char
            if (i <= len)//循环次数<=最小长度
            {
                if (this[i] < s[i])//<
                {
                    return -1;
                }
                else if (this[i] > s[i])
                {
                    return 1;
                }
            }
            #endregion
            else if (this.GetLength() == s.GetLength())////循环比较到末尾
            {
                return 0;
            }
            else if (this.GetLength() < s.GetLength())
            {
                return -1;
            }
            //else ( this.GetLength() > s.GetLength() )
            return 1;
        }

        public StringDS SubString(int index, int len)//求子串
        {

            if ( (index < 0) || ( index > this.GetLength()–1 ) || (len < 0) || (len > this.GetLength()–index)  )
            {
                Console.WriteLine("Position or Length is error!");
                return null;
            }
            StringDS s = new StringDS(len);
            for (int i = 0; i < len; ++i)
            {
                s[i] = this[i + index - 1];
            }
            return s;
        }

        public StringDS Concat(StringDS s)//串连接

        {
            StringDS s1 = new StringDS(this.GetLength() +
            s.GetLength());
            for (int i = 0; i < this.GetLength(); ++i)
            {
                s1.data[i] = this[i];
            }
            for (int j = 0; j < s.GetLength(); ++j)
            {
                s1.data[this.GetLength() + j] = s[j];
            }
            return s1;
        }

        public StringDS Insert(int index, StringDS s)//串插入
        {
            int len = s.GetLength();
            int len2 = len + this.GetLength();
            StringDS s1 = new StringDS(len2);
            if (index < 0 || index > this.GetLength() - 1)
            {
                Console.WriteLine("Position is error!");
                return null;
            }
            for (int i = 0; i < index; ++i)
            {
                s1[i] = this[i];
            }
            for (int i = index; i < index + len; ++i)
            {
                s1[i] = s[i - index];
            }
            for (int i = index + len; i < len2; ++i)
            {
                s1[i] = this[i - len];
            }
            return s1;
        }

        public StringDS Delete(int index, int len)//串删除
        {
            if ((index < 0) || (index > this.GetLength() - 1)
            || (len < 0) || (len > this.GetLength() - index))
            {
                Console.WriteLine("Position or Length is error!");
                return null;
            }
            StringDS s = new StringDS(this.GetLength() - len);
            for (int i = 0; i < index; ++i)
            {
                s[i] = this[i];
            }
            for (int i = index + len; i < this.GetLength(); ++i)
            {
                s[i] = this[i];
            }
            return s;
        }

        public int Index(StringDS s)//串定位
        {
            if (this.GetLength() < s.GetLength())
            {
                Console.WriteLine("There is not string s!");
                return -1;
            }
            int i = 0;
            int len = this.GetLength() - s.GetLength();
            while (i < len)
            {
                if (this.Compare(s) == 0)
                {
                    break;
                }
            }
            if (i <= len)
            {
                return i;
            }
            return -1;
        }
    }//public class StringDS
}//namespace StringChapter.Body
