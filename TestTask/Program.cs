namespace TestTask
{
    internal class Program
    {
        /// <summary>
        /// This method determines if there is a multiplicity of one number to another.
        /// </summary>
        /// <param name="dividend">Dividend</param>
        /// <param name="divisor">Divisor</param>
        /// <returns>True, if there is a multiplicity</returns>
        static bool CheckMultiplicity(int dividend, int divisor)
        {
            if (dividend % divisor == 0)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// The method outputs numbers from 1 to 100. If the number is a multiple of 3, then outputs
        /// Fizz. If a multiple of 5, then Buzz. If a multiple of both 3 and 5, then FizzBuzz.
        /// </summary>
        static void PrintNumbers()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (CheckMultiplicity(i, 15))       // If the number is a multiple of both 3 and 5 (15)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (CheckMultiplicity(i, 5))   // If the number is a multiple of 5
                {
                    Console.WriteLine("Buzz");
                }
                else if (CheckMultiplicity(i, 3))   // If the number is a multiple of 3
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Main(string[] args)
        {
            PrintNumbers();
        }
    }
}