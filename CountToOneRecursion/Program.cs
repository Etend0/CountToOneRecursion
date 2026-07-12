/*
 * Elijah Hodge
 * CST - 250
 * 07/10/2026
 * Count To One Recursion
 * Activity 3
 */

//-------------------------------------------------------
// Start of Main Method
//-------------------------------------------------------

// Declare and initialize
int choice = 0, result = 0, counter = 0;
string input = "";

// Prompt the user for a number
Console.Write("Enter a number (positive or negative): ");
// Get the users input
input = Console.ReadLine();
// See if the user entered a valid input
while (!int.TryParse(input, out choice))
{
    Console.Write("Invalid number. ");
    // Re-Prompt the user for a number
    Console.Write("Enter a number (positive or negative): ");
    // Get the users input
    input = Console.ReadLine();
}
// Call the CountToOne function
result = Utility.CountToOne(choice, ref counter);
Console.WriteLine($"The end number is {result}");
Console.WriteLine($"It took {counter} times to get down to 1.");

//------------------------------------------------------
// End of Main Method
// -----------------------------------------------------


//-------------------------------------------------------
// Start of the Utility Class
//-------------------------------------------------------
/// <summary>
/// Count to one using recursion
/// </summary>
/// <param name="num"></param>
/// <returns></returns>
static class Utility
{
    internal static int CountToOne(int num, ref int count)
    {
        // Print out the current number
        Console.WriteLine($"The current number is {num}");
        // Check if the number is 1
        if (num == 1)
        {
            return 1;
        }
        // Check if the number is a negative or zero
        else if (num < 1)
        {
            // Check if the number is 0
            if (num == 0)
            {
                // Incremenet the counter
                count++;
                Console.WriteLine("The number is 0. Add 1.");
                // Add 1 to the number and call the function
                return CountToOne(num + 1, ref count);
            }
            // Check if the number is divisible by 7
            else if ((num % 7) == 0)
            {
                // Incremenet the counter
                count++;
                Console.WriteLine("The number is negative and divisible by 7. Multiply by 3 and add 1.");
                // Multiply the number by 3 and add 1
                num = num * 3;
                num++;
                // Call the function
                return CountToOne(num, ref count);
            }
            // Check if the number is divisible by 4
            else if ((num % 4) == 0)
            {
                // Incremenet the counter
                count++;
                Console.WriteLine("The number is divisible by 4. Divide by 4");
                // Divide the number by 2 and call the function
                return CountToOne(num / 4, ref count);
            }
            // Check if the number is even
            else if ((num % 2) == 0)
            {
                // Incremenet the counter
                count++;
                Console.WriteLine("The number is negative and even. Divide by 2");
                // ievide the number by 2 and call the function
                return CountToOne(num / 2, ref count);
            }
            else
            {
                // Incremenet the counter
                count++;
                Console.WriteLine("The number is negative and odd. Add 1");
                // Add 1 to the number and call the function
                return CountToOne(num + 1, ref count);
            }
        }
        // Otherwise it's positive
        else
        {
            if ((num % 7) == 0)
            {
                // Incremenet the counter
                count++;
                Console.WriteLine("The number is divisible by 7. Multiply by 3 and subtract 1.");
                // Multiply the number by 3 and subtract 1
                num = num * 3;
                num--;
                // Call the function
                return CountToOne(num, ref count);
            }
            // Check if the number is divisible by 4
            else if ((num % 4) == 0)
            {
                // Incremenet the counter
                count++;
                Console.WriteLine("The number is divisible by 4. Divide by 4");
                // Divide the number by 2 and call the function
                return CountToOne(num / 4, ref count);
            }
            else if ((num % 2) == 0)
            {
                // Incremenet the counter
                count++;
                Console.WriteLine("The number is even. Divide by 2");
                // Divide the number by 2 and call the function
                return CountToOne(num / 2, ref count);
            }
            else
            {
                // Incremenet the counter
                count++;
                Console.WriteLine("The number is odd. Subtract 1");
                // Subtract 1 from the number and call the function
                return CountToOne(num - 1, ref count);
            }
        }
    }
}
//-------------------------------------------------------
// End of the Utility Class
//-------------------------------------------------------