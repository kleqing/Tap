using System;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Game Over")]
    [SerializeField] private GameObject gameOverScreen;

    [Header("Pause")]
    [SerializeField] private GameObject pauseScreen;
    
    [Header("Main Menu")]
    [SerializeField] private GameObject mainMenuScreen;
    
    [Header("Sound Icon")]
    [SerializeField] private Image pauseSoundIcon;
    [SerializeField] private Image gameOverSoundIcon;
    [SerializeField] private Image mainMenuSoundIcon;
    
    private void Awake()
    {
        if (gameOverScreen != null)
        {
            gameOverScreen.SetActive(false);
        }
        if (pauseScreen != null)
        {
            pauseScreen.SetActive(false);
        }
        if (mainMenuScreen != null)
        {
            mainMenuScreen.SetActive(true);
        }
        if (gameOverSoundIcon != null)
        {
            BackgroundMusic.Instance?.RegisterSoundIcon(gameOverSoundIcon);
        }
        if (pauseSoundIcon != null)
        {
            BackgroundMusic.Instance?.RegisterSoundIcon(pauseSoundIcon);
        }
        if (mainMenuSoundIcon != null)
        {
            BackgroundMusic.Instance?.RegisterSoundIcon(mainMenuSoundIcon);
        }
    }

    private void OnDestroy()
    {
        if (pauseSoundIcon != null)
        {
            BackgroundMusic.Instance?.UnregisterSoundIcon(pauseSoundIcon);
        }
        if (gameOverSoundIcon != null)
        {
            BackgroundMusic.Instance?.UnregisterSoundIcon(gameOverSoundIcon);
        }
        if (mainMenuSoundIcon != null)
        {
            BackgroundMusic.Instance?.UnregisterSoundIcon(mainMenuSoundIcon);
        }
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
    
    public void Restart()
    {
        Time.timeScale = 1;
        gameOverScreen.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    public void Quit()
    {
        Application.Quit();
        //* If you are using the Unity Editor, the application will not close.
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
    
    public void PauseGame(bool isPaused)
    {
        pauseScreen.SetActive(isPaused);
        Time.timeScale = isPaused ? 0 : 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseScreen.activeInHierarchy)
            {
                PauseGame(false);
            }
            else
            {
                PauseGame(true);
            }
        }
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void MuteBGM()
    {
        BackgroundMusic.Instance?.Mute(0.2f);
    }
}
