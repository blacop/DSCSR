using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueChapter.Body.SequenceStack {
    //实际是ArrayList Stack
    //属性 禁用
    //public int P_index {
    //    get {
    //        return p_index;
    //    }

    //    set {
    //        p_index = value;
    //    }
    //}//属性 p_index ptr
    //属性 禁用

    //索引器 禁用
    //public object this[int index] {
    //    get {
    //        return list[index];
    //    }
    //    set {
    //        list[index] = value;
    //    }
    //}//public T this[int index]
    //索引器 禁用

    //数据结构与算法 C#语言描述(中文) 50/246
    //这个ArrayList不是泛型,里面是Object,性能比泛型类的Stack要差
    public class CStack {
        private int p_index;//ref domain，top ptr，cur ptr 当前工作指针
        private ArrayList list; //data domain

        public CStack() {//构造器
            list = new ArrayList();//不定长16
            p_index = -1;
        }//构造器
        public int Count {
            get {
                return list.Count;
            }
        }//Length属性,只读
        public void push(object item) {
            list.Add(item);
            p_index++;
        }//入栈
        public object pop() {
            object obj = list[p_index];
            list.RemoveAt(p_index);
            p_index--;
            return obj;
        }//出栈
        public void clear() {
            list.Clear();
            p_index = -1;
        }//清空
        public object peek() {
            return list[p_index];
        }//得到栈顶元素
    }
}//namespace StackQueueChapter.Body.SequenceStack
