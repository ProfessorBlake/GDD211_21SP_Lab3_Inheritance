using UnityEngine;

namespace Inheritance
{
	public class Map : Item
	{
		public override void UseItem()
		{
			base.UseItem();
			Debug.Log("You are here!");
		}
	}
}
