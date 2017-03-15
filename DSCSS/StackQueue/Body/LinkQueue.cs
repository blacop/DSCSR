using StackQueue.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue.Body {
    //链队列类LinkQueue<T> 的实现说明如下所示。
    //数据结构（C#语言版）3.2 队列 99
    public class LinkQueue<T> : IQueue<T> {
        private Node<T> front; //队列头指示器
        private Node<T> rear; //队列尾指示器
        private int num; //队列结点个数        
        public Node<T> Front//队头属性
        {
            get {
                return front;
            }
            set {
                front = value;
            }
        }//队头属性
        public Node<T> Rear//队尾属性
        {
            get {
                return rear;
            }
            set {
                rear = value;
            }
        }//队尾属性
        public int Num//队列结点个数属性
        {
            get {
                return num;
            }
            set {
                num = value;
            }
        }//队列结点个数属性
        public LinkQueue()//构造器
        {
            front = rear = null;
            num = 0;
        }//构造器
        public int GetLength()//求链队列的长度
        {
            return num;
        }//求链队列的长度
        public void Clear()//清空链队列
        {
            front = rear = null;
            num = 0;
        }//清空链队列
        public bool IsEmpty()//判断链队列是否为空
        {
            if ((front == rear) && (num == 0)) {
                return true;
            } else {
                return false;
            }
        }//判断链队列是否为空
        public void In(T item)//入队
        {
            Node<T> q = new Node<T>(item);
            if (rear == null) {
                rear = q;
            } else {
                rear.Next = q;
                rear = q;
            }
            ++num;
        }//入队
        public T Out()//出队
        {
            if (IsEmpty()) {
                Console.WriteLine("Queue is empty!");
                return default(T);
            }
            Node<T> p = front;
            front = front.Next;
            if (front == null) {
                rear = null;
            }
            --num;
            return p.Data;
        }//出队
        public T GetFront()//获取链队列头结点的值
        {
            if (IsEmpty()) {
                Console.WriteLine("Queue is empty!");
                return default(T);
            }
            return front.Data;
        }//获取链队列头结点的值
    }//public class LinkQueue<T> : IQueue<T>
}//namespace StackQueueChapter.Body.LinkedQueue
