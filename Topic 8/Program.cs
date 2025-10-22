using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace Topic_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(); // Creates an empty List
            int randNum, listMax = 20;
            Random generator = new Random();
            for (int i = 0; i < listMax; i++)
            {
                randNum = generator.Next(40);
                numbers.Add(randNum);
            }
            Console.WriteLine("The largest number is " + numbers.Max());
            Console.WriteLine("The smallest number is " + numbers.Min());
            Console.WriteLine("The sum is " + numbers.Sum());
            Console.WriteLine("The Average is " + (numbers.Sum() / listMax));

            Console.ReadLine(); // Keeps the program from ending
        }
    }
}
