using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controllers : MonoBehaviour
{

    [SerializeField] private float moveForce = 1.0f;

    private Rigidbody2D playerRigidbody2D;


    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();

    }

    void Update()
    {

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        playerRigidbody2D.AddForce(new Vector2(moveX, 0) * moveForce * Time.deltaTime);
        playerRigidbody2D.AddForce(new Vector2(moveY, 0) * moveForce * Time.deltaTime);

    }



}
