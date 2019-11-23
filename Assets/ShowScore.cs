using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public Text TheScore;
    public Text HScore;
    public static int sc = WordManager.score;
    public Text numWords;
    public static string HighScore;
    public Text _WordsMissed;
    public static int wordsMissed;
    public static int numwords = WordManager.WordCount;

    public void Awake()
    {
        TheScore.text ="Score: " + WordManager.score.ToString();

        int hc=0;
        if (sc >= hc)
        {
            hc = sc;
           HighScore = hc.ToString();
        }
        HScore.text = "High Score: " + hc;
        numWords.text = "Total number of words spawned: " + WordManager.WordCount;
        wordsMissed = numwords - sc;
        _WordsMissed.text = "Words missed: " + wordsMissed;

        

    }

}
