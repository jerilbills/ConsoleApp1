/**
 * Tells player if they won or lost the game
 * 
 * @returns {string} message indicating win/loss
 */
function gameWinner()
{
    player1Wins = "Player 1, you're the winner!";
    player1Loses = "Player 1, you lost!";
    
    if (Player1Score > Player2Score)
    {
        return player1Wins;
    }
               
    return player1Loses;
}

/**
 * Compares players' moves and determines round winner.
 * Updates the currentScore object which holds player score.
 * 
 * currentScore object contains two key-value pairs:
 * player1score: {number} player 1's score for the round
 * player2score: {number} player 2's score for the round
 * 
 * @param {string} player1Move 
 * @param {string} player2Move 
 * @param {object} currentScore 
 * @returns {object} updated score
 */
function determineWinner(player1Move, player2Move, currentScore)
{
    if ((player1Move != player2Move) && (player1Move!="") && (player2Move!=""))
    {
        if (player1Move == "rock" && player2Move == "scissors" ||
        player1Move == "paper" && player2Move == "rock" ||
        player1Move == "scissors" && player2Move == "paper")
        {
            currentScore.player1Score++;
        }
        else
        {
            currentScore.player2Score++;
        }
    }
    return currentScore;
}

let currentScore = {
    player1Score: 0,
    player2Score: 0
}

/**
 * Takes a string id of the button that was clicked and returns the same string.
 * 
 * @param {string} id id of button clicked by player 
 * @returns {string} id of button clicked by player
 */
function getUserMove(id)
{
    userMove = id;

    return userMove;
}

/**
 * Gets the computer's move. 
 * @returns {string} randomly selected computer move
 */
function cpuMove()

{
    const moves = ["rock", "paper", "scissors"]
    // chooses a random number between 0 and the length of the array
    // minus 1
    moveIndex = Math.floor(Math.random() * moves.length)
    
    // selects the array item (move) at the randomly-chosen index
    // and returns it
    move = moves[moveIndex];
    return move;
}

function gameplay(id)
{

    // Checks whether anyone is leading by 2
    while (Math.abs(currentScore.player1Score - currentScore.player2Score) < 2)
    {
        playerMove = id;

        //method HERE for CPU's random move
        compMove = cpuMove();
        // decide who won the round
        currentScore = determineWinner(playerMove, compMove, currentScore);
        // output the score
        const scoreMessage = document.getElementById('score')
        scoreMessage.innerText = `The current score is ${currentScore.player1Score} to ${currentScore.player2Score}`
        
        // Console.WriteLine("Press any key to continue.");
        // Console.ReadKey(true);

    }
    // outputs Scorekeeper ToString method
    // Console.WriteLine($"GAME OVER! The final score is {keptScore}. Way to play! {keptScore.GameWinner()}");

}