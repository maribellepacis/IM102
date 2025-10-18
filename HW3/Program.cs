using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {
        static void GetCharFrequency(string input)
        {
            Dictionary<char, int> frequency = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (c == ' ' || c == ',' || c == '.')
                    continue;

                if (frequency.ContainsKey(c))
                    frequency[c]++;
                else
                    frequency[c] = 1;
            }

            foreach (KeyValuePair<char, int> item in frequency)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
        }

        static void Main()
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            GetCharFrequency(input);
            Console.ReadKey();
        }

    }
}
