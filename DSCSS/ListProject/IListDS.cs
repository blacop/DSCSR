using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProject
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
        int Locate(T value);/*按值查找 8 */
        /* void Reverse();//倒置,可选*/
        /*ADT
       为了和.NET 框架中的接口 IList 相区分，在 IList 后面加了“DS”，“DS”
       表示数据结构。下面对线性表的基本操作进行说明。
       1、 求长度：GetLength()
       初始条件：线性表存在；
       操作结果：返回线性表中所有数据元素的个数。
       2、 清空操作：Clear()
       初始条件：线性表存在且有数据元素；
       操作结果：从线性表中清除所有数据元素，线性表为空。
       3、 判断线性表是否为空：IsEmpty()
       初始条件：线性表存在；
       操作结果：如果线性表为空返回 true，否则返回 false。
       4、 附加操作：Append(T item)
       初始条件：线性表存在且未满；
       操作结果：将值为 item 的新元素添加到表的末尾。
       5、 插入操作：Insert(T item, int i)
       初始条件：线性表存在，插入位置正确()(1≤i≤n+1,n 为插入前的表长)。
       操作结果：在线性表的第 i 个位置上插入一个值为 item 的新元素，这样使得
       原序号为 i,i+1,…,n 的数据元素的序号变为 i+1,i+2,…,n+1，插入后表长=原
       表长+1。
       6、 删除操作：Delete(int i)
       初始条件：线性表存在且不为空，删除位置正确(1≤i≤n, n 为删除前的表
       长)。
       操作结果：在线性表中删除序号为 i 的数据元素，返回删除后的数据元素。
       删除后使原序号为 i+1, i+2,…, n 的数据元素的序号变为 i, i+1,…, n-1，删除后
           表长 = 原表长 - 1。
       7、 取表元：GetElem(int i)
       初始条件：线性表存在，所取数据元素位置正确（1≤i≤n，n 为线性表的表
       长）；
       操作结果：返回线性表中第 i 个数据元素。
       8、 按值查找：Locate(T value)
       初始条件：线性表存在。
       操作结果：在线性表中查找值为 value 的数据元素，其结果返回在线性表中
       首次出现的值为 value 的数据元素的序号，称为查找成功；否则，在线性表中未
       找到值为 value 的数据元素，返回一个特殊值表示查找失败。
       实际上，在.NET 框架中，许多类的求长度、判断满和判断空等操作都用属
       性来表示，这里在接口中定义为方法是为了说明数据结构的操作运算。实际上，
       属性也是方法。在后面章节的数据结构如栈、队列等的处理也是如此，就不一一
       说明了。
       */
    }
}
