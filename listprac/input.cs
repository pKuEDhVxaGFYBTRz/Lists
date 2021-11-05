using System;
using System.Collections.Generic;
using System.Text;

// version 1.1

namespace listprac
{
    class Input
    {
        // input int values
        public static int InputInt(string prompt, string err, int upperBound = Int32.MaxValue, int lowerbound = Int32.MinValue)
        {
            int input;

            while (true)
            {
                Console.WriteLine(prompt);

                try
                {
                    input =  int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine(err);
                    continue;
                }

                if ((input < lowerbound) || (input > upperBound)) {
                    Console.WriteLine(err);
                    continue;
                }

                return input;
            }
        }

        // input string values
        public static string InputStr(string prompt, string err)
        {
            while (true)
            {
                Console.WriteLine(prompt);

                try
                {
                    return Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine(err);
                }
            }
        }

        // yess no prompt
        public static bool InputYesNo(string prompt, string err, string append = " (y/n)")
        {
            string input;

            while (true)
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine();

                if (input == "y")
                {
                    return true;
                }

                if (input == "n")
                {
                    return false;
                }

                Console.WriteLine(err);
            }

        }
    }
}

