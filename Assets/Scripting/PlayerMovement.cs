using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;

    Rigidbody rb;
    Vector2 moveInput;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3 (moveInput.x, 0f, moveInput.y);

        movement = movement.normalized;

        rb.AddForce(movement * moveSpeed);
    }
}
