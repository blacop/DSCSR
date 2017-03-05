using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListProject
{

    public class SamplesArrayList
    {
        /*
数据结构（C#语言版）
2.5 C#中的线性表 66
*/
        public static void Main()
        {
            // 创建和初始化一个新的ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("Hello");
            myAL.Add("World");
            myAL.Add("!");
            //显示ArrayList的属性和值
            Console.WriteLine("myAL");
            Console.WriteLine("Count:{0}", myAL.Count);
            Console.WriteLine("Capacity: {0}", myAL.Capacity);
            Console.Write("Values:");
            PrintValues(myAL);
        }
        //方法，输出ArrayList中的每个元素
        public static void PrintValues(IEnumerable myList)
        {
            foreach (object obj in myList)
            {
                Console.Write("{0}", obj);
                Console.WriteLine();
            }
        }
    }

}
