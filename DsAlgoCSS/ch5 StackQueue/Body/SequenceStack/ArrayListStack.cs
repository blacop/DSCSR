using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueChapter.Body.SequenceStack {
    //CStack == ArrayListStack
    //p_index == top
    /*属性 禁用
    public int P_index //属性 p_index ptr
    {
        get
        {
            return p_index;
        }

        set
        {
            p_index = value;
        }
    }
    */
    /*索引器 禁用
public object this[int index]//索引器
{
    get
    {
        return list[index];
    }
    set
    {
        list[index] = value;
    }
}//public T this[int index]
*/
    //数据结构与算法 C#语言描述(中文) 50/246
    //这个ArrayList不是泛型,里面是Object,性能比泛型类的Stack要差
    public class ArrayListStack {
        private int top;//ref domain,top ptr，cur ptr
        private ArrayList list; //data domain
        
        public ArrayListStack() {//构造器
            list = new ArrayList();//不定长16
            top = -1;
        }//构造器
        public int Count {
            get {
                return list.Count;
            }
        }//Length属性,只读
        public void push(object item) {
            list.Add(item);
            top++;
        }//push()
        public object pop() {
            object obj = list[top];
            list.RemoveAt(top);
            top--;
            return obj;
        }//pop()
        public void clear() {
            list.Clear();
            top = -1;
        }//clear()
        public object peek() {
            return list[top];
        }//getTop()
    }//public class CStack
}//namespace StackQueueChapter.Body.SequenceStack
