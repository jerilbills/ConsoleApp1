using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public string[] moves = { "rock", "paper", "scissors" };
    // Returns a random move.
    private string cpuMove()
    {
        Random rnd = new Random();
        // chooses a random number between 0 and the length of the array
        // minus 1
        int moveIndex = rnd.Next(0, moves.Length);
        // selects the array item (move) at the randomly-chosen index
        // and returns it
        string move = moves[moveIndex];
        return move;
    }
    public static void Main(string[] args)
    {
        // Give instructions to user
        Console.WriteLine("Welcome to Rock Paper Scissors.");
        Console.WriteLine("I will be your opponent. The instructions are as follows:");
        Console.WriteLine("Press enter to start counting down to your move selection.");
        Console.WriteLine("You will then be prompted to select your move- R=rock, P= paper & S=scissors");
        Console.WriteLine("Rock smashes scissors. Paper covers rock. Scissors cuts paper.");
        Console.WriteLine("Matching moves result in a tie.");
        //code for rock->paper->scissors count down
        Console.WriteLine("Select your move: R, P, or S");
        string userInput;
        userInput = Console.ReadLine();
        //method HERE for CPU's random move
    }
}

