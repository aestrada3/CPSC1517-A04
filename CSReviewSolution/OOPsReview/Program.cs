using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPsReview
{
    class Program
    {
        static void Main(string[] args)
        {
            int Rounds;
            string PlayerOne;
            string PlayerTwo;
            int PlayerOneScore;
            int PlayerTwoScore;


            Console.WriteLine("Name of Player one:");
            PlayerOne = Console.ReadLine();

            Console.WriteLine("Name of Player two:");
            PlayerTwo = Console.ReadLine();

            Console.WriteLine("Enter the number of rounds to be played");
            Rounds = Convert.ToInt32( Console.ReadLine());

            for (;Rounds > 0;Rounds--)
            {
                PlayerOneScore = new Die();


            }
            

        }
    }
}
