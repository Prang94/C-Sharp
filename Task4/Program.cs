using System;

//Пользователь вводит шестизначное число. После чего пользователь вводит номера разрядов для обмена цифр. Например, если пользователь
//ввёл один и шесть — это значит, что надо обменять местами первую и шестую цифры. Число 723895 должно превратиться в 523897.
//Если пользователь ввел не шестизначное число требуется вывести сообщение об ошибке.

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите шестизначное число: ");

            uint value = uint.Parse(Console.ReadLine());
            
            if (value < 100000 || value > 999999)
            {
                Console.WriteLine("Ошибка ввода!");
                return;
            }

            byte first,second,third,fourth, fifth, sixth;

            first = (byte)(value / 100000);
            second = (byte)((value / 10000) % 10);
            third = (byte)((value / 1000) % 10);
            fourth = (byte)((value / 100) % 10);
            fifth = (byte)((value / 10) % 10);
            sixth = (byte)(value % 10);

            byte[] arr = new byte[6];
            arr[0] = first; arr[1] = second; arr[2] = third; arr[3] = fourth; arr[4] = fifth; arr[5] = sixth;


            byte changeVal1, changeVal2;

            Console.Write("Введите первый разряд: ");
            changeVal1 = byte.Parse(Console.ReadLine());

            Console.Write("Введите второй разряд: ");
            changeVal2 = byte.Parse(Console.ReadLine());

            if ((changeVal1 < 1 || changeVal1 > 6) || (changeVal2 < 1 || changeVal2 > 6))
            {
                Console.WriteLine("Ошибка ввода разрядов! Значение должно быть в диапазоне от 1 до 6!");
                return;
            }

            byte temp;

            temp = arr[changeVal1 - 1];
            arr[changeVal1 - 1] = arr[changeVal2 - 1];
            arr[changeVal2 - 1] = temp;

            uint result = (uint)(arr[0] * 100000 + arr[1] * 10000 + arr[2] * 1000 + arr[3] * 100 + arr[4] * 10 + arr[5]);

            Console.WriteLine("Новое число: " + result);


        }
    }
}
