using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ExemploSort
    {
        public static void Main(string[] args)
        {
            int[] numero = { 12, 13, 14, 22, 85, 2, 45 };
            Array.Sort(numero);
            foreach (int i in numero)
            {
                Console.WriteLine(i);
            }
        }
    }
}
