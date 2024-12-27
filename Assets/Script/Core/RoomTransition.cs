using System;
using UnityEngine;

public class RoomTransition : MonoBehaviour
{
    [SerializeField] private Transform previousRoom;
    [SerializeField] private Transform nextRoom;
    [SerializeField] private CameraController cameraController;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (transform.position.y > other.transform.position.y)
            {
                cameraController.MoveToNextRoom(nextRoom);
            }
            else
            {
                cameraController.MoveToNextRoom(previousRoom);
            }
        }
    }
}
