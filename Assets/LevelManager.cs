using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int pointsToWin = 1000;

    public void CheckPoints(int score)
    {
        if (score >= pointsToWin)
        {
            LoadNextLevel();
        }
    }

    private void LoadNextLevel()
    {
        int currentLevelIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentLevelIndex + 1);
    }
}
