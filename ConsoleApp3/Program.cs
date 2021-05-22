using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Формула для которой подбираем значения: Z = min(A^2, max(B, C, D + 1))      |");
            Console.WriteLine("___________________________________________________________________________|");
            Console.WriteLine("~");
            Console.WriteLine("Найдем значение min, для этого введем значения (Для продолжения нажми Enter)");
            Console.ReadKey();
            Console.WriteLine("Введи значение для B");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введи значение для C");
            double C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введи значение для D");
            double D = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Теперь введем значение A");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Все значения введены, для рассчета формула нажмите Enter");
            Console.ReadKey();

            //Метод нахождения решения данной задачи
            double Z;
            double Min()
            {
                double Max = 0;
                double G = D + 1;
                double A1 = Math.Pow(A, 2);
                if (B > G)
                {
                    Max = B;
                }
                else
                {
                    Max = G;
                }
                if (C > Max)
                {
                    Max = C;
                }
                else
                {
                    return Max;
                }
                if (A1 < Max)
                {
                    Z = A1;
                }
                else
                {
                    Z = Max;
                }
                return Z;
            }

            //Вывод ответа на экран
            double sum = Min();
            Console.WriteLine("В формуле min(A^2, max(B, C, D + 1) Z = {0}", sum);
            Console.ReadKey();
        }
    }
}
