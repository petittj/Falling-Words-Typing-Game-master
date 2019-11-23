using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShowData : MonoBehaviour
{
    public Text PName;
    //   public Text HScore;
    //    public Text Score;
    public Text wordCount;
    public Text FSpeed;


    private void Awake()
    {
        PName.text = KeepData.PlayerName;
 //       HScore.text = "High Score: " + KeepData.HighScore;
//        Score.text = "Score: " + KeepData.score;
        FSpeed.text = "Speed: " + KeepData.FallSpeed;
        //wordCount.text = "Number of words: " + WordManager.WordCount;

    }
}
