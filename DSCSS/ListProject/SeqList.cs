using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProject
{
    public class SeqList<T> : IListDS<T>
    {
        //顺序表类 SeqList<T>的实现说明如下所示。相当于c里面的typedef定义封装结构体
        //C# 里面 用class定义封装结构体,字段=>存储，属性=>逻辑，也是一种解耦思想
        private int maxsize; //顺序表的容量
        private T[] data; //数组，用于存储顺序表中的数据元素
        private int last; //cur工作指针,指示顺序表最后一个元素的位置
        public T this[int index] //索引器
        {
            //索引器,this=>实例化对象，实例化对象属性=>读写逻辑,
            //索引器,this表示这个类的实例化对象，对this的存储和读取都通过索引器进行
            get
            {
                return data[index];//数组名，下标
            }
            set
            {
                data[index] = value;
            }
        }
        public int Last //最后一个数据元素位置属性,last指针，只读
        {
            get
            {
                return last;
            }
        }
        public int Maxsize //字段用小写,属性用大写，字段是存储，属性是逻辑
        {//容量属性
            get
            {
                return maxsize;
            }
            set
            {
                maxsize = value;
            }
        }
        public SeqList(int size) //构造器，参数，数据域数组长度
        {
            //没有无参构造器
            //构造器,相当于C里面结构体的Init方法，C#里面实例化对象后自动调用一次构造方法
            //构造器方法，实例化对象的时候，自动分配内存空间
            data = new T[size]; //数据域数组
            maxsize = size; //数据域 数组长度
            last = -1;//cur 当前工作指针
        }
        public int GetLength() //求顺序表的长度
        {
            return last + 1;
        }
        public void Clear() //清空顺序表
        {//清空顺序表，void Clear();
         //初始条件：线性表L已存在。
         //操作结果：将L重置为空表。2
         //bool Destroy(Sq &L);
         //初始条件：线性表L已存在。
         //操作结果：销毁线性表L。由GC自动处理
            last = -1;
        }
        public bool IsEmpty() //判断顺序表是否为空
        {
            if (last == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsFull() //判断顺序表是否为满
        {
            if (last == maxsize - 1)
            {
                //last + 1 == i
                //end positon <==> maxsize - 1
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Append(T item) //在顺序表的末尾添加新元素
        {//在顺序表的末尾添加新元素
         //初始条件：线性表L已存在且未满。
         //操作结果：将值为item的新元素添加到表的末尾。
            if (IsFull())
            {
                #region means
                /*
                if (i == last + 2)
                {
                    //means append()
                    //last.value + 1 == i <==> cur_Position's index
                    //last.value + 2 == i+1 means i's next_Position <==> next Position's index
                    data[++last] = item;
                }
                */
                #endregion
                Console.WriteLine("List is full");
                return;
            }
            data[++last] = item;//last,cur指针 有修改++
        }
        public void Insert(T item, int i) //在顺序表的第i个数据元素的位置插入一个数据元素
        {//在顺序表的第i个数据元素的位置插入一个数据元素
         //初始条件：线性表L已存在，1<=i<=Length(L)+1.
         //操作结果：在L中第i个位置之前插入新的数据元素e，L的长度加1;  5
            #region if i mean is IsFull
            if (IsFull())
            {
                //i == last + 1
                //end positon <==> maxsize - 1
                Console.WriteLine("List is full");
                return;
            }
            #endregion
            #region if i is illegal
            if (i < 1 || i > last + 2)
            {//legal condition :
             //0 +1 <= i <= last+1
             //i == last + 1
             //end positon <==> maxsize - 1
                Console.WriteLine("Position is error!");
                return;
            }
            #endregion           
            #region if (i==last + 2) means insert cur's after position
            if (i == last + 2)
            {
                //means append()
                //last.value + 1 == i <==> cur_Position's index
                //last.value + 2 == i+1 means i's next_Position <==> next Position's index
                data[last + 1] = item;//last,cur指针没有修改
            }
            #endregion
            #region else i is illegal, move right,insert
            else
            {
                for (int j = last; j >= i - 1; --j)
                {
                    data[j + 1] = data[j]; //move right
                }
                data[i - 1] = item;//insert
            }
            #endregion
            ++last;// ++cur_Ptr
        }
        public T Delete(int i) //删除顺序表的第i个数据元素
        {//初始条件：线性表L已存在且非空，1<=i<=Length(L).
         //操作结果：删除L的第i个数据元素，并用T返回其值，L的长度减1  
            T tmp = default(T);//out value,赋值 defult value
            #region if IsEmpty()
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
                return tmp;
            }
            #endregion
            #region if (i < 1 || i > last + 1 //if i is illegal
            if (i < 1 || i > last + 1)
            {//legal condition :
             //0 +1 <= i <= last , because 大于last处为无效区
             //i == last + 1
             //end positon <==> maxsize - 1
                Console.WriteLine("Position is error!");
                return tmp;
            }
            #endregion
            #region if (i==last + 1) //删除的是最后一个元素 cur's position
            if (i == last + 1)
            {//cur's position
                tmp = data[last--];
            }
            #endregion
            #region else //删除的不是最后一个元素,else i is legal, get value,move left
            else
            {//legal
                tmp = data[i - 1];//先取值 get value first
                for (int j = i; j < last + 1; ++j) //length == last +1 ; for (int j = i - 1; j <= last; ++j)
                {
                    data[j - 1] = data[j]; //data[j] = data[j + 1];//move left               
                }
            }
            #endregion
            --last; //--cur_Ptr 
            return tmp; //return value
        }
        public T GetElem(int i) //获得顺序表的第i个数据元素
        {
            //获得顺序表的第i个数据元素
            //初始条件：线性表L已存在，1<=i<=Length(L)。
            //操作结果：返回L中第i个数据元素的值。
            if (IsEmpty() || (i < 1) || (i > last + 1))
            {
                Console.WriteLine("List is empty or Position is error!");
                return default(T);
            }
            return data[i - 1];
        }
        public int Locate(T value) //在顺序表中查找值为value的数据元素
        {
            //初始条件：线性表L已存在
            //返回L中第一个值为value的数据元素的位序。若这样的数据元素不存在，则返回值为0; 8
            #region if(IsEmpty())
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty!");
                return -1;
            }
            #endregion
            int i = 0;
            for (i = 0; i <= last; ++i)
            {//value
                if (value.Equals(data[i]))
                {//The object.字段.value to compare with the current object<==>data[i].
                    break;
                }
            }
            if (i > last)
            {//-1表示不存在
                return -1;
            }//return order
            return i + 1;
        }
        /*
        public bool Equals(T currentValue2)
        {//value.Equals(data[i]) 这句的Equals()怎么实现我不知道啊
        //只能瞎想出来这样的伪代码了
            if (obj.字段.value1== currentValue2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        */
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
        public void Reverse() //倒置
        {//倒置，思路，1条数组对半切成2条数组，循环下标指针交换
            //0.5向上取整
            T tmp = default(T);
            int len = GetLength();
            for (int i = 0; i < len / 2; ++i)
            {
                tmp = data[i];
                data[i] = data[len - i];
                data[len - i] = tmp;
            }
        }
        //存储整数的顺序表的倒置的算法实现如下：
        public void ReversSeqList(SeqList<int> L)
        {
            //重载方法
            //倒置，思路，1条数组对半切成2条数组，循环下标指针交换
            //0.5向上取整
            int tmp = 0;//default(T) == 0;
            int len = L.GetLength();
            for (int i = 0; i <= len / 2; ++i)
            {
                tmp = L[i];
                L[i] = L[len - i];
                L[len - i] = tmp;
            }
        }
        /* 
        Merge() 升序合并
        有数据类型为整型的顺序表 La 和 Lb，其数据元素均按从小到大的升
        序排列，编写一个算法将它们合并成一个表 Lc，要求 Lc 中数据元素也按升序排
        列。
        算法思路：
        依次扫描 La 和 Lb 的数据元素，比较 La 和 Lb 当前数据元素的
        值，将较小值的数据元素赋给 Lc，如此直到一个顺序表被扫描完，然后将未完
        的那个顺序表中余下的数据元素赋给 Lc 即可。 Lc 的容量要能够容纳 La 和 Lb
        两个表相加的长度。
        */
        public SeqList<int> Merge(SeqList<int> La, SeqList<int> Lb) //升序合并
        {
            SeqList<int> Lc = new SeqList<int>(La.Maxsize + Lb.Maxsize);//初始化Lc
            int i = 0; //temp Ptr 3个
            int j = 0;
            #region 两个表中都有数据元素
            while ((i <= (La.GetLength() - 1)) && (j <= (Lb.GetLength() - 1)))
            {
                if (La[i] < Lb[j])
                {
                    Lc.Append(La[i++]);
                }
                else //(La[i] > Lb[j])
                {
                    Lc.Append(Lb[j++]);
                }
            }
            #endregion
            #region a表中还有数据元素
            while (i <= (La.GetLength() - 1))
            {
                Lc.Append(La[i++]);
            }
            #endregion
            #region b表中还有数据元素
            while (j <= (Lb.GetLength() - 1))
            {
                Lc.Append(Lb[j++]);
            }
            #endregion
            return Lc;
            //算法的时间复杂度是 O(m+n)， m 是 La 的表长， n 是 Lb 的表长。
        }
        /*
        Purge() 净化
        [例 2-3]
        已知一个存储整数的顺序表 La，试构造顺序表 Lb，要求顺序表 Lb 中
        只包含顺序表 La 中所有值不相同的数据元素。  
        算法思路：
        先把顺序表 La 的第 1 个元素赋给顺序表 Lb，
        然后从顺序表 La的第 2 个元素起，
        每一个元素与顺序表 Lb 中的每一个元素进行比较，
        如果不相同，则把该元素附加到顺序表 Lb 的末尾。
        从表中删除相同数据元素的算法的 C#实现如下：
        */
        public SeqList<int> Purge(SeqList<int> La) //净化
        {
            SeqList<int> Lb = new SeqList<int>(La.Maxsize);//声明Lb
            Lb.Append(La[0]);//将a表中的第1个数据元素赋给b表
            //依次处理a表中的数据元素
            for (int i = 1; i <= La.GetLength() - 1; ++i)
            {
                int j = 0;
                #region 查看b表中有无与a表中相同的数据元素
                for (j = 0; j <= Lb.GetLength() - 1; ++j)
                {
                    #region 有相同的数据元素
                    if (La[i].CompareTo(Lb[j]) == 0)
                    {
                        continue;//跳过
                    }
                    #endregion
                    #region 没有相同的数据元素，将a表中的数据元素附加到b表的末尾。
                    if (j > Lb.GetLength() - 1) //mean next
                    {
                        Lb.Append(La[i]);
                    }
                    #endregion
                }
                #endregion
            }
            return Lb;
            //算法的时间复杂度是 O(m + n)， m 是 La 的表长， n 是 Lb 的表长。
        }
    }
}
