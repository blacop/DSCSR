using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeChapter.Body {
    //数据结构（ C#语言版）5.2 二叉树 134
    public class Node<T> {
        private T data; //数据域
        private Node<T> lChild; //左孩子
        private Node<T> rChild; //右孩子
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
    }//public class Node<T> {
}//namespace TreeChapter.Body {
