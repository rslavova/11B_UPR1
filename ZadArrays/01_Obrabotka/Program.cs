using System;
using System.Linq;

namespace _01_Obrabotka
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().ToArray();

            arr = arr.Distinct();
        }
    }
}
