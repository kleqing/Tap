using System;
using UnityEngine;

public class Spikes : MonoBehaviour
{
	[SerializeField] private float damage;

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			other.GetComponent<Health>().TakeDamage(damage);
		}
	}
}
