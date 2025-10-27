using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace Topic_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //colours();
            //Console.ReadLine();

            Numbers();
            Console.ReadLine();
        }


        public static void colours()
        {
            int randColour;

            Random generator = new Random();

            List<string> colours = new List<string>();

            Console.WriteLine("What are your top 5 favourite colours?");
            for (int i = 0; i < 5; i++)
            {
                Console.Write((i + 1) + ". ");
                colours.Add(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write(colours[i] + ", ");
            }

            Console.WriteLine();

            randColour = generator.Next(5);

            Console.WriteLine(colours[randColour]);
        }

        public static void Numbers()
        {
            int randMax = 0, randMin = 1, loopAmount, guessNum, equalToGuess = 0, replaceNum;

            Random generator = new Random();

            List<int> RandomNumbers = new List<int>();

            Console.WriteLine("How many numbers do you need?");

            while (!int.TryParse(Console.ReadLine(), out loopAmount))
            {
                Console.WriteLine("How many numbers do you need?");
                int.TryParse(Console.ReadLine(), out loopAmount);
            }

            Console.WriteLine("Enter a minimum value.");

            while (randMin > randMax)
            {
                randMin = 1; randMax = 0;
                while (!int.TryParse(Console.ReadLine(), out randMin))
                {
                    Console.WriteLine("Enter a minimum value.");
                    int.TryParse(Console.ReadLine(), out randMin);
                }

                Console.WriteLine("Enter a maximum value.");

                while (!int.TryParse(Console.ReadLine(), out randMax))
                {
                    Console.WriteLine("Enter a maximum value.");
                    int.TryParse(Console.ReadLine(), out randMax);
                }
            }

            for (int i = 0; i < loopAmount; i++)
            {
                RandomNumbers.Add(generator.Next(randMin, randMax));
            }

            for (int i = 0; i < loopAmount; i++) // Number 1.
                Console.WriteLine(RandomNumbers[i] + ", ");

            // 2. Prompt the user for a number and count the number of times that number appears in the List.

            Console.WriteLine("Pick a number between " + randMin + " and " + randMax + ".");
            int.TryParse(Console.ReadLine(), out guessNum);
            while (guessNum > randMax || guessNum < randMin)
            {
                Console.WriteLine("Pick a number between " + randMin + " and " + randMax + ".");
                int.TryParse(Console.ReadLine(), out guessNum);
            }
            for (int i = 0; i < RandomNumbers.Count; i++)
            {
                if (RandomNumbers[i] == guessNum)
                   equalToGuess = equalToGuess + 1;

            }

            Console.WriteLine("There are " + equalToGuess + " " + guessNum);

            // 3. Prompt the user for a number and replace all occurrences of that number with zero.
            Console.WriteLine("Pick another number between " + randMin + " and " + randMax + ".");
            int.TryParse(Console.ReadLine(), out replaceNum);
            while (replaceNum > randMax || replaceNum < randMin)
            {
                Console.WriteLine("Pick another number between " + randMin + " and " + randMax + ".");
                int.TryParse(Console.ReadLine(), out replaceNum);
            }
            for (int i = 0; i < RandomNumbers.Count; i++)
            {
                if (RandomNumbers[i] == replaceNum)
                    RandomNumbers[i] = 0;
            }

            // 4. Print the List to the screen on one line.
            for (int i = 0; i < loopAmount; i++)
                Console.Write(RandomNumbers[i] + ", ");

            // 5. Using a loop, reset each value in the List with zeros.
            Console.WriteLine();
            Console.WriteLine("Resetting All Numbers");
            
            for (int i = 0; i < loopAmount; i++)
                // 6. Print the List to the screen on one line.
                Console.Write(RandomNumbers[i] = 0);

            // 7. Use a loop to fill the List again with new random numbers.

            Console.WriteLine();
            Console.WriteLine("Let's fill the list with new numbers!");

            Console.WriteLine("Enter a minimum value.");
            randMin = 1; randMax = 0;

            while (randMin > randMax)
            {
                randMin = 1; randMax = 0;
                while (!int.TryParse(Console.ReadLine(), out randMin))
                {
                    Console.WriteLine("Enter a minimum value.");
                    int.TryParse(Console.ReadLine(), out randMin);
                }

                Console.WriteLine("Enter a maximum value.");

                while (!int.TryParse(Console.ReadLine(), out randMax))
                {
                    Console.WriteLine("Enter a maximum value.");
                    int.TryParse(Console.ReadLine(), out randMax);
                }


            }
          
            RandomNumbers.Clear();

            for (int i = 0; i < loopAmount; i++)
            {
                RandomNumbers.Add(generator.Next(randMin, randMax));
            }

            // 8. Print the List to the screen on one line.
            for (int i = 0; i < loopAmount; i++)
                Console.Write(RandomNumbers[i] + ", ");
        }
    }
}
