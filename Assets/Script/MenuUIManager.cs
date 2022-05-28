using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuUIManager : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI recordText;
    [SerializeField] public TextMeshProUGUI scoreTxt;
    public AudioHB audio;

    private void Start()
    {
        audio = FindObjectOfType<AudioHB>();
        if (kretanjePlatforme.TRecordUI == -1)
        {
            recordText.text = "";
            scoreTxt.text = "";
        }
        else
        {
            recordText.text = "BEST: " + kretanjePlatforme.TRecordUI.ToString();
            scoreTxt.text = "SCORE: " + kretanjePlatforme.TScoreUI.ToString();
        }
    }
}
