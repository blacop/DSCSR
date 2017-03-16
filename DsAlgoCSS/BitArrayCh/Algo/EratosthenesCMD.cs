using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArrayCh.Algo {
    class EratosthenesCMD {

        //先来看一个最终会用 BitArray 类来解决的问题。这个问题是要找到素数。在公元前三世纪，古希腊哲学家埃拉
        //托斯特尼发现了一种古来的方法来找素数，这种方法被称为是埃拉托斯特尼筛法。这种方法会一直筛选掉是其他数
        //倍数的那些数，直到最后剩下的数都是素数为止。例如，假设要确定出前 100 个整数集合内的素数。这里会先从 2
        //开始，它是第一个素数。接着从头到尾遍历整数集合，把所有是 2 倍数的整数都移除掉。然后，移动到下一个素数
        //3。还是此从头到尾遍历整数集合，把所有是 3 倍数的整数都移除掉。再随后移动到素数 5，继续如此往复操作。当
        //操作全部结束时，所有留下的就都是素数了。
        //这里将先用常规数组来解决这个问题。所要采用的方法与用 BitArray 来解决问题的方法类似。这种方法要初始
        //化含有 100 个元素的数组，并且把数组内每个元素的值都设为 1。操作会从索引 2（既然 2 是第一个素数）开始依
        //次检查每个后续的数组索引。先要查看索引对应的元素值是 1 还是 0。如果数值为 1，那么就接着查看该索引是否
        //是 2 的倍数。如果该索引是 2 的倍数，那么就把该索引上的数值设为 0。检查完所有数组索引后，会接着移动到索
        //引 3，重复相同的操作，如此一直反复下去。
        //为了编写解决这个问题的代码，这里会采用先前已开发的 CArray 类。需要做的第一件事就是创建一个执行筛选
        //的方法。代码如下所示：

        public void GenPrimes(int[] arr) { //取素数
            for (int outer = 2; outer <= arr.GetUpperBound(0); outer++)
                for (int inner = outer + 1; inner <= arr.GetUpperBound(0); inner++)
                    if (arr[inner] == 1)
                        if ((inner % outer) == 0)
                            arr[inner] = 0;
        }//取素数
        public void ShowPrimes(int[] arr) { //显示素数
            for (int i = 2; i <= arr.GetUpperBound(0); i++)
                if (arr[i] == 1)
                    Console.Write(i + " ");
        }//显示素数

        //接下来这个程序是用来测试所编写的代码的：
        //static void Main() {
        //    int size = 100;
        //    CArray primes = new CArray(size - 1);
        //    for (int i = 0; i <= size - 1; i++)
        //        primes.Insert(1);
        //    primes.GenPrimes();
        //    primes.ShowPrimes();
        //}

    }//class EratosthenesCMD
}//namespace BitArrayCh.Algo
