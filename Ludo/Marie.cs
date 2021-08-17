using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo
{
    class MarieProgram
    {
        /*3-5 Have the previous program convert the ciphertext back to the plaintext to
        verify the encoding and decoding.
        */

        const string Alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string Code = "QWERTYUIOPASDFGHJKLZXCVBNM";

        static string Encrypt(string plainText)
        {
            return SubstituteString(plainText, Alfabet, Code);
        }

        static string Decrypt(string plainText)
        {
            return SubstituteString(plainText, Code, Alfabet);
        }
        static string SubstituteString(string plainText, string fromAlphabet, string toAlfabet)
        {
            var cipherText = "";
            foreach (var character in plainText.ToArray())
            {
                    cipherText += TranslateCharacter(character, fromAlphabet, toAlfabet);
            }
            return cipherText;
        }
        //static char EncryptCharacter(char character)
        //{
        //    return TranslateCharacter(character, Alfabet, Code);
        //}
        //static char DecryptCharacter(char character)
        //{
        //    return TranslateCharacter(character, Code, Alfabet);
        //}

        static char TranslateCharacter(char character, string fromAlphabet, string toAlfabet)
        {
            var index = fromAlphabet.IndexOf(char.ToUpper(character));
            if (index >= 0)
            {
                return toAlfabet[index];
            }
            return character;
        }


        static bool IsSorted(int[] numbers)
        {
            var previousNumber = 0;
            foreach (var number in numbers)
            {
                if (previousNumber <= number)
                {
                    previousNumber = number;
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public static void Mainx()
        {
            //var sortedNumbers = new[] { 1, 4, 7, 8, 9 };
            //var NotSortedNumbers = new[] { 5, 1, 4, 7, 8, 9 };
            //var result = IsSorted(sortedNumbers);
            //var result2 = IsSorted(NotSortedNumbers);
            //Console.WriteLine("First array sorted result: " + result);
            //Console.WriteLine("Second array sorted result: " + result2);

            //var cipherString = Encrypt("deg");
            //var reverted = Decrypt(cipherString);
            //Console.WriteLine("Encrypted: " + cipherString);
            //Console.WriteLine("decrypted: " + reverted);

            int[] numbers = new[] {1, 1, 2, 3, 5, 8, 13};
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{i+1}: {numbers[i]}");
            }

        }
    }
}
