using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int score;
    public AudioHB audio;
    public float accx = 0.0f;
    public float accz = 0.0f;
    public float accy = 0.0f;
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
        accx = Input.acceleration.x;
        accz = Input.acceleration.z;
        accy = Input.acceleration.y;
    }
}
