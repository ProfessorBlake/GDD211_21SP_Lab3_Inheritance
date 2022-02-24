using System;
using UnityEngine;

public class ForestObject : MonoBehaviour
{
	public void Inspect()
	{
		Debug.Log("That's a " + gameObject.name + ".");
	}
}