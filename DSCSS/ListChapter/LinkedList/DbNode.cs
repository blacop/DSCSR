using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProject.LinkList {
    //双向链表
    /*
    数据结构（C#语言版）
2.4 其他链表 62*/
    public class DbNode<T> {
        private T data; //数据域
        private DbNode<T> prev; //前驱引用域
        private DbNode<T> next; //后继引用域

        public DbNode(T val, DbNode<T> p)//构造器
        {   //构造器
            data = val;
            next = p;
        }
        //构造器
        public DbNode(DbNode<T> p) {
            next = p;
        }
        //构造器
        public DbNode(T val) {
            data = val;
            next = null;
        }
        //构造器
        public DbNode() {
            data = default(T);
            next = null;
        }
        //数据域属性
        public T Data {
            get {
                return data;
            }
            set {
                data = value;
            }
        }
        //前驱引用域属性
        public DbNode<T> Prev {
            get {
                return prev;
            }
            set {
                prev = value;
            }
        }
        //后继引用域属性
        public DbNode<T> Next {
            get {
                return next;
            }
            set {
                next = value;
            }
        }
        /*      由于双向链表的结点有两个引用，所以，
         * 在双向链表中插入和删除结点比单链表要复杂。
         * 双向链表中结点的插入分为在结点之前插入和在结点之后插入，
         * 插入操作要对四个引用进行操作。
         * 下面以在结点之后插入结点为例来说明在双向链表中插入结点的情况。
         *      设p是指向双向链表中的某一结点，即p存储的是该结点的地址，
         * 现要将一个结点s插入到结点p的后面，
         * 插入过程如图2.16所示（以p的直接后继结点存在为例）。*/

        /*操作如下：
        ➀ p.Next.Prev = s;
        ➁ s.Prev = p;
        ➂ s.Next = p.Next;
        ➃ p.Next = s;*/
        /*后删除法，操作如下：
        ➀p.Next = P.Next.Next;
        ➁p.Next.Next.Prev = p;*/
        /*中删除法
        p.Prev.Next = P.Next;
        p.Next.Prev = p.Prev;*/
    }
}

