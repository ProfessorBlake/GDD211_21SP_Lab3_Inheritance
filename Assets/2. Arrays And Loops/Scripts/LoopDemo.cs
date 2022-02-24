using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopDemo : MonoBehaviour
{
    public string[] Passwords;
	public int TotalPasswords;
	public int PasswordLength;

	private System.Random rnd;

	private void Start()
	{
		Debug.Log($"Generating {TotalPasswords} passwords with {PasswordLength} characters, {string.Format("{0:n}",(decimal)Mathf.Pow(26, PasswordLength))} possible combinations.");

		// Seed our random number generator
		rnd = new System.Random(Random.Range(0, int.MaxValue));

		// Initialize string array with TotalPasswords number of elements
		Passwords = new string[TotalPasswords];

		// Loop through each element of the array and fill it in with a random string
		for (int i = 0; i < Passwords.Length; i++)
		{
			Passwords[i] = GeneratePassword();
		}


		// Check each password against each other password to look for duplicates
		for (int i = 0; i < Passwords.Length; i++)
		{
			for (int j = 0; j < Passwords.Length; j++)
			{
				if (i == j)
					continue;

				if (Passwords[i] == Passwords[j])
				{
					Debug.LogError($"MATCHING PASSWORDS FOUND: {i}/{j}");
					return;
				} 
			}
		}
		Debug.Log("No repeat passwords found!");
	}

	private string GeneratePassword()
	{
		//System.Random rnd = new System.Random(Random.Range(0,int.MaxValue));
		string pw = "";
		for (int i = 0; i < PasswordLength; i++)
		{
			pw += (char)rnd.Next('a', 'z');
		}
		return pw;
	}
}
