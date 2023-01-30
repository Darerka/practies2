using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const float pi = 3.14f;
            int userInput;
            Console.Write("Введите размер радиуса: ");
            userInput = Convert.ToInt32(Console.ReadLine());
            float otvet = pi * userInput * userInput;
            Console.WriteLine($"Ответ: {otvet}");
        }
    }
}
