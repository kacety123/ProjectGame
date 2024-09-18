using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGame
{
    internal class Player
    {
        private string playerName;
        private int playerHealth;
        private int playerAttackPower;
        private bool isAlive;
        
        public Player(string name) {
            playerName = name;
            playerHealth = 100;
            playerAttackPower = 0;
            isAlive = true;
        }

        public void TakeDamage(int damage)
        {
            if (playerHealth > damage)
            {
                playerHealth -= damage;
            }
            else
            {
                playerHealth = 0;
                isAlive = false;
            }
        }

        public void GainAttack(int power)
        {
            playerAttackPower += power;
        }

    }
}
