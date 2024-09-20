using ProjectGame.Lizards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGame
{
    internal static class Game
    {
        public static void StartGame()
        {
            //get the players name and initialize player stats, paths, etc.
            Player player = new Player(UserIO.GetPlayerName());
            Pathways path = new Pathways();
            List<int> paths = new List<int> { 1, 2 };
            Lizard lizard;
            //greet the player under the new name
            UserIO.GreetPlayer(player.playerName);
            while(player.IsAlive() || paths.Contains(11) != true)
            {
                //offer the path options to the player
                UserIO.OfferPath(paths);
                //get the players choice, will loop until the correct input is provided
                int pathChosen = UserIO.GetPlayerChoice(paths);
                //player gains 10 attack pts for choosing a path and set the players path in profile
                player.GainAttack();
                player.currentPath = pathChosen;
                //Display path story and info
                if(player.GetAttackPower() > 30)
                {
                    lizard = GetLizardTypeHL();
                }
                else
                {
                    lizard = GetLizardType();
                }
                UserIO.DisplayPathStory(path.GetPathStory(player, lizard));
                //Utilize attack sequence for player, generate random to determine who attacks first. 
                if (player.mustFight)
                {
                    switch (RollFirstAttack())
                    {
                        case 1: //Player attacks first
                            PlayerAttacksFirst(player, lizard);
                            break;

                        case 2: //Lizard attacks first
                            LizzardAttacksFirst(player, lizard);
                            break;
                    }
                    //if player is not alive, display message and end game
                    //if player is alive, display message with updated stats that player defeated lizard
                    if (player.IsAlive())
                    {
                        UserIO.DisplaySuccessMessage(player);
                    }
                    else
                    {
                        UserIO.DisplayPlayerDiedMessage();
                    }
                }
                paths = SetPlayerPaths(paths);
            }
        }

        //Incrementor method that will increment the previous path list items by 1 to create two new path choices
        public static List<int> SetPlayerPaths(List<int> path) {
        
            for (int i = 0; i< path.Count(); i++)
            {
                path[i]+=2;
            }
            return path;
        }
        //Random Lizard generators based on level
        private static Lizard GetLizardType()
        {
            Random random = new Random();
            int roll = random.Next(1, 2);
            switch (roll)
            {
                case 1:
                    return new BabyLizard();
                case 2:
                    return new AdultLizard();
                default: return new BabyLizard();
            }
        }
        private static Lizard GetLizardTypeHL()
        {
            Random random = new Random();
            int roll = random.Next(1, 3);
            switch (roll)
            {
                case 1:
                    return new BabyLizard();
                case 2:
                    return new AdultLizard();
                case 3:
                    return new QueenLizard();
                default: return new BabyLizard();
            }
        }
        //Random generator to determine who fights first
        private static int RollFirstAttack()
        {
            Random random = new Random();
            return random.Next(1, 2);
        }
        //function for Lizard to attack first
        private static void LizzardAttacksFirst(Player player, Lizard lizard)
        {
            while (player.IsAlive())
            {
                lizard.AttackPlayer(player);
                if (player.GetHealth() > 0)
                {
                    player.AttackLizard(lizard);
                }
                else
                {
                    break;
                }
            }
        }

        //function for player to attack first
        private static void PlayerAttacksFirst(Player player, Lizard lizard)
        {
            while (player.IsAlive())
            {
                player.AttackLizard(lizard);
                if (lizard.GetHealth() > 0)
                {
                    lizard.AttackPlayer(player);
                }
                else
                {
                    break;
                }
            }
        }

    }
}
