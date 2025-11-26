using System;

class Program
{
    static int Add(int a, int b) => a + b;

    static int Main(string[] args)
    {
        if (Add(2, 3) != 5)
        {
            Console.Error.WriteLine("Test failed: expected 5");
            return 1;
        }

        Console.WriteLine("All tests passed");
        return 0;
    }
}
