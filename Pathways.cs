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
        //Get the path story based on the users selection using switch case funcion that calls each path function.
        //Inside each path, there is a reference to mustFight bool which the GAME class uses to determine if a fight is happening
        public string GetPathStory(Player player, Lizard lizard)
        {
            switch (player.currentPath)
            {
                case 1:
                    return PathOne(player);
                case 2:
                    return PathTwo(lizard, player);
                case 3:
                    return PathThree(lizard, player);
                case 4:
                    return PathFour(player);
                case 5:
                    return PathFive(lizard, player);
                case 6:
                    return PathSix(player);
                case 7:
                    return PathSeven(lizard, player);
                case 8:
                    return PathEight(player);
                case 9:
                    return PathNine(lizard, player);
                case 10:
                    return PathTen(lizard, player);
                default:
                    return "Someting broke...";


            }
        }


        private string PathOne(Player player)
        {
            player.mustFight = false;
            player.GainAttack();
            return "Now entering path 1... \r\n" +
                "Lucky for you, path 1 is a safe path, there appears to be no Lizard beasts.\r\n" +
                "But remember to choose your next path wisely, for you may be doomed! \r\n" +
                "You gain 10 Attack pts";
        }

        private string PathTwo(Lizard baby, Player player)
        {

            player.mustFight = true;
            return $"Now entering path 2... \r\n" +
                $"oooohhhh SNAP! A wild {baby.GetType().Name} appeared! You have no choice but to fight to move on! \r\n" +
                $"Your stats are...\r\n" +
                $"Attack Power: {player.GetAttackPower()}\r\n" +
                $"Health: {player.GetHealth()}\r\n" +
                $"\r\n \r\nThe Lizards stats are...\r\n" +
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
                $"A WILD {lizard.GetType().Name} appeared!\r\n" +
                $"There's no option to run, or take another way...\r\n" +
                $"Your stats are...\r\n" +
                $"Health: {player.GetHealth()}\r\n" +
                $"Attack Power: {player.GetAttackPower()}\r\n\r\n" +
                $"The Lizards stats are ....\r\n" +
                $"Attack Power: {lizard.GetAttackPower()}\r\n" +
                $"Health: {lizard.GetHealth()}";
        }
        private string PathFour(Player player)
        {
            player.mustFight = false;
            player.GainAttack();
            return $"Now entering path 4...\r\n" +
                $"Well, it would appear that you got lucky this time.\r\n" +
                $"There are no lizards here....\r\n" +
                $"You gained 10 Attack Pts";
        }
        private string PathFive(Lizard lizard, Player player)
        {
            player.mustFight = true;
            return $"Now entering path...OH SHIT!\r\n" +
                $"Its a Damned {lizard.GetType().Name}\r\n" +
                $"Time to fight!\r\n" +
                $"Your stats are...\r\n" +
                $"Health: {player.GetHealth()}\r\n" +
                $"Attack Power: {player.GetAttackPower()}\r\n" +
                $"\r\n" +
                $"The lizards stats are ...\r\n" +
                $"Attack Power: {lizard.GetAttackPower()}\r\n" +
                $"Health: {lizard.GetHealth()}";
        }
        private string PathSix(Player player)
        {
            player.mustFight = false;
            player.GainAttack();
            return $"Well you lucky little b*tch...\r\n" +
                $"You made it to path 6 AND nothing to fight.\r\n" +
                $"Rest easy, young padawan, for doom still awaits!\r\n" +
                $"MWUAHAHAHAHAHAAAAAAA!";
        }
        private string PathSeven(Lizard lizard, Player player)
        {
            player.mustFight = true;
            return $"Welcome to Paradize...\r\n" +
                $"Said the mighty {lizard.GetType().Name} that stands before you...\r\n" +
                $"Your stats are...\r\n" +
                $"Health: {player.GetHealth()}\r\n" +
                $"Attack Power: {player.GetAttackPower()}\r\n" +
                $"\r\n" +
                $"The lizards stats are ...\r\n" +
                $"Attack Power: {lizard.GetAttackPower()}\r\n" +
                $"Health: {lizard.GetHealth()}";
        }
        private string PathEight(Player player)
        {
            player.mustFight = false;
            player.GainAttack();
            return $"Alright alright, your luck WILL run out, I promise you!\r\n" +
                $"MOVE ON with your stupid +10\r\n" +
                $"GO ALREADY!";
        }
        private string PathNine(Lizard lizard, Player player)
        {
            player.mustFight = true;
            return $"It's the END of the line!\r\n" +
                $"The exit is so CLOSE!\r\n" +
                $"BUT there is a {lizard.GetType().Name} blocking you...\r\n" +
                $"Your stats are...\r\n" +
                $"Health: {player.GetHealth()}\r\n" +
                $"Attack Power: {player.GetAttackPower()}\r\n" +
                $"\r\n" +
                $"The lizards stats are ...\r\n" +
                $"Attack Power: {lizard.GetAttackPower()}\r\n" +
                $"Health: {lizard.GetHealth()}";
        }
        private string PathTen(Lizard lizard, Player player)
        {
            player.mustFight = true;
            return $"It's the other end of the line....\r\n" +
                $"But alas, it IS the end!\r\n" +
                $"Peering off just past the {lizard.GetType().Name} blocking your path, you can see bright light!\r\n" +
                $"Will you survive, or will you DIE?\r\n" +
                $"Probably die...\r\n" +
                $"Your stats are...\r\n" +
                $"Health: {player.GetHealth()}\r\n" +
                $"Attack Power: {player.GetAttackPower()}\r\n" +
                $"\r\n" +
                $"The lizards stats are...\r\n" +
                $"Attack Power: {lizard.GetAttackPower()}\r\n" +
                $"Health: {lizard.GetHealth()}";
        }
    }
}
