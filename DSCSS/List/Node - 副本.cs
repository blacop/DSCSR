using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class Node<T> //单链表结点类的实现
    {
        private T data; //数据域 字段
        private Node<T> next; //引用域 字段                
        public Node(T val, Node<T> p)//构造器，4个重载，参数 数据域 引用域
        {
            data = val;
            next = p;
        }
        public Node(Node<T> p)//构造器,参数 引用域
        {
            next = p;
        }        
        public Node(T val) //构造器，参数 数据域
        {
            data = val;
            next = null;
        }        
        public Node() //构造器，参数 无参
        {
            data = default(T); 
            next = null;
        }       
        public T Data //数据域属性
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
        public Node<T> Next //引用域属性
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
    }
}
