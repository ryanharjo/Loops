namespace Loops_Harjo_Ryan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print a message asking the user where their phone is
            Console.WriteLine("Where is my phone?");
            // Read the user's response (the sentence where they mention the location of their phone)
            string response = Console.ReadLine();
            // Print a message with the number of spaces in the response using the CountNumberOfSpaces method
            Console.WriteLine($"The sentence, \"{response}\" has {CountNumberOfSpaces(response)} spaces in it.");

            // Prompt the user to enter a whole number
            Console.WriteLine("Please enter a whole number");
            // Read the user's response (the number in string form)
            string response2 = Console.ReadLine();
            // Print a message displaying the sum of the individual digits of the entered number
            Console.WriteLine($"The sum of the individual digits of {response2} is {SumOfDigits(response2)}");
        }

        static int CountNumberOfSpaces(string sentence)  // Method to count the number of spaces in a given sentence
        {
            int numberOfSpaces = 0;  

            foreach (char character in sentence)  // Loop through each character in the sentence
            {
                if (character == ' ') // If the character is a space, increment the counter
                    numberOfSpaces++;
                
            }
            return numberOfSpaces; // Return the total number of spaces found in the sentence
        }

        static int SumOfDigits(string number)// Method to sum the individual digits of a string number
        {
            int sum = 0;
            foreach (char digit in number)  // Loop through each character in the string (which represents a number)
            {
                sum += (int)Char.GetNumericValue(digit); // Convert the character to its numeric value and add it to the sum
            }
            return sum;  // Return the total sum of the digits

        }
    }

}


