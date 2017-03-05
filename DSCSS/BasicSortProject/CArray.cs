using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSortProject
{
    public class CArray
    {
        //测试类
        private int[] arr; //数据域
        private int upper;//upper == last ptr, ==> Length-1;
        private int length;//patch, length==uppper+1;
        private int numElements;
        public CArray(int size) //构造器
        {
            arr = new int[size];  //数据域 //size is Length
            upper = size - 1; //upper is last ptr, ==> Length-1;
            numElements = 0;
            length = size;
        }
        public void Insert(int item)
        {
            arr[numElements] = item;
            numElements++;
        }
        public void DisplayElements()
        {
            for (int i = 0; i <= upper; i++)
                Console.Write(arr[i] + " ");
        }
        public void Clear()
        {
            for (int i = 0; i <= upper; i++)
                arr[i] = 0;
            numElements = 0;
        }
        static void CreateArray_ASC()
        {
            //升序数组
            CArray nums = new CArray(50);
            for (int i = 0; i <= 49; i++)
                nums.Insert(i);
            nums.DisplayElements();
            Console.ReadKey();
        }
        static void CreateArray_Random()
        {
            //随机数数组
            CArray nums = new CArray(10);
            Random rnd = new Random(100);
            for (int i = 0; i < 10; i++)
            {
                nums.Insert(rnd.Next(0, 100));
            }
            nums.DisplayElements();
        }
    }

}//class CArray
}//namespace





