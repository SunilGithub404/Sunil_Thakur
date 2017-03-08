using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Sentence:- ");
            string sentence = Console.ReadLine();
            int[] a = new int[10];
            int i = 0;
            foreach (List<int> count in ParseSentence(sentence))
            {
                //Console.WriteLine(String.Format("Sentence {0} = {1} words.", count[0], count[1]));
                a[i] = count[1];
                i++;
            }

            Array.Sort(a);
            Array.Reverse(a);
            Console.WriteLine("\nThe Maximum no. of words in a Longest Sentence:- {0}", --a[0]);

            Console.ReadKey();
        }
        private static IEnumerable<List<int>> ParseSentence(string input)
        {
            int wordCount = 0;
            int sentenceCount = 0;
            List<int> ret = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ') //End of word
                {
                    ++wordCount;
                    continue;
                }

                if (input[i] == '.' || input[i] == '?' || input[i] == '!') //End of sentence
                {
                    ++wordCount; //Period should be at the end of a word...
                    ++sentenceCount;
                    ret.Add(sentenceCount);
                    ret.Add(wordCount);
                    yield return ret;

                    ret = new List<int>();
                    wordCount = 0;
                }
            }
        }

    }
}
