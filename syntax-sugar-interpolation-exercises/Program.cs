using System;

namespace syntax_sugar_interpolation_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //write this in different ways...
            int answer = 4;
            string response;
            Console.WriteLine("original code");

            if (answer < 9)
            {
                response = answer + " is less than nine";
                Console.WriteLine(response);
            }
            else
            {
                response = answer + " greater than or equal to nine";
                Console.WriteLine(response);
            }









        }
    }
}
