using System;
using System.Collections.Generic;
using System.Text;

namespace StudioCountingCharacters
{
    class CountChars
    {
        public static Dictionary<char, int> GetCount(string myString)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            char[] charArray = myString.ToLower().ToCharArray();
            foreach (char character in charArray)
            {
                if (charCount.ContainsKey(character))
                {
                    charCount[character]++;
                }
                else
                {
                    if (Char.IsLetter(character))
                    {
                        charCount.Add(character, 1);
                    }
                }
            }

            return charCount;
        }
    }
}
