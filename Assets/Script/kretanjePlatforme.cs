using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class kretanjePlatforme : MonoBehaviour
{
    private float speed = 5.5f;
    public randomkreiraj rankre;
    private int kraj = 1;
    private static int trenutniScore = 0;
    public Player player;
    public ScoreManager scoremanager;
    public static int TScoreUI = -1;
    public static int TRecordUI = -1;
    public AudioHB audio;
    private void OnCollisionEnter(Collision other)
    {
        if(other.collider.name == "spawnujponovo")
            rankre.funkcija();
        else if (other.collider.name == "kugla" && kraj == 1)
        {
            kraj = 2;
            Destroy(this.gameObject);
            if (trenutniScore > player.score)
            {
                player.score = trenutniScore;
                player.SavePlayer();
            }
            TRecordUI = player.score;
            TScoreUI = trenutniScore;
            trenutniScore = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }

    void Start()
    {
        rankre = GameObject.FindObjectOfType(typeof(randomkreiraj)) as randomkreiraj;
        player = GameObject.FindObjectOfType(typeof(Player)) as Player;
        player.LoadPlayer();
        TRecordUI = player.score;
        scoremanager = FindObjectOfType<ScoreManager>();
        audio = FindObjectOfType<AudioHB>();
        scoremanager.Score = trenutniScore;
    }

    void FixedUpdate()
    {
        
        if (this.transform.position.y >= -10.9)
        {
            Destroy(this.gameObject);
            trenutniScore++;
            scoremanager.Score++;
            audio.Goal();
        }
        else
        {
            this.transform.position += new Vector3(0, 5, 0) * speed * Time.deltaTime;
        }
    }
}
