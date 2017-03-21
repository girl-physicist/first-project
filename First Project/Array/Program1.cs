using System;
using System.Threading.Tasks;

namespace Array
{
    class Program1
    {
        static void Main(string[] args)
        {
            string param = "new";
            while (param == "new")
            {
                int[] arr = new int[10];
                Random rand = new Random();
                // Array filling
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Choose how to fill the array.");
                Console.Write("\n" + "Enter the value from the keyboard. Enter ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n" + "Set values using the random number generator. Enter ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("2");
                string choose = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                if (choose == "1")
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
                 var P = 0;
                 var Q = 0;
                while (P >= Q)
                {
                    Console.WriteLine("\n"+"Enter P and Q (P < Q)");
                    Console.WriteLine("P:");
                    if (int.TryParse(Console.ReadLine(), out P))
                    {
                        Console.WriteLine("Q:");
                        if (int.TryParse(Console.ReadLine(), out Q))
                        {
                            if (P >= Q)
                            {
                                Console.WriteLine("P should be less than Q");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Q must be number");
                            P = 0;
                        }
                    }
                    else
                        Console.WriteLine("P must be number");
                }
                // The number of elements between P and Q
                int a = 0;
                for (int j = 0; j < arr.Length; j++)
                    if (P < arr[j] && Q > arr[j])
                        a += 1;
                Console.WriteLine("\n"+"The number of elements between P and Q = " + a + " elements"+ "\n");
                //Max and Min
                {
                    int min = arr[0], max = arr[0];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (min > arr[i])
                            min = arr[i];
                        if (max < arr[i])
                            max = arr[i];
                    }
                    {
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i] == max)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            else if (arr[i] == min)
                                Console.ForegroundColor = ConsoleColor.Cyan;
                            else Console.ForegroundColor = ConsoleColor.Gray;
                       Console.Write(arr[i] + "\t");
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n"+ "\n" + "min= " + min + "\n" + "max= " + max + "\n");
                }
                //Insert sorting
                int newElement, location;
                for (int i = 1; i < arr.Length; i++)
                {
                    newElement = arr[i];
                    location = i - 1;
                    while (location >= 0 && arr[location] > newElement)
                    {
                        arr[location + 1] = arr[location];
                        location = location - 1;
                    }
                    arr[location + 1] = newElement;
                }
                Console.Write("Sorted array:\n");
                for (int i = 0; i < arr.Length; i++)
                    Console.Write(arr[i]+"\t");
                





                Console.WriteLine();
                Console.WriteLine("\n"+"To close the console, press 'Y', If you want to restart the script, press 'N'");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    param = "close";
                else
                {
                    param = "new";
                    Console.Clear();

                }
                    
              }
            }
        }
    }
