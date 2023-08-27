using System;

//Пользователь вводит с клавиатуры число в диапазоне от 1 до 100. Если число кратно 3 (делится на 3 без
//остатка) нужно вывести слово Fizz. Если число кратно 5 нужно вывести слово Buzz. Если число кратно 3 и 5 нужно
//вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно вывести само число. Если пользователь ввел значение не в диапазоне от 1
//до 100 требуется вывести сообщение об ошибке.

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите число от 1 до 100: ");

            byte value = byte.Parse(Console.ReadLine());

            if (value < 1 || value > 100)
            {
                Console.WriteLine("Ошибка ввода!");
                return;
            }

            if (value % 3 == 0 && value % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }

            else if (value % 3 == 0) {
                Console.WriteLine("Fizz");
            }

            else if (value % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }

            else if (value % 3 != 0 && value % 5 != 0) 
            {

                Console.WriteLine(value);

            }
        }
    }
}
