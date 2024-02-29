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

        //logic to determine winner of round
        //takes in string player moves and current score
        //returns updated score
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

        //returns message indicating win/loss
        public string GameWinner()
        {
            
            string player1Wins = "Player 1, you're the winner!";
            string player1Loses = "Player 1, you lost!";

            if (Player1Score > Player2Score)
            {
                return player1Wins;
            }
           
            return player1Loses;

        }
    }
}
