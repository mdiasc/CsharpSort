using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ExemploMatriz
    {
        public static void Main(string[] args)
        {
            int[,] numero = { { 1, 5, 8 }, { 9, 6, 4 } };
            Console.WriteLine(numero[1, 2]);
            //saída linha 1 coluna 2, pois o array sempre começa com 0
        }
    }
}
