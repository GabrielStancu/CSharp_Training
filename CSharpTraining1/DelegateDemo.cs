using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining1
{
    class DelegateDemo
    {
        private delegate void DisplayDictionaryDelegate(Dictionary<int, string> words);
        public void Run()
        {
            Dictionary<int, string> Words = new Dictionary<int, string>()
            {
                [1] = "The",
                [2] = "dictionary",
                [3] = "is",
                [4] = "initialized"
            };

            DisplayDictionaryDelegate display = new DisplayDictionaryDelegate(DisplayDictionary);
            display(Words);
        }

        private void DisplayDictionary(Dictionary<int, string> words)
        {
            foreach (KeyValuePair<int, string> entry in words)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }
    }
}
