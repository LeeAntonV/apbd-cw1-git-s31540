using System;
using System.ComponentModel.DataAnnotations;

namespace App {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter numbers: ");
            int limit = int.Parse(Console.ReadLine());
            Console.WriteLine("Printing Numbers:");
            for (int i = 0; i < limit; i ++) {
                Console.WriteLine(i * i);
            }
            Console.Write("Goodbye");
        }

        static int CalculateAverage(int[] values)
        {
            int average = 0;
            for (int i = 0; i < values.Length; i++){
                average += values[i];
            }
            
            return average / values.Length;
        }
    }
}
    