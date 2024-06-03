using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number from 0 to 9: ");
            string input = Console.ReadLine();
            try
            {
                int number = Convert.ToInt32(input);
                if(number < int.MinValue || number > int.MaxValue)
                {
                    throw new OverflowException("Number has gone out of bounds");
                }
                Console.WriteLine("The converted number" + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("It's not a number");
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
