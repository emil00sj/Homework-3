using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Задачи_файла
{
    internal class Program
    {
        enum Week
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            /* 1) Дана последовательность из 10 чисел. Определить, является ли эта последовательность
            упорядоченной по возрастанию. В случае отрицательного ответа определить
            порядковый номер первого числа, которое нарушает данную последовательность.
            Использовать break */
            Console.WriteLine("Номер 1) \nВведите последовательность из 10 чисел");
            Console.Write("Введите певрое число: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе  число: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Введите четвертое число: ");
            int num4 = int.Parse(Console.ReadLine());
            Console.Write("Введите пятое число: ");
            int num5 = int.Parse(Console.ReadLine());
            Console.Write("Введите шестое число: ");
            int num6 = int.Parse(Console.ReadLine());
            Console.Write("Введите седьмое число: ");
            int num7 = int.Parse(Console.ReadLine());
            Console.Write("Введите восьмое число: ");
            int num8 = int.Parse(Console.ReadLine());
            Console.Write("Введите девятое число: ");
            int num9 = int.Parse(Console.ReadLine());
            Console.Write("Введите десятое число: ");
            int num10 = int.Parse(Console.ReadLine());
            int[] sequence = { num1, num2, num3, num4, num5, num6, num7, num8, num9, num10 };
            bool up = true;
            int i = 0;
            while ((i < 9) && (up))
            {
                if (sequence[i] >= sequence[i + 1])
                {
                    up = false;
                    break;
                }
                i++;
            }
            if (up)
            {
                Console.WriteLine("Последовательность возрастает");
            }
            else
            {
                int index = 0;
                for (int j = 0; j < 10; j++)
                {
                    if (sequence[j] >= sequence[j + 1])
                    {
                        index = j + 1;
                        break;
                    }
                }
                Console.WriteLine($"Последовательность не возрастает. Последовательность нарушает {index + 1} число.");
            }

            /*2. Игральным картам условно присвоены следующие порядковые номера в зависимости от
            их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
            Порядковые номера остальных карт соответствуют их названиям («шестерка»,
            «девятка» и т. п.). По заданному номеру карты k (6 <=k <= 14) определить достоинство
            соответствующей карты. Использовать try-catch-finally */
            Console.WriteLine("\nНомер 2)");
            Console.Write("Введите номер карты от 6 до 14: ");
            int k = int.Parse(Console.ReadLine());
            if ( k < 6 || k > 14)
            {
                Console.WriteLine("Некорректный ввод, повторите попытку");
            }
            else
            {
                try
                {
                    switch (k)
                    {
                        case 6:
                            Console.WriteLine("Ваша карта - шестерка"); break;
                        case 7:
                            Console.WriteLine("Ваша карта - семерка"); break;
                        case 8:
                            Console.WriteLine("Ваша карта - восьмерка"); break;
                        case 9:
                            Console.WriteLine("Ваша карта - девятка"); break;
                        case 10:
                            Console.WriteLine("Ваша карта - десятка"); break;
                        case 11:
                            Console.WriteLine("Ваша карта - валет"); break;
                        case 12:
                            Console.WriteLine("Ваша карта - дама"); break;
                        case 13:
                            Console.WriteLine("Ваша карта - король"); break;
                        case 14:
                            Console.WriteLine("Ваша карта - туз"); break;
                    }
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод, повторите попытку");
                }
            }
            

            /* 3) Напишите программу, которая принимает на входе строку и производит выходные
            данные в соответствии со следующей таблицей:*/
            Console.WriteLine("\nНомер 3)");
            Console.WriteLine("Введите значение из таблицы");
            string name = Console.ReadLine();
            switch (name.ToLower())
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");break;
                case "politician":
                    Console.WriteLine("Your tax dollars");break;
                case "rapper":
                    Console.WriteLine("Cristal");break;
            }
            if ((name.ToLower() != "jabroni") && (name.ToLower() != "school counselor") && (name.ToLower() != "programmer") && (name.ToLower() != "bike gang member") && (name.ToLower() != "politician") && (name.ToLower() != "rapper"))
            {
                Console.WriteLine("Beer");
            }

            /*4. Составить программу, которая в зависимости от порядкового номера дня недели (1, 2,
            ...,7) выводит на экран его название (понедельник, вторник, ..., воскресенье).
            Использовать enum.*/
            Console.WriteLine("\nНомер 4)");
            Console.WriteLine("Введите день недели по счёту: ");
            int weekDay = int.Parse(Console.ReadLine());
            Week currentDay = (Week)weekDay;
            switch (currentDay)
            {
                case Week.Monday:
                    Console.WriteLine("Понедельник");break;
                case Week.Tuesday:
                    Console.WriteLine("Вторник");break;
                case Week.Wednesday:
                    Console.WriteLine("Среда");break;
                case Week.Thursday:
                    Console.WriteLine("Четверг");break;
                case Week.Friday:
                    Console.WriteLine("Пятница");break;
                case Week.Saturday:
                    Console.WriteLine("Суббота");break;
                case Week.Sunday:
                    Console.WriteLine("Воскресенье");break;
            }
            if ((weekDay < 1) || (weekDay > 7))
            {
                Console.WriteLine("Номер дня недели введен неправильно");
            }

            /*5. Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента
            "Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е. прибавить к
            результату. Вывести на экран сколько кукол в “сумке”.*/
            Console.WriteLine("\nНомер 5)");
            string[] array = { "Hello Kitty", "Barbie doll", "Man", "Women", "Cat", "a", "qwerty" };
            int sumka = 0;
            foreach (string s in array)
            {
                if ((s == "Hello Kitty") || (s == "Barbie doll"))
                {
                    sumka++;
                }
            }
            Console.WriteLine($"В сумке {sumka} кукол");
            Console.ReadKey();
        }
    }
}
