using System;
using UnityEngine;

public class Inventory
{
	public int Gold;
	public int Silver;

	public Inventory()
	{
		Gold = 5;
		Silver = 10;
	}

	public void Start()
	{
		Debug.Log("Start");
	}

	public void Update()
	{
		Debug.Log("Update");
	}
}