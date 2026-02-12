using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Light light;
    public InputActionReference action;
    void Start()
    {
        light = GetComponent<Light>();

        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            light.color = new Color(light.color.b, light.color.r, light.color.g);
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
