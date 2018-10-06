//Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
//где m — масса тела в килограммах, h — рост в метрах

//Павел Орестов

using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите рост (см):");
            float height = Convert.ToSingle(Console.ReadLine()) / 100;
            Console.WriteLine("Введите вес (кг):");
            float weight = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("ИМТ: {0:F1}", weight / (height * height));
            Console.ReadKey();
        }
    }
}