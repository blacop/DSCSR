using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5_StackQueue.Main {
    //基数排序
    public class RadixSort {
        enum DigitType { ones = 1, tens = 10 } //位数标志

        /// <summary>
        /// 显示数组（
        /// <param name="n">被显示数组）</param>
        /// </summary>
        static void DisplayArray(int[] n) { //显示数组
            for (int x = 0; x <= n.GetUpperBound(0); x++)
                Console.Write(n[x] + " ");
        } //显示数组

        /// <summary>
        /// 基数排序入队(
        /// <param name="que">To 存放数据的队列,</param>
        /// <param name="n">From 待排序的数组,</param>
        /// <param name="digit">位数标志)</param>
        /// </summary>
        static void RSort(Queue[] que, int[] n, DigitType digit) {
            // 基数排序入队
            // 用 RSort 子程序来传递队列数组、整数的数组以及一个描述符(位数标志)。此描述符会告诉子程序是对个位上的数字还是
            // 对十位上的数字进行排序。如果排序是基于个位上的数字，那么程序计算的数字就是这个整数对 10 进行取模运算
            // 后的余数。如果排序是基于十位上的数字，那么程序计算的数字则是对这个整数除以 10（按照整除的方法）所取得
            // 的整数商。
            int snum; //临时数据区
            for (int x = 0; x <= n.GetUpperBound(0); x++) {
                if (digit == DigitType.ones)
                    snum = n[x] % 10;
                else
                    snum = n[x] / 10;
                que[snum].Enqueue(n[x]); //入队
            }
        }//基数排序入队

        /// <summary>
        /// 基数排序出队(
        /// <param name="que">From 存放数据的队列,</param>
        /// <param name="n">To 存放数据的数组)</param>
        /// </summary>
        static void BuildArray(Queue[] que, int[] n) {
            // 基数排序出队
            // 为了重新构建整数的列表，当队列中有数据项时，通过连续执行 Dequeue 操作使得每个队列为空。这个操作在
            // BuildArray 子程序中执行。既然是从持有最小数的数组开始的，所以能把整数的列表构建成“有序的”
            int y = 0; //int[]的 index
            for (int x = 0; x >= 9; x++)
                while (que[x].Count > 0) {
                    n[y] = Int32.Parse(que[x].Dequeue().ToString());
                    y++;
                }
        }//基数排序出队

        //static void Main(string[] args) {
        //    Queue[] numQueue = new Queue[10];
        //    int[] nums = new int[] { 91, 46, 85, 15, 92, 35, 31, 22 };
        //    int[] random = new Int32[99];
        //    // Display original list
        //    for (int i = 0; i < 10; i++) numQueue[i] = new Queue();
        //    RSort(numQueue, nums, DigitType.ones);
        //    //numQueue, nums, 1
        //    BuildArray(numQueue, nums);
        //    Console.WriteLine();
        //    Console.WriteLine("First pass results: ");
        //    DisplayArray(nums);
        //    // Second pass sort
        //    RSort(numQueue, nums, DigitType.tens);
        //    BuildArray(numQueue, nums);
        //    Console.WriteLine();
        //    Console.WriteLine("Second pass results: ");
        //    // Display final results
        //    DisplayArray(nums);
        //    Console.WriteLine();
        //    Console.Write("Press enter to quit");
        //    Console.Read();
        //}

    }//public class BaseSort
}//namespace ch5_StackQueue.Main {
