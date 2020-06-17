﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script manages the behavior of individual obstacle
public class Obstacle : MonoBehaviour
{
    [SerializeField] private float Speed = 3;
    public float Bypass = 1;
    void Update()
    {
        transform.position += Vector3.left * Speed * Time.deltaTime;
        if (transform.position.x <= 0 && Bypass == 1)
        {
            Bypass = 0;
            GameManager.thisManager.UpdateScore();
        }
        if (transform.position.x <= -12)
        {
            Destroy(gameObject);
        }
    }
}
