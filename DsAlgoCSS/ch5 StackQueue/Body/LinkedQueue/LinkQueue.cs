using StackQueueChapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueChapter.Body.LinkedQueue
{
    //链队列类LinkQueue<T> 的实现说明如下所示。
    //数据结构（C#语言版）3.2 队列 99
    public class LinkQueue<T> : IQueue<T>
    {
        private Node<T> front; //队列头指示器
        private Node<T> rear; //队列尾指示器
        private int num; //队列结点个数        
        public Node<T> Front//队头属性
        {
            get
            {
                return front;
            }
            set
            {
                front = value;
            }
        }
        public Node<T> Rear//队尾属性
        {
            get
            {
                return rear;
            }
            set
            {
                rear = value;
            }
        }
        public int Num//队列结点个数属性
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
        public LinkQueue()//构造器
        {
            front = rear = null;
            num = 0;
        }
        public int GetLength()//求链队列的长度
        {
            return num;
        }
        public void Clear()//清空链队列
        {
            front = rear = null;
            num = 0;
        }
        public bool IsEmpty()//判断链队列是否为空
        {
            if ((front == rear) && (num == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void In(T item)//入队
        {
            Node<T> q = new Node<T>(item);
            if (rear == null)
            {
                rear = q;
            }
            else
            {
                rear.Next = q;
                rear = q;
            }
            ++num;
        }
        public T Out()//出队
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty!");
                return default(T);
            }
            Node<T> p = front;
            front = front.Next;
            if (front == null)
            {
                rear = null;
            }
            --num;
            return p.Data;
        }
        public T GetFront()//获取链队列头结点的值
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty!");
                return default(T);
            }
            return front.Data;
        }
    }//public class LinkQueue<T> : IQueue<T>
}//namespace StackQueueChapter.Body.LinkedQueue
