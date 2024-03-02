using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
using System.Text.RegularExpressions;
namespace Lesson006                                                           //https://www.codewars.com/kata/52bc74d4ac05d0945d00054e/train/csharp
{                                                                           //muhammetmuhammetmuhammet    x= 24 y =x*2+
                                                                              //mertmertmert              x=12  y=x*2+
                                                                              //hamzahamzahamza           x=15  y=x*2+    k>a.length+ 
      public class Program_5kyu                                                     //hamzahamzahamza           
    {
        public static void Main_5kyu(string[] args)
       {

          string a = "mert5mertmert";

          char [] array = new char [a.Length];


          for (int i = 0; i < a.Length; i++)
          {
            array[i] = char.ToLower(a[i]);
          }
        


        int k = 0;
         for (int i = 0; i < a.Length; i++)
         {
          int c =0;
          for (int j = 0; j < a.Length; j++)
          {
            if (array[i]== array[j])
            {
              c++;
              k++;
            }
          }
          if (c<=1)
          {
            Console.Write(a[i]);
            break;
          }
         }

        
         
           if (k>=a.Length*2)
           {
            Console.Write("0_o");
           }
        }

   
       


    }
}


