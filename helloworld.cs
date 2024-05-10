using System;

class Program
{
    // Function to print "Hello, World!" to the console
    static string HelloWorld()
    {
        Console.WriteLine("Hello, World!");
        return "Hello, World!";
    }

    static void Main(string[] args)
    {
        // Test case 1: Call HelloWorld function
        Console.WriteLine(HelloWorld()); // Output: Hello, World!

        // Test case 2: Call HelloWorld function and store the result in a variable
        string message = HelloWorld();
        Console.WriteLine(message); // Output: Hello, World!
        
        // Test case 3: Call HelloWorld function multiple times
        for (int i = 0; i < 3; i++)
        {
            HelloWorld(); // Output: Hello, World! (printed 3 times)
        }
    }
}