/* Write a program that encodes and decodes a string 
 * using given encryption key (cipher). The key consists 
 * of a sequence of characters. The encoding/decoding 
 * is done by performing XOR (exclusive or) operation 
 * over the first letter of the string with the first 
 * of the key, the second – with the second, etc. When the 
 * last key character is reached, the next is the first.
 */

using System;
using System.Text;

class Cipher
{
    static string EncodeAndDecode(string text, string cipher)
    {
        StringBuilder sb = new StringBuilder(text.Length);

        for (int index = 0; index < text.Length; index++)
        {
            sb.Append((char)(text[index] ^ cipher[index % cipher.Length]));
        }
        return sb.ToString();
    }
    static void Main()
    {
        string text = "Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.";
        string cipher = "str";
        string encrypted = EncodeAndDecode(text, cipher);
        Console.WriteLine(encrypted);
        Console.WriteLine(EncodeAndDecode(encrypted, cipher));
    }
}
