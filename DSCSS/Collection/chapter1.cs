using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class chapter1//测试用例
    {
        static void Main()
        {
            Collection names = new Collection();
            names.Add("David");
            names.Add("Bernica");
            names.Add("Raymond");
            names.Add("Clayton");
            foreach (Object name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Number of names: " + names.Count());
            names.Remove("Raymond");
            Console.WriteLine("Number of names: " + names.Count());
            names.Clear();
            Console.WriteLine("Number of names: " + names.Count());
        }
    }
}
