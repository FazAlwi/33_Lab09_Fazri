﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script manages the behavior of individual obstacle
public class Obstacle : MonoBehaviour
{
    [SerializeField] private float Speed = 3;
    public Player player;

    private void Start()
    {
        player = GameObject.Find("AngryDuck").GetComponent<Player>();
    }

    void Update()
    {
        if (transform.position.x <= -8)
        {
            player.score++;
            player.scoreText.text = "Score: " + player.score;
            Destroy(gameObject);
        }            
        else
            transform.Translate(Vector3.right * Time.deltaTime * -Speed);
    }
}
