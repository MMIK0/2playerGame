﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBall : MonoBehaviour
{

    public float ballSpeed;
    public GameObject snowBallEffect;
    private Rigidbody2D theRB;

    
    void Start()
    {
        theRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        theRB.velocity = new Vector2 (ballSpeed * transform.localScale.x, 0);
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player1") {
            FindObjectOfType<GameManager>().HurtP1();
        }

        if (other.tag == "Player2") {
            FindObjectOfType<GameManager>().HurtP2();
        }
        Instantiate (snowBallEffect, transform.position, transform.rotation);
        Destroy (gameObject);
    }
}
