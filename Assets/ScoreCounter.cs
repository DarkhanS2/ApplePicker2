using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreCounter : MonoBehaviour
{
    [Header("Dynamic")]
    public int score = 0;
    private Text uiText;

    private

        // Start is called before the first frame update
        void Start()
    {
        uiText = GetComponent<Text>();
        LoadGame();

    }


    // Update is called once per frame
    void Update()
    {
        uiText.text = score.ToString("#,0");
       
    }
    public void LoadGame()
    {
        score = SaveManager.LoadScore();
    }
    public void NewGame()
    {
        score = 0;
        SaveManager.SaveScore(score);
    }

}
