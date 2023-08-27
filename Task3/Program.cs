using System;


//Пользователь вводит с клавиатуры четыре цифры. Необходимо создать число, содержащее эти цифры. Например, если с клавиатуры введено 1, 5, 7, 8
//тогда нужно сформировать число 1578.

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte first, second, third, fourth;

            Console.Write("Введите первую цифру: ");
            first = byte.Parse(Console.ReadLine());

            Console.Write("Введите вторую цифру: ");
            second = byte.Parse(Console.ReadLine());

            Console.Write("Введите третью цифру: ");
            third = byte.Parse(Console.ReadLine());

            Console.Write("Введите четвертую цифру: ");
            fourth = byte.Parse(Console.ReadLine());


            ushort result = (ushort)(first * 1000 + second * 100 + third * 10 + fourth);

            Console.WriteLine("Результат = " + result);

        }
    }
}
