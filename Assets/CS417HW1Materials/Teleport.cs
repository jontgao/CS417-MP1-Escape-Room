using UnityEngine;
using UnityEngine.InputSystem;

public class Teleport : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public InputActionReference action;
    [SerializeField] private GameObject teleportPlane;
    bool inRoom = true;
    void Start()
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (inRoom)
            {
                transform.position = teleportPlane.transform.position;
            } else
            {
                transform.position = new Vector3(0f, 0f, 0f);
            }
            inRoom = !inRoom;
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
