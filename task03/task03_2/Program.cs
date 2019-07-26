using System;
using System.Collections.Generic;
namespace task03_2
{
    class Program
    {
        static void Main(string[] args)
        {


           
        }
        static Dictionary<string, int> WordsFrequncy(string text)
        {
            text = text.ToLower();
            char[] splitters = new char[] { '.', ' ' };
            String[] words = text.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> wordsFrequency = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (wordsFrequency.ContainsKey(word))               
                    wordsFrequency[word]++;               
                else
                    wordsFrequency[word] = 1;
            }
            return wordsFrequency;
        }
    }
}
