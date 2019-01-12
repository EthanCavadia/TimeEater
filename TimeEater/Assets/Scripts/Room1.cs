using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room1 : MonoBehaviour
{

	[SerializeField] private GameObject candle1;
	[SerializeField] private GameObject candle2;
	[SerializeField] private GameObject candle3;
	[SerializeField] private GameObject candle4;
	[SerializeField] private GameObject candle5;
	[SerializeField] private GameObject candle6;
	[SerializeField] private GameObject door1;
	
	void Start ()
	{
		
	}
	
	void Update () 
	{
		
	}

	private void OpenDoorCondition()
	{
		if ((candle2 && candle3 && candle6).Equals(true) && (candle1&& candle4 && candle5).Equals(false))
		{
			door1.GetComponent<BoxCollider2D>().enabled = false;
		}
	}

	private void OnTriggerEnter(Collider candle)
	{
		if (candle.gameObject.CompareTag("Player"))
		{
			if (Input.GetButton("Interact"))
			{
				gameObject.GetComponent<SpriteRenderer>().enabled = false;
			}
			else if (Input.GetButtonDown("Interact"))
			{
				gameObject.GetComponent<SpriteRenderer>().enabled = true;
			}
		}
	}
}
