using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueChapter.LinkedStack
{
    /*数据结构（C#语言版）
3.1 栈 79*/
    //链栈类LinkStack<T> 的实现说明如下所示。
    public class LinkStack<T> : IStack<T>
    {
        private Node<T> top; //栈顶指示器
        private int num; //栈中结点的个数                         
        public Node<T> Top//栈顶指示器属性
        {
            get
            {
                return top;
            }
            set
            {
                top = value;
            }
        }
        public int Num//元素个数属性
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }
        public LinkStack()//构造器
        {
            top = null;
            num = 0;
        }
        public int GetLength()//求链栈的长度
        {
            return num;
        }
        public void Clear()//清空链栈
        {
            top = null;
            num = 0;
        }
        public bool IsEmpty()//判断链栈是否为空
        {
            if ((top == null) && (num == 0))
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
            Node<T> q = new Node<T>(item);
            if (top == null)
            {
                top = q;
            }
            else
            {
                q.Next = top;//head append
                top = q;
            }
            ++num;
        }        
        public T Pop()//出栈
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return default(T);
            }
            Node<T> p = top;
            top = top.Next;//top move next
            --num;
            return p.Data;
        }        
        public T GetTop()//获取栈顶结点的值
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return default(T);
            }
            return top.Data;
        }
    }//public class LinkStack<T> : IStack<T>
}//namespace StackQueueChapter.LinkedStack
