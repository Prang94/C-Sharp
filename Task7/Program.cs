using System;

//Пользователь вводит с клавиатуры два числа. Нужно показать все четные числа в указанном диапазоне. Если границы диапазона указаны неправильно
//требуется произвести нормализацию границ. Например, пользователь ввел 20 и 11, требуется нормализация, после которой начало диапазона станет
//равно 11, а конец 20.


namespace Task7
{

    internal class Program
    {
      
        static void Main(string[] args)
        {
            int FirstValue, SecondValue;

            Console.Write("Введите первое число: ");
            FirstValue = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            SecondValue = int.Parse(Console.ReadLine());

            if (FirstValue > SecondValue) 
            {
                int temp = FirstValue;
                FirstValue = SecondValue;
                SecondValue = temp;
            }

            ShowEvenValues(FirstValue, SecondValue);

        }

        static void ShowEvenValues(int a, int b)
        {
            Console.Write("Четные числа указанного диапазона: ");

            for (int i = a; i < b; ++i)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine("\n");


        }

    }
}
