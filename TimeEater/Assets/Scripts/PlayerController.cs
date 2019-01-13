using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    [SerializeField] private float moveForce = 1.0f;

    private Rigidbody2D playerRigidbody2D;
   

	void Start ()
	{
        playerRigidbody2D = GetComponent<Rigidbody2D>();
       
	}

    void Update()
    {

        float moveX = Input.GetAxisRaw("Horizontal");
        
        playerRigidbody2D.AddForce(new Vector2(moveX, 0) * moveForce * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W))
        playerRigidbody2D.AddForce(Vector2.up * moveForce);

        if (Input.GetKeyDown(KeyCode.S))
        playerRigidbody2D.AddForce(Vector2.down * moveForce);
    }

        

}
