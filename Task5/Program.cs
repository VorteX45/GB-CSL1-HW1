//а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) Сделать задание, только вывод организуйте в центре экрана
//в) * Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)

//Павел Орестов

using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //а, б, в
            PrintCenter("Павел Орестов, Москва");

            Console.ReadKey();
        }

        static void PrintCenter(string message)
        {
            int x = (Console.WindowWidth - message.Length) / 2;
            int y = (int)Math.Ceiling((float)Console.WindowHeight / 2);
            Console.SetCursorPosition(x, y);
            Console.Write(message);
        }
    }
}