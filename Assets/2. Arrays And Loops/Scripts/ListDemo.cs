using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Lists are like arrays, but with more functionality. You can add/remove elements, changing the size of the list.

public class ListDemo : MonoBehaviour
{
    private List<int> Numbers;

	private void Start()
	{
		Numbers = new List<int>(); // Initialize the empty list of ints.

		Debug.Log(Numbers.Count); // Note: the number of elements is Count, not Length, like on an array.

		Numbers.Add(10);

		Debug.Log(Numbers[0]); // Print out the first element in the list.

		Numbers.Add(20);
		Numbers.Add(30);
		Numbers.Add(40); // The list now has [10, 20, 30, 40] 4 elements.

		Debug.Log(Numbers[2]);

		Numbers.Remove(20); // You can remove an element from the list by passing a reference to that element into Remove()

		Numbers.RemoveAt(1); // You can also remove an element by it's position in the list.

		for(int i = 0; i < Numbers.Count; i++) // Print out each element.
		{
			Debug.Log(Numbers[i]);
		}
	}
}
