using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGame
{
    internal class Game
    {
        public static void StartGame(Player player)
        {
            //get the players name and initialize player stats, paths, etc.
            player = new Player(UserIO.GetPlayerName());
            Path path = new Path();
            //greet the player under the new name
            UserIO.GreetPlayer(player.playerName);
            //offer the player their first path choice
            path.pathNumbers = CheckPlayerPathing(player, path.pathNumbers);
            UserIO.OfferPath();




        }

        public static Player ChoosePath(Player player)
        {
            player.GainAttack(10);
            if player
        }
        public static List<int> CheckPlayerPathing(Player player, List<int> path) {
        
            if (player.currentPath == 0)
            {
                return path;
            }
            else
            {
                if ()
                {
                    
                }
                path.RemoveAt(player.currentPath);
                   
            }
        }


    }
}
