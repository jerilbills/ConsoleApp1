using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //method to add score to winner after round
    //continue play through 3 rounds
    //method to display score for game after each round

    public class Scorekeeper
    {
        public int Player1Score { get; set; } = 0;
        public int Player2Score { get; set; } = 0;

        public override string ToString()
        {
            return $"The score is: Player 1: {Player1Score} Computer: {Player2Score}";
        }
    }
}
