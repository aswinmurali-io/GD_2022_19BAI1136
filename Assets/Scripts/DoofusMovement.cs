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
        var move = new Vector3(
            Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")
        );

        if (diaryComponent.diaryData == null)
        {
            Debug.Log("No data in diary found! DoofusMovement component is waiting...");
            return;
        }

        var speed = diaryComponent.diaryData.playerData.speed;
        // Debug.Log(string.Format("Found speed property with value {0}", speed));

        controller.Move(move * Time.deltaTime * speed);
    }
}
