using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour {

    private float score = 5f;

    public Text uiHighscore;
    public Text uiScore;

    private void Start()
    {
        PlayerPrefs.SetInt("Highscore", 0); // this need to be removed for highscore to work
        SetUiHighscore();
    }

    private void Update()
    {
        if (GlobalVars.isGameOn)
        {
            GlobalVars.score += score * Time.deltaTime * PlayerPrefs.GetInt("ScoreMultiplier", 1);
            uiScore.text = "Score : " + ((int)GlobalVars.score).ToString();

            if(GlobalVars.score > PlayerPrefs.GetInt("Highscore", 0))
            {
                PlayerPrefs.SetInt("Highscore", (int)GlobalVars.score);
                SetUiHighscore();
            }
            print((int)GlobalVars.score);
        }
    }

    private void SetUiHighscore()
    {
        uiHighscore.text = "Highscore : " + PlayerPrefs.GetInt("Highscore", 0).ToString();
    }

}
