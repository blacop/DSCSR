using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    //ADT Collection,这是一个ADT抽象数据类型Collection
    public class Collection<T>
    {   //对于一个类如果不定义构造方法，编译器默认一个无参的构造方法
        //Collection里面默认有InnerList 用来存放数据
        //InnerList是ArrayList类型，用Object格式存储
        public void Add(Object item)
        {
            InnerList.Add(item);
        }
        public void Remove(Object item)
        {
            InnerList.Remove(item);
        }
        public new void Clear()
        {
            InnerList.Clear();
        }
        public new int Count()
        {
            return InnerList.Count;
        }
        /*
        //请对 Collection 类添加下列方法：
        a.Insert
        b.Contains
        c.IndexOf
        d. RemoveAt
        */
        public void Insert(Object item)
        {
            InnerList.Insert(item);
        }
        public void Contains(Object item)
        {
            InnerList.Contains(item);
        }
        public void IndexOf(Object item)
        {
            InnerList.IndexOf(item);
        }
        public void RemoveAt(Object item)
        {
            InnerList.RemoveAt(item);
        }
    }
}
