using System;
namespace Project
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B: ");
            int b = Convert.ToInt32(Console.ReadLine());


            int x = a, y = b;

            Console.WriteLine("Bmm is: " + Bmm(a, b) + " Kmm is: " + Kmm(x, y, a));
        }
        private static int Bmm(int a, int b)
        {
            int temp;
            while (b != 0)
            {
                temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }
        private static int Kmm(int x, int y, int a)
        {
            return (x * y) / a;
        }
    }
}