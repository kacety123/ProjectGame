using ProjectGame.Lizards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGame
{
    internal class Path
    {
        private Dictionary<int, string> path;
        public List<int> pathNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public Path() { 
            path = new Dictionary<int, string>() { {1, PathOne() }, {2, PathTwo()},{3, PathThree()},{4, PathFour()},{5, PathFive()},{6, PathSix() },{7, PathSeven() }, {8,PathEight() }, {9, PathNine() } {10, PathTen() } };
        }

        private string PathOne()
        {
            return "Now entering path 1... \r\n" +
                "Lucky for you, path 1 is a safe path, there appears to be no Lizard beasts. But remember to choose your next path wisely, for you may be doomed! \r\n" +
                "You gain 10 Attack pts";
        }

        private string PathTwo(BabyLizard baby) {
            return $"Now entering path 2... \r\n" +
                $"oooohhhh SNAP! A wild {baby.GetType().ToString()} appeared! You have no choice but to fight to move on! \r\n" +
                $"Your stats are "
        }
    }
}
