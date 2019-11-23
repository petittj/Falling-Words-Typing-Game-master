using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.UI;

public class writeScore : MonoBehaviour
{


    public void WriteString()//NEED TO MAKE THIS PUBLIC SO WE CAN CONNECT TO BUTTON
    {
        string path = "Assets/Resource/Scores.txt";

        // get text from the inputfield
        string Name = KeepData.PlayerName;
        string score = ShowScore.sc.ToString();
        string Hscore = ShowScore.HighScore;
        string numWords = WordManager.WordCount.ToString();
        string MissedWords = ShowScore.wordsMissed.ToString();


        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("Player: " +Name +"\n Score: "+score+ " HighScore"+Hscore+ " Number of words: "+numWords+ " Missed words: "+MissedWords);
        writer.Close();

        //Re-import the file to update the reference in the editor
        AssetDatabase.ImportAsset(path);
        TextAsset asset = (TextAsset)Resources.Load("Scores"); // NEED TO CAST AS A TEXT ASSET SO IT CAN BE USED. TRY WITHOUT.
    }
}
