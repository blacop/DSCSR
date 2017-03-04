using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class chapter2//测试用例
    {//测试用例
        static void Main()
        {
            int[] nums = new int[100000];
            BuildArray(nums);
            Timing tObj = new Timing();
            tObj.startTime();
            DisplayNums(nums);
            tObj.stopTime();
            Console.WriteLine("time (.NET): " + tObj.Result().TotalSeconds);
        }
        static void BuildArray(int[] arr)
        {
            for (int i = 0; i < 100000; i++)
                arr[i] = i;
        }
        static void DisplayNums(int[] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
                Console.Write(arr[i] + " ");
        }
    }
}
