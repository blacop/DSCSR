using StackQueueChapter.Body.SequenceQueue;
using StackQueueChapter.Body.SequenceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueChapter.Algorithm
{
    public class QueueAlgorithm
    {
        /*
【例3-4】编程判断一个字符串是否是回文。
回文是指一个字符序列以中间字符为基准两边字符完全相同，
如字符序列“ACBDEDBCA”是回文。
算法思想：判断一个字符序列是否是回文，就是把第一个字符与最后一个字符相比较，
第二个字符与倒数第二个字符比较，依次类推，第i个字符与第n-i个字符比较。
如果每次比较都相等，则为回文，如果某次比较不相等，就不是回文。
因此，可以把字符序列分别入队列和栈，
然后逐个出队列和出栈并比较出队列的字符和出栈的字符是否相等，
若全部相等则该字符序列就是回文，否则就不是回文。
         */
        public static void Main()
        {
            SeqStack<char> s = new SeqStack<char>(50);
            CSeqQueue<char> q = new CSeqQueue<char>(50);
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length; ++i)
            {
                s.Push(str[i]);
                q.In(str[i]);
            }
            while (!s.IsEmpty() && !q.IsEmpty())
            {
                if (s.Pop() != q.Out())
                {
                    break;
                }
            }
            if (!s.IsEmpty() || !q.IsEmpty())
            {
                Console.WriteLine(“这不是回文！”);
            }
            else
            {
                Console.WriteLine(“这是回文！”);
            }
        }//public static void Main()

    }//public class QueueAlgorithm
}//namespace StackQueueChapter.Algorithm
