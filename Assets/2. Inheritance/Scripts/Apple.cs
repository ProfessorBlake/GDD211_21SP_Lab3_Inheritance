using UnityEngine;

public class Apple : Item
{
	public override void UseItem()
	{
		base.UseItem();
		Debug.Log("Gained 5 health!");
	}
}
