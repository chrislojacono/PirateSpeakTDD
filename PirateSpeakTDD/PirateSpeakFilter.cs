using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PirateSpeakTDD
{
    public class PirateSpeakFilter
    {

        public List<string> Translator(string jumbleWord, List<string> possibleWords)
        {
            var matchedList = new List<string>();

            foreach (var word in possibleWords) { 
           
                var sortedJumble = string.Concat(jumbleWord.OrderBy(c => c));
                var sortedTest = string.Concat(word.OrderBy(c => c));

                if (sortedJumble == sortedTest)
                {
                    matchedList.Add(word);
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }

            return matchedList;
        }
    }
}
