using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectObjectDestroy : MonoBehaviour
{
    [SerializeField]
    private float timeToDestroy;

    void Start()
    {
        Destroy(gameObject, timeToDestroy);
    }
}
