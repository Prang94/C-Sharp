using System;
using System.Globalization;


//Пользователь вводит с клавиатуры два числа. Первое число — это значение, второе число процент, который необходимо посчитать.
//Например, мыввели с клавиатуры 90 и 10. Требуется вывести на экран 10 процентов от 90. Результат: 9.

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b;

            Console.Write("Введите число: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Введите значение процента: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Результат = " + (a * b / 100));

        }
    }
}
