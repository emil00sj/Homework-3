using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задачи__Тумакова
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Упражнение 4.1) Написать программу, которая читает с экрана число от 1 до 365(номер дня
            в году), переводит этот число в месяц и день месяца. Например, число 40 соответствует 9
            февраля(високосный год не учитывать) */
            Console.Write("Упражнение 4.1 \nВведите номер дня в году от 1 до 365: ");
            int num = int.Parse(Console.ReadLine());
            if ((1 <= num) && ( num <= 31))
            {
                Console.WriteLine($"{num} January");
            }
            else if ((32 <= num) && (num <= 59))
            {
                Console.WriteLine($"{num-31} February");
            }
            else if ((60 <= num) && (num <= 90))
            {
                Console.WriteLine($"{num - 59} March");
            }
            else if ((91 <= num) && (num <= 120))
            {
                Console.WriteLine($"{num - 90} April");
            }
            else if ((121 <= num) && (num <= 151))
            {
                Console.WriteLine($"{num - 120} May");
            }
            else if ((152 <= num) && (num <= 181))
            {
                Console.WriteLine($"{num - 151} June");
            }
            else if ((182 <= num) && (num <= 212))
            {
                Console.WriteLine($"{num - 181} July");
            }
            else if ((213 <= num) && (num <= 242))
            {
                Console.WriteLine($"{num - 212} August");
            }
            else if ((243 <= num) && (num <= 273))
            {
                Console.WriteLine($"{num - 242} September");
            }
            else if ((274 <= num) && (num <= 304))
            {
                Console.WriteLine($"{num - 273} October");
            }
            else if ((305 <= num) && (num <= 334))
            {
                Console.WriteLine($"{num - 304} November");
            }
            else
            {
                Console.WriteLine($"{num - 334} December");
            }

            /*Упражнение 4.2) Добавить к задаче из предыдущего упражнения проверку числа введенного
            пользователем. Если число меньше 1 или больше 365, программа должна вырабатывать
            исключение, и выдавать на экран сообщение */
            Console.Write("\nУпражнение 4.2 \nВведите номер дня в году от 1 до 365: ");
            int day = int.Parse(Console.ReadLine());
            if ((1 <= day) && (day <= 31))
            {
                Console.WriteLine($"{day} January");
            }
            else if ((32 <= day) && (day <= 59))
            {
                Console.WriteLine($"{day - 31} February");
            }
            else if ((60 <= day) && (day <= 90))
            {
                Console.WriteLine($"{day - 59} March");
            }
            else if ((91 <= day) && (day <= 120))
            {
                Console.WriteLine($"{day - 90} April");
            }
            else if ((121 <= day) && (day <= 151))
            {
                Console.WriteLine($"{day - 120} May");
            }
            else if ((152 <= day) && (day <= 181))
            {
                Console.WriteLine($"{day - 151} June");
            }
            else if ((182 <= day) && (day <= 212))
            {
                Console.WriteLine($"{day - 181} July");
            }
            else if ((213 <= day) && (day <= 242))
            {
                Console.WriteLine($"{day - 212} August");
            }
            else if ((243 <= day) && (day <= 273))
            {
                Console.WriteLine($"{day - 242} September");
            }
            else if ((274 <= day) && (day <= 304))
            {
                Console.WriteLine($"{day - 273} October");
            }
            else if ((305 <= day) && (day <= 334))
            {
                Console.WriteLine($"{day - 304} November");
            }
            else if ((335 <= day) && (day <= 365))
            {
                Console.WriteLine($"{day - 334} December");
            }
            else
            {
                Console.WriteLine("Вы ввели неверное число, номер дня должен быть от 1 до 366");
            }

            /* Домашнее задание 4.1) Изменить программу из упражнений 4.1 и 4.2 так, чтобы она
            учитывала год (високосный или нет). Год вводится с экрана. (Год високосный, если он
            делится на четыре без остатка, но если он делится на 100 без остатка, это не високосный
            год. Однако, если он делится без остатка на 400, это високосный год.) */
            Console.WriteLine("\nДомашнее задание 4.1");
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Введите номер дня в году от 1 до 366: ");
            int numDay = int.Parse(Console.ReadLine());
            if ((year % 4 == 0) && (year % 100 != 0))
                if ((1 <= numDay ) && (numDay <= 31))
                {
                    Console.WriteLine($"{numDay} January");
                }
                else if ((32 <= numDay) && (numDay <= 60))
                {
                    Console.WriteLine($"{numDay - 31} February");
                }
                else if ((61 <= numDay) && (numDay <= 91))
                {
                    Console.WriteLine($"{numDay - 60} March");
                }
                else if ((92 <= numDay) && (numDay <= 121))
                {
                    Console.WriteLine($"{numDay - 91} April");
                }
                else if ((122 <= numDay) && (numDay <= 152))
                {
                    Console.WriteLine($"{numDay - 121} May");
                }
                else if ((153 <= numDay) && (numDay <= 182))
                {
                    Console.WriteLine($"{numDay - 152} June");
                }
                else if ((183 <= numDay) && (numDay <= 213))
                {
                    Console.WriteLine($"{numDay - 182} July");
                }
                else if ((214 <= numDay) && (numDay <= 243))
                {
                    Console.WriteLine($"{numDay - 213} August");
                }
                else if ((244 <= numDay) && (numDay <= 274))
                {
                    Console.WriteLine($"{numDay - 243} September");
                }
                else if ((275 <= numDay) && (numDay <= 305))
                {
                    Console.WriteLine($"{numDay - 274} October");
                }
                else if ((306 <= numDay) && (numDay <= 335))
                {
                    Console.WriteLine($"{numDay - 305} November");
                }
                else if ((336 <= numDay) && (numDay <= 366))
                {
                    Console.WriteLine($"{numDay - 335} December");
                }
                else
                {
                    Console.WriteLine("Вы ввели неверное число, номер дня должен быть от 1 до 366");
                }
            else
                if ((1 <= numDay) && (numDay <= 31))
                {
                    Console.WriteLine($"{numDay} January");
                }
                else if ((32 <= numDay) && (numDay <= 59))
                {
                    Console.WriteLine($"{numDay - 31} February");
                }
                else if ((60 <= numDay) && (numDay <= 90))
                {
                    Console.WriteLine($"{numDay - 59} March");
                }
                else if ((91 <= numDay) && (numDay <= 120))
                {
                    Console.WriteLine($"{numDay - 90} April");
                }
                else if ((121 <= numDay) && (numDay <= 151))
                {
                    Console.WriteLine($"{numDay - 120} May");
                }
                else if ((152 <= numDay) && (numDay <= 181))
                {
                    Console.WriteLine($"{numDay - 151} June");
                }
                else if ((182 <= numDay) && (numDay <= 212))
                {
                    Console.WriteLine($"{numDay - 181} July");
                }
                else if ((213 <= numDay) && (numDay <= 242))
                {
                    Console.WriteLine($"{numDay - 212} August");
                }
                else if ((243 <= numDay) && (numDay <= 273))
                {
                    Console.WriteLine($"{numDay - 242} September");
                }
                else if ((274 <= numDay) && (numDay <= 304))
                {
                    Console.WriteLine($"{numDay - 273} October");
                }
                else if ((305 <= numDay) && (numDay <= 334))
                {
                    Console.WriteLine($"{numDay - 304} November");
                }
                else if ((335 <= numDay) && (numDay <= 365))
                {
                    Console.WriteLine($"{numDay - 334} December");
                }
                else
                {
                    Console.WriteLine("Вы ввели неверное число, номер дня должен быть от 1 до 366");
                }
            Console.ReadKey();
        }
    }
}
