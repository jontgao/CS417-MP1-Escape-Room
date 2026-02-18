using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class SocketDetector : MonoBehaviour
{
    UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor socket;
    public UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable key;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        socket = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
        socket.selectEntered.AddListener(socketCheck);
    }

    void OnDisable()
    {
        socket.selectEntered.RemoveListener(socketCheck);
    }

    public void socketCheck(SelectEnterEventArgs args)
    {
        if (key)
        {
            UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable objName = socket.interactablesSelected[0];
            
            Debug.Log(objName.transform.name + " in socket of " + transform.name + " ");

            if (objName != null && objName == key)
            {
                Debug.Log("Match1");
            }
                
        }
    }
}
