using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	[SerializeField] private float playerSpeed;

	private Animator animator;
	
	void Start ()
	{
		
	}
	
	void Update () 
	{
		
		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(Vector2.up * playerSpeed);
		}

		else if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(Vector2.left * playerSpeed);
		}
		
		else if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(Vector2.down * playerSpeed);
		}
		
		else if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(Vector2.right * playerSpeed);
		}
	}
}
