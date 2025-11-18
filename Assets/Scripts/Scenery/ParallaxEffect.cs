using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    [SerializeField] float parallaxFactor;

    Transform cam;
    Vector3 previousCamPos;

    void Start()
    {
        cam = Camera.main.transform;
        previousCamPos = cam.position;
    }

    void LateUpdate()
    {
        Vector3 delta = cam.position - previousCamPos;

        transform.position += new Vector3(delta.x * parallaxFactor, delta.y * parallaxFactor, 0f);

        previousCamPos = cam.position;
    }
}

