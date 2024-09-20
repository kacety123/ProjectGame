using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGame
{
    internal class  Lizard
    {
        protected int attackPower;
        protected int health;

        public void AttackPlayer(Player player)
        {

        }
        public int GetAttackPower()
        {
            return attackPower;
        }
        public int GetHealth()
        {
            return health;
        }
    }
}
