using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int score;
    public AudioHB audio;
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadData();
        score = data.score;
    }

    private void Start()
    {
        audio = FindObjectOfType<AudioHB>();
        audio.Play();
    }
}
