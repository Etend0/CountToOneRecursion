/*
 * Elijah Hodge
 * CST - 250
 * 03/15/2026
 * Count To One Recursion
 * Activity 3
 * */

//-------------------------------------------------------
// Start of the Main Method
//-------------------------------------------------------

// Declare and initialize
int choice = 0, result = 0;
string input = "";

// Prompt the user for a number
Console.Write("Enter a positive number: ");
// Get the users input
input = Console.ReadLine();
// See if the user entered a valid input
while (!int.TryParse(input, out choice) || choice > 0)
{
    Console.Write("Invalid number");
    // Re-Prompt the user for a number
    Console.Write("Enter a positive number: ");
    // Get the users input
    input = Console.ReadLine();
}
// Call the CountToOne function
result = Utility.CountToOne(choice);
Console.WriteLine($"The end number is {result}");

//-------------------------------------------------------
// End of the Main Method
//-------------------------------------------------------

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
    internal static int CountToOne(int num)
    {
        // Print out the current number
        Console.WriteLine($"The current number is {num}");
        // Check if the number is 1
        if (num <= 1)
        {
            return 1;
        }
        else
        {
            // Check if the number is even
            if ((num % 2) == 0)
            {
                Console.WriteLine("The number is even. Divide by 2");
                // Divide the number by 2 and call the function
                return CountToOne(num / 2);
            }
            else
            {
                Console.WriteLine("The number is odd. Add 1");
                // If the number is odd, subtract 1 from it
                return CountToOne(num + 1);
            }
        }
    }
}
//-------------------------------------------------------
// End of the Utility Class
//-------------------------------------------------------