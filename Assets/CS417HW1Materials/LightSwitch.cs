using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Light mylight;
    public InputActionReference action;
    void Start()
    {
        mylight = GetComponent<Light>();

        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            mylight.color = new Color(mylight.color.b, mylight.color.r, mylight.color.g);
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
