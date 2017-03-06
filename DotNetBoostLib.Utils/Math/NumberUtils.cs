namespace DotNetBoostLib.Utils.Math
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class NumberUtils
    {
        private static Dictionary<char, string> hexLetterToBinaryLetters;

        public static string HexToBinary(string hexValue)
        {
            if(hexValue == null)
            {
                throw new ArgumentNullException("hexValue can't be null");
            }

            if(hexValue.Length == 0)
            {
                return "";
            }

            InitHexLetterToBinaryDictionary();
            StringBuilder binaryResult = new StringBuilder();
            var hexValueLowerCase = hexValue.ToLower();

            foreach(var letter in hexValueLowerCase)
            {
                binaryResult.Append(hexLetterToBinaryLetters[letter]);
            }

            return binaryResult.ToString();
        }

        private static void InitHexLetterToBinaryDictionary()
        {
            if (hexLetterToBinaryLetters != null)
            {
                return;
            }

            hexLetterToBinaryLetters = new Dictionary<char, string>();
            hexLetterToBinaryLetters.Add('0', "0000");
            hexLetterToBinaryLetters.Add('1', "0001");
            hexLetterToBinaryLetters.Add('2', "0010");
            hexLetterToBinaryLetters.Add('3', "0011");
            hexLetterToBinaryLetters.Add('4', "0100");
            hexLetterToBinaryLetters.Add('5', "0101");
            hexLetterToBinaryLetters.Add('6', "0110");
            hexLetterToBinaryLetters.Add('7', "0111");
            hexLetterToBinaryLetters.Add('8', "1000");
            hexLetterToBinaryLetters.Add('9', "1001");
            hexLetterToBinaryLetters.Add('a', "1010");
            hexLetterToBinaryLetters.Add('b', "1011");
            hexLetterToBinaryLetters.Add('c', "1100");
            hexLetterToBinaryLetters.Add('d', "1101");
            hexLetterToBinaryLetters.Add('e', "1110");
            hexLetterToBinaryLetters.Add('f', "1111");
        }
    }
}
