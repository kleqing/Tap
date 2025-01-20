using System;
using UnityEngine;

public class PeashooterProjectile : DamagePlayer
{
	[SerializeField] private float speed;
	[SerializeField] private float resetTime;
	private float lifeTime;

	public void ActiveProjectile(float direction)
	{
		lifeTime = 0;
		gameObject.SetActive(true);
	}

	private void Update()
	{
		float moveSpeed = speed * Time.deltaTime;
		transform.Translate(moveSpeed, 0, 0);
		lifeTime += Time.deltaTime;

		if (lifeTime > resetTime)
		{
			gameObject.SetActive(false);
		}	
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		base.OnTriggerEnter2D(other);
		gameObject.SetActive(false);
	}
}

