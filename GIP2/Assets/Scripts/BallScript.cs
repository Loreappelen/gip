﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool inPlay;
    public Transform paddle;
    public float speed;
    public UIScript ui;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ui.gameOver)
        {
            return;
        }

        if(inPlay == false)
        {
            transform.position = paddle.position;
        }
        if(Input.GetButtonDown("Jump") && !inPlay)
        {
            inPlay = true;
            rb.AddForce(Vector2.up * speed);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag ("bottom")) 
        {
            Debug.Log("ball hit bottom");
            rb.velocity = Vector2.zero;
            inPlay = false;
            ui.UpdateLives();
        }
    }
}
