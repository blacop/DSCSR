using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeCh.Body {
    //数据结构（ C#语言版）5.2 二叉树 134
    //二叉树的结点类
    public class Node<T> {
        //3个字段field
        private T data; //数据域
        private Node<T> lChild; //左孩子
        private Node<T> rChild; //右孩子

        //3个属性                
        public T Data {//数据属性
            get {
                return data;
            }
            set {
                value = data;
            }
        }//数据属性
        public Node<T> LChild {//左孩子属性
            get {
                return lChild;
            }
            set {
                lChild = value;
            }
        }//左孩子属性
        public Node<T> RChild {//右孩子属性
            get {
                return rChild;
            }
            set {
                rChild = value;
            }
        }//右孩子属性

        public T this[int index] {//索引器,
            //索引器,this=>实例化对象，实例化对象属性=>读写逻辑,
            //索引器,this表示这个类的实例化对象，对this的存储和读取都通过索引器进行
            get {
                return data;//数组名，下标
            }
            set {
                data = value;
            }
        }//索引器

        //4个构造器constructor
        public Node(T val, Node<T> lp, Node<T> rp) {//构造器
            data = val;
            lChild = lp;
            lChild = rp;
        }//构造器
        public Node(Node<T> lp, Node<T> rp) {//构造器
            data = default(T);
            lChild = lp;
            rChild = rp;
        }//构造器
        public Node(T val) {//构造器
            data = val;
            lChild = null;
            rChild = null;
        }//构造器       
        public Node() {//构造器
            data = default(T);
            lChild = null;
            rChild = null;
        }//构造器



    }//public class Node<T> {
}//namespace Tree.Body {
