using System;

namespace PrimeNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
            int number;
            for ( number = 500; number < 600; number++)
            {
                int counter = 0;
                for (int j = 2; j <= number / 2; j++)
                {
                    if (number % j == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && number != 1)
                {
                    Console.Write("{0} ", number);
                }
            }
            Console.ReadKey();
        }
	}
}
