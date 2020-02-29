using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;
            int result;
            char input = 'A';

            Console.WriteLine("Chad Ally");
            Console.WriteLine("Enter the first number.");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number.");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What math operation would you like to perform?");
            Console.WriteLine("Math Operations");
            Console.WriteLine("1.) Addition");
            Console.WriteLine("2.) Subtraction");
            Console.WriteLine("3.) Multiplication");
            Console.WriteLine("4.) Division");
            Console.WriteLine("Enter the number of the math operation you would like to perform.");

            input = Convert.ToChar(Console.ReadLine());
            switch (input)
            {
                case '1':
                    result = n1 + n2;
                    Console.WriteLine("The sum of the numbers" + " " + n1 + " " + "and" + " " + n2 + " " + "is: ");
                    Console.WriteLine(result);
                    break;
                case '2':
                    result = n1 - n2;
                    Console.WriteLine("The difference of the numbers" + " " + n1 + " " + "and" + " " + n2 + " " + "is: ");
                    Console.WriteLine(result);
                    break;
                case '3':
                    result = n1 * n2;
                    Console.WriteLine("The product of the numbers" + " " + n1 + " " + "and" + " " + n2 + " " + "is: ");
                    Console.WriteLine(result);
                    break;
                case '4':
                    result = n1 / n2;
                    Console.WriteLine("The quotient of the numbers" + " " + n1 + " " + "and" + " " + n2 + " " + "is: ");
                    Console.WriteLine(result);
                    break;
            }

        }
    }
}
