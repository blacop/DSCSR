﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeChapter.Body {
    //数据结构（ C#语言版）5.2 二叉树 135
    //不带头引用的二叉树
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
        public void InsertL(T val, Node<T> p) { //插入左子树
            //将结点p的左子树插入值为val的新结点，
            //原来的左子树成为新结点的左子树
            Node<T> tmp = new Node<T>(val);
            tmp.LChild = p.LChild;
            p.LChild = tmp;
        } //插入左子树
        public void InsertR(T val, Node<T> p) {
            //将结点p的右子树插入值为val的新结点，
            //原来的右子树成为新结点的右子树
            Node<T> tmp = new Node<T>(val);
            tmp.RChild = p.RChild;
            p.RChild = tmp;
        }//右子树插入
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
    }
}//namespace TreeChapter.Body {
