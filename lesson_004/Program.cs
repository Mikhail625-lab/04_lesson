using System;
using System.Text;

/*
ver: 0.2a date: 2021.04.13
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
        static string GetStrFromCons( string strByDef, string strQuestion)
        {
            string  strResult  = "";
            if (TestForNullOrEmpty(strQuestion)==true)
            { strQuestion = "Enter value:"; }

            Console.WriteLine(strQuestion);
            strResult  = Console.ReadLine();

            // check/verife isNull Empty
            if (TestForNullOrEmpty( strResult )==true)
            {
                 strResult  = strByDef;
                Console.WriteLine("Not value, set by default: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(strResult);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("");

            }
            return  strResult ;
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return (firstName + " " + lastName + " " + patronymic);
        }

        static bool TestForNullOrEmpty(string s)
        {
            bool result;
            result = s == null || s == string.Empty;
            return result;
        }


        static void Main(string[] args)
        {
            //Task1();
            Task2();



            static void Task1()
            { // Task № 01  Написать метод GetFullName(string firstName, string lastName, string patronymic)
              // block declare init vars
                string name1;
                string name2;
                string name3;
                string name4;

                bool positive = false;
                bool negative = false;
                bool countDown = false;
                string[] arrNegativeAnswear = { "0", "n", "N", "no", "NO", "н", "Н", "нет", "НЕТ", "", "", "", "", "", "", "" };
                string[] arrPostiveAnswear = { "1", "y", "Y", "yes", "YES", "д", "Д", "да", "ДА", "", "", "", "", "", "", "", "" };
                

                string nameDef1 = "Тарковский";
                string nameDef2 = "Арсений";
                string nameDef3 = "Александрович";

                string textQuestion1 = " Enter firstName:";
                string textQuestion2 = " Enter lastName:";
                string textQuestion3 = " Enter patronymic:";
                string answear;

                // block executive

                /*
                do
                { }
                while (answear = "n");
                */

                //GetStrFromCons(valueByDefault) 

                name1 = GetStrFromCons(nameDef1, textQuestion1);
                name2 = GetStrFromCons(nameDef2, textQuestion2);
                name3 = GetStrFromCons(nameDef3, textQuestion3);

                name4 = GetFullName(name1, name2, name3);

                // Configure console.
                Console.Title = "lesson n 4";
                Console.BufferWidth = 80;
                Console.WindowWidth = Console.BufferWidth;
                Console.TreatControlCAsInput = true;

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(" Result:");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n   {0}", GetFullName(name1, name2 , name3) );
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("   \n \n Screen clear after :");


                for (int i=21; i>0; i--)
                {   
                System.Threading.Thread.Sleep(1000);
                    if (i == 10) { countDown = true; }
                    if (countDown == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("\r    ");
                    Console.Write("\r  {0}", i);  
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Clear();

 
                // end of  Task № 01  Написать метод GetFullName(string firstName, string lastName, string patronymic)
            }


            static void Task2()
            { // Task № 02
              // block declare init vars
                bool PosStart = false;
                bool PosFinish = false;

                int indx1;
                int indx2;

                string inputStr;
                string tmpStr;
                string textQuestion1 = " Enter a group of numbers separated by a space:";
                string valueByDefault = "326 625 11 0 27 147 01";

                var sb = new StringBuilder();

                // block executive
                inputStr = GetStrFromCons(valueByDefault, textQuestion1);
                char[] arrChars = inputStr.ToCharArray();
                int[] arrInt = new int[arrChars.Length];

                indx1 = 0;
                indx2 = inputStr.IndexOf(" ");

                foreach (char ch in arrChars)
                {  Console.WriteLine(ch);}
                { int i = 0;  int j = 0;
                    do
                    {
                        indx1 = i;
                        if (arrChars[i] != ' ')
                        {
                            sb.Append(arrChars[i]);
                        }
                        else
                        {
                            arrInt[j] = Convert.ToInt32(sb);
                            sb.Clear();
                            
                            j++;
                        }
                        i++;
                    }
                    while (i < arrChars.Length);






                }
                for (int i=0; i< arrChars.Length; i++)
                {
                    if (arrChars[i] == ' ' )
                    {
                        PosStart = true;
                        indx1 = arrChars[i];
                        for (int j = i + 1; j < arrChars.Length; j++)
                        {
                            if (arrChars[j]!=' ')
                            {
                                sb.Append(arrChars[i]);
                               // tmpStr = tmpStr + Convert.ToString(arrChars[j]);
                            }
                        
                            i = j;
                        }
                    }
                }



                // Parsing string 
                /*
                 char[] chars = str.ToCharArray();

                */


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
