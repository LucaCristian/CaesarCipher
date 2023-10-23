using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ENCRYPT (E) OR DECRYPT (D): ");
            string option = Console.ReadLine();

            Console.Write("\nSHIFT KEY: ");
            int shift = int.Parse(Console.ReadLine());

            Console.WriteLine("\nENTER THE TEXT");
            string plainText = Console.ReadLine();

            string cipherText = "";

            if (option == "E" || option == "e")
            {
                cipherText = Encrypt(plainText, shift);
                Console.WriteLine($"\nENCRYPTED TEXT BY +{shift}\n{cipherText}");
            }
            else if (option == "D" || option == "d")
            {
                cipherText = Decrypt(plainText, shift);
                Console.WriteLine($"\nDECRYPTED TEXT BY -{shift}\n{cipherText}");
            }
            
            Console.ReadKey();
        }
        static string Encrypt(string plainText, int shift)
        {
            string cipherText = "";
            foreach (char c in plainText)
            {
                char lowerC = char.ToLower(c);
                char shifted = (char)(((lowerC + shift - 'a') % 26) + 'a');
                cipherText += shifted;
            }
            return cipherText;
        }
        static string Decrypt(string plainText, int shift)
        {
            string cipherText = "";
            foreach (char c in plainText)
            {
                char shifted = (char)(((c - shift - 'a') % 26) + 'a');
                cipherText += shifted;
            }
            return cipherText;
        }
    }
}
