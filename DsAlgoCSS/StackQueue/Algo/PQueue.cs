using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5_StackQueue.algo {
    //进程优先队列
    public struct pqItem {
        //通常会把存储在优先队列中的数据项作为键值对来构造，其中关键字就是指优先级别，而值则用来识别数据项。
        //例如，可以按照如下形式对一个操作系统进程进行定义：
        public int priority;
        public string name;
    }//public struct pqItem
    public class PQueue : Queue {
        //大家不能把未修改的 Queue 对象用于优先队列。 DeQueue 方法在被调用时只会把队列中的第一个数据项移除。
        //但是，大家可以从 Queue 类派生出自己的优先队列类，同时覆盖 DeQueue 方法来实现自己的需求。
        //大家把这个类称为 PQueue。所有 Queue 的方法都可以照常使用，同时覆盖 Dequeue 方法来移除具有最高优先
        //级的数据项。为了不从队列前端移除数据项，首先需要把队列的数据项写入一个数组。然后遍历整个数组从而找到
        //具有最高优先级的数据项。最后，根据标记的数据项，就可以在不考虑此标记数据项的同时对队列进行重新构建。
        //下面就是有关 PQueue 类的代码：
        public PQueue() { } //构造器
        public override object Dequeue() {
            object[] items;
            int min;
            items = this.ToArray(); //this转成数组
            min = ((pqItem)items[0]).priority; //找到最高优先级item
            for (int x = 1; x <= items.GetUpperBound(0); x++) //遍历//找到最高优先级item
                if (((pqItem)items[x]).priority < min) {
                    min = ((pqItem)items[x]).priority; //标记最高优先级item
                }
            this.Clear(); //清空this数组
            int x2;
            for (x2 = 0; x2 <= items.GetUpperBound(0); x2++)
                if (((pqItem)items[x2]).priority == min && ((pqItem)items[x2]).name != "")  //遍历//找到最高优先级item
                    this.Enqueue(items[x2]); //将 最高优先级item 入队
            return base.Dequeue(); //出队
        } //重写Dequeue()方法

        //接下来的代码说明了 PQueue 类的一个简单应用。急诊等待室对就诊的病人配置了优先级。心脏病突发的病人
        //应该在割伤的病人之前进行治疗。 下面这个程序模拟了三位几乎在同一时间进入急诊室的病人。分诊护士在检查完
        //每一位病人后会分配得他们一个优先级，同时会把这些病人添加到队列内。进行治疗的第一个病人会通过 Dequeue
        //方法从队列中移除。
        //由于 Mary Brown 拥有高于其他两位病人的优先级，所以这段程序的输出是“ Mary Brown”。

        //static void Main() {
        //    PQueue erwait = new PQueue();
        //    pqItem[] erPatient = new pqItem[3];
        //    pqItem nextPatient;
        //    erPatient[0].name = "Joe Smith";
        //    erPatient[0].priority = 1;
        //    erPatient[1].name = "Mary Brown";
        //    erPatient[1].priority = 0;
        //    erPatient[2].name = "Sam Jones";
        //    erPatient[2].priority = 3;
        //    for (int x = 0; x <= erPatient.GetUpperBound(0); x++)
        //        erwait.Enqueue(erPatient[x]);
        //    nextPatient = (pqItem)erwait.Dequeue();
        //    Console.WriteLine(nextPatient.name);
        //}

    }//public class PQueue : Queue
}//namespace ch5_StackQueue.algo
