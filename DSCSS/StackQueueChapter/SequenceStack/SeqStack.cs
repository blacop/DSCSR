using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueChapter.SequenceStack
{
    //顺序栈类SeqStack<T> 的实现说明如下所示。
    public class SeqStack<T> : IStack<T>
    {
        //C 的Stack 的 Top 指向last+1
        //C# 的Stack 的 Top指向last
        private T[] data; //数组，用于存储顺序栈中的数据元素 data
        private int maxsize; //顺序栈的容量
        private int top; //指示顺序栈的栈顶 ref
        public T this[int index]//索引器
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }//public T this[int index]       
        public int Maxsize //容量属性
        {
            get
            {
                return maxsize;
            }
            set
            {
                maxsize = value;
            }
        }
        public int Top//栈顶属性
        {
            get
            {
                return top;
            }
        }
        public SeqStack(int size)//构造器
        {
            data = new T[size];
            maxsize = size;
            top = -1;
        }
        public int GetLength()//求栈的长度
        {
            return top + 1;
        }
        public void Clear()//清空顺序栈
        {
            top = -1;
        }
        public bool IsEmpty()//判断顺序栈是否为空
        {
            if (top == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsFull()//判断顺序栈是否为满
        {
            if (top == maxsize - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Push(T item)//入栈
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full");
                return;
            }
            data[++top] = item;
        }
        public T Pop()//出栈
        {
            T tmp = default(T);
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return tmp;
            }
            tmp = data[top];
            --top;
            return tmp;
        }
        public T GetTop()//获取栈顶数据元素
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return default(T);
            }
            return data[top];
        }
    }//public class SeqStack<T> : IStack<T>
}//namespace StackQueueChapter

