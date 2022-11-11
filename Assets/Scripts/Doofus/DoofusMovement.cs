using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class DoofusMovement : MonoBehaviour
{
    [SerializeField]
    private CharacterController controller;

    private void Start()
    {
        controller.detectCollisions = true;
    }

    private void Update()
    {
        var move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        // Keep character controller activated for gravity to work.
        controller.SimpleMove(Vector3.forward * 0);

        if (move != Vector3.zero)
        {
            var speed = DoofusDiaryDataComponent.data.playerData.speed * 3;
            controller.Move(move * Time.deltaTime * speed);
        }
    }
}
