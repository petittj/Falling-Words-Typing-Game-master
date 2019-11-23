using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChoice : MonoBehaviour
{
    public Dropdown PlayerColorDropdown;
    public static string PlayerColor;

    public Text MyChoice;

    public void SetColor()
    {
        switch (PlayerColorDropdown.value)
        {
            case 1:
                PlayerColor = "Red";
                MyChoice.text = "Red";
                break;
            case 2:
                PlayerColor = "Blue";
                MyChoice.text = "BLue";
                break;
            case 3:
                PlayerColor = "Yellow";
                MyChoice.text = "Yellow";
                break;
            case 4:
                PlayerColor = "Green";
                MyChoice.text = "Green";
                break;

            default:
                MyChoice.text = "Please Select";
                break;
        }
    }
}
