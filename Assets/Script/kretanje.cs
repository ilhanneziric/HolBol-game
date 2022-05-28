using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableObjects;
using UnityEngine;

public class kretanje : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    public float speed = 0.2f;
    
    [SerializeField]
    private GameMetrics Metrics;

    [SerializeField]
    private ParticleSystem kuglaDestroyEffect;

    public Player player;

    private int kraj = 1;

    private void Start()
    {
        player = GameObject.FindObjectOfType(typeof(Player)) as Player;
    }

    private void FixedUpdate()
    {
        if (Input.acceleration.z < 0)
        {
            transform.Translate((Input.acceleration.x - player.accx) * speed, 0, (Input.acceleration.y - player.accy) * speed);
        }
        else
        {
            transform.Translate((-Input.acceleration.x + player.accx) * speed, 0, (-Input.acceleration.y + player.accy) * speed);
        }

        if (kraj == 1)
        {
            this.transform.position = new Vector3(
                Mathf.Clamp(this.transform.position.x, Metrics.LimitLeft, Metrics.LimitRight),
                -11,
                Mathf.Clamp(this.transform.position.z, Metrics.LimitLeft, Metrics.LimitRight)
            );
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.name != "krug")
        {
            Instantiate(kuglaDestroyEffect, transform.position, Quaternion.identity);
            kraj = 2;
            this.transform.position = new Vector3(15, 0, 15);
        }
    }
}
