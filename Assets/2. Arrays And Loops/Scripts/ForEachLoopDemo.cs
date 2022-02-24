using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arrays
{
    public class ForEachLoopDemo : MonoBehaviour
    {
        public List<Student> Students;

		private void Start()
		{
			// Initialize the list
			Students = new List<Student>();

			// Create 30 new student objects and add them to the list
			for (int i = 0; i < 30; i++)
			{
				Students.Add(new Student());
			}

			// Identify and students with grades below 70
			foreach(Student s in Students)
			{
				if(s.Grade < 70f)
				{
					Debug.Log($"Student {s.ID} grade below 70.");
				}
			}
		}
	}
}