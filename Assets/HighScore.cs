using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
 

     static private Text _UI_TEXT;                                        // a
     static private int _SCORE = 1000;                                   // b
 
     private Text txtCom;  
     void Awake()
        {                                                           // c
 _UI_TEXT = GetComponent<Text>();                                      // d
     }
 
     static public int SCORE
        {                                                 // e
         get { return _SCORE; }
         private set
            {                                                         // f
 _SCORE = value;
             if (_UI_TEXT != null)
                {                                         // g
 _UI_TEXT.text = "High Score: " + value.ToString("#,0");
             }
         }
    }
 
     static public void TRY_SET_HIGH_SCORE(int scoreToTry)
        {                 // h
         if (scoreToTry <= SCORE) return; 
 SCORE = scoreToTry;
     }

    }
