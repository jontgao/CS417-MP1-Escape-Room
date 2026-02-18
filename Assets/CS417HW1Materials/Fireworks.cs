using UnityEngine;

public class Fireworks : MonoBehaviour
{
    public GameObject fireworksObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObject()
    {
        Instantiate(fireworksObject, transform.position, transform.rotation);
    }
}
