using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoreboard_Controller : MonoBehaviour
{
    public static Scoreboard_Controller instance;

    public Text playerOneScoreText;
    public Text playerTwoScoreText;

    public int playerOneScore;
    public int playerTwoScore;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        playerOneScore = playerTwoScore = 0;
    }

    public void GivePlayerOneAPoint(){
        
        playerOneScore += 1;

        playerOneScoreText.text = playerOneScore.ToString();
    }

    public void GivePlayerTwoAPoint(){
        playerTwoScore += 1;

        playerTwoScoreText.text = playerTwoScore.ToString();
    }
}
