using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsButton : MonoBehaviour
{
    public void OptionButton()
    {
        //Load the Pause Menu
        SceneManager.LoadScene("MainMenu");
    }
}
