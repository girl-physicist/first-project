﻿using System;
using System.Threading.Tasks;

namespace Array
{
    class Program1
    {
        static void Main(string[] args)
        {
            //Дан одномерный массив размером 10 и два числа P и Q (P<Q). Определить, сколько элементов массива лежит между P и Q.

            2:int[] arr=new int[10];//Как это сделать меткой?
            Random rand = new Random();
          // Array filling
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Choose how to fill the array.");
            Console.Write("\n"+"Enter the value from the keyboard. Enter ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n" + "Set values using the random number generator. Enter ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("2");
            int choose = Convert.ToInt32(Console.Read());
            Console.ForegroundColor = ConsoleColor.White;
            if (choose == 1)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(string.Format("Enter the {0} element of the array:", i + 1));
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("Array[10]");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(-100, 100);
                    Console.Write(arr[i] + "\t");
                }
            }
            // Input P and Q
           Console.WriteLine();
      1: Console.WriteLine("Enter P and Q (P < Q)");
          int P = int.Parse(Console.ReadLine());//выбрасывает??????????
          int  Q = int.Parse(Console.ReadLine());
            if (P < Q)
                Console.WriteLine("Your number P=" + P + " Your number Q= " + Q);
            else
            {
                Console.WriteLine("You entered P>=Q. Please, Enter P and Q (P<Q) ");
                goto 1;
            }
           


            // The number of elements between P and Q
           int a = 0;
           for (int j = 0; j < arr.Length; j++)
                if (P < arr[j] && Q > arr[j])
                    a += 1;
            Console.WriteLine("Между элементами лежит " + a + " элеметнов");
            Console.WriteLine(" ");

            Console.WriteLine("Для закрытия консоли нажмите 'Y', Если вы хотите перезапустить скрипт, нажмите 'N'");
            if (Console.ReadKey().Key == ConsoleKey.N)
            {
                Console.WriteLine();
                
            }
           else
                goto 2;








        }
    }
}