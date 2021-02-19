using UnityEngine;

public class Bees : ForestObject, IDamagable
{
	private bool shake;

	public void TakeDamage(float amount)
	{
		Debug.Log("Buzzzzzz!");
		shake = true;
	}

	private void Update()
	{
		if (shake && Random.value > 0.90f)
			transform.eulerAngles = new Vector3(0f, 0f, Random.Range(-5f, 5f));
	}
}
