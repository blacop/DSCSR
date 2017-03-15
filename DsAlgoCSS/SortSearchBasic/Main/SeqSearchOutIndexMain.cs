using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSearchBasic.Main {
    public class SeqSearchOutIndexMain
    {
        /*
        public static void Main()
        {
            int[] numbers = new int[100];
            StreamReader numFile = File.OpenText(@"c:\\numbers.txt");
            for (int i = 0; i < numbers.Length - 1; i++)
                numbers[i] = Convert.ToInt32(numFile.ReadLine(), 10);
            int searchNumber;
            Console.Write("Enter a number to search for: ");
            searchNumber = Convert.ToInt32(Console.ReadLine(), 10);
            int foundAt;
            foundAt = SeqSearch(numbers, searchNumber);
            if (foundAt >= 0)
                Console.WriteLine(searchNumber + " is in the array at position " + foundAt);
            else
                Console.WriteLine(searchNumber + " is not in the array.");
        }//public static void Main()
        */
        public static int SeqSearch(int[] arr, int sValue)
        {
            for (int index = 0; index < arr.Length; index++) //小 bug
                if (arr[index] == sValue)
                    return index;
            return -1;
        }//public static int SeqSearch(int[] arr, int sValue)

    }//public class SeqSearchOutIndex
}//namespace BasicSearchProject
