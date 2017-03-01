﻿using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class LinkList<T> : IListDS<T> //单链表类 LinkList<T>的实现说明如下所示。
    {
        private Node<T> head; //单链表的头引用 字段 
        public Node<T> Head //头引用属性，对头引用字段操作，get方法得到head的引用
        { //将头引用属性 作为了head的引用
            //LinkList.head.get方法得到head的引用,这是C#的可以在head存数据的原因
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
            //C语言的Head不存储数据，只存储Node1的引用
            //Head其实也可以存放数据，C#的这本书里是这样
            head = null;//将head 作为字段//CLang:head.next = null;
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
            head = null;//CLang:head.next = null;
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
        public void InsertPost(T item, int i) //在单链表的第i个结点的位置后插入一个值为item的结点
        {
            if (IsEmpty() || i < 1)
            {
                Console.WriteLine("List is empty or Position is error!");
                return;
            }
            if (i == 1)
            {
                Node<T> q = new Node<T>(item);
                q.Next = head.Next;
                head.Next = q;
                return;
            }
            Node<T> p = head;
            int j = 1;
            while (p != null && j < i)
            {
                p = p.Next;
                ++j;
            }
            if (j == i)
            {
                Node<T> q = new Node<T>(item);
                q.Next = p.Next;
                p.Next = q;
            }
        }
        public T Delete(int i) //删除单链表的第i个结点
        {
            if (IsEmpty() || i < 0)
            {
                Console.WriteLine("Link is empty or Position is
                error!");
            return default(T);
            }
            Node<T> q = new Node<T>();
            if (i == 1)
            {
                q = head;
                head = head.Next;
                return q.Data;
            }
            Node<T> p = head;
            int j = 1;
            while (p.Next != null && j < i)
            {
                ++j;
                q = p;
                p = p.Next;
            }
            if (j == i)
            {
                q.Next = p.Next;
                return p.Data;
            }
            else
            {
                Console.WriteLine("The ith node is not exist!");
                return default(T);
            }
        }
        public T GetElem(int i) //获得单链表的第i个数据元素
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty!");
                return default(T);
            }
            Node<T> p = new Node<T>();
            p = head;
            int j = 1;
            while (p.Next != null && j < i)
            {
                p = p.Next;
            }
            if (j == i)
            {
                return p.Data;
            }
            else
            {
                Console.WriteLine("The ith node is not exist!");
                return default(T);
            }
        }
        public int Locate(T value)  //在单链表中查找值为value的结点
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty!");
                return -1;
            }
            Node<T> p = new Node<T>();
            p = head;
            int i = 1;
            while (!p.Data.Equals(value) && p.Next != null)
            {
                P = p.Next;
                ++i;
            }
            return i;
        }
        public int GetLength() //求单链表长度的算法
        {
            Node<T> p = head;
            int len = 0;
            while (p != null)
            {
                ++len;
                p = p.Next;
            }
            return len;
            //时间复杂度分析：求单链表的长度需要遍历整个链表，
            //所以，时间复杂度为
            //O(n)， n 是单链表的长度。
        }

    }
}

