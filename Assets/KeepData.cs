using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepData : MonoBehaviour
{
    public static string PlayerName;
    public static float FallSpeed;
    public static int HighScore=0;
    public static int score;
    public static int numWords;



    public InputField PlayerNameInput;
    public Slider SpeedSlider;


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text;
    }
    public void ChangeFallSpeed()
    {
        FallSpeed = SpeedSlider.value;
    }
    public static void GetScore()
    {
        score = WordManager.score;

    }
    public static void GetnumWords()
    {
        numWords = WordManager.WordCount;

    }


}
