using System;


/*
ver: 0.1b date: 2021.04.13
autor: Mikhail625@protonmail.com
*/

/*
1. Написать метод GetFullName(string firstName, string lastName, string patronymic), 
принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО. 
Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.

2. Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, 
и возвращающую число — сумму всех чисел в строке. Ввести данные с клавиатуры и вывести 
результат на экран.

3. Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца. 
На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn. 
Написать метод, принимающий на вход значение из этого перечисления и возвращающий 
название времени года (зима, весна, лето, осень). Используя эти методы, ввести с 
клавиатуры номер месяца и вывести название времени года. Если введено некорректное 
число, вывести в консоль текст «Ошибка: введите число от 1 до 12».

4. (*) Написать программу, вычисляющую число Фибоначчи для заданного значения 
рекурсивным способом.

5. (**) Есть предложение String str1 = " Предложение один Теперь предложение два 
Предложение три"; нужно превести строку к нормально виду " Предложение один. 
Теперь предложение два. Предложение три";

Сдайте задание до: 14 апр., 19:00 +03:00
 
 */



namespace lesson_004
{


    class Program
    {
        static void Main(string[] args)
        {




            { // Task № 01  Написать метод GetFullName(string firstName, string lastName, string patronymic)
              // block declare init vars
                string name1;
                string name2;
                string name3;
                string name4;


                bool positive = false;
                bool negative = false;
                string[] arrNegativeAnswear = { "0", "n", "N", "no", "NO", "н", "Н", "нет", "НЕТ", "", "", "", "", "", "", "" };
                string[] arrPostiveAnswear = { "1", "y", "Y", "yes", "YES", "д", "Д", "да", "ДА", "", "", "", "", "", "", "", "" };
                string answear;



                // block executive
                /*
                do
                { }
                while (answear = "n");
                */
                name1 = "Тарковский";
                name2 = "Арсений";
                name3 = "Александрович";
                name4 = GetFullName(name1, name2, name3);

                // Configure console.
                Console.BufferWidth = 80;
                Console.WindowWidth = Console.BufferWidth;
                Console.TreatControlCAsInput = true;
                Console.Title = "lesson n 4";
                Console.WriteLine(" \n   {0}", GetFullName(name1, name2 , name3) );
                
                System.Threading.Thread.Sleep(10000);
                Console.Clear();
                static string GetFullName(string firstName, string lastName, string patronymic)
                {
                    return (firstName + " " + lastName + " " + patronymic);
                }
 
                // end of  Task № 01  Написать метод GetFullName(string firstName, string lastName, string patronymic)
            }



            { // Task № xx
              // block declare init vars
              // block executive
              // end of  Task № xx
            }

            { // Task № xx
              // block declare init vars
              // block executive
              // end of  Task № xx
            }

            { // Task № xx
              // block declare init vars
              // block executive
              // end of  Task № xx
            }

            { // Task № xx
              // block declare init vars
              // block executive
              // end of  Task № xx
            }

            { // Task № xx
              // block declare init vars
              // block executive
              // end of  Task № xx
            }
        }
    }
}
