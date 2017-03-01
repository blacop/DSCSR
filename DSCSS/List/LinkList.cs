using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class LinkList<T> : IListDS<T> //单链表类 LinkList<T>的实现说明如下所示。
    {
        private Node<T> head; //单链表的头引用 字段                             
        public Node<T> Head //头引用属性
        {
            get
            {
                return head;
            }
            set
            {
                head = value;
            }
        }
        public LinkList() //构造器,构造的时候自动加head
        {
            head.next = null;//将head 作为属性
        }
        public int GetLength() //求单链表的长度
        {
            Node<T> p = head;
            int len = 0;
            while (p != null)
            {
                ++len;
                p = p.Next;
            }
            return len;
        }
        public void Clear() //清空单链表,c#里面Clear和Destroy和二为一，Free()释放内存由GC垃圾清理自动完成
        {
            head.next = null;
        }
        public bool IsEmpty() //判断单链表是否为空
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Append(T item) //在单链表的末尾添加新元素
        {
            Node<T> q = new Node<T>(item);//insert node
            Node<T> p = new Node<T>();
            if (head.next == null)
            {
                head.next = q;//C#里的head是一个空Node,next引用指向后继结点
                return;
            }
            p = head;
            while (p.Next != null)
            {
                p = p.Next;//ptr++
            }
            p.Next = q;
        }        
        public void Insert(T item, int i) //在单链表的第i个结点的位置前插入一个值为item的结点
        {
            if (IsEmpty() || i < 1)
            {
                Console.WriteLine("List is empty or Position is error!");
                return;
            }
            if (i == 1)
            {
                Node<T> q = new Node<T>(item);
                q.Next = head;
                head = q;
                return;
            }
            Node<T> p = head;
            Node<T> r = new Node<T>();
            int j = 1;
            while (p.Next != null && j < i)
            {
                r = p;
                p = p.Next;
                ++j;
            }
            if (j == i)
            {
                Node<T> q = new Node<T>(item);
                q.Next = p;
                r.Next = q;
            }
        }
        //在单链表的第i个结点的位置后插入一个值为item的结点
    }
}
