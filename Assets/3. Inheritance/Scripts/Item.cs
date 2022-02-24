using UnityEngine;

// This class serves as a base class for other items. This is the default template for an item, but other items can 
// build on top of this.

namespace Inheritance
{
	public class Item : MonoBehaviour
	{
		public string Name;
		public int Cost;
		public bool Consumable;

		private void OnMouseDown()
		{
			UseItem();
		}

		public virtual void UseItem()
		{
			Debug.Log("Using " + Name);
			if (Consumable)
			{
				Destroy(this.gameObject);
			}
		}
	}
}