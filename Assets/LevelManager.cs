using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (SceneManager.GetActiveScene().buildIndex + 1 != 2)
            GoToNextLevel();
        else
            Debug.Log("Game Over! \n You won the game");
    }
    private void GoToNextLevel()
    {
        Debug.Log("Level "+SceneManager.GetActiveScene().buildIndex+ " is completed");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
