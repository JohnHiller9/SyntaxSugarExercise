using System;

namespace SyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int answer = 4;
            string response;

            if (answer < 9)
            {
                response = answer + "is less than nine";
            }
            else
            {
                response = answer + "greater than or equal to nine";
            }
            Console.WriteLine(response);
            */

            // Inferred Typing -----
            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";
            Console.WriteLine(response);

            /* OR:
             * var answer = 4;
             * Console.WriteLine((answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine");
             */


        }
        static void String(string[] args)
        {
            // String Interpolation -----

            string answer = "4";
            string response = answer;
            if (int.Parse(answer) < 9) {Console.WriteLine($"{answer} is less than nine"); }
            if (int.Parse(answer) > 9) {Console.WriteLine($"{answer} is greater than or equal to nine"); }
            Console.WriteLine(response);


        }
    }
}
