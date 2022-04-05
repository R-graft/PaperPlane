using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeChooser : MonoBehaviour
{
    public static bool isChallenge;
     
   public void Easy()
    {
        isChallenge = false;
        SceneManager.LoadScene("Game");
        MoveScript.speed = 0.15f;
        Time.timeScale = 0.7f;
    }
   public void Normal()
    {
        isChallenge = false;
        SceneManager.LoadScene("Game");
        MoveScript.speed = 0.15f;
        Time.timeScale = 1f;
    }
   public void Hard()
    {
        isChallenge = false;
        SceneManager.LoadScene("Game");
        MoveScript.speed = 0.15f;
        Time.timeScale = 1.5f;
    }
    public void Challenge()
    {
        isChallenge = true;
        SceneManager.LoadScene("Game");
        MoveScript.speed = 0.15f;
        Time.timeScale = 1f;
        
    }
}
