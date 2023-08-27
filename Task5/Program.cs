using System;


//Пользователь вводит с клавиатуры дату. Приложение должно отобразить название сезона и дня недели. Например, если введено 22.12.2021, приложение должно
//отобразить Winter Wednesday

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            sbyte day, month;
            ushort year;

            Console.Write("Введите число: ");
            day = sbyte.Parse(Console.ReadLine());

            Console.Write("Введите месяц (1-12): ");
            month = sbyte.Parse(Console.ReadLine());

            Console.Write("Введите год: ");
            year = ushort.Parse(Console.ReadLine());

            sbyte Day_of_Week = (sbyte)((month * 30 + day) % 7);

            if (month == 12 || (month >= 1 && month < 3)) {
                Console.Write("Winter");
            }

            else if (month > 2 && month < 6)
            {
                Console.Write("Spring");
            }

            else if (month > 5 && month < 9)
            {
                Console.Write("Summer");
            }

            else
            {
                Console.Write("Autumn");
            }

            switch(Day_of_Week) 
            {

                case 1:
                    Console.WriteLine(" Monday"); break;
                case 2:
                    Console.WriteLine(" Tuesday"); break;
                case 3:
                    Console.WriteLine(" Wednesday"); break;
                case 4:
                    Console.WriteLine(" Thursday"); break;
                case 5:
                    Console.WriteLine(" Friday"); break;
                case 6:
                    Console.WriteLine(" Saturday"); break;
                case 7:
                    Console.WriteLine(" Sunday"); break;

            }
        }
    }
}
