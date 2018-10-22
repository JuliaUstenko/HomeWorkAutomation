using System;
using System.Linq;

namespace MyProject1
{
    public class PalindromeCheck
    {
        public PalindromeCheck(string str)
        {
            if (str != "" && str.Length>2)
            {
                string strWithoutSpace=str.Replace(" ", "").ToLower();
                string strReverse = new string(strWithoutSpace.ToCharArray().Reverse().ToArray());
                if (strWithoutSpace == strReverse)
                {
                    Console.WriteLine("Your line is palindrome!");
                    string strReverseLeftPart= strReverse.Remove(strReverse.Length/2);
                    Console.WriteLine(strReverseLeftPart);
                }
                else
                {
                    Console.WriteLine("Your line isn't palindrome.");
                }
            }
            else
            {
                Console.WriteLine("You have short line.");
            }
        }
    }
}