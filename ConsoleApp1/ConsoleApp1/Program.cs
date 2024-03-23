// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");
class program
{
    static void Main(string[] args)
    {
for (int number = 100; number < 1000; number++) {
            int digit1 = number / 100;
            int digit2 = (number / 10) % 10;
            int digit3 =number % 10;
            int product = digit1 * digit2 * digit3;
            if (product > number  / 2)
            {
                Console.WriteLine(number);
            }
        }
    }
    }