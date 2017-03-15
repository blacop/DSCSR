using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringChapter.Body {
    //ADT 串类StringDS 的C#实现如下所示：
    public class StringDS {
        private char[] data; //字符数组
        public char this[int index] { //索引器,只读
            get {
                return data[index];
            }
            set {
                data[index] = value;
            }
        } //索引器,只读
        public StringDS(char[] arr) { //构造器,Init(),字符串赋值方法
            data = new char[arr.Length]; //字符数组 实例化
            for (int i = 0; i < arr.Length; ++i) { //遍历赋值
                data[i] = arr[i]; //遍历赋值
            }
        } //构造器
        public StringDS(StringDS s) { //构造器
            for (int i = 0; i < this.GetLength(); ++i) {
                data[i] = s[i];
            }
        } //构造器
        public StringDS(int len) { //构造器
            char[] arr = new char[len];
            data = arr;
        } //构造器
        public int GetLength() { //求串长
            return data.Length;
        }//求串长
        public int CompareStringLength(StringDS s) { //串长度比较
            if (this.GetLength() > s.GetLength()) {
                return 1;
            } else if (this.GetLength() == s.GetLength()) {
                return 0;
            } else {// this.GetLength() <= s.GetLength()
                return -1;
            }
        }
        /*串比较
        如果两个串的长度相等并且对应位置的字符相同，则串相等，返回0；
        如果串s对应位置的字符大于该串的字符或者如果串s的长度大于该串，
        而在该串的长度返回内二者对应位置的字符相同，则返回-1，该串小于串s；
        其余情况返回1，该串大于串s。
        */
        /* int len;
        if ((this.GetLength() <= s.GetLength()) {
            len = this.GetLength();
        } else {
            len = s.GetLength();
        }
        */
        public int Compare(StringDS s) { //串值比较            
            int len = ((this.GetLength() <= s.GetLength()) ? this.GetLength() : s.GetLength());//先 比出2个串的相对较小的长度
            int i = 0;//循环次数
            for (i = 0; i < len; ++i) { //循环比较
                if (this[i] != s[i]) { //不相等时
                    break;//跳出
                }
            } //循环比较 //for (i = 0; i < len; ++i)
            #region//判断相同的位数的值相等 循环完毕,比较不相等位数的char值
            if (i <= len) { //先循环 判断相同的位数的值相等 完毕,比较不相等位数的char值 //循环次数<=最小长度
                if (this[i] < s[i]) {
                    return -1;
                } else if (this[i] > s[i]) {
                    return 1;
                } //循环完毕,比较不相等位数的char值
            } //先循环 判断相同的位数的值相等 完毕,比较不相等位数的char值
            #endregion
            else if (this.GetLength() == s.GetLength()) { //所有的值都相等 循环比较到末尾后,判断长度
                return 0;
            } else if (this.GetLength() < s.GetLength()) {
                return -1;
            }//循环比较到末尾后,判断长度
            //else ( this.GetLength() > s.GetLength() )
            return 1;
        } //串比较
        /* BinSearch()的泛型方法写不出来
        public int GetIndex(char x) {
            int index;
            BinSearch(x);
            return index;
        }
        */
        public bool IndexIsLegal(int index) { //下标合法
            if ((index < 0) || (index > this.GetLength() - 1)) {
                return false;
            } else {
                return true;
            }
        } //串下标合法
        public bool SubStringLengthIsLegal(int StartIndex, int Length) { //取子串输入的下标和长度合法 index=>StartIndex
            if ((Length < 0) || (Length > this.GetLength() - StartIndex)) {
                return false;
            } else {
                return true;
            }
        } //取子串输入的下标和长度合法
        public StringDS SubString(int index, int len) { //求子串,index=>StartIndex,len=>Length
            bool legal = (index < 0) || (index > this.GetLength() - 1);
            if (!IndexIsLegal(index) || !SubStringLengthIsLegal(index, len)) { //下标合法 || 取子串输入的下标和长度合法 
                Console.WriteLine("Position or Length is error!");
                return null;
            }
            StringDS s = new StringDS(len);
            for (int i = 0; i < len; ++i) {
                s[i] = this[i + index - 1];
            }
            return s;
        }

        public StringDS Concat(StringDS s)//串连接

        {
            StringDS s1 = new StringDS(this.GetLength() +
            s.GetLength());
            for (int i = 0; i < this.GetLength(); ++i) {
                s1.data[i] = this[i];
            }
            for (int j = 0; j < s.GetLength(); ++j) {
                s1.data[this.GetLength() + j] = s[j];
            }
            return s1;
        }

        public StringDS Insert(int index, StringDS s)//串插入
        {
            int len = s.GetLength();
            int len2 = len + this.GetLength();
            StringDS s1 = new StringDS(len2);
            if (index < 0 || index > this.GetLength() - 1) {
                Console.WriteLine("Position is error!");
                return null;
            }
            for (int i = 0; i < index; ++i) {
                s1[i] = this[i];
            }
            for (int i = index; i < index + len; ++i) {
                s1[i] = s[i - index];
            }
            for (int i = index + len; i < len2; ++i) {
                s1[i] = this[i - len];
            }
            return s1;
        }

        public StringDS Delete(int index, int len)//串删除
        {
            if ((index < 0) || (index > this.GetLength() - 1)
            || (len < 0) || (len > this.GetLength() - index)) {
                Console.WriteLine("Position or Length is error!");
                return null;
            }
            StringDS s = new StringDS(this.GetLength() - len);
            for (int i = 0; i < index; ++i) {
                s[i] = this[i];
            }
            for (int i = index + len; i < this.GetLength(); ++i) {
                s[i] = this[i];
            }
            return s;
        }

        public int Index(StringDS s)//串定位
        {
            if (this.GetLength() < s.GetLength()) {
                Console.WriteLine("There is not string s!");
                return -1;
            }
            int i = 0;
            int len = this.GetLength() - s.GetLength();
            while (i < len) {
                if (this.Compare(s) == 0) {
                    break;
                }
            }
            if (i <= len) {
                return i;
            }
            return -1;
        }
    }//public class StringDS
}//namespace StringChapter.Body
