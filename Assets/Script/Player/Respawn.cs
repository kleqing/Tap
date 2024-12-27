using System;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private Health playerHealth;
    private Transform spamPoint;
    private UIManager uiManager;
    
    private void Awake()
    {
        playerHealth = GetComponent<Health>();
        uiManager = FindObjectOfType<UIManager>();
    }
    
    public void RespawnPlayer()
    {
        if (spamPoint == null)
        {
            uiManager.GameOver();
            return;
        }
        playerHealth.Respawn();
        transform.position = spamPoint.position;
        
        //* Reset camera position
        Camera.main.GetComponent<CameraController>().MoveToNextRoom(spamPoint.parent);
    }
}
