using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var arr2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var item in arr1)
            {
                foreach (var item1 in arr2)
                {
                    if (item==item1)
                    {
                        Console.Write(item.Trim()+ " ");
                        
                    }
                }

            }Console.WriteLine();
        }
    }
}
