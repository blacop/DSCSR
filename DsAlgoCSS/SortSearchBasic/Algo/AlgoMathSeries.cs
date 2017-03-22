using System;

namespace SortSearchBasic.Algo {
    public class AlgoMathSeries {

        //级数求和,
        //伪 lanmda 写法 
        //double Series=（double base, int limit, int Constant） => int constant + sigma{ base^i / i | (1 <= i <= 100) };
        //Constant 常数项 , base 底数，limit 极限上界
        //double Series(double baseX, int limit, int Constant) {
        //    double sum = 0.0;
        //    int i;
        //    //limit is 1 to 100
        //    for (i = 1; i <= limit; i++) {
        //        sum += Math.Pow(baseX, i) / i;
        //    }
        //    //sum 初值为1
        //    sum += Constant;
        //    return sum;
        //}

        //C# lanmda mySeries写法
        //级数求和 C#真lanmda写法
        //Constant 常数项, base 底数，limit 极限上界
        double baseX;
        int limit;
        int Constant;
        delegate double del(double baseX, int limit, int Constant);
        del mySeries = (baseX, limit, Constant) => {
            double sum = 0.0;
            int i;
            // limit is 1 to 100
            for (i = 1; i <= limit; i++) {
                sum += Math.Pow(baseX, i) / i;
            }
            //sum 初值为1
            sum += Constant;
            return sum;
        };


    }//!_public class Algo
}//!_namespace SortSearchBasic.Algo
