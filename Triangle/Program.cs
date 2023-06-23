// See https://aka.ms/new-console-template for more information
using PyramidApp;
using System;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace PyramidApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of the pyramid:");
            int height = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= height; i++)
            {
               
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}






