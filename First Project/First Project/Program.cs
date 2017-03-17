using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Data Types and Operations


            //int a = 25;
            //double b = 2.5;
            //string s = "Hello ";
            //var v = "dear "; //универсальный тип
            //string name;
            //string date = DateTime.Today.ToShortDateString();
            //string time = DateTime.Now.ToShortTimeString();
            //const string Text = "There. are, too many/ punctuation?  marks! in; this: text! ";

            //// Действия
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("Действия");
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("Summa1 = " + (a + b));
            //double result = Math.Sqrt((a + b) * (a + b));
            //Console.WriteLine("Sqrt = " + result);
            //Console.WriteLine("Sqrt = " + Math.Sqrt((a + b) * (a + b)));
            //Console.ReadLine();

            ////Конкатенация строк
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("Конкатенация строк");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("Enter your name ");
            //name = Console.ReadLine();
            //string str = s + v + name + ". Today is " + date + ". And now " + time + ".";
            //Console.WriteLine(str);
            //Console.ReadLine();

            ////Split
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("Split");
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine(Text);
            //string[] Array_words = Text.Split(new Char[] { ' ', ',', ':', '?', '!', ';', '/', '.' }, StringSplitOptions.RemoveEmptyEntries);
            //foreach (string word in Array_words)
            //{
            //    Console.WriteLine(word);
            //}
            //Console.ReadLine();

            ////Replase
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("Replase");
            //Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.WriteLine((s + v));
            //Console.WriteLine((s + v).Replace("dear", "World"));
            //Console.ReadLine();
            #endregion


            #region Conditional constructions
            //IF - ELSE
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("IF-ELSE");
            Console.ForegroundColor = ConsoleColor.Green;
            if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12)
            {
                Console.WriteLine("Good MORNING");
            }
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
            {
                Console.WriteLine("Good AFTERNOON");
            }
            else if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour < 20)
            {
                Console.WriteLine("Good EVENING");
            }
            else if (DateTime.Now.Hour >= 20 && DateTime.Now.Hour < 6)
            {
                Console.WriteLine("Good NIGHT");
            }
            Console.ReadLine();

            //Тернарный оператор
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Тернарный оператор / дата");
            Console.ForegroundColor = ConsoleColor.Yellow;
            var result = DateTime.Now.Hour >=18 ? "Time after 18" : "Time to 18";
            Console.WriteLine(result);
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Тернарный оператор / модуль числа");
            Console.ForegroundColor = ConsoleColor.Yellow;
            int result2;
            for (int i = 5; i >= -5; i--)
            {
                result2 = i >= 0 ? i : -i;
                Console.Write("{0}\t", result2);
            }
            Console.ForegroundColor = ConsoleColor.White;
      
            Console.ReadLine();
            Console.WriteLine("Тернарный оператор / четные числа");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int j=0; j<=10; j++)
            {
                if  (j % 2 == 0 ? true : false)                             
            Console.Write("{0}\t", j);
            }
            Console.ReadLine();



            // Switch 
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Switch-название дня");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ввеите номер дня");
            int day =Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Пн");
                    break;
                case 2:
                    Console.WriteLine("Вт");
                    break;
                case 3:
                    Console.WriteLine("Ср");
                    break;
                case 4:
                    Console.WriteLine("Чт");
                    break;
                case 5:
                    Console.WriteLine("Пт");
                    break;
                case 6:
                    Console.WriteLine("Сб");
                    break;
                case 7:
                    Console.WriteLine("Вс");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
                        }
           
            
            //Switch - выходной
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Switch-выходной");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ввеите номер дня");
            int day2 = Convert.ToInt32(Console.ReadLine());
            switch (day2)
            {
                case 1:                   
                case 2:            
                case 3:                    
                case 4:                   
                case 5:
                    Console.WriteLine("Рабочий");
                    break;
                case 6:                  
                case 7:
                    Console.WriteLine("Выходной");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            Console.ReadLine();
            #endregion
        }
    }
}
