using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeCh.Huffman {
    //    哈夫曼树类 HuffmanTree 中只有一个成员方法 Create，它的功能是输入 n 个
    //叶子结点的权值，创建一棵哈夫曼树。哈夫曼树类 HuffmanTree 的实现如下。
    public class HuffmanTree {
        //2个字段
        private Node[] data; //结点数组，是个连续的内存空间
        private int leafNum; //叶子结点数目

        //2个属性
        //索引器
        public Node this[int index] {
            get {
                return data[index];
            }
            set {
                data[index] = value;
            }
        }
        //叶子结点数目属性
        public int LeafNum {
            get {
                return leafNum;
            }
            set {
                leafNum = value;
            }
        }

        //构造器，int n是length
        public HuffmanTree(int n) {
            data = new Node[2 * n - 1]; //分配数组内存
            leafNum = n;
        }
            



    }//!_public class HuffmanTree
}//!_namespace TreeCh.Huffman
