using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue.Interface {
    /*ADT下面对队列的基本操作进行说明。
1、求队列的长度：GetLength()
初始条件：队列存在；
操作结果：返回队列中数据元素的个数。
2、判断队列是否为空：IsEmpty()
初始条件：队列存在；
操作结果：如果队列为空返回true，否则返回false。
3、清空操作：Clear()
初始条件：队列存在；
操作结果：使队列为空。
4、入队列操作：In(T item)
初始条件：队列存在；
操作结果：将值为item的新数据元素添加到队尾，队列发生变化。
5、出队列操作：Out()
初始条件：队列存在且不为空；
操作结果：将队头元素从队列中取出，队列发生变化。
6、取队头元素：GetFront()
初始条件：队列存在且不为空；
操作结果：返回队头元素的值，队列不发生变化。*/
    //数据结构（C#语言版）3.2 队列 89
    //队列接口IQueue<T> 的定义如下所示。
    public interface IQueue<T> {
        int GetLength(); //求队列的长度
        bool IsEmpty(); //判断对列是否为空
        void Clear(); //清空队列
        void In(T item); //入队
        T Out(); //出队
        T GetFront(); //取对头元素
    }//public interface IQueue<T>
}//namespace StackQueue.Interface 
