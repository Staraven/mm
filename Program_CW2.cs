using System;


namespace Lesson006
{
    public class Program_Cw2
    {
        public static void Main_CW2(string[] args)
        {
        int number =Convert.ToInt32(Console.ReadLine());

          if(number%2==0)
          {
            Console.Write("Even");
          }
          else
          {
            Console.Write("Odd");
          }
            
        }
    }
}