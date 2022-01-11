using System;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            EquationResolver resolver = new EquationResolver();
            Console.WriteLine("Enter a");
            resolver.a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b");
            resolver.b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter c"); ;
            resolver.c = int.Parse(Console.ReadLine()); ;
            resolver.DelataOperation();
            resolver.Resolve();
            Console.ReadKey();
        }
    }
    class EquationResolver
    {
        public int a;
        public int b;
        public int c;
        public int delta;
        public void DelataOperation()
        {
            delta = (b * b) - (4 * a * c);
        }

        public void Resolve()
        {

            if (delta > 0)
            {
                double answer1 = ((-1 * b) + Math.Sqrt(delta)) / (2 * a);
                double answer2 = ((-1 * b) - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("The Root 1 is " + answer1);
                Console.WriteLine("The Root 2 is " + answer2);
            }
            else if (delta == 0)
            {
                double answer = ((-1 * b)) / (2 * a);
                Console.WriteLine("The Root  is " + answer);
            }
            else
            {
                Console.WriteLine("Has No Root");
            }


        }


    }
}
