using System;

namespace App {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter numbers: ");
            int limit = int.Parse(Console.ReadLine());
            Console.WriteLine("Printing Numbers:");
            for (int i = 0; i < limit; i ++) {
                Console.WriteLine(i * i);
            }
        }
    }
}
    