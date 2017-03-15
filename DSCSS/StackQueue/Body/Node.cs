using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue.Body {    
    public class Node<T> {
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
            get {
                return data;
            }
            set {
                data = value;
            }
        }
        public Node<T> Next//引用域属性
        {
            get {
                return next;
            }
            set {
                next = value;
            }
        }
    }//public class Node<T>
}//namespace StackQueue.Body
