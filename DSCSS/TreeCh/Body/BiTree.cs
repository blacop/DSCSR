using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeCh.Body {
    //数据结构（ C#语言版）5.2 二叉树 135
    //不带头引用的二叉树
    //二叉树的类
    public class BiTree<T> {
        private Node<T> head; //头引用
        public Node<T> Head {//头引用属性
            get {
                return head;
            }
            set {
                head = value;
            }
        }//头引用属性
        public BiTree() {//构造器
            head = null;
        }//构造器
        public BiTree(T val) {//构造器
            Node<T> p = new Node<T>(val);//实例化一个结点，节点的构造器
            head = p;//头引用指向结点
        }//构造器
        public BiTree(T val, Node<T> lp, Node<T> rp) {//构造器
            Node<T> p = new Node<T>(val, lp, rp);//实例化一个结点，节点的构造器
            head = p;//头引用指向结点
        }//构造器        
        public bool IsEmpty() {//判断是否是空二叉树
            if (head == null) {
                return true;
            } else {
                return false;
            }
        }//判断是否是空二叉树

        public Node<T> Root() {//获取根结点
            return head;
        }//获取根结点        
        public Node<T> GetLChild(Node<T> p) {//获取结点的左孩子结点
            return p.LChild;
        }//获取结点的左孩子结点
        public Node<T> GetRChild(Node<T> p) {//获取结点的右孩子结点
            return p.RChild;
        }//获取结点的右孩子结点     

        public void InsertL(T val, Node<T> p) { //插入到p的左子树
            //将结点p的左子树插入值为val的新结点，
            //原来的左子树成为新结点的左子树
            Node<T> tmp = new Node<T>(val);
            tmp.LChild = p.LChild;
            p.LChild = tmp;
        }
        public void InsertR(T val, Node<T> p) { //插入到p的右子树
            //将结点p的右子树插入值为val的新结点，
            //原来的右子树成为新结点的右子树
            Node<T> tmp = new Node<T>(val);
            tmp.RChild = p.RChild;
            p.RChild = tmp;
        }

        public Node<T> DeleteL(Node<T> p) {//若p非空，删除p的左子树
            if ((p == null) || (p.LChild == null)) {
                return null;
            }
            Node<T> tmp = p.LChild;
            p.LChild = null;
            return tmp;
        }//若p非空，删除p的左子树

        public Node<T> DeleteR(Node<T> p) {//若p非空，删除p的右子树
            if ((p == null) || (p.RChild == null)) {
                return null;
            }
            Node<T> tmp = p.RChild;
            p.RChild = null;
            return tmp;
        }//若p非空，删除p的右子树

        //判断是否是叶子结点
        public bool IsLeaf(Node<T> p) {
            if ((p != null) && (p.LChild == null) && (p.RChild == null)) {
                return true;
            } else {
                return false;
            }
        }
        //1、 先序遍历（ DLR）
        public void PreOrder(Node<T> root) {
            //根结点为空
            if (root == null) {
                return;
            }
            //处理根结点
            Console.WriteLine("{0}", root.Data);

            //先序遍历左子树
            PreOrder(root.LChild);
            //先序遍历右子树
            PreOrder(root.RChild);
        }

        //2、 中序遍历（ LDR）
        //中序遍历的基本思想是：首先中序遍历根结点的左子树，然后访问根结点，
        //最后中序遍历其右子树。中序遍历的递归算法实现如下：
        public void InOrder(Node<T> root) {
            //根结点为空
            if (root == null) {
                return;
            }
            //中序遍历左子树
            InOrder(root.LChild);
            //处理根结点
            Console.WriteLine("{0}", root.Data);
            //中序遍历右子树
            InOrder(root.RChild);
        }

        //3、 后序遍历（ LRD）
        //后序遍历的基本思想是：首先后序遍历根结点的左子树，然后后序遍历根结
        //点的右子树，最后访问根结点。后序遍历的递归算法实现如下，
        public void PostOrder(Node<T> root) {
            //根结点为空
            if (root == null) {
                return;
            }
            //后序遍历左子树
            PostOrder(root.LChild);
            //后序遍历右子树            
            PostOrder(root.RChild);
            //处理根结点
            Console.WriteLine("{0}", root.Data);
        }

        //4、 层序遍历（Level Order）
        //层序遍历的基本思想是：由于层序遍历结点的顺序是先遇到的结点先访问，
        //与队列操作的顺序相同。所以，在进行层序遍历时，设置一个队列,将根结点引
        //用入队，当队列非空时，循环执行以下三步：
        //（ 1） 从队列中取出一个结点引用，并访问该结点；
        //（2） 若该结点的左子树非空，将该结点的左子树引用入队；
        //（3） 若该结点的右子树非空，将该结点的右子树引用入队；
        //层序遍历的算法实现如下：
        public void LevelOrder(Node<T> root) {
            //根结点为空
            if (root == null) {
                return;
            }
            //设置一个队列保存层序遍历的结点
            CSeqQueue<Node<T>> sq = new CSeqQueue<Node<T>>(50);
            //根结点入队
            sq.In(root);
            //队列非空，结点没有处理完
            while (!sq.IsEmpty()) {
                //结点出队
                Node<T> tmp = sq.Out();
                //处理当前结点
                Console.WriteLine("{o}", tmp);

                //将当前结点的左孩子结点入队
                if (tmp.LChild != null) {
                    sq.In(tmp.LChild);
                }
                //将当前结点的右孩子结点入队                
                if (tmp.RChild != null) {
                    sq.In(tmp.RChild);
                }
            }
        }

        //        【例 5-1】编写算法，在二叉树中查找值为 value 的结点。
        //算法思路：在二叉树中查找具有某个特定值的结点就是遍历二叉树，对于遍
        //历到的结点，判断其值是否等于 value，如果是则返回该结点，否则返回空。本
        //节例题的算法都作为 BiTree<T> 的成员方法。
        Node<T> Search(Node<T> root, T value) {
            Node<T> p = root;
            if (p == null) {
                return null;
            }
            if (!p.Data.Equals(value)) {
                return p;
            }
            if (p.LChild != null) {
                return Search(p.LChild, value);
            }
            if (p.RChild != null) {
                return Search(p.RChild, value);
            }
            return null;
        }

        //【例 5-2】统计出二叉树中叶子结点的数目。
        int CountLeafNode(Node<T> root) {
            if (root == null) {
                return 0;
            } else if (root.LChild == null && root.RChild == null) {
                return 1;
            } else {
                return (
                    CountLeafNode(root.LChild) +
                    CountLeafNode(root.RChild)
                );
            }
        }

        //        【例 5-3】编写算法，求二叉树的深度。
        //算法思路：用递归实现该算法。如果二叉树为空，则返回 0；如果二叉树只
        //有一个结点（根结点），返回 1，否则返回根结点的左分支的深度与右分支的深
        //度中较大者加 1。
        //算法实现如下：
        int GetHeight(Node<T> root) {
            int lh;
            int rh;
            if (root == null) {
                return 0;
            } else if (root.LChild == null && root.RChild == null) {
                return 1;
            } else {
                lh = GetHeight(root.LChild);
                rh = GetHeight(root.RChild);
                return (lh > rh ? lh : rh) + 1;
            }
        }//!_GetHeight

    }//!_public class BiTree<T>
}//!_namespace TreeCh.Body
