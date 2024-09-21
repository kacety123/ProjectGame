using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userReplay = "";
            while (userReplay != "x" && userReplay != "X")
            {
                Game.StartGame();
                userReplay = UserIO.GetUserReplayInput();
            }

        }
    }
}
