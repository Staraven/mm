using System;

namespace Lesson006
{
    public class Program_CW1
    {
        public static void Main_CW1(string[] args)
        {
          /* https://www.codewars.com/kata/50654ddff44f800200000004 en büyük bölenlerine ayırma */
          
            Console.Write("Your number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= number; i++)
            {
              if (number%i == 0)
              {
                Console.Write(i+" , "+number/i);
                break;    
              }       
            }
        }
    }
}