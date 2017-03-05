using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSortProject
{
    class BasicSort
    {
        public void BubbleSortOuterPlus()
        {   //外循环加法
            int temp = 0;
            #region 将大的数字移到数组的arr.Length-1-i
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++) //inner循环，排除外循环1个,排除掉最后1个
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            #endregion
        }
        public void BubbleSortOuterMinus(int[] arr)
        {   //冒泡排序，沉底排序，page 35/246,descreption
            //外循环减法
            //upper上界 是长度length-1，MaxSize-1,排除掉最后一个 0
            int temp;
            for (int outer = arr.Length - 1; outer > 0; outer--)
            {
                for (int inner = 0; inner <= outer - 1; inner++) //inner循环，排除外循环1个,排除掉最后1个
                {
                    if ((int)arr[inner] > arr[inner + 1])
                    {
                        temp = arr[inner];
                        arr[inner] = arr[inner + 1];
                        arr[inner + 1] = temp;
                    }
                }
                this.DisplayElements();
            }
        }
        public void SelectionSort()
        {
            //选择排序
            //时间复杂度也是O(n * n)
            int min, temp; //temp min index
            for (int outer = 0; outer <= upper; outer++)
            {
                min = outer; //temp min index
                for (int inner = outer + 1; inner <= upper; inner++)
                {
                    if (arr[inner] < arr[min]) min = inner;
                }
                temp = arr[outer];
                arr[outer] = arr[min];
                arr[min] = temp;
                this.DisplayElements();
            }
        }//SelectionSort()
         /*
 **直接插入排序
 */
        void InsertSort(int a[], int len)
        {
            int i, j, key;
            for (i = 1; i < len; ++i)
            {
                key = a[i];
                for (j = i - 1; j >= 0; --j)
                {
                    if (a[j] > key)
                        a[j + 1] = a[j];
                    else
                        break;
                }
                a[j + 1] = key;
            }
        }
        /*插入排序的核心core思路，*外部指针 与 *内部指针 比较，内部指针 控制数组整体右移 */
        public void InsertionSort_StrtBy0()
        {
            //从0开始，容易
            for (int outer = 1; outer < length; outer++) //out right, index 1 开始
            {
                if (arr[outer] < arr[outer - 1]) ////注意[0,i-1]都是有序的。如果待插入元素比arr[i-1]还大则无需再与[i-1]前面的元素进行比较了，反之则进入if语句
                {
                    int temp = arr[outer]; //inner出内部后重新赋值为outer
                    int inner;
                    for (inner = outer - 1; inner >= 0 && arr[inner] > temp; inner--)
                    {
                        arr[inner + 1] = arr[inner]; //把比temp大或相等的元素全部往后移动一个位置    
                    }
                    arr[inner + 1] = temp;//把待排序的元素temp插入腾出位置的(j+1)
                }
            }
        }
        //插入排序的思路，*外部指针 与 *内部指针 比较，内部指针 控制数组整体右移
        public void InsertionSort_StartBy1() //插入排序，从1开始，困难
        {
            int inner, temp;
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
                this.DisplayElements();
            }
            #endregion
        }//InsertionSort()
        /*
        public static void main(String[] args)
        {
            int array[] = { 4, 2, 1, 5 };

            System.out.println("排序之前：");
            for (int element : array)
            {
                System.out.print(element + " ");
            }

            insertsort(array);
            System.out.println("\n排序之后：");
            for (int element : array)
            {
                System.out.print(element + " ");
            }
        }
        */
    }
}
