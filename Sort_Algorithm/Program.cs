using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 2, 1, 5, 7, 3, 9, 4, 6, 8, 10 };
            int temp = 0;
            string choice = string.Empty;
           
            Console.WriteLine("1. Bubble Sort");
            Console.WriteLine("2. Exit");
            Console.Write("Choose a Sort ");
            (choice) = Console.ReadLine();
            Console.WriteLine(arr[10]);
            if (choice == "1")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr[i] < arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("{0},", arr[i]);
                }
            }
            else
            {
                Console.WriteLine("Press Enter to Exit");
            }
            Console.ReadKey();
        }
    }
}
