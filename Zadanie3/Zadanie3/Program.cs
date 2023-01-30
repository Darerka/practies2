using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dlinna1, shirina1, dlinna2, shirina2;
            Console.Write("Введите данные первого прямоугольника\n\n");
            Console.Write("Длинна: ");
            dlinna1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ширина: ");
            shirina1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите данные второго прямоугольника\n\n");
            Console.Write("Длинна: ");
            dlinna2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ширина: ");
            shirina2 = Convert.ToInt32(Console.ReadLine());
            int otvet1 = dlinna1 * shirina1;
            int otvet2 = dlinna2 * shirina2;
            Console.WriteLine($"\n\nПлощадь первого прямоугольника: {otvet1}\nПлощадь второго прямоугольника: {otvet2}");
            if (otvet1 > otvet2)
            {
                int razn = otvet1 - otvet2;
                Console.WriteLine($"Площадь первого больше на {razn}");
            }
            else if (otvet1 > otvet2)
            {
                int razn2 = otvet2 - otvet1;
                Console.WriteLine($"Площадь второго больше на {razn2}");
            }
            else if (otvet1 == otvet2)
            {
                Console.WriteLine("Площади равны");
            }
        }
    }
}
