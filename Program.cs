using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("Napište fibonacciho čislo (nebo  'exit' pro ukončeni):");
            string input = Console.ReadLine();


            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Programm skončil. Zmačkněte libovolnou klavesnici  pro ukončeni.");
                Console.ReadKey();
                break;
            }


            if (int.TryParse(input, out int fib) && fib >= 0)
            {
                long result = Fib(fib);
                Console.WriteLine($" Fibonacciho čislo  №{fib}: {result}");
            }
            else
            {
                Console.WriteLine("Cyba napište kladne čislo");
            }

            Console.WriteLine("\nZmačkněte libovolnou klavesnici");
            Console.ReadKey();
        }
    }

    static long Fib(int n)
    {
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;

        long prev = 0;
        long next = 1;
        for (int i = 2; i <= n; i++)
        {
            long sum = prev + next;
            prev = next;
            next = sum;
        }
        return next;
    }
}
