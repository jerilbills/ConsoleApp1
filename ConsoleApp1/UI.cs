using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class UI
    {
        public void Gameplay()
        {
            Scorekeeper keptScore = new Scorekeeper();

            // Checks whether anyone is leading by 2
            while (Math.Abs(keptScore.Player1Score - keptScore.Player2Score) < 2)
            {
                Countdown();
                string playerMove = GetUserMoves();

                
                //method HERE for CPU's random move
                ComputerPlayer cpu = new ComputerPlayer();
                string cpuMove = cpu.CpuMove();
                Console.WriteLine($"Opponent chose {cpuMove}");
                
                keptScore.DetermineWinner(playerMove, cpuMove, keptScore);
                Console.WriteLine(keptScore);
                Thread.Sleep(5000);

            }
            Console.WriteLine($"GAME OVER! The final score is {keptScore}. Way to play! {keptScore.GameWinner()}");

            //Console.WriteLine(keptScore.GameWinner());

            //if (keptScore.Player1Score > keptScore.Player2Score) 
            //{
            //    Console.WriteLine($"Player 1, you're the winner!");
            //}
            //else
            //{
            //    Console.WriteLine($"Player 1, you lost!");
            //}
            //tidy end of game after a win by 2
        }
        public void Run() 
        {
            
            // Give instructions to user
            Console.WriteLine("Welcome to Rock Paper Scissors.");
            Console.WriteLine("I will be your opponent. The instructions are as follows:");
            Console.WriteLine("To begin, you will be prompted to select your move- R=rock, P= paper & S=scissors");
            Console.WriteLine("Rock smashes scissors. Paper covers rock. Scissors cut paper.");
            Console.WriteLine("Matching moves result in a tie.");
            //code for rock->paper->scissors count down
            Thread.Sleep(10000);
            
            Gameplay();
                        
        }

        public void Countdown()
        {
            Console.Clear();
            Console.WriteLine($"Rock!");
            Thread.Sleep(2000); //Wait for 1 second
            Console.Clear(); //Clear the console for a countdown effect
            Console.WriteLine($"Paper!");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine($"Scissors!");
            Thread.Sleep(2000);
            Console.Clear();
                       
        }

        public string GetUserMoves()
        {
            Dictionary<string, string> moves = new Dictionary<string, string>()
            {
                {"r", "rock" },
                {"p", "paper" },
                {"s", "scissors" }
            };

            Console.WriteLine("Select your move: R, P, or S");
            string userInput;
            userInput = Console.ReadLine();
            string userInputCaseInsensitive = userInput.ToLower();
            string userMove = moves[userInputCaseInsensitive];

            return userMove;
        }
        
    }
}
