using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSearchBasic.Algo {
    public class CArray<T> {
        //测试类 泛型
        private T[] arr; //数据域
        private int upper;//upper == last ptr, ==> Length-1;
        private int length;//patch, length==uppper+1;
        private int numElements;//count
        //---------------分隔线---------------
        public T this[int index] { //索引器
            //索引器,this=>实例化对象，实例化对象属性=>读写逻辑,
            //索引器,this表示这个类的实例化对象，对this的存储和读取都通过索引器进行
            get {
                return arr[index];//数组名，下标
            }
            set {
                arr[index] = value;
            }
        } //索引器
        public int Upper { //属性
            get {
                return upper;
            }

            set {
                upper = value;
            }
        }//属性
        public int Length {//属性
            get {
                return length;
            }

            set {
                length = value;
            }
        }//属性
        public int NumElements {//属性
            get {
                return numElements;
            }

            set {
                numElements = value;
            }
        }//属性
        public CArray(int size) { //构造器
            arr = new T[size];  //数据域 //size is Length
            Upper = size - 1; //upper is last ptr, ==> Length-1;
            Length = size;
            NumElements = 0;//count
        } //构造器
        //---------------分隔线---------------
        public void Insert(T item) { //插入
            arr[NumElements] = item;
            NumElements++;
        } //插入
        public void DisplayElements() { //遍历输出
            for (int i = 0; i <= Upper; i++)
                Console.Write(arr[i] + " ");
        } //遍历输出
        public void Clear() {
            for (int i = 0; i <= Upper; i++)
                arr[i] = default(T);
            NumElements = 0;
        }

        //---------------分隔线---------------------  
        /*public static T SeqSearch(T[] arr, T sValue)
        {   //顺序查找,返回index
            for (int index = 0; index < arr.Length; index++) //小 bug
                if (arr[index] == sValue)
                    return index;
            return -1;
        }//public static T SeqSearch(T[] arr, T sValue)*/
        /*public static bool SeqSearch(T[] arr, T sValue)
        {   //顺序查找,自动调频,自组织,返回bool
            int index = 0;
            int indexPrev = index - 1;
            for (index = 0; index < arr.Length - 1; index++)
                if (arr[index] == sValue)
                {
                    indexPrev = index - 1;
                    if (indexPrev == -1)
                        indexPrev = 0;
                    swap(ref arr, ref index, ref indexPrev);
                    return true;
                }
            return false;
        }*/

        /*如果查找成功，那么会利用交换函数把找到的数据项与元素在数组的前一个位置上进行交换，显示如下所示：*/
        //---------------分隔线---------------------
        public static void swap(ref T[] arr, ref int item1, ref int item2) {
            T temp = arr[item1];
            arr[item1] = arr[item2];
            arr[item2] = temp;
        }
        //---------------分隔线---------------------

        //---------------分隔线---------------------

        //---------------分隔线---------------------
    }//public class CArray<T>
}//namespace SortSearchBasic.Algo





