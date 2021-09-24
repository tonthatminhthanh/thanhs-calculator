using System;

namespace Calculator
{
    class Program
    {
        
        static int Cal(int a, int b, char o)
        {
            switch(o)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    return a / b;
            } 
            return -1;
        }
        static void Main(string[] args)
        {
            int a, b, r;
            char o;
            Console.WriteLine("Welcome to Thanh's calculator!\nInput a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input operator (+,-,*,/): ");
            do
            {
                o = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            while(o != '+' && o != '-' && o != '*' && o != '/');
            Console.WriteLine("Input b: ");
            do
            {
                b = Convert.ToInt32(Console.ReadLine());
            }
            while(b == 0 && o == '/');

            r = Cal(a,b,o);

            Console.WriteLine("Result: " + r);
        }
    }
}
