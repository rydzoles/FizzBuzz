using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            Console.WriteLine("Gra FizzBUZZ Podaj jakąś liczbę");
            while (true)
            {
                Console.WriteLine("podaj Liczbę");
                var number = InputNumber();
                var wynik = fizzBuzz.CheckNumber(number);
                Console.WriteLine(wynik);
            }
        }
        private static int InputNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Podaj Liczbę.");
                    continue;
                }
                return number;
            }
        }
    }
}
