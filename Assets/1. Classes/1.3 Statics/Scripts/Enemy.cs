using UnityEngine;

namespace Basics
{
    public class Enemy : MonoBehaviour
    {
        static int TotalEnemies; // A static variable belongs to the class, not instances of the class. All Enemys will share this int.

		private float move; // A non-static variable belongs to the instance of this class. Each Enemy will have it's own value.

		private void Start()
		{
			TotalEnemies++;

			Debug.Log($"Spawned Enemy #{TotalEnemies}");

			move = Random.Range(-2f, 2f);
		}

		private void Update()
		{
			transform.position += new Vector3(Mathf.Sin(Time.time * move) * Time.deltaTime, 0f);
		}
	}
}