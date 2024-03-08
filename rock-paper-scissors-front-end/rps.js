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
 * Compares players' moves and determines round winner
 * Updates the currentScore object which holds player score
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

const currentScore = {
    player1Score: 0,
    player2Score: 0
}