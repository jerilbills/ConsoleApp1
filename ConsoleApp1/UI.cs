using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class UI
    {
        //start of THE GAME!
        public void Run()
        {
            GameInstructions();
            Gameplay();
        }

        // Give instructions to user at start of THE GAME!
        public void GameInstructions()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors.");
            Console.WriteLine("I will be your opponent. The instructions are as follows:");
            Console.WriteLine("To begin, you will be prompted to select your move- R=rock, P= paper & S=scissors");
            Console.WriteLine("Rock smashes scissors. Paper covers rock. Scissors cut paper.");
            Console.WriteLine("Matching moves result in a tie.");
            Console.WriteLine("Press any key to continue.");
            //Thread.Sleep(10000);
            Console.ReadKey(true);
        }

        public void Gameplay()
        {
            Scorekeeper keptScore = new Scorekeeper();

            // Checks whether anyone is leading by 2
            while (Math.Abs(keptScore.Player1Score - keptScore.Player2Score) < 2)
            {
                //Starts each round of gameplay with a rockpaperscissors countdown
                Countdown();
                string playerMove = GetUserMoves();


                //method HERE for CPU's random move
                ComputerPlayer cpu = new ComputerPlayer();
                string cpuMove = cpu.CpuMove();
                Console.WriteLine($"Opponent chose {cpuMove}");

                // decide who won the round
                keptScore.DetermineWinner(playerMove, cpuMove, keptScore);
                // output the score
                Console.WriteLine(keptScore);
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);

            }
            // outputs Scorekeeper ToString method
            Console.WriteLine($"GAME OVER! The final score is {keptScore}. Way to play! {keptScore.GameWinner()}");

        }


        //Starts each round of gameplay with a rockpaperscissors countdown
        public void Countdown()
        {
            Console.Clear();
            Console.WriteLine($"Rock!");
            Thread.Sleep(1000); //Wait for 1 second
            Console.Clear(); //Clear the console for a countdown effect
            Console.WriteLine($"Paper!");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine($"Scissors!");
            Thread.Sleep(1000);
            Console.Clear();

        }

        //reads user input from dictionary of moves
        public string GetUserMoves()
        {
            Dictionary<string, string> moves = new Dictionary<string, string>()
            {
                {"r", "rock" },
                {"p", "paper" },
                {"s", "scissors" }
            };
            string userMove = "";

            // runs as long as userMove is not a valid move
            while (!moves.ContainsValue(userMove))
            {
                try
                {
                    Console.WriteLine("Select your move: R, P, or S");
                    string userInput = Console.ReadLine();
                    string userInputCaseInsensitive = userInput.ToLower();
                    // check dictionary for user's move, throw exception if not found
                    if (moves.ContainsKey(userInputCaseInsensitive))
                    {
                        userMove = moves[userInputCaseInsensitive];
                    }
                    else
                    {
                        throw new KeyNotFoundException();
                    }
                }
                //tell user move is invalid & return to "Select your move..."
                catch (KeyNotFoundException)
                {
                    Console.WriteLine("You did not select a valid move!");
                }
                catch (Exception)
                {

                    Console.WriteLine("Oops. Something went wrong!");
                }

            }

            return userMove;

        }

    }
}
