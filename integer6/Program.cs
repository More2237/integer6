using System;

namespace integer6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double taqsim = a / b;
            double vzyatya = a % b;
            Console.WriteLine(taqsim);
            Console.WriteLine(vzyatya);
            
            
        }
    }
}