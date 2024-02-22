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
            return $"Player 1: {Player1Score} Computer: {Player2Score}";
        }

        public Scorekeeper DetermineWinner(string player1Move, string player2Move, Scorekeeper scorekeeper)
        {
            
            if (!(player1Move == player2Move))
            {
                if (player1Move == "rock" && player2Move == "scissors" ||
                player1Move == "paper" && player2Move == "rock" ||
                player1Move == "scissors" && player2Move == "paper")
                {
                    scorekeeper.Player1Score++;
                }
                else
                {
                    scorekeeper.Player2Score++;
                }
            }
            return scorekeeper;
        }

        public Scorekeeper GameWinner(Scorekeeper gameOver)
        {
            if (Player1Score > Player2Score)
            {
                Console.WriteLine($"Player 1, you're the winner!");
            }
            else
            {
                Console.WriteLine($"Player 1, you lost!");
            }
            return gameOver;
                
        }
    }
}
