﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace BasicSortProject
{
    public class Timing
    {        
        /*时间测试类时间差方法        
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
        */
        /*时间测试类TotalProcessorTime方法*/
        TimeSpan duration;
        public Timing()//Timing 构造器
        {
            duration = new TimeSpan(0);
        }//public Timing()
        public void startTime() //GC run
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }//public void startTime()
        public void stopTime()//get TotalProcessorTime
        {
            duration = Process.GetCurrentProcess().TotalProcessorTime;
        }//public void stopTime()
        public TimeSpan Result()
        {
            return duration;
        }//public TimeSpan Result()
    }//public class Timing
}//namespace BasicSortProject
