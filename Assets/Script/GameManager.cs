using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int _playerScore, _computerScore;
    public Ball ball;
    public Text playerScoreText, computerScoreText;
    public Paddle playerpaddle, computerPaddle;


    public void playerScored(){
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();
        Debug.Log("Player Scored: " + _playerScore);
    }
    public void computerScored(){
        _computerScore++;
        this.computerScoreText.text = _computerScore.ToString();
        Debug.Log("Computer Scored: " + _computerScore);
    }

    public void resetRound(){
        this.ball.resetPosition();
        computerPaddle.ResetPosition();
        playerpaddle.ResetPosition();
        ball.AddStartingForce();
    }

}
