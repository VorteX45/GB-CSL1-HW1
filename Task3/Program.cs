//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле
//r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
//Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
//б) * Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;

//Павел Орестов

using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату X1:");
            float x1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите координату Y1:");
            float y1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите координату X2:");
            float x2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите координату Y2:");
            float y2 = Convert.ToSingle(Console.ReadLine());

            //а
            Console.WriteLine("Расстояние между точками: {0:F2}", Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            //б
            Console.WriteLine("Расстояние между точками: {0:F2}", CalculateRange(x1, y1, x2, y2));

            Console.ReadKey();
        }

        static double CalculateRange(float x1, float y1, float x2, float y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}