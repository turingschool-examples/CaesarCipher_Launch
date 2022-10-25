using System;

namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a message to Encrypt: ");
            var message = Console.ReadLine();

            Console.Write("Enter a shift value (1 - 26): ");
            int shift = Convert.ToInt32(Console.ReadLine());

            var result = Encrypt(message, shift);
            Console.WriteLine(result);
        }

        static string Encrypt(string message, int shift)
        {
            char[] alphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            
            char[] cipherAlphabet = new char[26];
            Array.Copy(alphabet, shift, cipherAlphabet, 0, 26 - shift);
            Array.Copy(alphabet, 0, cipherAlphabet, 26 - shift, shift);

            char[] splitMessage = message.ToCharArray();

            string encrypted = "";

            foreach (var letter in splitMessage)
            {
                if (alphabet.Contains(letter))
                {
                    int indexOfLetter = Array.IndexOf(alphabet, letter);
                    char encryptedLetter = cipherAlphabet[indexOfLetter];
                    encrypted += encryptedLetter;
                }
                else
                {
                    encrypted += letter;
                }
            }

            return encrypted;
        }
    }
}
