using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    private int _scr;

    public int Score
    {
        get { return _scr; }
        set
        {
            _scr = value;
            scoreText.text = Score.ToString();
        }
    }
}
