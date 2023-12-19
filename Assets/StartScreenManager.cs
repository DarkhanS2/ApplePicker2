using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreenManager : MonoBehaviour
{
    public void NewGame()
    {
        // Load the main game scene
        SceneManager.LoadScene("Level1");
    }
    public void LoadGame()
    {
        // Load the main game scene
        SceneManager.LoadScene("Level1");
    }
}
