using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGame
{
    internal class Player
    {
        public string playerName;
        private int playerHealth;
        private int playerAttackPower;
        private bool isAlive;
        public int currentPath;
        
        public Player(string name) {
            playerName = name;
            playerHealth = 100;
            playerAttackPower = 0;
            isAlive = true;
            currentPath = 0;
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
        public int GetAttackPower() { return playerAttackPower; }
        public bool IsAlive() { return isAlive; }
    }
}
