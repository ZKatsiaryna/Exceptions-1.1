using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.WriteLine("Enter number of lines of the text: ");

                int number;
                bool result = Int32.TryParse(Console.ReadLine(), out number);

                List<string> listText = new List<string>();

                if (result)
                {
                    Console.WriteLine("Enter the text: ");
                    string line;
                    do
                    {
                        line = Console.ReadLine();
                        listText.Add(line);
                    } while (listText.Count != number);
                }
                else
                {
                    Console.WriteLine("Invalid number.");
                }

                try
                {
                    StringScaner scan = new StringScaner();
                    var arraySymbols = scan.GetFirstSymbol(listText);

                    foreach (var s in arraySymbols)
                    {
                        Console.WriteLine("result: {0}", s);
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("The string cannot be empty. Please try again. ", ex.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("An unknown error occurred. Please try again.");
                }
                Console.WriteLine("Pressed Enter to continue or Escape to end the program");
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}
