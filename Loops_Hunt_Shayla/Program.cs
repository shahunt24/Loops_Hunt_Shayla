namespace Loops_Hunt_Shayla
{
    internal class Program
    {
        static void Main(string[] args)
        { // Asks the user why they make games and then counts the number of spaces in their response.
            Console.WriteLine("Why do you make games?");
            string response = Console.ReadLine();
            Console.WriteLine($"The sentence, \"{response}\" has {CountNumberOfSpaces(response)} spaces in it.");

            // Asks the user to enter a whole number and then calculates the sum of the individual digits.
            Console.WriteLine("Please enter a whole number.");
            string response2 = Console.ReadLine();
            Console.WriteLine($"The sum of the induvidual digits of {response2} is {SumOfDigits(response2)}!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sentence">The sentence to count number of spaces in</param>
        /// <returns>Number of spaces in the sentence</returns>
        static int CountNumberOfSpaces(string sentence)
        {
            int numberOfSpaces = 0;
            foreach(char character in sentence) 
            { 
                if(character == ' ')
                {
                    numberOfSpaces++;
                }
            }
            return numberOfSpaces;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number">The number adds up the digits in the sentence spaces</param>
        /// <returns>The digits added up</returns>
        static int SumOfDigits(string number)
        {
            int sum = 0;
            foreach (char digit in number)
            {
                sum += (int)Char.GetNumericValue(digit);
            }
            return sum;
        }
    }
}
