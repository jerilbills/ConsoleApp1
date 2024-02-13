using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ComputerPlayer
    {
        public string CpuMove()
        {
            string[] moves = { "rock", "paper", "scissors" };
            Random rnd = new Random();
            // chooses a random number between 0 and the length of the array
            // minus 1
            int moveIndex = rnd.Next(0, moves.Length);
            // selects the array item (move) at the randomly-chosen index
            // and returns it
            string move = moves[moveIndex];
            return move;
        }
    }
}
