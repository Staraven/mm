using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
using System.Text.RegularExpressions;
//https://www.codewars.com/kata/55bf01e5a717a0d57e0000ec
namespace Lesson006
{
    public class Program_Failed
    {
        public static void Main_Failed(string[] args)
       {

          int number = 39;

        int a = 0;

        a=number*10;

        

        int c=a/100;


       int  b=c*100;

        int d = a-b;

        int e=d/10;

        int f=c*e;

        int g =f*10;

        int h =g/100;

        int j=g-h*100;

        int k=j/10;

        int l=h*k;

        int m=l*10;

        int n=m/100;

        int o = m-n*100;

        int p = o/10;

        int s = p*n;

        Console.Write(s);
    }
}


}