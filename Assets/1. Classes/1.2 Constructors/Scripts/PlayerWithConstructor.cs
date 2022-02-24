using UnityEngine;

namespace Basics
{
    public class PlayerWithConstructor : MonoBehaviour
    {
		public Inventory Inventory;
		public float Health;

		private void Start()
		{
			Inventory = new Inventory(10, 2, 0);
			Health = 50;
		}

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
				if (Inventory.UseMedpack())
				{
					Health += 25f;
				}
			}
		}
	}
}