namespace Assignment1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Write a C# Sharp program to accept two integers and check whether they are equal or not.
            Console.WriteLine("Choose the First number to compare");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose the Second number to compare");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("The two integers are the same.");
            }
            else
            {
                Console.WriteLine("The two integers are NOT the same");
            }


            // 2. Write a C# Sharp program to find the sum of first 10 natural numbers (1-10). The sum should be 55.

            // Loop through numbers 1 - 10 and add each one to the existing sum
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }

            Console.WriteLine("\nThe sum of the first 10 natural numbers is: " + sum);


            // 3. Write a menu driven application to perform calculation functions like addition, subtraction, multiplication, and division.
            //    Call them appropriately when user selects the option. Give the user the option to continue or exit the program.

            // While loop initially set to false used to repeat depending on user input
            bool input = false;
            while (input == false)
            {
                // Choose which operation  and number to use
                Console.WriteLine("\nChoose an operation by entering a number that represents the operation shown below");
                Console.WriteLine("| (1) Addition  \n| (2) Subtraction  \n| (3) Multiplication  \n| (4) Division");
                int func = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nChoose the first number for your function");
                double fNum = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nChoose the second number for your function");
                double sNum = Convert.ToDouble(Console.ReadLine());

                // Switch function for the four operation choices plus default
                Console.WriteLine();
                switch (func)
                {
                    // Addition
                    case 1:
                        Console.WriteLine("The result of your two numbers added is: " + (fNum + sNum));
                        break;
                    // Subtraction
                    case 2:
                        Console.WriteLine("The result of your two numbers subtracted is: " + (fNum - sNum));
                        break;
                    // Multiplication
                    case 3:
                        Console.WriteLine("The result of your two numbers multiplied is: " + (fNum * sNum));
                        break;
                    // Division
                    case 4:
                        if (sNum != 0)
                        {
                            Console.WriteLine("The result of your two numbers divided is: " + (fNum / sNum));
                        }
                        else
                        {
                            Console.WriteLine("ERROR: Cannot divide by zero as it is undefined.");
                        }
                        break;
                    // Default case
                    default:
                        Console.WriteLine("ALERT: An operation was either not chosen or input does not exist in choices offered.");
                        break;
                }

                // This uses the user input for exiting or continuing the while loop
                Console.WriteLine("\nWould you like to try a new operation?");
                Console.WriteLine("Enter (1) for Yes to continue or Enter (2) for No to exit the program.");
                int ans = Convert.ToInt32(Console.ReadLine());

                // Exits the while loop
                if (ans == 2)
                {
                    input = true;
                }

            }
        }
    }
}
