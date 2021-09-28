using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHB : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;
    public void Goal()
    {
        source.PlayOneShot(clip1);
    }
    public void GameOver()
    {
        source.PlayOneShot(clip2);
    }
    public void Play()
    {
        source.PlayOneShot(clip3);
    }
}
