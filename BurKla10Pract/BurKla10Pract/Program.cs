using System;
using System.Collections.Generic;

namespace RomToArab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("I — 1\nV — 5\nX — 10\nL — 50\nC — 100\nD — 500\nM — 1000\nВведите римское число: ");
            string roman = Console.ReadLine();
            try
            {
                Console.WriteLine("Результат: " + RomanToArab(roman));
            }
            catch
            {
                Console.Write("Неизвестное число\nПопробуйте еще раз: ");
                roman = Console.ReadLine();
                Console.WriteLine("Результат: " + RomanToArab(roman));
            }
        }

        private static int RomanToArab(string roman)
        {
            int result = 0;
            var RomToArab = new Dictionary<char, int>
            {{ 'I', 1 },{ 'V', 5 },{ 'X', 10 },{ 'L', 50 },{ 'C', 100 },{ 'D', 500 },{ 'M', 1000 } };
            for (int i = 0; i < roman.Length - 1; ++i)
            {
                if (RomToArab[roman[i]] < RomToArab[roman[i + 1]]) result -= RomToArab[roman[i]];
                else if (RomToArab[roman[i]] >= RomToArab[roman[i + 1]]) result += RomToArab[roman[i]];
            }
            return result += RomToArab[roman[^1]];
        }
    }
}