using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project: Multiplication Table");
            Console.WriteLine("Hello! Today you're going to give me a number and I will generate the multiplication table for it!");
            Console.WriteLine();

            Console.WriteLine("Please enter the number you want to see the table for: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < 13; i++) 
            {
                Console.Write("{0} X {1} = {2} \n", num, i, num * i);
            }
        }
    }
}
