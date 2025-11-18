using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Transform playerTransform;

    void Start()
    {
        playerTransform = FindAnyObjectByType<PlayerController>().transform;
    }

    void LateUpdate()
    {
        transform.position = new Vector3(playerTransform.position.x, 0, -10);
    }
}
