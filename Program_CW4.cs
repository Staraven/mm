using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
using System.Text.RegularExpressions;
//https://www.codewars.com/kata/55bf01e5a717a0d57e0000ec
namespace Lesson006
{
    public class Program_CW4
    {
        public static void Main_CW4(string[] args)
       {
          int number = 1652;
         
         string a = number.ToString();

        int [] array = new int [a.Length];

        for (int i = 0; i < a.Length; i++)
        {
          array[i] = Convert.ToInt32(a[i]);
        }
          
          int c = 0;
        for (int i = 0; i < a.Length; i++)
        {
          int b=1;
          
          for (int j = 0; j < a.Length; j++)
          {
            b=b*(array[i]-48);
            
          }
         c = c +b;
        }
        Console.Write(c);

         
       


    }
}


}