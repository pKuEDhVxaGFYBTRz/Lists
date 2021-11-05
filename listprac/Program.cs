using System;
using System.Collections.Generic;

namespace listprac
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> WordList = new List<string>();

            int qtyNaughty = 0;

            // add 5 words
            for (int i = 0; i < 5; i++)
            {
                WordList.Add(
                    item: Input.InputStr("input a word", "invalid input")
                    );
            }

            // remove naughty from list
            for (int i = WordList.Count; i > 0; i--)
            {
                if (WordList[i-1] == "naughty")
                {
                    WordList.RemoveAt(i);
                    qtyNaughty++;
                }
            }

            // add 2 more words
            for (int i = 0; i < 2; i++)
            {
                WordList.Add(
                    item: Input.InputStr("input a word", "invalid input")
                    );
            }

            // remove naughty from list
            for (int i = WordList.Count; i > 0; i--)
            {
                if (WordList[i-1] == "naughty")
                {
                    WordList.RemoveAt(i);
                    qtyNaughty++;
                }
            }

            // count instances of nice
            int qtyNice = 0;
            for (int i = WordList.Count; i > 0; i--)
            {
                if (WordList[i-1] == "nice")
                {
                    qtyNice++;
                }
            }

            // display qty of removed naughty
            System.Console.WriteLine(
                String.Format("removed {0} instances of naughty", qtyNaughty)
                );

            // display qty of nice
            System.Console.WriteLine(
                String.Format("there are {0} instances of nice", qtyNice)
                );
        }
    }
}
