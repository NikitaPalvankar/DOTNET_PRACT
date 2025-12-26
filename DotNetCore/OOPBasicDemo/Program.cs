using OOPBasic;
using System;
namespace OOPBasicDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Int32 x = 10;
            System.Int32 y = 20;
            Console.WriteLine("Using System.Int32 -> x: " + x+" y: "+y);


            Int32 a = 100;
            Int32 b = 200;
            Console.WriteLine("Using Int32 -> a: " + a + " b: " + b);


            int p = 101;
            int q = 500;
            Console.WriteLine("Using int -> p: " + p + " q: " + q);


            //OOPBasic.MyClass. = new MyClass();
            MyClass obj = new MyClass();
            obj.getMessage();

        }
    }

   
}
