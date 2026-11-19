using UnityEngine;

public class SpinningMovement : MonoBehaviour
{
    [SerializeField] float xAngle;
    [SerializeField] float yAngle;
    [SerializeField] float zAngle;

    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
