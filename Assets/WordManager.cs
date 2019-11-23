using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WordManager : MonoBehaviour {

	public List<Word> words;
    public static int LossCount = 0;
    public static int score;
    public int count = 0;
	public WordSpawner wordSpawner;
    public AudioSource mySound;
    public Text NumWords;
    public Text Score;
    private bool hasActiveWord;
	private Word activeWord;
    WordDisplay display;
    public static int WordCount;


    public void AddWord ()
	{
		Word word = new Word(WordGenerator.GetRandomWordFile(), wordSpawner.SpawnWord());
		Debug.Log(word.word);
        WordCount++;
        NumWords.text ="Number Words Spawned: " + WordCount.ToString();
		words.Add(word);

    }

    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            if (activeWord.GetNextLetter() == letter)
            {
                mySound.Play();

                activeWord.TypeLetter();
            }
        }
        else
        {
            foreach (Word word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    mySound.Play();
                    word.TypeLetter();
                    break;
                }
            }
        }

        if (hasActiveWord && activeWord.WordTyped())
        {
            count += 1;
            score = count;
            Score.text = "Score: " +count.ToString();
            hasActiveWord = false;
            words.Remove(activeWord);
        }
    }
}
