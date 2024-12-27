using System;
using UnityEngine;

public class ExtraHeart : MonoBehaviour
{
	[SerializeField] private float healthValue;

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			other.GetComponent<Health>().AddHealth(healthValue);
			Destroy(gameObject);
		}
	}
}
