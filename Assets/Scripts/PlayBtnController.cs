using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayBtnController : MonoBehaviour
{
    public void PacmanButton()
    {
        //Load the Pacman Game
        SceneManager.LoadScene("Pacman");
    }

    public void PongButton()
    {
        //Load the Pong Game
        SceneManager.LoadScene("Pong");
    }

    public void SpaceInvadersButton()
    {
        //Load the SpaceInvaders Game
        SceneManager.LoadScene("Space_Invaders");
    }
}
