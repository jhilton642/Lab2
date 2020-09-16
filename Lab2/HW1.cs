using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class HW1
    {
        static void Main(string[] args) {
            int sum;
            int product;
            int difference;
            int quotient;
            Console.WriteLine("Enter a number:  ");
            int int1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number:  ");
            int int2 = Convert.ToInt32(Console.ReadLine());
            sum = int1 + int2;
            product = int1 * int2;
            difference = int1 - int2;
            quotient = int1 / int2;
            Console.WriteLine("Sum: " + sum + "Product: " + product + "Difference: " + difference + "Quotent: " + quotient);
        }
    }
}