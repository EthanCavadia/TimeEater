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

	private bool candleStates = true;
	private GameManager door1;
	
	void Start () 
	{
		
	}
	
	void Update () 
	{
		if (Input.GetButton("Interact"))
		{
			ChangeCandleStates();
		}
	}

	private void OpenDoorCondition()
	{
		if ((candle2 && candle3 && candle6) == true && (candle1&&candle4&&candle5) == false)
		{
			door1.GetComponent<BoxCollider2D>().enabled = false;
		}
	}
	
}
