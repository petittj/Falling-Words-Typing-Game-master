using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour {

	public Text text;
    public string color;

    public float pos= 0.0f;


	public void SetWord (string word)
	{
		text.text = word;
	}

	public void RemoveLetter ()
	{
		text.text = text.text.Remove(0, 1);
        color = ColorChoice.PlayerColor;
        if (color == "Red")
        {
		text.color = Color.red;
        }
        if(color == "Blue")
        {
            text.color = Color.blue;
        }
        if (color == "Yellow")
        {
            text.color = Color.yellow;
        }
        if (color == "Green")
        {
            text.color = Color.green;
        }
    }

	public void RemoveWord ()
	{
        
		Destroy(gameObject);
	}

	private void Update()
	{
		transform.Translate(0f, -KeepData.FallSpeed * Time.deltaTime, 0f);
        
        float verticalPos = transform.position.y;

        if (verticalPos <= -330)
        {
            RemoveWord();
        }
    }

}
