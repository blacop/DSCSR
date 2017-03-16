using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSearchBasic.Algo {

    public class CArray {
        //自定义数组测试类
        private int[] arr; //数据域
        private int upper;//upper == last ptr, ==> Length-1;
        private int length;//patch, length==uppper+1;
        private int numElements;//count
        //---------------分隔线---------------
        public int this[int index] { //索引器
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
            arr = new int[size];  //数据域 //size is Length
            Upper = size - 1; //upper is last ptr, ==> Length-1;
            Length = size;
            NumElements = 0;//count
        } //构造器
        //---------------分隔线---------------
        public void Insert(int item) { //插入
            arr[NumElements] = item;
            NumElements++;
        } //插入
        public void DisplayElements() { //遍历输出
            for (int i = 0; i <= Upper; i++)
                Console.Write(arr[i] + " ");
        } //遍历输出
        public void Clear() {
            for (int i = 0; i <= Upper; i++)
                arr[i] = 0;
            NumElements = 0;
        }
        //排序-----------分隔线---------------
        static void CreateArray_ASC() { //升序数组
            CArray nums = new CArray(50);
            for (int i = 0; i <= 49; i++)
                nums.Insert(i);
            nums.DisplayElements();
            Console.ReadKey();
        } //生成升序数组//static void CreateArray_ASC()
        static void CreateArray_Random() { //随机数数组
            CArray nums = new CArray(10);
            Random rnd = new Random(100);
            for (int i = 0; i < 10; i++) {
                nums.Insert(rnd.Next(0, 100));
            }
            nums.DisplayElements();
        }//生成随机数数组//static void CreateArray_Random()
        //冒泡排序---------分隔线---------------
        public void BubbleSort(int[] arr) {
            //冒泡排序，沉底排序，page 35/246,descreption
            //外循环减法
            //upper上界 是长度length-1，MaxSize-1,排除掉最后一个 0
            int temp;
            for (int outer = arr.Length - 1; outer > 0; outer--) {
                for (int inner = 0; inner <= outer - 1; inner++) //inner循环，排除外循环1个,排除掉最后1个
                {
                    if ((int)arr[inner] > arr[inner + 1]) {
                        temp = arr[inner];
                        arr[inner] = arr[inner + 1];
                        arr[inner + 1] = temp;
                    }
                }
                //this.DisplayElements();
            }
        } //冒泡排序
        public void BubbleSort() {
            //冒泡排序
            //外循环减法 冒泡排序
            //page 35/246,descreption            
            //upper上界 是长度length-1，MaxSize-1,排除掉最后一个 0
            int[] arr = this.arr;
            int temp;
            for (int outer = arr.Length - 1; outer > 0; outer--) {
                for (int inner = 0; inner <= outer - 1; inner++) { //inner循环，排除外循环1个,排除掉最后1个
                    if ((int)arr[inner] > arr[inner + 1]) {
                        temp = arr[inner];
                        arr[inner] = arr[inner + 1];
                        arr[inner + 1] = temp;
                    }
                } //inner循环，排除外循环1个,排除掉最后1个
                this.DisplayElements();
            }//for (int outer = arr.Length - 1; outer > 0; outer--)
        }//冒泡排序//public void BubbleSort()
        public void BubbleSortOuterPlus(int[] arr) { //冒泡排序 外循环加法 
            int temp = 0;
            #region 将大的数字移到数组的arr.Length-1-i
            for (int i = 0; i < arr.Length - 1; i++) {
                for (int j = 0; j < arr.Length - 1 - i; j++) //inner循环，排除外循环1个,排除掉最后1个
                {
                    if (arr[j] > arr[j + 1]) {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            #endregion
        }//冒泡排序 外循环加法//public void BubbleSortOuterPlus(int[] arr)
        //选择排序---------分隔线--------------------- 
        public void SelectionSort(int[] arr) {
            //选择排序
            //时间复杂度也是O(n * n)
            int min, temp; //temp min index
            int upper = arr.Length - 1;
            for (int outer = 0; outer <= upper; outer++) {
                min = outer; //temp min index
                for (int inner = outer + 1; inner <= upper; inner++) {
                    if (arr[inner] < arr[min]) min = inner;
                }
                temp = arr[outer];
                arr[outer] = arr[min];
                arr[min] = temp;
                //this.DisplayElements();
            }
        }//选择排序//SelectionSort()
        public void SelectionSort() {
            //选择排序
            //时间复杂度也是O(n * n)
            int[] arr = this.arr;
            int min, temp; //temp min index
            int upper = arr.Length - 1;
            for (int outer = 0; outer <= upper; outer++) {
                min = outer; //temp min index
                for (int inner = outer + 1; inner <= upper; inner++) {
                    if (arr[inner] < arr[min]) min = inner;
                }
                temp = arr[outer];
                arr[outer] = arr[min];
                arr[min] = temp;
                //this.DisplayElements();
            }
        } //选择排序//SelectionSort()
        //插入排序----------分隔线--------------------- 
        public void InsertSort(int[] a, int len) {
            //直接插入排序
            int i, j, key;
            for (i = 1; i < len; ++i) {
                key = a[i];
                for (j = i - 1; j >= 0; --j) {
                    if (a[j] > key)
                        a[j + 1] = a[j];
                    else
                        break;
                }
                a[j + 1] = key;
            }
        }//插入排序
        public void InsertSort(int[] a) {   //InsertSort_CleanCode(int[] a)
            int i, j, key;
            int len = a.Length;
            for (i = 1; i < len; ++i) {
                key = a[i];
                for (j = i - 1; j >= 0; --j) {
                    if (a[j] > key)
                        a[j + 1] = a[j];
                    else
                        break;
                }
                a[j + 1] = key;
            }//for (i = 1; i < len; ++i)
        }// public void InsertSort(int[] a)
        public void InsertionSort(int[] arr) { //插入排序，从1开始，困难
            //InsertionSort_StartBy1()
            int inner, temp;
            int upper = arr.Length - 1;
            #region case : outer <= upper 
            for (int outer = 1; outer <= upper; outer++) //out right, index 1 开始
            {
                temp = arr[outer];
                inner = outer;  //innter left, index 1 开始，出内部后重置为
                #region case : arr[inner - 1] >= temp && inner > 0 ，数组全部右移
                while (temp > arr[inner - 1] && inner > 0) //innter left, index 1 开始
                {   //left >= right
                    arr[inner] = arr[inner - 1]; //right <= left, 数组全部右移
                    inner -= 1; //right <= left, 数组全部右移
                }
                #endregion
                arr[inner] = temp;//插入 数据
                //this.DisplayElements();
            }
            #endregion
        } //插入排序//public void InsertionSort()
        public void InsertionSort() { //插入排序，从1开始，困难//InsertionSort_StartBy1()
            int[] arr = this.arr;
            int inner, temp;
            int upper = arr.Length - 1;
            #region case : outer <= upper 
            for (int outer = 1; outer <= upper; outer++) //out right, index 1 开始
            {
                temp = arr[outer];
                inner = outer;  //innter left, index 1 开始，出内部后重置为
                #region case : arr[inner - 1] >= temp && inner > 0 ，数组全部右移
                while (temp > arr[inner - 1] && inner > 0) //innter left, index 1 开始
                {   //left >= right
                    arr[inner] = arr[inner - 1]; //right <= left, 数组全部右移
                    inner -= 1; //right <= left, 数组全部右移
                }
                #endregion
                arr[inner] = temp;//插入 数据
                //this.DisplayElements();
            }
            #endregion
        } //插入排序//public void InsertionSort()
        //查找-----------分隔线--------------------- 
        public static int FindMin(int[] arr) {
            int min = arr[0];
            for (int index = 0; index < arr.Length - 1; index++)
                if (arr[index] < min)
                    min = arr[index];
            return min;
        } //FindMin(int[] arr)//public static int FindMin(int[] arr)
        public static int FindMax(int[] arr) {
            int max = arr[0];
            for (int index = 0; index < arr.Length - 1; index++)
                if (arr[index] > max)
                    max = arr[index];
            return max;
        } //FindMax(int[] arr) //public static int FindMax(int[] arr)
        /*上述两个函数的另外一种替换写法是返回最大值或最小值在数组内的位置，而不是返回实际的数值。*/
        //---------------分隔线---------------------  
        /*public static int SeqSearch(int[] arr, int sValue)
        {   //顺序查找,返回index
            for (int index = 0; index < arr.Length; index++) //小 bug
                if (arr[index] == sValue)
                    return index;
            return -1;
        }//public static int SeqSearch(int[] arr, int sValue)*/
        /*public static bool SeqSearch(int[] arr, int sValue)
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
        public static int SeqSearch(int[] arr, int sValue) {
            //顺序查找,自动调频,自组织,返回index,遵循“ 80–20” 规则
            /* “ 80–20” 规则,定义一条原则，
            那就是只有当数据项的位置位于数据集合前20%数据项之外的时候,
            才可以把它重新定位到数据集合的开始部分。*/
            int index = 0;
            int indexPrev = index - 1;
            for (index = 0; index < arr.Length - 1; index++)
                if (arr[index] == sValue && index > (arr.Length * 0.2)) {
                    indexPrev = index - 1;
                    if (indexPrev == -1)
                        indexPrev = 0;
                    swap(ref arr, ref index, ref indexPrev);
                    return index;
                } else //not in 0.2 percent
                if (arr[index] == sValue)
                    return index;
            return -1;
        } //顺序查找 //public static int SeqSearch(int[] arr, int sValue)
          /*如果查找成功，那么会利用交换函数把找到的数据项与元素在数组的前一个位置上进行交换，显示如下所示：*/
          //---------------分隔线---------------------
        public static void swap(ref int[] arr, ref int item1, ref int item2) {
            int temp = arr[item1];
            arr[item1] = arr[item2];
            arr[item2] = temp;
        }//引用交换
        //---------------分隔线---------------------
        public int BinSearch(int value) {
            //二叉查找算法,返回index,时间复杂度O()=O(logn)
            //二分查找算法,返回index,时间复杂度O()=O(logn)
            int upperBound, lowerBound, mid;
            upperBound = arr.Length - 1; lowerBound = 0;
            while (lowerBound <= upperBound) {
                mid = (upperBound + lowerBound) / 2;
                if (arr[mid] == value)
                    return mid;
                else
                if (value < arr[mid])
                    upperBound = mid - 1;
                else
                    lowerBound = mid + 1;
            }
            return -1;
        } //二分查找算法//public int binSearch(int value)
        //---------------分隔线---------------------
        public int RBinSearch(int value, int lower, int upper) {
            //递归二叉查找算法,返回index,时间复杂度O(n^2)
            //O(n^2)            
            if (lower > upper)
                return -1;
            else {
                int mid;
                mid = (int)(upper + lower) / 2;
                if (value < arr[mid])
                    return RBinSearch(value, lower, mid - 1);
                else if (value == arr[mid])
                    return mid;
                else
                    return RBinSearch(value, mid + 1, upper);
            }
        }////递归二叉查找算法
         //---------------分隔线---------------------

        //先来看一个最终会用 BitArray 类来解决的问题。这个问题是要找到素数。在公元前三世纪，古希腊哲学家埃拉
        //托斯特尼发现了一种古来的方法来找素数，这种方法被称为是埃拉托斯特尼筛法。这种方法会一直筛选掉是其他数
        //倍数的那些数，直到最后剩下的数都是素数为止。例如，假设要确定出前 100 个整数集合内的素数。这里会先从 2
        //开始，它是第一个素数。接着从头到尾遍历整数集合，把所有是 2 倍数的整数都移除掉。然后，移动到下一个素数
        //3。还是此从头到尾遍历整数集合，把所有是 3 倍数的整数都移除掉。再随后移动到素数 5，继续如此往复操作。当
        //操作全部结束时，所有留下的就都是素数了。
        //这里将先用常规数组来解决这个问题。所要采用的方法与用 BitArray 来解决问题的方法类似。这种方法要初始
        //化含有 100 个元素的数组，并且把数组内每个元素的值都设为 1。操作会从索引 2（既然 2 是第一个素数）开始依
        //次检查每个后续的数组索引。先要查看索引对应的元素值是 1 还是 0。如果数值为 1，那么就接着查看该索引是否
        //是 2 的倍数。如果该索引是 2 的倍数，那么就把该索引上的数值设为 0。检查完所有数组索引后，会接着移动到索
        //引 3，重复相同的操作，如此一直反复下去。
        //为了编写解决这个问题的代码，这里会采用先前已开发的 CArray 类。需要做的第一件事就是创建一个执行筛选
        //的方法。代码如下所示：
        public void GenPrimes() { //取素数
            for (int outer = 2; outer <= arr.GetUpperBound(0); outer++)
                for (int inner = outer + 1; inner <= arr.GetUpperBound(0); inner++)
                    if (arr[inner] == 1)
                        if ((inner % outer) == 0)
                            arr[inner] = 0;
        }//取素数
        public void ShowPrimes() { //显示素数
            for (int i = 2; i <= arr.GetUpperBound(0); i++)
                if (arr[i] == 1)
                    Console.Write(i + " ");
        }//显示素数
        
        //接下来这个程序是用来测试所编写的代码的：
        //static void Main() {
        //    int size = 100;
        //    CArray primes = new CArray(size - 1);
        //    for (int i = 0; i <= size - 1; i++)
        //        primes.Insert(1);
        //    primes.GenPrimes();
        //    primes.ShowPrimes();
        //}

        //---------------分隔线---------------------
    }//自定义数组测试类//public class CArray
}//namespace SortSearchBasic.Algo 
