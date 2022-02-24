using UnityEngine;

namespace Arrays
{
	[System.Serializable]
	public class Student
	{
		public int ID;
		public float Grade;

		public Student()
		{
			ID = Random.Range(100, 999);
			Grade = Mathf.Round(Random.Range(60f, 100f) * 10) / 10;
		}
	}
}