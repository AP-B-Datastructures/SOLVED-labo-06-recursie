using System;

namespace Recursie.library
{
    public class ReverseString
    {
        // INPUT: hallo
        // OUTPUT: ollah
        public static string ReverseText(string text)
        {
            if (text.Length == 1)
            {
                return text;
            }

            char lastLetter = text[text.Length - 1];
            string textWithoutLastLetter = text.Substring(0, text.Length - 1);

            return lastLetter + ReverseText(textWithoutLastLetter);
        }
    }
}
