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
            Dictionary<string, string> moves = new Dictionary<string, string>()
            {
                {"r", "rock" },
                {"p", "paper" },
                {"s", "scissors" }
            };
            Scorekeeper keptScore = new Scorekeeper();

            while (Math.Abs(keptScore.Player1Score - keptScore.Player2Score) < 2)
            {
                Console.WriteLine($"Rock!");
                Thread.Sleep(2000); //Wait for 1 second
                Console.Clear(); //Clear the console for a countdown effect
                Console.WriteLine($"Paper!");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine($"Scissors!");
                Thread.Sleep(2000);
                Console.Clear();

                Console.WriteLine("Select your move: R, P, or S");
                string userInput;
                userInput = Console.ReadLine();
                string userInputCaseInsensitive = userInput.ToLower();
                string userMove = moves[userInputCaseInsensitive];
                //method HERE for CPU's random move
                ComputerPlayer cpu = new ComputerPlayer();
                string cpuMove = cpu.CpuMove();
                Console.WriteLine($"Opponent chose {cpuMove}");
                
                keptScore.DetermineWinner(userMove, cpuMove, keptScore);
                Console.WriteLine(keptScore);

            }
            Console.WriteLine($"GAME OVER! The final score is {keptScore}. Way to play!");
            //Scorekeeper.GameWinner(keptScore);
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
        
    }
}
