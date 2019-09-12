using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Calculator
    {
        



        public static int Sum(int a, int b)
        {
 
            return a+b;
        }
        public static int diff(int a, int b)
        {
            
            return a - b;
        }
        public static int comp(int a, int b)
        {
            return a*b;
        }

        public static int del(int a, int b)
        {
            return a/b;
        }
        
    }


    
        
        
    class Program
    {
        

        
        static void Main(string[] args)
        {


            Console.WriteLine(Calculator.Sum(2, 2));
            Console.WriteLine(Calculator.diff(2, 2));
            Console.WriteLine(Calculator.comp(2, 2));
            Console.WriteLine(Calculator.del(2, 2));
            Console.ReadKey();

        }
    }
}

