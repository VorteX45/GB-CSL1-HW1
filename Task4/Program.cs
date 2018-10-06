//Написать программу обмена значениями двух переменных.
//а) с использованием третьей переменной;
//б) * без использования третьей переменной.

//Павел Орестов

using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Введите число a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b:");
            b = Convert.ToInt32(Console.ReadLine());

            //а
            c = a;
            a = b;
            b = c;
            Console.WriteLine("Меняем местами...");
            Console.WriteLine($"a: {a}\tb: {b}");

            Console.WriteLine("Возвращаем как было...");
            c = a; a = b; b = c;
            Console.WriteLine($"a: {a}\tb: {b}");

            //б
            Console.WriteLine("Меняем местами вторым способом...");
            b = a ^ b;
            a = a ^ b;
            b = a ^ b;
            Console.WriteLine($"a: {a}\tb: {b}");

            Console.ReadKey();
        }
    }
}