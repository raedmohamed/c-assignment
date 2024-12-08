using System;

class Program
{
    static void Main()
    {
        double num1, num2, result;
        string operation;
        string userInput;

        // Displaying a welcome message
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("------------------");

        // Start the loop for continuous calculation
        for (; ; )
        {
            // Ask if the user wants to exit
            Console.WriteLine("\nType 'exit' to stop or press Enter to continue.");
            userInput = Console.ReadLine().ToLower();

            // If user types "exit", break out of the loop
            if (userInput == "exit")
            {
                Console.WriteLine("Exiting the calculator. Goodbye!");
                break;
            }

            // Ask the user for the first number
            Console.Write("Enter the first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            // Ask for the operation
            Console.Write("Enter an operation (+, -, *, /): ");
            operation = Console.ReadLine();

            // Ask the user for the second number
            Console.Write("Enter the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Perform the operation using a switch statement
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Result: {num1} - {num2} = {result}");
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Result: {num1} * {num2} = {result}");
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                    break;
            }
        }
    }
}
