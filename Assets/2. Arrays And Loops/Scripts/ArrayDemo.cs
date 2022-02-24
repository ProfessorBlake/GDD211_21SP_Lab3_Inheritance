using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arrays
{
    public class ArrayDemo : MonoBehaviour
    {
		// Declare an int array. Note that the array is not initialized here.
        private int[] Numbers;

		private void Start()
		{
			// ERROR 
			Debug.Log(Numbers.Length); // This throws an error because the array isn't yet initialized. 

			Numbers = new int[0]; // Set Numbers to an array with 0 elements.

			Debug.Log(Numbers.Length); // Now that we have initialized the array we can reference it.

			// ERROR
			Numbers[0] = 123;

			Debug.Log(Numbers[0]); // We get an error because there are no elements in the array, so there is no element Numbers[0].

			Numbers = new int[3];

			Debug.Log(Numbers[0]); // Now we have 3 elements in the array, [0,0,0]
		}
	}
}