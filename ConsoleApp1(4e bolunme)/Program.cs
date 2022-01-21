using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 16;

            int x = a % 4;

            if (x==0)
            {
                Console.WriteLine("eded 4-e bolunur");
            }

            else if (x!=0)
            {
                Console.WriteLine("eded 4-else bolunmur");
            }

           
            
        }
    }
}
