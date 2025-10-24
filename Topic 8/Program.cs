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
            int randMax = 0, randMin = 1, loopAmount, guessNum, equalToGuess = 0;

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

            Console.WriteLine("Pick a number between " + randMin + " and " + randMax + ".");
                Console.WriteLine("Pick a number between " + randMin + " and " + randMax + ".");
                int.TryParse(Console.ReadLine(), out guessNum);

            for (int i = 0; i < RandomNumbers.Count; i++)
            {
                if (RandomNumbers[i] == guessNum)
                    equalToGuess = equalToGuess + 1;

            }

            Console.WriteLine(RandomNumbers[i]);

        }
    }
}
