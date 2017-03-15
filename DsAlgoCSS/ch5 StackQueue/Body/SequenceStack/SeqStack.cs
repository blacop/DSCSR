using StackQueueChapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueChapter.Body.SequenceStack {
    //顺序栈类SeqStack<T> 的实现说明如下所示。
    public class SeqStack<T> : IStack<T> {
        //C 的Stack 的 Top 指向last+1
        //C# 的Stack 的 Top指向last
        private T[] data; //数组，用于存储顺序栈中的数据元素 data
        private int maxsize; //顺序栈的容量
        private int top; //指示顺序栈的栈顶 ref
        public T this[int index] {
            get {
                return data[index];
            }
            set {
                data[index] = value;
            }
        }//索引器//public T this[int index]       
        public int Maxsize {
            get {
                return maxsize;
            }
            set {
                maxsize = value;
            }
        }//容量属性
        public int Top {
            get {
                return top;
            }
        }//栈顶属性
        public SeqStack(int size) {
            data = new T[size];
            maxsize = size;
            top = -1;
        }//构造器
        public int GetLength() {
            return top + 1;
        }//求栈的长度
        public void Clear() {
            top = -1;
        }//清空顺序栈
        public bool IsEmpty() {
            if (top == -1) {
                return true;
            } else {
                return false;
            }
        }//判断顺序栈是否为空
        public bool IsFull() {
            if (top == maxsize - 1) {
                return true;
            } else {
                return false;
            }
        }//判断顺序栈是否为满
        public void Push(T item) {
            if (IsFull()) {
                Console.WriteLine("Stack is full");
                return;
            }
            data[++top] = item;
        }//入栈
        public T Pop() {
            T tmp = default(T);
            if (IsEmpty()) {
                Console.WriteLine("Stack is empty");
                return tmp;
            }
            tmp = data[top];
            --top;
            return tmp;
        }//出栈
        public T GetTop() {
            if (IsEmpty()) {
                Console.WriteLine("Stack is empty!");
                return default(T);
            }
            return data[top];
        }//获取栈顶数据元素
    }//public class SeqStack<T> : IStack<T>
}//namespace StackQueueChapter

