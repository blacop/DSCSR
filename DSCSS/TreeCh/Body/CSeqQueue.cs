using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeCh.Interface;

namespace TreeCh.Body {
    //循环顺序队列类CSeqQueue<T> 的实现说明如下所示。
    //初始化init:front = rear = -1;
    public class CSeqQueue<T> : IQueue<T> {
        private T[] data; //数组，用于存储循环顺序队列中的数据元素
        private int maxsize; //循环顺序队列的容量        
        private int front; //指示循环顺序队列的队头
        private int rear; //指示循环顺序队列的队尾
        public T this[int index]//索引器
        {
            get {
                return data[index];
            }
            set {
                data[index] = value;
            }
        }
        public int Maxsize//容量属性
        {
            get {
                return maxsize;
            }
            set {
                maxsize = value;
            }
        }
        public int Front//队头属性
        {
            get {
                return front;
            }
            set {
                front = value;
            }
        }
        public int Rear//队尾属性
        {
            get {
                return rear;
            }
            set {
                rear = value;
            }
        }
        public CSeqQueue(int size)//构造器
        {
            data = new T[size];
            maxsize = size;
            front = rear = -1;
        }
        public int GetLength()//求循环顺序队列的长度
        {
            return (rear - front + maxsize) % maxsize;
        }
        public void Clear()//清空循环顺序队列
        {
            front = rear = -1;
        }
        public bool IsEmpty()//判断循环顺序队列是否为空
        {
            if (front == rear) {
                return true;
            } else {
                return false;
            }
        }
        public bool IsFull()//判断循环顺序队列是否为满
        {
            if ((rear + 1) % maxsize == front) {
                return true;
            } else {
                return false;
            }
        }
        public void In(T item)//入队
        {
            if (IsFull()) {
                Console.WriteLine("Queue is full");
                return;
            }
            data[++rear] = item;
        }
        public T Out()//出队
        {
            T tmp = default(T);
            if (IsEmpty()) {
                Console.WriteLine("Queue is empty");
                return tmp;
            }
            tmp = data[++front];
            return tmp;
        }
        public T GetFront()//获取队头数据元素
        {
            if (IsEmpty()) {
                Console.WriteLine("Queue is empty!");
                return default(T);
            }
            return data[front + 1];
        }
    }//public class CSeqQueue<T> : IQueue<T>
}//namespace StackQueue.Body
