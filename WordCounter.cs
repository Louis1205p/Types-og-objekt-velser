using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    public class WordCounter
    {
        // method to count the amount of times our word appears
        public int CountOccurrences(string text, string word)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(word))
            {
                return 0;
            }
            // splits the text into an array of words and uses (' ') to seperate it
            string[] words = text.Split(' ');
            int count = 0;

            foreach (string currentWord in words)
            {
                // checks if words matches word and adds it to the counter
                if (currentWord.ToLower().Contains(word.ToLower()))
                {
                    count++;
                }
            }
            return count;
        }
    }
}