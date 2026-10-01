using UnityEngine;

public class TurnOnLight : MonoBehaviour
{
    public GameObject lightObject; // drag your light here in the Inspector
    private Light myLight;

    void Start()
    {
        myLight = lightObject.GetComponent<Light>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Optional: check if the collider is the player
        if (other.CompareTag("Player"))
        {
            myLight.enabled = true; // turns the light on
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Optional: turn off light when leaving
        if (other.CompareTag("Player"))
        {
            myLight.enabled = false;
        }
    }
}
