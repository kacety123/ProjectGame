using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGame.Lizards
{
    internal class BabyLizard : ILizard
    {
        public BabyLizard()
        {
            health = 10;
            attackPower = 10;
        }
    }
}
