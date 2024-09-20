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
        public bool mustFight;
        
        public Player(string name) {
            playerName = name;
            playerHealth = 100;
            playerAttackPower = 0;
            isAlive = true;
            currentPath = 0;
        }

        public void AttackLizard(Lizard lizard)
        {
            if (lizard.GetHealth() > playerAttackPower)
            {
                lizard.SetHealth(playerAttackPower);
            }
            else
            {
                lizard.SetHealth(lizard.GetHealth());
            }
        }

        public void GainAttack()
        {
            playerAttackPower += 10;
        }
        public int GetAttackPower() { return playerAttackPower; }
        public bool IsAlive() { return isAlive; }
        public void SetIsAlive(bool alive) {  isAlive = alive; }
        public int GetHealth() { return playerHealth; }
        public int SetHealth(int delta)
        {
            return playerHealth -= delta;
        }
        public void GainHealth() { playerHealth += 10; }
    }
}
