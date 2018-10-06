//Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
//В результате вся информация выводится в одну строчку.

//Павел Орестов

using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string family;
            int age;
            int height;
            int weight;

            Console.WriteLine("Введите Ваше имя:");
            name = Console.ReadLine();
            Console.WriteLine("Ваша фамилия:");
            family = Console.ReadLine();
            Console.WriteLine("Ваш возраст:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваш рост:");
            height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваш вес:");
            weight = Convert.ToInt32(Console.ReadLine());

            //а
            Console.WriteLine("Имя: " + name + "\tФамилия: " + family + "\tВозраст: " + age + "\tРост: " + height + "\tВес: " + weight);
            //б
            Console.WriteLine("Имя: {0}\tФамилия: {1}\tВозраст: {2:D}\tРост: {3:D}\tВес: {4:D}", name, family, age, height, weight);
            //в
            Console.WriteLine($"Имя: {name}\tФамилия: {family}\tВозраст: {age:D}\tРост: {height:D}\tВес: {weight:D}");

            Console.ReadKey();
        }
    }
}