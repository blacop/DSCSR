using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProject.LinkListNH
{    //Type ADT //LinkListNoHeadNode
    public class LinkListNH<T> : IListDS<T> //单链表类 LinkListNH<T>的实现说明如下所示。
    {
        private Node<T> head; //单链表的头引用 字段 
        public Node<T> Head //头引用属性，对头引用字段操作，get方法得到head的引用
        { //将头引用属性 作为了head的引用
            //LinkListNH.head.get方法得到head的引用,这是C#的可以在head存数据的原因
            get
            {
                return head;
            }
            set
            {
                head = value;
            }
        }
        public LinkListNH() //构造器,构造的时候自动加head
        {
            //C语言的Head不存储数据，只存储Node1的引用
            //Head其实也可以存放数据，C#的这本书里是这样
            head = null;
            //linklist()<==> head; LinkListNH().head<==>.next
            //将head 作为字段//CLang:head.next = null;
            //clan mean:Pnode LinkListNH() head = LinkListNH();
            //clan mean:head->next = NULL;
        }
        public int GetLength() //求单链表长度
        {
            Node<T> p = head;
            int len = 0;
            while (p != null)
            {
                ++len;
                p = p.Next;
            }
            return len;
            //时间复杂度分析：求单链表的长度需要遍历整个链表，
            //所以，时间复杂度为
            //O(n)， n 是单链表的长度。
        }
        public void Clear() //清空单链表,c#里面Clear和Destroy和二为一，Free()释放内存由GC垃圾清理自动完成
        {
            head = null;//CLang:head.next = null;
        }
        public bool IsEmpty() //判断单链表是否为空
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Append(T item) //在单链表的末尾添加新元素
        {
            Node<T> q = new Node<T>(item);//insert node
            Node<T> p = new Node<T>();//temp ptr
            #region  if (head.Next == null) 
            if (head.Next == null)
            {
                head.Next = q;//C#里的head是一个空Node,next引用指向后继结点
                return;
            }
            #endregion
            #region p find to to end
            p = head;
            while (p.Next != null) //p find to end
            {
                p = p.Next;//ptr++
            }
            #endregion
            p.Next = q;
        }
        public void AppendHead(T item)
        {//在单链表的Head=>第一个结点，添加新元素
            Node<T> q = new Node<T>(item);
            q.Next = head;
            head = q;
        }
        public void Insert(T item, int i) //在单链表的第i个结点的位置前插入一个值为item的结点
        {
            #region if (IsEmpty() || i < 1)
            if (IsEmpty() || i < 1) //illegal
            {
                Console.WriteLine("List is empty or Position is error!");
                return;
            }
            #endregion
            #region //if 前插法 插入到第一个结点
            if (i == 1)
            {
                /*。设p指向第i个位置的结点，
                 * q指向待插入的新结点，
                 * r指向p的直接前驱结点
                 * 如果要在第一个结点之前插入新结点，
                 * 则需要把p结点的地址保存在q的引用域中，
                 * 然后把p的地址保存在头引用中*/
                Node<T> q = new Node<T>(item);//q is inserted node
                q.Next = head;//clan mean:q->Next = head->next
                head = q;//clan mean:head->next = q
                return;
            }
            #endregion
            Node<T> p = head; //temp Ptr r points i's reference
            Node<T> r = new Node<T>(); //temp Ptr r points i's precursor
            int j = 0; //size_t of r , j => order i-1
            #region //find r => order i-1
            while (p.Next != null && j < i - 1)//find p==> order i
            {
                r = p; //find r => order i-1
                p = p.Next; //p++ move
                ++j;
            }
            #endregion
            //now temp Ptr r points i's reference
            #region core
            if (j == i - 1) //if 前插法 core
            {   //q is inserted node
                Node<T> q = new Node<T>(item);//malloc node q,并且赋值
                q.Next = p; //前插法 core
                r.Next = q; //前插法 core
            }
            #endregion
        }
        public void InsertPost(T item, int i) //在单链表的第i个结点的位置后插入一个值为item的结点
        {
            #region if (IsEmpty() || i < 1)
            if (IsEmpty() || i < 1)
            {
                Console.WriteLine("List is empty or Position is error!");
                return;
            }
            #endregion
            #region if (i == 1)
            if (i == 1)
            { //insert 1st node
                Node<T> q = new Node<T>(item);
                q.Next = head.Next;
                head.Next = q;
                return;
            }
            #endregion
            Node<T> p = head;
            int j = 0;
            #region //find p => 第i个结点的位置
            while (p != null && j < i)
            {//find p => 第i个结点的位置
                p = p.Next;
                ++j;
            }
            #endregion
            #region //达成匹配条件
            if (j == i - 1)
            { //达成匹配条件
                Node<T> q = new Node<T>(item);
                q.Next = p.Next; //后插法 core
                p.Next = q; //后插法 core
            }
            #endregion
        }
        public T Delete(int i) //删除单链表的第i个结点
        {//由于要删除结点，所以在遍历过程中需要保存被遍历到的结点的直接前驱，
         //找到第i个结点后，把该结点的直接后继作为该结点的直接前驱的直接后继
            #region illegal
            if (IsEmpty() || i < 0)
            {
                Console.WriteLine("Link is empty or Position is error!");
                return default(T);
            }
            #endregion
            Node<T> q = new Node<T>();
            #region 1st node
            if (i == 1)
            {
                q = head;
                head = head.Next;
                return q.Data;
            }
            #endregion
            Node<T> p = head; //p is deleted node
            int j = 0; //size_t
            #region //find q => 要删除结点 的 前驱
            while (p.Next != null && j < i)
            {//find q => 要删除结点 的 前驱
                ++j;
                q = p;
                p = p.Next;
            }
            //now p is deleted node
            #endregion
            #region //Delete() core
            if (j == i - 1)
            {//Delete() core
                q.Next = p.Next; //Delete() core
                return p.Data; //Delete() core
            }
            #endregion
            else
            {
                Console.WriteLine("The ith node is not exist!");
                return default(T);
            }
        }
        public T GetElem(int i) //获得单链表的第i个数据元素
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty!");
                return default(T);
            }
            Node<T> p = new Node<T>();
            p = head;
            int j = 0;
            while (p.Next != null && j < i)
            {
                ++j;
                p = p.Next;
            }
            if (j == i - 1)
            {
                return p.Data;
            }
            else
            {
                Console.WriteLine("The ith node is not exist!");
                return default(T);
            }
        }
        public int Locate(T value)  //在单链表中查找值为value的结点
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty!");
                return -1;
            }
            Node<T> p = new Node<T>();
            p = head;
            int i = 1;
            while (!p.Data.Equals(value) && p.Next != null)
            {
                p = p.Next;
                ++i;
            }
            return i;
        }
        LinkListNH<int> CreateLListHead_DeadCirle_HandData_HandEnd()
        {
            int d;
            LinkListNH<int> L = new LinkListNH<int>();//L是新生成的链表引用
            d = Int32.Parse(Console.ReadLine());
            while (d != -1)
            {   //-1是输入数据的结束标志
                Node<int> p = new Node<int>(d);//p是新插入的结点
                p.Next = L.Head;//L.Head是Node1
                L.Head = p;//Clan mean: L.head = >L.next
                d = Int32.Parse(Console.ReadLine());
            }
            return L;
        }
        LinkListNH<int> CreateLListHead_HandData_HandCount()
        {   //在头部插入结点建立单链表的算法
            int count;
            int val;
            LinkListNH<int> L = new LinkListNH<int>();
            Console.WriteLine("input count:");
            count = Int32.Parse(Console.ReadLine());
            Console.WriteLine("input val:");
            val = Int32.Parse(Console.ReadLine());

            while (count != 0)
            {
                Node<int> p = new Node<int>(d);
                p.Next = L.Head;//头插法 core
                L.Head = p;//头插法 core                
                count--;
            }
            return L;
        }
        LinkListNH<int> CreateListTail()
        {
            Node<int> R = new Node<int>();//Temp Ptr R是L.Head是L->next
            int d;
            LinkListNH<int> L = new LinkListNH<int>();//L是新生成的链表引用
            R = L.Head;
            d = Int32.Parse(Console.ReadLine());
            while (d != -1)
            {
                Node<int> p = new Node<int>(d);
                if (L.Head == null)
                {   //空表
                    L.Head = p;
                }
                else
                {   //head->next = p
                    R.Next = p;
                }
                R = p;
                d = Int32.Parse(Console.ReadLine());
            }
            if (R != null)
            {   //set the tail
                R.Next = null;
            }
            return L;
        }
    }
}

