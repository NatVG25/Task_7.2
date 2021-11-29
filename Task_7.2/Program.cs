using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //вводим исходные параметры
            Console.WriteLine("Введите длину стороны куба:");
            int a = Convert.ToInt32(Console.ReadLine());
            double S, V; //инициализация переменных
            CalcCube(a, out S, out V); 
            Console.WriteLine("Для куба со стороной {0} Объем V равен {1,0:00}, площадь поверхности S равна {2,0:00}", a, V, S);//вывод результата
            Console.ReadKey();

        }
        static void CalcCube(int a, out double S, out double V) //метод расчета объема и площади поверхности куба 
        {
            V = (double)Math.Pow(a, 3); //объем
            S = 6 * Math.Pow(a, 2); //площадь поверхности
        }
    }
}
