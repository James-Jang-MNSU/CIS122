// Written by James Jang
// 02/18/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class Solution
    {
        // class methods

        // 1. countWords: counts the number of words in a given sentence
        public int countWords(string aSentence)
        {
            int wordCount = 0;
            bool inAWord = false;
            for (int i = 0; i < aSentence.Length; i++)
            {
                if (inAWord)
                {
                    if (aSentence[i] == ' ')
                    {
                        inAWord = false;
                        wordCount++;
                    }
                    else if (i == aSentence.Length-1)
                    {
                        wordCount++;
                    }
                }
                else 
                { 
                    if (aSentence[i] != ' ')
                    {
                        inAWord = true;
                    }
                }
            }
            return wordCount;
        }

        // 2. flipEndChars: takes a string and returns a new string with its first and last characters swapped
        public string flipEndChars(string aString)
        {
            if (aString.Length < 2)
            {
                return "Incompatible.";
            }
            else if (aString[0] == aString[^1])
            {
                return "Two's a pair.";
            }
            else
            {
                string newString = aString[^1] + aString.Substring(1, aString.Length-2) + aString[0];
                return newString;
            }
        }

        // 3. isInOrder: takes a string and returns true or false, depending on whether the characters are in order or not
        public bool isInOrder(string aString)
        {
            for (int i = 0; i < aString.Length-1; i++)
            {
                if (aString[i] > aString[i + 1]) // works because this implicitly converts chars to ints
                {
                    return false;
                }
            }
            return true;
        }

        // 4. firstNVowels: returns the first n vowels of a string.
        public string firstNVowels(string aString, int aNumber)
        {
            string vowelRecord = "";
            for (int i = 0; i < aString.Length; i++)
            {
                if (vowelRecord.Length == aNumber)
                {
                    return vowelRecord;
                }
                if (aString[i] == 'a' || aString[i] == 'e' || aString[i] == 'i' || aString[i] == 'o' || aString[i] == 'u')
                {
                    vowelRecord += aString[i];
                }
            }
            if (vowelRecord.Length < aNumber) 
            {
                return "invalid";
            }
            else
            {
                return vowelRecord;
            }
        }

        // 5. move: changes every letter to the next letter
        public string move(string aString)
        {
            string newString = "";
            foreach (char c in aString) 
            {
                newString += (char)(c + 1); // char c implicitly converts to an int when added to 1,
                                            // then we use casting to convert the int back to a char
            }
            return newString;
        }
    }
}
