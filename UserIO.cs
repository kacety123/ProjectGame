using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGame
{
    internal class UserIO
    {

        public static string GetPlayerName()
        {
            Console.WriteLine("Please Enter Your Desired Player Name: ");
            return Console.ReadLine();
        }

        public static void GreetPlayer(string playerName)
        {
            Console.WriteLine($"Well hello, and welcome to your doom...{playerName} \r\n" +
                $"*evil laugh* \r\n" +
                $"There is no escape and you will not be able to leave until death or prompted to do so otherwise. \r\n" +
                $"Happy Doom!");
        }
        public static void OfferPath(List<int> paths)
        {
            Console.Write($"Choose wisely, there are two paths in front of you. Enter numerical {paths[1]} or numerical {paths[2]}: ");
        }

        public static int GetPlayerChoice(List<int> paths)
        {
            while (true)
            {
                string playerChoice = Console.ReadLine();
                if (playerChoice == paths[1].ToString() || playerChoice == paths[2].ToString())
                {
                    return Convert.ToInt32(playerChoice);
                }
                else
                {
                    Console.WriteLine("Please enter a valid path from the two options provided: ");
                }
            }
        }
        public static void DisplayPathStory(string path)
        {
            Console.WriteLine(path);

        }
        public static void DisplaySuccessMessage(Player player)
        {
            Console.WriteLine($"Congratulations!\r\n" +
                $"You won this round, defeating the lizzard!\r\n" +
                $"Your stats are...\r\n" +
                $"Health: {player.GetHealth()}\r\n" +
                $"Attack Power: {player.GetAttackPower()}");
        }
    }
}
