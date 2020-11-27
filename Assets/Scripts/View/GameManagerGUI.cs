using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerGUI : MonoBehaviour
{

    public Text winnerText;

    public void GameResult(string result)
    {
        winnerText.text = result;
    }
}