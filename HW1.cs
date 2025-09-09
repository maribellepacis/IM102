using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            do
            {
                Console.Write("Enter string: ");
                input = Console.ReadLine();

                if (input == "*")
                    break;

                string original = input;
                string lower = input.ToLower();

                string reversed = "";
                for (int i = lower.Length - 1; i >= 0; i--)
                {
                    reversed += lower[i];
                }

                string result = (lower == reversed) ? "Yes" : "No";

                Console.WriteLine("\nOriginal String         Reversed String            Palindrome?");
                Console.WriteLine($"  {original,-20}{reversed,-25}{result}\n");

            } while (true);

            Console.WriteLine("\n//End execution");
        }
    }
}
