using Hash_Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hash_Tables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] sentenceWords = { "TO", "BE", "OR", "NOT", "TO", "BE" };
            checkingFrequencyOfWords(sentenceWords);    
        }
        public static void checkingFrequencyOfWords(string[] sentenceWords)
        {
            MyMapNode<string, int> MyMapNode = new MyMapNode<string, int>(5);
            //Adding words with their count by checking with "CHECKWORD" Function.
            foreach (string word in sentenceWords)
            {
                int count = MyMapNode.CheckWord(word);
                MyMapNode.Add(word, count);
            }
            IEnumerable<string> uniqueWords = sentenceWords.Distinct<string>();
            foreach(string word in uniqueWords)
            {
                int frequencyOfWord = MyMapNode.Get(word);
                Console.WriteLine($"\"{word}\"comes {frequencyOfWord} times");
            }

        }
    }
}


