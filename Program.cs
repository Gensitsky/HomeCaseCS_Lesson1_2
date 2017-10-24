/*Начальный вклад в банке равен 10000 грн. Через
каждый месяц размер вклада увеличивается на P
процентов от имеющейся суммы (P — вещественное
число, 0 < P < 25). Значение Р программа должна полу-
чать у пользователя. По данному P определить через
сколько месяцев размер вклада превысит 11000 грн.,
и вывести найденное количество месяцев K (целое
число) и итоговый размер вклада S (вещественное
число).*/
using System;

namespace HomeCaseCS_Lesson1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int startDeposit = 10000;
            int increasedDeposit = 11000;
            int k = 0;
            double s = startDeposit;
            Console.Write("Enter your monthly deposit interest: ");
            double p = Convert.ToDouble(Console.ReadLine());
            if (p >= 25 || p <= 0)
            {
                Console.WriteLine("Error! The range is from 0 to 25.");
            }
            else
            {
                while (s <= increasedDeposit)
                {
                    s *= (1 + p / 100);
                    k++;
                }
                s = (int)s;
                Console.WriteLine($"The number of months found is: {k}");
                Console.WriteLine("The total amount " +
                    $"of the deposit is: {s}");
            }

            Console.ReadKey();
        }
    }
}
