using System;

namespace More_about_methods {
    class Program {
        static void Main(string[] args) {
            double b = 7;
            double a;

            Console.WriteLine("Input any number: "); 
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your number: " + a + " To the power of 7 is: " + Pow( a, b));             

            Console.ReadKey();
        }
        
        static double Pow( double a, double b) { 
            return Math.Pow(a , b);
        }
    }
}