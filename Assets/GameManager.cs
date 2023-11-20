using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool game_ended = false;
    public float restart_time = 2f;
    public void levelEnd()
    {
        Debug.Log("end");
    }
    public void endGame()
    {
        if (game_ended == false)
        {
            game_ended = true;
            Debug.Log("GAME OVER");
            Invoke("restartGame", restart_time);
        }
    }
    void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
