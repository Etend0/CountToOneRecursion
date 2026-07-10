/*
 * Elijah Hodge
 * CST - 250
 * 07/10/2026
 * Count To One Recursion
 * Activity 3
 */

//------------------------------------------------------
// Start of Main Method
// -----------------------------------------------------

// Declare and initialize
int choice = 0, result = 0;
string input = "";

// Prompt the user for a number
Console.WriteLine("Please enter a positive number: ");
// Get the users input
input = Console.ReadLine();
// See if the user entered valid input
while (!int.TryParse(input, out choice) && choice > 0)
{
    Console.WriteLine("Invalid number");
    // Re-Prompt the user for a number
    Console.WriteLine("Please enter a positive number: ");
    // Get the users input
    input = Console.ReadLine();
}
// Call the CountToOne function
result = Utility.CountToOne(choice);
Console.WriteLine($"The end number is {result}");

//------------------------------------------------------
// End of Main Method
// -----------------------------------------------------


//------------------------------------------------------
// Start of the Utility Class
// -----------------------------------------------------
public class Utility
{
    internal static int CountToOne(int num)
    {
        // Print out the current number
        Console.WriteLine($"The current number is {num}");
        // Check if the number is 1
        if (num == 1)
        {
            return 1;
        }
        else
        {
            // Check if the number is even
            if ((num % 2) == 0)
            {
                Console.WriteLine("The number is even. Divide by 2.");
                // Divide the number by 2 and call the function
                return CountToOne(num / 2);
            }
            else
            {
                Console.WriteLine("The number is odd. Add 1.");
                // Add 1 and call the function
                return CountToOne(num + 1);
            }
        }
    }
    //------------------------------------------------------
    // End of the Utility Class
    // -----------------------------------------------------
}