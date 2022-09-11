using UnityEngine;

public class DoofusMovement : MonoBehaviour
{
    private CharacterController controller;

    public GameObject gameSystem;

    private DoofusDiaryDataComponent diaryComponent;

    void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
        diaryComponent = gameSystem.GetComponent<DoofusDiaryDataComponent>();
    }

    void Update()
    {
        if (!diaryComponent.DiaryFound("DoofusMovement")) return;

        var move = new Vector3(
            Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")
        );

        // Keep character controller activated for gravity to work.
        controller.SimpleMove(Vector3.forward * 0);

        if (move != Vector3.zero)
        {
            var speed = diaryComponent.diaryData.playerData.speed;
            controller.Move(move * Time.deltaTime * speed);
        }
    }
}
