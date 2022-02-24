using UnityEngine;

public class Bear : ForestObject, IDamagable
{
	private float speed = 2f;


	public void TakeDamage(float amount)
	{
		Debug.Log("Bear: RAWR!");
		speed = 5f;
	}

	private void Update()
	{
		transform.position += new Vector3(Mathf.Sin(Time.time) * Time.deltaTime * speed, 0f);
	}
}
