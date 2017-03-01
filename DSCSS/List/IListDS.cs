using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public interface IListDS<T>
    {
        //InterfaceListDataStruct
        //线性表基本操作,自定义一个泛型接口
        //item的类型用T泛型描述,实现数据类型和算法分离
        //这可以实现算法对不同数据结构的重用
        int GetLength(); //求长度 1
        void Clear(); //清空操作  2
        bool IsEmpty();//判断线性表是否为空 3
        void Append(T item); //附加操作 4
        void Insert(T item, int i); //插入操作 5
        T Delete(int i); //删除操作 6
        T GetElem(int i); //取表元 7
        int Locate(T value);//按值查找 8
        /*
        可选实现方法
        bool PriorElem(T cur_e, T &pre_e);
        //初始条件：线性表L已存在。
        //操作结果：若cur_e是L中的数据元素，且不是第一个，则用pre_e返回它的前驱，否则操作失败，pre_e无定义。
        bool NextElem(T cur_e, T &next_e);
        //初始条件：线性表L已存在。
        //操作结果：若cur_e是L中的数据元素，且不是最后一个，则用next_e返回它的后继，否则操作失败，next_e无定义。
        bool Traverse(bool(*visit)(T));
        //初始条件：线性表L已存在
        //操作结果：依次对L的每个元素调用函数visit().一旦visit()失败,则操作失败。
        //Sq.h end
        */
        void Reverse();//倒置
    }
}
