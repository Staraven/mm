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
      public class Program                                                    //hamzahamzahamza           
    {
        public static void Main(string[] args)
       {

          string a = "mert5mertmert";

          char [] array = new char [a.Length];


          for (int i = 0; i < a.Length; i++)
          {
            array[i] = char.ToLower(a[i]);
          }

            for (int i = 0; i < a.Length; i++)
            {
              int k=0;
              for (int j = 0; j < a.Length; j++)
              {
                if (array[j]==array[j+1])
                {
                  k++;
                  break;
                }

              
                
                
                  
                
              }
              if (k==1)
              {
                Console.Write(array[i]);
              }


            }



        }

   
       


    }
}


