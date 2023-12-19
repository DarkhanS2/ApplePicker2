using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    private const string ScoreKey = "score";


    public static void SaveScore(int score)
    {
        PlayerPrefs.SetInt(ScoreKey, score);
        PlayerPrefs.Save();
    }

   
    public static int LoadScore()
    {
        return PlayerPrefs.GetInt(ScoreKey, 0);
    }
}
