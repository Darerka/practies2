using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aA = "AaaaaAA0AAaaaAA";
            int count = 0;
            char nol = '0';
            for (int i = 0; i < aA.Length; i++)
            {
                if (aA[i] != nol)
                {
                    count++;
                }
            }
                for (int i = 0; i < aA.Length; i++)
            {
                if (aA[i] != nol)
                {
                    char otvet = aA[i];
                    Console.WriteLine(otvet);
                }
                else
                {
                    Console.WriteLine(i+1);
                    break;
                }
            }
            Console.WriteLine($"Строка {aA}, кол-во A и а = {count}");
        }
    }
}
