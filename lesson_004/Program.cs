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

                // shutdown countdown 
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
            { // Task № 02 Ура !Работат. Надо причесать 
              // block declare init vars

               // int indx1;
               // int indx2;
                int summaNumbers = 0;
                int countNumbers = 0; // количество слов и\или чисел вычлененных из строки; необязательный 

                string inputStr;
                string textQuestion1 = " Enter a group of numbers separated by a space: \n or press key [ENTER] for set value by default:";
                string valueByDefault ;
                //for testing:
                valueByDefault = "01 326 625 11 0 27 147 "; // 	 correct result : 1137

             
                valueByDefault = "144 1"; //correct result : 145  Test:OK! 
                valueByDefault = "147 326 625 11 0 27 01 "; //correct result : 1137 Test:OK! 
                valueByDefault = "01 326 625 11 0 27 147"; //correct result : 1137 Test:OK! 
                valueByDefault = "5369 8001	2914 7786 81 7989 2139 4026";     //	 correct result :38305  range 10-10000	+ \t in middle string  
                valueByDefault = "5369 8001	2914 7786	81	7989	2139	4026";    //	 correct result :38305  range 10-10000	+ double SPACE in middle string  
                valueByDefault = " 6270	4245	2736	8936	4795	4932	1703	4424";// correct result :38041	range 1000-10000	+ prime symbol is SPACE

                valueByDefault = "32	55	59	87	71	33	15	98 ";              // correct result : 450	range 10-100    + SPACE end string 	
                valueByDefault = "458	908	485	704	800	342	740	0440";// correct result : 4877	range 100-1000	 + last number 0xx
                valueByDefault = " 6270	4245	2736	8936	4795	4932	1703	4424";// correct result :38041	range 1000-10000	+ prime symbol is SPACE
                 

                var sb = new StringBuilder();

                // block executive
                inputStr = GetStrFromCons(valueByDefault, textQuestion1);
                inputStr = (inputStr.Replace('\t', ' ')).Trim(' '); // избавляемся от вкравшихся табов и пограничных пробелов 
                char[] arrChars = inputStr.ToCharArray();

                // run parsing 
                { int i = 0; // int j = 0;
                    do
                    {

                        if ( (arrChars[i] != ' ') && (i<arrChars.Length-1) ) // or end lenth\range massive
                        {
                            sb.Append(arrChars[i]);
                        }
                        else if ((arrChars[i] != ' ') && i == arrChars.Length-1)
                        {
                            sb.Append(arrChars[i]);
                            summaNumbers = summaNumbers + Convert.ToInt32(sb.ToString());
                            sb.Clear();
                            countNumbers++;

                        }
                        else if (arrChars[i]==' ')
                        {
                            summaNumbers = summaNumbers + Convert.ToInt32(sb.ToString());
                            sb.Clear();
                            countNumbers++;
                        }
                        i++;
                    }
                    while (i < arrChars.Length);
  

                }
                // Report:
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("*************** Output  report  & results   *********************");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.Write("Source string : \"");Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(inputStr );Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\" ");

                Console.Write("  Detected {0} numbers " , countNumbers);
                Console.WriteLine("");

                //countNumbers
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("");

                Console.Write("Summa =");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(summaNumbers);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("");


                // shutdown countdown 
                /*
                for (int i = 21; i > 0; i--)
                {
                    System.Threading.Thread.Sleep(1000);
                    if (i == 10) 
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("\r    ");
                    Console.Write("\r  {0}", i);
                }
                */
                // end of  Task № 02
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
