using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeCh.Huffman {
    //结点类 Node 的定义如下：
    public class Node {
        private int weight; //结点权值
        private int lChild; //左孩子结点
        private int rChild; //右孩子结点
        private int parent; //父结点

        //结点权值属性
        public int Weight {
            get {
                return weight;
            }
            set {
                weight = value;
            }
        }
        //左孩子结点属性
        public int LChild {
            get {
                return lChild;
            }
            set {
                lChild = value;
            }
        }
        //右孩子结点属性
        public int RChild {
            get {
                return rChild;
            }
            set {
                rChild = value;
            }
        }
        //父结点属性
        public int Parent {
            get {
                return parent;
            }
            set {
                parent = value;
            }
        }
        //构造器
        public Node() {
            weight = 0;
            lChild = -1;
            rChild = -1;
            parent = -1;
        }
        //构造器
        public Node(int w, int lc, int rc, int p) {
            weight = w;
            lChild = lc;
            rChild = rc;
            parent = p;
        }
    }
}
