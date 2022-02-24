using UnityEngine;

namespace Inheritance
{
	public class Orb : Item
	{
		public int Uses;

		public override void UseItem()
		{
			Uses--;
			if (Uses >= 0)
			{
				Debug.Log("The magic orb shows you your fate! It cracks slightly...");
			}
			else
			{
				Debug.Log("The magic orb shatters in your hands!");
				Destroy(this.gameObject);
			}
		}
	}
}