using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
	[SerializeField] private ParticleSystem psystem;
	[SerializeField] private LineRenderer line;

	private void Start()
	{
		line.SetPosition(0, transform.position);
	}

	private void Update()
	{
		transform.RotateAround(transform.forward, Input.GetAxis("Horizontal") * -Time.deltaTime);

		RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);
		if(hit)
		{
			//Play particles on any item.
			if (hit.collider.GetComponent<Item>())
			{
				psystem.Emit(1);
				psystem.transform.position = hit.transform.position;
				line.SetPosition(1, hit.point);
			}

			if (Input.GetKeyDown(KeyCode.Space))
			{
				hit.collider.GetComponent<Item>().UseItem();
			}
		}
		else
		{
			line.SetPosition(1, transform.position +  transform.up * 2f);
		}
	}
}
