using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class Node<T> //单链表结点类的实现
    {
        private T data; //数据域 字段
        private Node<T> next; //引用域 字段                
        public Node(T val, Node<T> p)//构造器
        {
            data = val;
            next = p;
        }
        public Node(Node<T> p)//构造器,参数 引用域,重载形式的构造器，单参数构造，包含双参数构造
        {
            next = p;
        }        
        public Node(T val) //构造器
        {
            data = val;
            next = null;
        }        
        public Node() //构造器
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
