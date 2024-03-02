using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
using System.Text.RegularExpressions;

//https://www.codewars.com/kata/5526fc09a1bbd946250002dc/train/csharp
namespace Lesson006
{
    public class Program_CW3
    {
        public static void Main_CW3(string[] args)
       {
        int [] array = {2, 4, 0, 100, 4, 11, 2602, 36};
        

      int [] odd = new int [array.Length];
        
      int [] even = new int [array.Length];

  int a =0;
  int b=0;

      for (int i = 0; i < array.Length; i++)
      {
        if (array[i]%2==0)
        {
          even[a] = array[i];
          a++;
        }
        else
        {
          odd[b] = array[i];
          b++;
        }
      }
       
       if (b>a)
       {
        for (int i = 0; i < a; i++)
        {
          Console.Write(even[i]+" ");
        }

       }
       else
       {
        for (int i = 0; i < b; i++)
        {
          Console.Write(odd[i]);
        }
       }

    }
}


}