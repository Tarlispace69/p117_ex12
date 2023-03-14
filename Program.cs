using System;

namespace p117_ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int input1 = 0, input2 = 0, buffer = 0;
            //recieving 2 inputs
            Console.WriteLine("Enter a number: ");
            input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            input2 = int.Parse(Console.ReadLine());

            if (input1 > input2)
            {
                buffer = input1;
                input1 = input2;
                input2 = buffer;
            }

            //printing from smaller to bigger input
            for (; input1 <= input2; input1++)
            {
                Console.WriteLine(input1 + " ");
            }

        }
    }
}
