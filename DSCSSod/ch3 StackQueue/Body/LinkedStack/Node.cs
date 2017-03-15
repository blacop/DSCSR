using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueChapter.Body.LinkedStack
{
    /*数据结构（C#语言版）
3.1 栈 77*/
    //链栈结点类(Node<T>)的实现如下：
    public class Node<T>
    {
        private T data; //数据域
        private Node<T> next; //引用域
        public Node(T val, Node<T> p)//构造器
        {
            data = val;
            next = p;
        }
        public Node(Node<T> p)//构造器
        {
            next = p;
        }
        public Node(T val)//构造器
        {
            data = val;
            next = null;
        }
        public Node()//构造器
        {
            data = default(T);
            next = null;
        }
        public T Data//数据域属性
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
        public Node<T> Next//引用域属性
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }
    }//public class Node<T>
}//namespace StackQueueChapter.LinkedStack
