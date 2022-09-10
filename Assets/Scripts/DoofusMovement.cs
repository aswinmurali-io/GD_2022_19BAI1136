using UnityEngine;

public class DoofusMovement : MonoBehaviour
{
    private Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            rigidBody.AddForce(Vector3.left);

        if (Input.GetKey(KeyCode.D))
            rigidBody.AddForce(Vector3.right);

        if (Input.GetKey(KeyCode.W))
            rigidBody.AddForce(Vector3.up);

        if (Input.GetKey(KeyCode.S))
            rigidBody.AddForce(Vector3.down);
    }
}
