using UnityEngine;

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
