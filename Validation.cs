using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGame
{
    internal static class Validation
    {
        public static bool IsValidChoice(int choice, int[] pathChoices)
        {
            foreach (int i in pathChoices)
            {
                if (i == choice) return true;
            }
            return false;
        }
    }
}
