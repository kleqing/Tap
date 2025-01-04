using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("Player Camera")]
    [SerializeField] private Transform player;
    [SerializeField] private float cameraAhead;

    [Header("Room Transition")] 
    [SerializeField] private float cameraSpeed;
    
    private Vector3 velocity = Vector3.zero;
    private float currentPositonY;
    private float lookAheadY;
    
    private void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, 
            new Vector3(transform.position.x, currentPositonY, transform.position.z), 
            ref velocity, 
            cameraSpeed * Time.deltaTime);
        lookAheadY = Mathf.Lerp(lookAheadY, (cameraAhead * transform.localScale.y), Time.deltaTime * cameraSpeed);
    }

    public void MoveToNextRoom(Transform nextRoom)
    {
        currentPositonY = nextRoom.position.y;
    }
}
