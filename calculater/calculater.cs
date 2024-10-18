namespace calculatar
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double result = 0;

            System.Console.WriteLine("-------------");
            System.Console.WriteLine("Calculator");
            System.Console.WriteLine("-------------");

            // Get first number
            System.Console.Write("Enter number 1: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            // Get second number
            System.Console.Write("Enter number 2: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Show menu
            System.Console.WriteLine("Enter an option");
            System.Console.WriteLine("\t+  : Add");
            System.Console.WriteLine("\t-  : Subtract");
            System.Console.WriteLine("\t*  : Multiply");
            System.Console.WriteLine("\t/  : Divide");
            System.Console.Write("Enter an option:");

            // Read user input for operation
            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    System.Console.WriteLine($"Your result: {num1} + {num2} = {result}");
                    break;

                case "-":
                    result = num1 - num2;
                    System.Console.WriteLine($"Your result: {num1} - {num2} = {result}");
                    break;

                case "*":
                    result = num1 * num2;
                    System.Console.WriteLine($"Your result: {num1} * {num2} = {result}");
                    break;

                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        System.Console.WriteLine($"Your result: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        System.Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;

                default:
                    System.Console.WriteLine("That was not a valid option");
                    break;
            }

            // Keep the console window open
            System.Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
