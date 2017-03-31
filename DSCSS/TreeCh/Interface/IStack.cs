using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeCh.Interface {
    /*ADT下面对栈的基本操作进行说明。
    1、求栈的长度：GetLength()
    初始条件：栈存在；
    操作结果：返回栈中数据元素的个数。
    2、判断栈是否为空：IsEmpty()
    初始条件：栈存在；
    操作结果：如果栈为空返回true，否则返回false。
    3、清空操作：Clear()
    初始条件：栈存在；
    操作结果：使栈为空。
    4、入栈操作：Push(T item)
    初始条件：栈存在；
    操作结果：将值为item的新的数据元素添加到栈顶，栈发生变化。
    5、出栈操作：Pop()
    初始条件：栈存在且不为空；
    操作结果：将栈顶元素从栈中取出，栈发生变化。
    6、取栈顶元素：GetTop()
    初始条件：栈表存在且不为空；
    操作结果：返回栈顶元素的值，栈不发生变化。
    */
    public interface IStack<T> {
        int GetLength(); //求栈的长度
        bool IsEmpty(); //判断栈是否为空
        void Clear(); //清空操作
        void Push(T item); //入栈操作
        T Pop(); //出栈操作
        T GetTop(); //取栈顶元素
    }//public interface IStack<T>
}//namespace StackQueue.Interface
