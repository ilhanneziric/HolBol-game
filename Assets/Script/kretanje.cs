using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kretanje : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    public float speed = 0.2f;
    public Joystick joystick;

    private void Start()
    {
        joystick = FindObjectOfType<Joystick>();
    }

    private void Update()
    {
        var rigid = GetComponent<Rigidbody>();
         // Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
         // Vector3 pos = mainCamera.ScreenToViewportPoint(Input.mousePosition);
         // if (Physics.Raycast(ray, out RaycastHit raycasthit))
         // {
         //     transform.position = new Vector3((pos.x - 0.5f) *3 ,-10,(pos.y - 0.5f) *3 );
         // }
        
        transform.Translate(Input.acceleration.x * speed, 0, Input.acceleration.y * speed);
        //rigid.velocity = new Vector3(joystick.Horizontal * 5f, rigid.velocity.y, joystick.Vertical * 5f);
    }
}
