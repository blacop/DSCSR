﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace Collection
{//时间测试类
    /*时间差方法
    public class Timing
    {
        TimeSpan startingTime;
        TimeSpan duration;
        public Timing()//Timing 构造器
        {            
            startingTime = new TimeSpan(0);//参数，差值，0为马上
            duration = new TimeSpan(0);
        }
        public void StopTime()//StopTime 方法
        {
            duration =
            Process.GetCurrentProcess().Threads[0].
            UserProcessorTime.Subtract(startingTime);
        }
        public void startTime()//startTime 构造器
        {
            GC.Collect();//GC run
            GC.WaitForPendingFinalizers();//等待堆上对象的所有 finalizer 方法都运行后再继续,GC wait clear queue
            startingTime =
            Process.GetCurrentProcess().Threads[0].
            UserProcessorTime;//get startingTime
        }
        public TimeSpan Result()
        {
            return duration;
        }
    }
    */
    public class Timing//TotalProcessorTime方法
    {//时间测试类
        TimeSpan duration;
        public Timing()//Timing 构造器
        {
            duration = new TimeSpan(0);
        }
        public void stopTime()//get TotalProcessorTime
        {
            duration = Process.GetCurrentProcess().TotalProcessorTime;
        }
        public void startTime() //GC run
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        public TimeSpan Result()
        {
            return duration;
        }
    }
    class chapter1//测试用例
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
