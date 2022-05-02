using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] Vector3 offset;
    [SerializeField] float smoothingSp�ed = 10f;

    Transform playerTransform;

    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void FixedUpdate()
    {
        Vector3 targetPos = playerTransform.position + offset;

        transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * smoothingSp�ed);
        transform.LookAt(playerTransform);
    }
}
