using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player; // Reference to the player character

    public float cameraHeight = 10f; // The height of the camera above the game world
    public float cameraDistance = 10f; // The distance of the camera from the player character
    public float cameraAngle = 45f; // The angle at which the camera is rotated

    private Camera mainCamera;

    private void Awake()
    {
        mainCamera = GetComponent<Camera>();
    }

    private void Start()
    {
        // Set the camera position and rotation
        Vector3 cameraPosition = player.position + new Vector3(0f, cameraHeight, 0f);
        Quaternion cameraRotation = Quaternion.Euler(cameraAngle, 0f, 0f);
        transform.position = cameraPosition;
        transform.rotation = cameraRotation;
    }

    private void LateUpdate()
    {
        // Follow the player character
        Vector3 targetPosition = player.position + new Vector3(0f, cameraHeight, -cameraDistance);
        transform.position = targetPosition;
    }
}
