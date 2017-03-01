using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class LinkList<T> : IListDS<T> //单链表类 LinkList<T>的实现说明如下所示。
    {
        private Node<T> head; //单链表的头引用                              
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
        //构造器
        public LinkList()
        {
            head = null;
        }
        //求单链表的长度
        public int GetLength()
        { }
    }
}
