using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.EnglishDictionary
{
    class EnglishDictionaryOperation
    {
        public static void Answer() {

            String[] words = new string[] { "Boat","House","Cat","River","Cupboard"}; 

            Console.WriteLine("\n\nProblem 2: English Dictionary Operations\n");
            Console.WriteLine("Plurals of all words:");
            foreach (var word in words)
            {
                if (word.EndsWith("s") || word.EndsWith("x") || word.EndsWith("z") || word.EndsWith("ch") || word.EndsWith("sh"))
                    Console.WriteLine(word + "es");
                else
                    Console.WriteLine(word + "s");        
            }

            words[1] = "Home";
            Console.WriteLine("\nSynonym of 2nd word: " + words[1]);


            Array.Resize(ref words, words.Length + 1);
            words[words.Length - 1] = "Tuesday";

            Console.WriteLine("\nAfter adding new word \"Tuesday\", length of a list: "+words.Length);

            Console.WriteLine("\nWords with length 7:");

            var wordslength7 = words.Where(x => x.Length == 7).ToArray<string>();

            if (wordslength7.Length != 0)
            {
                foreach (var word in wordslength7)
                {
                    Console.WriteLine(word);
                }
            }
            else {

                Console.WriteLine("No words are found with length of 7");
            }

            Console.WriteLine("\nWords in ascending order:");


            foreach (var word in (from s in words orderby s select s)) {
                Console.WriteLine(word);
            }

            Console.WriteLine("\nReverse of original array:");
            
            
            foreach (var word in words.Reverse().ToArray())
            {
                Console.WriteLine(word);
            }

        }
    }
}
