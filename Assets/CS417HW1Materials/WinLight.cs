using UnityEngine;

public class WinLight : MonoBehaviour
{
    private Light thisLight;
    void Start()
    {
        thisLight = GetComponent<Light>();
    }
    public void BrightenRoom()
    {
        thisLight.intensity = 1000;
    }
}
