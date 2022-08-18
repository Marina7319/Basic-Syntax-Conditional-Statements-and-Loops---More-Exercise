using System;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int sms = int.Parse(Console.ReadLine());
            int letterIndex = 0;
            string result = "";
            for ( int i = 0; i < sms; i++)
            {
                string num = Console.ReadLine();
               
                if (num == "0")
                {
                    result = " ";
                }
                else
                {

                    int numDigits = num.Length;
                    int digitmain = num[0];
                    int nums = int.Parse(num);
                    int mainNum = nums % 10;
                    int mainDigit = (mainNum - 2) * 3;
                    if (mainNum == 8 || mainNum == 9)
                    {
                        mainDigit += 1;
                    }
                    letterIndex = (mainDigit + numDigits - 1);
                    char firstChar = (char)('a' + letterIndex);
                    result = firstChar.ToString();
                }
                Console.Write(result);
            }   
        }
    }
}
