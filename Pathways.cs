using ProjectGame.Lizards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGame
{
    internal class Pathways
    {
        public string GetPathStory(Player player, Lizard lizard)
        {
            switch (player.currentPath)
            {
                case 1 :
                    return PathOne(player);
                case 2:
                    BabyLizard babyLizard = new BabyLizard();
                    return PathTwo(babyLizard, player);
                case 3:
                    return PathThree(lizard, player);
                    //TODO: Finish building story paths and cases
                    

            }
        }
        

        private string PathOne(Player player)
        {
            player.mustFight = false;
            return "Now entering path 1... \r\n" +
                "Lucky for you, path 1 is a safe path, there appears to be no Lizard beasts. But remember to choose your next path wisely, for you may be doomed! \r\n" +
                "You gain 10 Attack pts";
        }

        private string PathTwo(BabyLizard baby, Player player) {

            player.mustFight = true;
            return $"Now entering path 2... \r\n" +
                $"oooohhhh SNAP! A wild {baby.GetType().ToString()} appeared! You have no choice but to fight to move on! \r\n" +
                $"Your stats are...\r\n" +
                $"Attack Power: {player.GetAttackPower()}\r\n" +
                $"Health: {player.GetHealth()}\r\n" +
                $"\r\n \r\n The Lizards stats are...\r\n" +
                $"Attack Power: {baby.GetAttackPower()}\r\n" +
                $"Health: {baby.GetHealth()}";

        }
    }
}
