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
        //
        public string GetPathStory(Player player, Lizard lizard)
        {
            switch (player.currentPath)
            {
                case 1 :
                    return PathOne(player);
                case 2:
                    BabyLizard babyLizard = new BabyLizard();
                    return PathTwo(babyLizard, player);
                //case 3:
                //    return PathThree(lizard, player);
                //    //TODO: Finish building story paths and cases
                default:
                    return "Someting broke...";
                    

            }
        }
        

        private string PathOne(Player player)
        {
            player.mustFight = false;
            player.GainHealth();
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
                $"Health: {baby.GetHealth()}\r\n" +
                $"How ever will you manage to attack and KILL a poor wittle innocent baby lizard?\r\n" +
                $"P.S. Is that a friggin pacifier in its..mouth....?";
        }
        private string PathThree(Lizard lizard, Player player)
        {
            player.mustFight = true;
            return $"Now entering path 3...\r\n" +
                $"Oh HECK! (Seee sometimes I care about who I offend!)\r\n" +
                $"A WILD {lizard.GetType().ToString()} appeared!\r\n" +
                $"There's no option to run, or take another way...\r\n" +
                $"Your stats are...\r\n" +
                $"Health: {player.GetHealth()}\r\n" +
                $"Attack Power: {player.GetAttackPower()}\r\n"+
                $"The Lizards stats are ....\r\n" +
                $"Attack Power: {lizard.GetAttackPower()}\r\n" +
                $"Health: {lizard.GetHealth()}";
        }
        private string PathFour(Player player)
        {
            player.mustFight = false;
            return $"Now entering path 4...\r\n" +
                $"Well, it would appear that you got lucky this time.\r\n" +
                $"There are no lizards here....\r\n" +
                $"You gained 10 Attack Pts";
        }
        private string PathFive(Lizard lizard, Player player) {
            player.mustFight = true;
            return $"Now entering path...OH SHIT!\r\n" +
                $"Its a Damned {lizard.GetType().Name}\r\n" +
                $"Time to fight!\r\n" +
                $""
    }
}
