using System;

/*
     Таск_3
     Известны год, номер месяца и день рождения каждого из двух человек.
     Определить, кто из них старше. Даты вводятся с клавиатуры.
*/

namespace СompareTwoDates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Stas's birthday in the format (yyyy.mm.dd): ");
            DateTime date1 = new DateTime();
            date1 = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Ruslan's birthday in the format (yyyy.mm.dd): ");
            DateTime date2 = new DateTime();
            date2 = DateTime.Parse(Console.ReadLine());

            if (date1 < date2)
            {
                Console.WriteLine("\nStas is older than Ruslan!!!");
            }
            else
            {
                Console.WriteLine("\nRuslan is older than Stas!!!");
            }

            
        }
    }
}
