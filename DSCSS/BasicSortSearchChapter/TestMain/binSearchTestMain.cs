using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicSortChapter;

namespace BasicSearchChapter
{
    public class binSearchTestMain
    {
        public int binSearch(int[] arr, int value)
        {
            //二分查找,返回index            
            int upperBound, lowerBound, mid;
            upperBound = arr.Length - 1; lowerBound = 0;
            while (lowerBound <= upperBound)
            {
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
        }//public int binSearch(int value)
        //---------------分隔线---------------------
        /*
        public static void Main(string[] args)
        {
            Random random = new Random();
            CArray mynums = new CArray(910);
            for (int i = 0; i <= 9; i++)
                mynums.Insert(random.Next(100));
            mynums.BubbleSort();
            mynums.DisplayElements();
            int position = mynums.binSearch(77);
            if (position >= -1)
            {
                Console.WriteLine("found item");
                mynums.DisplayElements();
            }
            else
                Console.WriteLine("Not in the array");
            Console.Read();
        }//public static void Main(string[] args)
        */
    }//public class binSearchTestMain
}//namespace BasicSearchProject
