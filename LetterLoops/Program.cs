using System;
using System.Collections.Generic;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            var letters = Console.ReadLine();
            char upperLetter;
            var counter = 1;
            var increment = 0;
            var index = 0;
            var letterList = new List<string>();

            for (var i = 0; i < letters.Length; i++)
            {
                upperLetter = Char.ToUpper(letters[i]);
                letterList.Add(upperLetter.ToString());
                counter++;
            }

            for (var j = 0; j < letters.Length; j++)
            {
                while (index < increment) // increment index but then reset to 0;
                {
                    letterList[j] += letterList[j][0].ToString().ToLower();
                    index++;
                }
                index = 0;
                increment++;
                letterList[j] += "-";
            }
            string result = string.Join("", letterList);
            Console.WriteLine(result.TrimEnd('-'));
        }
    }
}
