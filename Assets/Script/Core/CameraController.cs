using UnityEngine;

public class CameraController : MonoBehaviour
{
    //* Fixed camera
    [Header("Room Transition")] 
    [SerializeField] private float cameraSpeed;
    
    private Vector3 velocity = Vector3.zero;
    private float currentPositonY;
    
    //* Camera follow player
    [Header("Player Camera")]
    [SerializeField] private Transform player;
    [SerializeField] private float aheadDistance;
    
    private float lookAheadX;
    private float lookAheadY;
    
    private void Update()
    {
        //* Camera transition between rooms
        /* transform.position = Vector3.SmoothDamp(transform.position, 
            new Vector3(transform.position.x, currentPositonY, transform.position.z), 
            ref velocity, 
            cameraSpeed * Time.deltaTime); */
        
        //* Camera follow player
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
        lookAheadX = Mathf.Lerp(lookAheadX, (aheadDistance * transform.localScale.x), Time.deltaTime * cameraSpeed);
        lookAheadY = Mathf.Lerp(lookAheadY, (aheadDistance * transform.localScale.y), Time.deltaTime * cameraSpeed);

    }

    public void MoveToNextRoom(Transform nextRoom)
    {
        currentPositonY = nextRoom.position.y;
    }
}
