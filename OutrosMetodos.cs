using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class OutrosMetodos
    {
        public static void Main(string[] args)
        {
            int[] numero = { 5, 7, 8, 15, 3 };
            Console.WriteLine(numero.Length);
            Console.WriteLine(numero[0]);
            Console.WriteLine(numero.Max());
            Console.WriteLine(numero.Min());
            Console.WriteLine(numero.Sum());
            Console.WriteLine(numero.Average());
        }
    }
}
