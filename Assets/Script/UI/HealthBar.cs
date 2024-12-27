using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
	[SerializeField] private Health playerHealth;
	[SerializeField] private Image currentHealthBar;
	[SerializeField] private Image totalHealthBar;

	private void Start()
	{
		totalHealthBar.fillAmount = playerHealth.currentHealth / 10;
	}

	private void Update()
	{
		currentHealthBar.fillAmount = playerHealth.currentHealth / 10;
	}
}
