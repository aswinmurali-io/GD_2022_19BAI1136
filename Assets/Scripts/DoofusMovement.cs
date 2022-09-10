using UnityEngine;

public class DoofusMovement : MonoBehaviour
{
    private Rigidbody rigidBody;

    public int speed = 3;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            rigidBody.AddForce(Vector3.left * speed);

        if (Input.GetKey(KeyCode.D))
            rigidBody.AddForce(Vector3.right * speed);

        if (Input.GetKey(KeyCode.W))
            rigidBody.AddForce(Vector3.back * speed);

        if (Input.GetKey(KeyCode.S))
            rigidBody.AddForce(Vector3.forward * speed);
    }
}
