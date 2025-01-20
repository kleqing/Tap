using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flag : MonoBehaviour
{ 
	private UIManager uiManager;

	private void Awake()
	{
		uiManager = FindObjectOfType<UIManager>();
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			int currentScene = SceneManager.GetActiveScene().buildIndex;
			//* Save the current scene index
			PlayerPrefs.SetInt("SavedScene", currentScene);
			PlayerPrefs.Save();
			uiManager.NextLevel();
		}
	}
}
