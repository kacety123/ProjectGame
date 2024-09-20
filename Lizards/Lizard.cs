using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectGame
{
    internal class  Lizard
    {
        protected int attackPower;
        protected int health;

        public void AttackPlayer(Player player)
        {
            if (player.GetHealth() > attackPower)
            {
                player.SetHealth(attackPower);
            }
            else
            {
                player.SetHealth(player.GetHealth());
                player.SetIsAlive(false);
            }
        }
        public int GetAttackPower()
        {
            return attackPower;
        }
        public int GetHealth()
        {
            return health;
        }
        public int SetHealth(int delta) { return health -= delta; }
    }
}
