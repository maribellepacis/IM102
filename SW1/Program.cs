using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW1
{
    class Program
    {
        static string CheckPrime(int num)
        {
            if (num <= 1)
                return "Neither Prime nor Composite";

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return "Composite";
            }
            return "Prime";
        }

        // convert $ to p and y
        static void ConvertCurrency(double dollar, out double peso, out double yen)
        {
            double ratePeso = 57.17;
            double rateYen = 146.67;

            peso = dollar * ratePeso;
            yen = dollar * rateYen;
        }

        static void Main()
        {
            //prime or composite
            Console.Write("Enter numbers separated by space: ");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            Console.WriteLine("\nPrime and Composite Check:\n");
            for (int i = 0; i < parts.Length; i++)
            {
                int num = int.Parse(parts[i]);
                Console.WriteLine($"{i + 1}. {num,-5} {CheckPrime(num)}");
            }

            //currency conversion
            Console.Write("\nEnter currency in $: ");
            double usd = double.Parse(Console.ReadLine());

            ConvertCurrency(usd, out double peso, out double yen);

            Console.WriteLine("\nDollar($)\tPhil Peso(P)\tJpn Yen(Y)");
            Console.WriteLine($"{usd}\t{peso:N2}\t{yen:N2}");

            Console.ReadKey();
        }
    }
 }