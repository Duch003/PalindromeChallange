using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChallange
{
    public static class PalindromeDetector
    {
        public static string ReturnReversedSecondHalf(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "";

            var output = "";

            if (text.Length % 2 == 0)
                output = text.Substring((text.Length / 2));
            else
                output = text.Substring(((text.Length + 1) / 2) - 1);

            output = MergeCharArrayIntoString(output.Reverse().ToArray());

            return output;
        }

        public static string ReturnFirstHalff(string text)
        {
            var output = "";

            if (text.Length % 2 == 0)
                output = text.Substring(0, (text.Length / 2));
            else
                output = text.Substring(0, ((text.Length + 1) / 2));


            return output;
        }

        public static string MergeCharArrayIntoString(char[] array)
        {
            var output = "";

            foreach (var letter in array)
            {
                output += letter;
            }

            return output;
        }

        public static string ClearString(string input)
        {
            foreach (var letter in input)
            {
                if (!char.IsLetterOrDigit(letter))
                    input = input.Replace(letter.ToString(), "");
            }

            return input;
        }

        public static bool IsPalindrome(string input)
        {
            input = ClearString(input);

            if (string.IsNullOrEmpty(input))
                return false;

            if (input.Length == 1)
                return true;            

            var secondHalfOfText = ReturnReversedSecondHalf(input).ToLower();
            var firstHalfOfText = ReturnFirstHalff(input).ToLower();

            return string.Equals(secondHalfOfText, firstHalfOfText);
        }

        public static bool IsPalindrome(int input) => IsPalindrome(input.ToString());
    }
}
