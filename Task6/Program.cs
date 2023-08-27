using System;

//Пользователь вводит с клавиатуры показания температуры. В зависимости от выбора пользователя программа переводит температуру из Фаренгейта в Цельсий
//или наоборот.

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float temperature;

            Console.Write("Введите показатель температуры: ");

            temperature = float.Parse(Console.ReadLine());

            do
            {
                byte temp;
                Console.WriteLine("0 - Выход из программы\n1 - Перевести в градусы цельсия\n2 - Перевести в градусы по фаренгейту");
                temp = byte.Parse(Console.ReadLine());

                switch(temp)
                {
                    case 0: return;
                    case 1:
                        Console.WriteLine("Температура в цельсиях = " + ((temperature - 32) * 5 / 9)); break;
                    case 2:
                        Console.WriteLine("Температура в фаренгейтах = " + ((temperature * 9) / 5 + 32)); break;

                    default:
                        Console.WriteLine("В меню нет такого пункта!"); return;
                }


            } while(true);
            

        }
    }
}
