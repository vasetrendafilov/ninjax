using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public Transform target;
    public float smooth = 0.125f;
    public Vector3 ofset;
    private Vector3 velocity = Vector3.zero;

    private void LateUpdate()
    {
        Vector3 desiredPos = target.position + ofset;
        transform.position = Vector3.SmoothDamp(transform.position, desiredPos, ref velocity, smooth* Time.deltaTime);
    }
}
