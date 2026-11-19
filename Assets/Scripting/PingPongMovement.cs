using UnityEngine;

public class PingPongMovement : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 5f;
    public bool moveRight = true;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float movement = Mathf.PingPong(Time.time * speed, distance);

        if (moveRight)
        {
            transform.position = startPosition + Vector3.right * movement;
        }
        else
        {
            transform.position = startPosition + Vector3.left * movement;
        }
    }
}