using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : Item
{
	public int HealthRecover;
	[Range(0f,1f)]	public float Rottenness;

	public override void UseItem()
	{
		base.UseItem();
		float hpRecoevered = Mathf.Round(HealthRecover / Rottenness);
		Debug.Log("Recovered " + hpRecoevered + " health!");
	}
}
