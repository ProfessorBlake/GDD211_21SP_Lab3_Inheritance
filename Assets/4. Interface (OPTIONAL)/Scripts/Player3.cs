using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3 : MonoBehaviour
{
	[SerializeField] private LineRenderer line;

	private void Start()
	{
		line.SetPosition(0, transform.position);
	}

	private void Update()
	{
		transform.RotateAround(transform.forward, Input.GetAxis("Horizontal") * -Time.deltaTime);

		
		RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);
		if (hit)
		{
			line.SetPosition(1, hit.point);
			if (Input.GetKeyDown(KeyCode.Space))
			{
				ForestObject fo = hit.transform.GetComponent<ForestObject>();
				if (fo != null)
				{
					fo.Inspect();

					IDamagable damagable = hit.transform.GetComponent<IDamagable>();
					if (damagable != null)
					{
						damagable.TakeDamage(1);
					}
				}
			}
		}
		else
		{
			line.SetPosition(1, transform.position + transform.up * 2f);
		}
	}
}
