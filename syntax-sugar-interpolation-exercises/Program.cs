using System;

namespace syntax_sugar_interpolation_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //write this in different ways...
            Console.WriteLine("Original Code");
            int answer = 9;
            string response;

            if (answer < 9)
            {
                response = answer + " is less than nine";
                Console.WriteLine(response);
            }
            else
            {
                response = answer + " greater than or equal to 9";
                Console.WriteLine(response);
            }
            Console.WriteLine();
            Console.WriteLine();

            //Ternary or Inline
            Console.WriteLine("Ternary or Inline version");
            var i = 9;
            var compareToNine = (i > 0 && i != 9) ? $"  {i} is less than 9" : $"  {i} is greater than or equal to 9...";
            Console.WriteLine(compareToNine);






        }
    }
}
