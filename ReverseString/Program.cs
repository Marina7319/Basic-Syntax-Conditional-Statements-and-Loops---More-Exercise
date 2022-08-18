using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentWord = Console.ReadLine();
            int numLett = currentWord.Length-1;

            for (int i = numLett; i >= 0; i--)
            {
 
                Console.Write(currentWord[i]);
               
            }
        }
    }
}
