using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class CircleDestroy : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem krugDestroyEffect;

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.name == "kugla")
        {
            pokreniParticles();
        }
    }

    public void pokreniParticles()
    {
        Instantiate(krugDestroyEffect, transform.position, Quaternion.Euler(90, 0, 0));
        Destroy(this.gameObject);
    }
}
