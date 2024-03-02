using System;
using System.Buffers;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
using System.Text.RegularExpressions;
namespace Lesson006                                                           
{                                                                           
                                                                              
                                                                            /*https://www.codewars.com/kata/54b42f9314d9229fd6000d9c/train/csharp*/
      public class Program_KYU5

    {
        public static void Main_KYU5(string[] args)
       {
          string a = "Success";

          char [] array = new char [a.Length];


          for (int i = 0; i < a.Length; i++)
          {
            array[i] = char.ToLower(a[i]);
          }
           
          /* string b = "()";

          char [] array2 = new char [b.Length];

          for (int i = 0; i < b.Length; i++)
          {
            array2[i] = b[i];
          } */
           
           

           

          for (int i = 0; i < a.Length; i++)                       
          {
            int k = 0;
            for (int j =0 ; j < a.Length; j++)
            {
              if (array[i] == array[j])
              {
                k++;
               if (k>1)
               {
                Console.Write(")");
                break;
               }
                
              }

            }
            if (k==1)
            {
              Console.Write("(");
              
            }
          }
               
              



        }

   
       


    }
}


