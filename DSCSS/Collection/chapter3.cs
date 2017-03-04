using System;
using System.Collections.Generic;
using System.Text;

using System.Diagnostics;
using System.Threading;

using Collection.Collection;
using Collection.Timing;

namespace Collection
{
    //将要引用的.cs文件拷贝到项目中，添加现有项 加到项目里，然后就可以通过该.cs的命名空间.类名.方法的方式访问了...
    class chapter3//测试用例 23 / 246,数据结构与算法 : C#语言描述(中文)
    {//3. 请使用 Timing 类来比较向 Collection 类和 ArrayList 类分别添加了 100000 个整数时的性能。
        static void Main()
        {
            Collection<int> Coll = new Collection<int>();
            ArrayList<int> arrl = new ArrayList<int>();
            Timing tColl = new Timing();
            tColl.startTime();
            BuildArray(coll);
            tColl.stopTime();
            Console.WriteLine("time (tColl): " + tColl.Result().TotalSeconds);
            //----
            Timing tArrl = new Timing();
            tArrl.startTime();
            BuildArray(tArrl);
            tArrl.stopTime();
            Console.WriteLine("time (tArrl): " + tArrl.Result().TotalSeconds);
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
